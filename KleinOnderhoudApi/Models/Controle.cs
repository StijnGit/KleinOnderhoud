﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KleinOnderhoudApi.Models
{
    public class Controle
    {
        public DateTime Datum { get; set; }
        public bool BandenspanningOk { get; set; }
        public bool Eindresultaat { get; set; }
        public List<ControlePunt> lstControlePunt { get; set; }
    }
}