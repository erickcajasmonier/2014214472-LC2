﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_ENT.Entities
{
    public class Llanta
    {
        public int LlantaId { get; set; }

        public string NumSerie { get; set; }

        // 1 a 1
        public Carro Carro { get; set; }
        public int CarroId { get; set; }
    }
}
