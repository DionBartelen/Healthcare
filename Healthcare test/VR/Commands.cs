using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_test.VR
{
    class Commands
    {
        public static dynamic SessionList()
        {
            dynamic request = new
            {
                id = "session/list"
            };

            return request;
        }

        public static dynamic CreateTunnel(string clientID)
        {
            dynamic request = new
            {
                id = "tunnel/create",
                data = new
                {
                    session = clientID
                }
            };

            return request;
        }

        public static dynamic SendTunnel(string tunnel, dynamic dataToSend)
        {
            dynamic request = new
            {
                id = "tunnel/send",
                data = new
                {
                    dest = tunnel,
                    data = dataToSend
                }
            };
            return request;
        }

        public static dynamic SetTime(string tunnel, double timeToSet)
        {
            dynamic timeRequest = new
            {
                id = "scene/skybox/settime",
                data = new
                {
                    time = timeToSet
                }
            };
            return Commands.SendTunnel(tunnel, timeRequest);
        }

        public static dynamic CreateGroundTerrain(string tunnel)
        {
            dynamic groundTerrain = new
            {
                id = "scene/terrain/add",
                data = new
                {
                    size = new[] { 256, 256 },
                    heights = Enumerable.Repeat(0, (256 * 256)).ToArray()
        }

    };
            return Commands.SendTunnel(tunnel, groundTerrain);

        }

        public static dynamic RemoveTerrain(String tunnel)
        {
            dynamic removeTerrain = new
            {
                id = "scene/terrain/delete",
                data = new
                {

                }

            };
            return Commands.SendTunnel(tunnel, removeTerrain);
        }
    }
}
