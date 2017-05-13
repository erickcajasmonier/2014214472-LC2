using _2014214472_ENT.Entities;
using _2014214472_ENT.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_ENT.IRepositories
{
    public interface IPropietarioRepository : IRepository<Propietario>
    {
        //Obtener la relacion de propietarios por sus carros
        IEnumerable<Propietario> GetPropietarioByCarro(Carro carro, int pageIndex, int pageSize);

        //Obtener la relacion de propietarios por sus carros y tipos de carros
        IEnumerable<Propietario> GetPropietarioByCarroAndTipoCarro(Carro carro, TipoCarro tipoCarro);
    }
}
