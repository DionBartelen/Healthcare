﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_test.VR
{
    class Commands
    {
        public static string tree1 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\trees\fantasy\tree1.obj");
        public static string tree2 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\trees\fantasy\tree2.obj");
        public static string tree3 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\trees\fantasy\tree3.obj");
        public static string tree4 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\trees\fantasy\tree4.obj");
        public static string tree5 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\trees\fantasy\tree5.obj");
        public static string tree6 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\trees\fantasy\tree6.obj");
        public static string tree7 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\trees\fantasy\tree7.obj");
        public static string tree10 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\trees\fantasy\tree10.obj");

        public static string bike = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\bike\bike.fbx");
        public static string carcartoon = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\cars\cartoon\Pony_cartoon.obj");
        public static string carcartoon2 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\cars\cartoon\Pony_cartoon2.obj");
        public static string house1 = Path.Combine(Directory.GetCurrentDirectory(), @"NetwerkEngineData\models\houses\set1\house1.obj");



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


        public static dynamic AddObject(string tunnel)
        {
            int[] aPosition = new int[3] { 0, 0, 0 };
            int[] aRotation = new int[3] { 0, 0, 0 };
            int[] aPanelSize = new int[2] { 1, 1 };
            int[] aResolution = new int[2] { 512, 512 };
            int[] aBackground = new int[4] { 1, 1, 1, 1 };
            int[] aWaterSize = new int[2] { 20, 20 };

            dynamic request = new
            {
                id = "scene/node/add",
                data = new
                {
                    name = "name",
                    //parent = "guid",
                    components = new
                    {
                        transform = new
                        {
                            position = aPosition,
                            scale = 1,
                            rotation = aRotation
                        },
                        model = new
                        {
                            file = bike,
                            cullbackfaces = true,
                            animated = false,
                            animation = "animationname",
                        }//,
                        //terrain = new
                        //{
                        //    smoothnormals = true
                        //},
                        //panel = new
                        //{
                        //    size = aPanelSize,
                        //    resolution =  aResolution,
                        //    background = aBackground,
                        //},
                        //water = new
                        //{
                        //    size = aWaterSize,
                        //    resolution = 0.1f
                        //}
                    }
                }
            };
            return Commands.SendTunnel(tunnel, request);
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

        public static dynamic AddRoute(string tunnel)
        {
            int[] pos1 = new int[3] { 0, 0, 0 };
            int[] pos2 = new int[3] { 50, 0, 0 };
            int[] pos3 = new int[3] { 50, 0, 50 };
            int[] pos4 = new int[3] { 0, 0, 50 };

            int[] dir1 = new int[3] { 5, 0, -5 };
            int[] dir2 = new int[3] { 5, 0, 5 };
            int[] dir3 = new int[3] { -5, 0, 5 };
            int[] dir4 = new int[3] { -5, 0, -5 };
            dynamic node1 = new
            {
                pos = pos1,
                dir = dir1
            };
            dynamic node2 = new
            {
                pos = pos2,
                dir = dir2
            };
            dynamic node3 = new
            {
                pos = pos3,
                dir = dir3
            };
            dynamic node4 = new
            {
                pos = pos4,
                dir = dir4
            };

            dynamic[] routeNodes = new dynamic[4] { node1, node2, node3, node4 };

            dynamic request = new
            {
                id = "route/add",
                data = new
                {
                    nodes = routeNodes
                }
            };

            return Commands.SendTunnel(tunnel, request);
        }

        public static dynamic AddRoad(string tunnel, string uuid)
        {
            dynamic request = new
            {
                id = "scene/road/add",
                data = new
                {
                    route = uuid,
                    heightoffset = 0.01
                }
            };
            return Commands.SendTunnel(tunnel, request);
        }
    }
}
