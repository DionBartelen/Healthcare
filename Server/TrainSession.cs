﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [Serializable]
    class TrainSession
    {
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public List<ErgometerData> data;

        public TrainSession()
        {
            data = new List<ErgometerData>();
        }

        public void SetData(List<ErgometerData> data)
        {
            this.data = data;
        }

        public void AddData(ErgometerData ergometerData)
        {
            data.Add(ergometerData);
        }
    }
}
