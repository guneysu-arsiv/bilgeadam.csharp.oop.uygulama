﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjandaUygulama.Entity
{
    [Serializable]
    public class Durum:Kayit
    {
        public Enums.Durum durum { get; set; }
    }
}
