﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVendas.BLLClasses
{
    class produtoBLL
    {
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public string descrition { get; set; }
        public decimal rate { get; set; }
        public decimal qty { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }


    }
}