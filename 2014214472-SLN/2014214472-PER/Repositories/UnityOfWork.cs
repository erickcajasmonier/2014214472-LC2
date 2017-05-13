using _2014214472_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {

        public IAsientoRepository Asientos
        {
            get;
            private set;
        }

        public IAutomovilRepository Automoviles
        {
            get;
            private set;
        }

        public IBusRepository Buses
        {
            get;
            private set;
        }

        public ICinturonRepository Cinturones
        {
            get;
            private set;
        }

        public IEnsambladoraRepository Ensambladoras
        {
            get;
            private set;
        }

        public ILlantaRepository Llantas
        {
            get;
            private set;
        }

        public IPropietarioRepository Propietarios
        {
            get;
            private set;
        }

        public IParabrisasRepository Parabrisas
        {
            get;
            private set;
        }

        public IVolanteRepository Volantes
        {
            get;
            private set;
        }



        //Privado para qeu fuerce a utilizar la propiedad Instance
        private readonly EnsambladoraDbContext _Context;
        private UnityOfWork()
        {
            //Se crea un unico contexto de BD para apuntar a todos los repositorios a la misma BD
            _Context = new EnsambladoraDbContext();

            Asientos = new AsientoRepository(_Context);
            Automoviles = new AutomovilRepository(_Context);
            Buses = new BusRepository(_Context);
            Cinturones = new CinturonRepository(_Context);
            Ensambladoras = new EnsambladoraRepository(_Context);
            Llantas = new LlantaRepository(_Context);
            Parabrisas = new ParabrisasRepository(_Context);
            Propietarios = new PropietarioRepository(_Context);
            Volantes = new VolanteRepository(_Context);
        }


        //Implementacion del patron Singleton para instanciar la clase UnityOfWork
        //Asegura que en cualquier parte del codigo que se quiera instanciar la BD, se devuelva una unica referencia
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();
        public static UnityOfWork Instance 
        {
            get 
            {
                //Variable de control para manejar el acceso concurrente al instanciamiento de la clase UnityOfWork
                lock (_Lock)
                {
                    if (_Instance == null)
                    {
                        _Instance = new UnityOfWork();
                    }
                }

                return _Instance;
            }
        }



        public int SaveChanges()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
