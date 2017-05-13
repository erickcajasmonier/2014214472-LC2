using _2014214472_ENT.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_ENT.Entities
{
    public class Ensambladora
    {
        public int EnsambladoraId { get; set; }

        //1 a muchos
        public List<Carro> Carros { get; set; }


        public Ensambladora()
        {
            //Composicion 1 a muchos
            Carros = new List<Carro>();
        }

    }
}
