﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfFromDb
{
    [DataContract]
    public class Data
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surename { get; set; }
        [DataMember]
        public string Address { get; set; }
    }
}
