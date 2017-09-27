using System;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Server
{
    class Session
    {
        TcpClient client;
        NetworkStream stream;
        public Boolean IsDoctor = false;
        public string username;

        public Session(TcpClient client)
        {
            this.client = client;
            stream = client.GetStream();
        }

        //Send to networkstream
        #region
        public void Send(string message)
        {
            System.Diagnostics.Debug.WriteLine("Send from server: \r\n" + message);
            byte[] prefixArray = BitConverter.GetBytes(message.Length);
            byte[] requestArray = Encoding.Default.GetBytes(message);
            byte[] buffer = new Byte[prefixArray.Length + message.Length];
            prefixArray.CopyTo(buffer, 0);
            requestArray.CopyTo(buffer, prefixArray.Length);
            stream.Write(buffer, 0, buffer.Length);
        }
        #endregion

        //Read from networkstream
        #region
        public void Read()
        {
            while (true)
            {
                try
                {
                    StringBuilder response = new StringBuilder();
                    int numberOfBytesRead = 0;
                    int totalBytesreceived = 0;
                    int lengthMessage = -1;
                    byte[] receiveBuffer = new byte[1024];
                    bool messagereceived = false;

                    do
                    {
                        numberOfBytesRead = stream.Read(receiveBuffer, 0, receiveBuffer.Length);
                        totalBytesreceived += numberOfBytesRead;
                        string received = Encoding.ASCII.GetString(receiveBuffer, 0, numberOfBytesRead);
                        response.AppendFormat("{0}", received);
                        if (lengthMessage == -1)
                        {
                            if (receiveBuffer.Length >= 4)
                            {
                                Byte[] lengthMessageArray = new Byte[4];
                                Array.Copy(receiveBuffer, 0, lengthMessageArray, 0, 3);
                                lengthMessage = BitConverter.ToInt32(lengthMessageArray, 0);
                                if ((totalBytesreceived - 4) == lengthMessage)
                                {
                                    messagereceived = true;
                                }
                            }
                        }
                        else if ((totalBytesreceived - 4) == lengthMessage)
                        {
                            messagereceived = true;
                        }
                    }
                    while (!messagereceived);
                    stream.Flush();
                    string toReturn = response.ToString().Substring(4);
                    System.Diagnostics.Debug.WriteLine("Received at server: \r\n" + toReturn);
                    ProcesAnswer(toReturn);
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.Message);
                }
            }
        }
        #endregion

        //Process answer
        #region
        public void ProcesAnswer(dynamic answer)
        {
            dynamic jsonObject = JsonConvert.DeserializeObject(answer);
            try
            {
                if (jsonObject.id == "log in")
                {
                    CheckCredentials((string)jsonObject.data.username, (string)jsonObject.data.password);
                }
                else if (jsonObject.id == "session/start")
                {
                    NoPermission("session/start");
                    //Console.WriteLine("New session: " + jsonObject.data.username);
                    //CreateNewSession(jsonObject);
                }
                else if (jsonObject.id == "data")
                {
                    Console.WriteLine("Data recieved");
                    DataRecieved(jsonObject);
                }
                else if (jsonObject.id == "start")
                {

                }
                else if (jsonObject.id == "pauze")
                {

                }
                else if (jsonObject.id == "session/end")
                {
                    NoPermission("session/end");
                    //Console.WriteLine("Session ended with client");
                    //CloseSession(jsonObject);
                }
                else if (jsonObject.id == "doctor/login")
                {
                    CheckDoctorCredentials((string)jsonObject.data.username, (string)jsonObject.data.password);
                }
                else if (jsonObject.id == "doctor/sessions")
                {
                    SessionList();
                }
                else if (jsonObject.id == "session/data/historic")
                {
                    GetDataFromUser(jsonObject);
                }
                else if (jsonObject.id == "doctor/training/start")
                {
                    string patient = jsonObject.data.patientId;
                    if (CreateNewSession(patient))
                    {
                        dynamic response = new
                        {
                            id = "doctor/training/start",
                            data = new
                            {
                                status = "ok"
                            }
                        };
                        Send(JsonConvert.SerializeObject(response));
                    }
                }
                else if (jsonObject.id == "doctor/training/stop")
                {
                    string patient = jsonObject.data.patientId;
                    if (CloseSession(patient))
                    {
                        dynamic response = new
                        {
                            id = "doctor/training/stop",
                            data = new
                            {
                                status = "ok"
                            }
                        };
                        Send(JsonConvert.SerializeObject(response));
                    }
                }
                else if (jsonObject.id == "doctor/message/toClient")
                {

                }
                else if (jsonObject.id == "doctor/message/toAll")
                {

                }
                else if (jsonObject.id == "doctor/setPower")
                {
                    if (SetPowerFromClient(jsonObject))
                    {
                        dynamic response = new
                        {
                            id = "doctor/setPower",
                            data = new
                            {
                                status = "ok",
                            }
                        };
                        Send(response);
                    }
                }
            }
            catch (Exception e)
            {
                dynamic error = new
                {
                    id = "command",
                    status = "Error",
                    error = e.Message
                };
                Send(JsonConvert.SerializeObject(error));
            }
        }
        #endregion

        //Login normal and doctor.
        #region
        public void CheckCredentials(string username, string password)
        {
            if (Database.CheckCredentials(username, password))
            {
                this.username = username;
                Send(JsonConvert.SerializeObject(Commands.LoginResponse("ok")));
            }
            else
            {
                Send(JsonConvert.SerializeObject(Commands.LoginResponse("error")));
            }
        }

        public void CheckDoctorCredentials(string username, string password)
        {
            if (Database.CheckDoctorCredentials(username, password))
            {
                IsDoctor = true;
                this.username = username;
                Send(JsonConvert.SerializeObject(Commands.DoctorLoginResponse("ok")));
            }
            else
            {
                Send(JsonConvert.SerializeObject(Commands.DoctorLoginResponse("error")));
            }
        }
        #endregion

        //Create new session.
        #region
        public Boolean CreateNewSession(string username)
        {
            if (!IsDoctor)
            {
                NoPermission("doctor/training/start");
                return false;
            }
            else
            {
                Session client = Program.GetSessionWithUsername(username);
                if (client == null)
                {
                    Send(JsonConvert.SerializeObject(Commands.DoctorTrainingStartError("No client active with given username.")));
                    return false;
                }
                try
                {
                    if (Database.AddActiveSession(username))
                    {
                        dynamic answer = new
                        {
                            id = "session/start",
                            data = new
                            {
                                status = "OK",
                                sessionID = username
                            }
                        };
                        client.Send(JsonConvert.SerializeObject(answer));
                        return true;
                    }
                    else
                    {
                        Send(JsonConvert.SerializeObject(Commands.DoctorTrainingStartError("Username already active. Other session has to be stopped first before starting a new one.")));
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Send(JsonConvert.SerializeObject(Commands.DoctorTrainingStartError(e.Message)));
                    return false;
                }
            }
        }
        #endregion

        //Return list with active sessions to doctor
        #region
        public void SessionList()
        {
            if (!IsDoctor)
            {
                Console.WriteLine("No permission");
                NoPermission("doctor/sessions");
            }
            else
            {
                List<Session> sessions = Program.GetAllPatients();
                List<string> sessionNames = new List<string>();
                foreach (Session s in sessions)
                {
                    sessionNames.Add(s.username);
                }
                dynamic response = new
                {
                    id = "doctor/sessions",
                    data = new
                    {
                        sessions = sessionNames.ToArray()
                    }
                };
                Console.WriteLine(JsonConvert.SerializeObject(response));
                Send(JsonConvert.SerializeObject(response));
            }
        }
        #endregion

        //Recieved data from patient
        #region
        public void DataRecieved(dynamic jsonObject)
        {
            try
            {
                string session = jsonObject.session;
                int power = jsonObject.data.power;
                double speed = jsonObject.data.speed;
                int time = jsonObject.data.time;
                int rpm = jsonObject.data.RPM;
                double distance = jsonObject.data.distance;
                int pulse = jsonObject.data.pulse;
                Boolean added = Database.AddErgometerDataToSession(session, new ErgometerData(pulse, rpm, speed, distance, time, 0, 0, power));
                if (added)
                {
                    dynamic answer = new
                    {
                        id = "data",
                        data = new
                        {
                            status = "OK"
                        }
                    };
                    Send(JsonConvert.SerializeObject(answer));
                }
                else
                {
                    dynamic answer = new
                    {
                        id = "data",
                        data = new
                        {
                            status = "ERROR",
                            error = "Geen sessie voor username bekend"
                        }
                    };
                    Send(JsonConvert.SerializeObject(answer));
                }

            }
            catch (Exception e)
            {
                dynamic answer = new
                {
                    id = "data",
                    status = "Error",
                    error = e.Message
                };
                Send(JsonConvert.SerializeObject(answer));
            }
        }
        #endregion

        //Close session
        #region
        public Boolean CloseSession(string sessionID)
        {
            if (!IsDoctor)
            {
                NoPermission("doctor/training/stop");
                return false;
            }
            else
            {
                Session client = Program.GetSessionWithUsername(sessionID);
                if (client == null)
                {
                    Send(JsonConvert.SerializeObject(Commands.DoctorTrianingStopError("No client active with given username.")));
                    return false;
                }
                try
                {
                    Database.CloseActiveSession(sessionID);
                    dynamic answer = new
                    {
                        id = "session/end",
                        data = new
                        {
                            status = "OK"
                        }
                    };
                    client.Send(JsonConvert.SerializeObject(answer));
                    Program.sessions.Remove(client);
                    return true;
                }
                catch (Exception e)
                {
                    Send(JsonConvert.SerializeObject(Commands.DoctorTrianingStopError(e.Message)));
                    return false;
                }
            }
        }
        #endregion

        //Historic data
        #region
        public void GetDataFromUser(dynamic jsonObject)
        {
            if (IsDoctor)
            {
                string DataFromUser = Database.GetDataFromUser(jsonObject.data.client);
                dynamic response = new
                {
                    id = "session/data/historic",
                    data = DataFromUser
                };
                Send(JsonConvert.SerializeObject(response));
            }
            else
            {
                NoPermission("session/data/historic");
            }
        }
        #endregion

        //Set power from client
        #region
        public Boolean SetPowerFromClient(dynamic jsonObject)
        {
            if (!IsDoctor)
            {
                NoPermission("doctor/setPower");
                return false;
            }
            else
            {
                string patientID = jsonObject.data.patientID;
                Session client = Program.GetSessionWithUsername(patientID);
                if (client == null)
                {
                    Send(JsonConvert.SerializeObject(Commands.SetPowerError("No client active with given username.")));
                    return false;
                }
                else
                {
                    dynamic power = new
                    {
                        id = "client/SetPower",
                        data = new
                        {
                            power = jsonObject.data.power
                        }
                    };
                    client.Send(JsonConvert.SerializeObject(power));
                    return true;
                }
            }
        }
        #endregion

        //NoPermission
        #region
        public void NoPermission(string id)
        {
            dynamic answer = new
            {
                id = id,
                status = "Error",
                error = "You do not have permission for this action"
            };
            Send(JsonConvert.SerializeObject(answer));
        }
        #endregion
    }
}
