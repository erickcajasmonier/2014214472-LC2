using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        //Propiedades de solo lectura
        IAsientoRepository Asientos { get; }
        IAutomovilRepository Automoviles { get; }
        IBusRepository Buses { get; }
        ICinturonRepository Cinturones { get; }
        IEnsambladoraRepository Ensambladoras { get; }
        ILlantaRepository Llantas { get; }
        IPropietarioRepository Propietarios { get; }
        IParabrisasRepository Parabrisas { get; }
        IVolanteRepository Volantes { get; }

        //Metodo que guardara los cambios en la BD
        int SaveChanges();
    }
}
