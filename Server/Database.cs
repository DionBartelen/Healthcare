using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Database
    {
        static Dictionary<string, List<TrainSession>> TrainSessions = new Dictionary<string, List<TrainSession>>();
        static Dictionary<string, TrainSession> ActiveTrainSessions = new Dictionary<string, TrainSession>();

        public static void ReadSavedData()
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), @"Database\Database.txt");
                List<string> lines = File.ReadAllLines(path).ToList();
                Dictionary<string, List<TrainSession>> dictionary = new Dictionary<string, List<TrainSession>>();
                foreach (string s in lines)
                {
                    dynamic jsonObject = JsonConvert.DeserializeObject(s);
                    string username = jsonObject.username;
                    List<TrainSession> sessions = new List<TrainSession>();
                    foreach (dynamic training in jsonObject.TrainingSessions)
                    {
                        List<ErgometerData> ergoData = new List<ErgometerData>();
                        foreach (dynamic ergometerData in training)
                        {
                            ergoData.Add(new ErgometerData(ergometerData.pulse, ergometerData.rpm, ergometerData.speed, ergometerData.distance, ergometerData.time, 0, 0, ergometerData.power));
                        }
                        TrainSession trainingsession = new TrainSession();
                        trainingsession.SetData(ergoData);
                        if (dictionary.ContainsKey(username))
                        {
                            dictionary[username].Add(trainingsession);
                        }
                        else
                        {
                            List<TrainSession> trainingList = new List<TrainSession>();
                            sessions.Add(trainingsession);
                            dictionary.Add(username, trainingList);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error while reading:(\r\n" + e.Message);
            }
        }

        public static Boolean AddActiveSession(string username)
        {
            if (!ActiveTrainSessions.ContainsKey(username))
            {
                ActiveTrainSessions.Add(username, new TrainSession());
                return true;
            }
            return false;
        }

        public static Boolean AddErgometerDataToSession(string username, ErgometerData data)
        {
            if (ActiveTrainSessions.ContainsKey(username))
            {
                ((TrainSession)ActiveTrainSessions[username]).AddData(data);
                return true;
            }
            return false;
        }

        public static void CloseActiveSession(string username)
        {
            TrainSession sessionToClose = ActiveTrainSessions[username];
            ActiveTrainSessions.Remove(username);
            if (TrainSessions.ContainsKey(username))
            {
                ((List<TrainSession>)TrainSessions[username]).Add(sessionToClose);
            }
            else
            {
                List<TrainSession> trainList = new List<TrainSession>();
                trainList.Add(sessionToClose);
                TrainSessions.Add(username, trainList);
            }

        }

        public static void Close()
        {
            try
            {
                String path = Path.Combine(Directory.GetCurrentDirectory(), @"Database\Database.txt");
                string toWrite = "";
                foreach (KeyValuePair<string, List<TrainSession>> entry in TrainSessions)
                {

                    dynamic keyValuePair = new
                    {
                        username = entry.Key,
                        data = new
                        {
                            Trainingsession = entry.Value
                        }
                    };
                    toWrite += JsonConvert.SerializeObject(keyValuePair) + "\r\n";
                }
                File.WriteAllText(path, toWrite);
            } catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Error while saving:(\r\n" + e.Message);
            }
        }
    }
}
