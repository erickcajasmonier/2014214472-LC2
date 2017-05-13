using _2014214472_ENT.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_ENT.Entities
{
    public class Automovil : Carro
    {

        //Enumerador
        public TipoAuto TipoAuto { get; set; }



        public Automovil(TipoAuto tipoAuto)
        {
            //Enumerador
            TipoAuto = tipoAuto;
        }

        public Automovil()
        {
            TipoAuto = TipoAuto.NoDefinido;
        }
    }
}
