﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ClientInfo
    {
        public String HostName { get; }
        public String ID { get; }

        public ClientInfo(String HostName, String ID)
        {
            this.HostName = HostName;
            this.ID = ID;
        }
    }
}
