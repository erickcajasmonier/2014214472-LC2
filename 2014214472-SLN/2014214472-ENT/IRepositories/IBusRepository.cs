using _2014214472_ENT.Entities;
using _2014214472_ENT.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_ENT.IRepositories
{
    public interface IBusRepository : IRepository<Bus>
    {
        //Obtener la relacion de buses por sus tipos de buses
        IEnumerable<Bus> GetBusByTipoBus(TipoBus tipoBus);
    }
}
