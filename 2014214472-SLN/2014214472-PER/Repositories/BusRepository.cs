using _2014214472_ENT.Entities;
using _2014214472_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_PER.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public BusRepository(EnsambladoraDbContext context)
        {
            // TODO: Complete member initialization
            _Context = context;
        }

        private BusRepository() : base()
        {

        }


        IEnumerable<Bus> IBusRepository.GetBusByTipoBus(_2014214472_ENT.Enumerados.TipoBus tipoBus)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Add(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.AddRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        Bus IRepository<Bus>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Bus> IRepository<Bus>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Bus> IRepository<Bus>.Find(System.Linq.Expressions.Expression<Func<Bus, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Update(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.UpdateRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Delete(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.DeleteRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }
    }
}
