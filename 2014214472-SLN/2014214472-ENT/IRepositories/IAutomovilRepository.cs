using _2014214472_ENT.Entities;
using _2014214472_ENT.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_ENT.IRepositories
{
    public interface IAutomovilRepository : IRepository<Automovil>
    {
        //Obtener la relacion de automoviles por tipo de auto
        IEnumerable<Automovil> GetAutomovilByTipoAuto(TipoAuto tipoAuto);
    }
}
