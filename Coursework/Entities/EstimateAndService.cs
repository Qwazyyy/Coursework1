﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Entities
{
    public class EstimateAndService
    {
        public int ContractID { get; set; }
        //public int ServiceID { get; set; }
        public int EstimateID { get; set; }
        public string ServiceName { get; set; }
        public int ServicePrice { get; set; }
        public string ServiceUnit { get; set; }
        public double EstimateFullPrice { get; set; }
        public double EstimateCount { get; set; }
    }
}
