using _2014214472_ENT.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_ENT.Entities
{
    public class Bus : Carro
    {

        //Enumerador
        public TipoBus TipoBus { get; set; }



        public Bus(TipoBus tipoBus)
        {
            //Enumerador
            TipoBus = tipoBus;
        }

        public Bus()
        {
            TipoBus = TipoBus.NoDefinido;
        }
    }
}
