using _2014214472_ENT.Entities;
using _2014214472_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_PER.Repositories
{
    public class LlantaRepository : Repository<Llanta>, ILlantaRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public LlantaRepository(EnsambladoraDbContext context)
        {
            // TODO: Complete member initialization
            _Context = context;
        }

        private LlantaRepository() : base()
        {

        }


        void IRepository<Llanta>.Add(Llanta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.AddRange(IEnumerable<Llanta> entities)
        {
            throw new NotImplementedException();
        }

        Llanta IRepository<Llanta>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Llanta> IRepository<Llanta>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Llanta> IRepository<Llanta>.Find(System.Linq.Expressions.Expression<Func<Llanta, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.Update(Llanta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.UpdateRange(IEnumerable<Llanta> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.Delete(Llanta entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Llanta>.DeleteRange(IEnumerable<Llanta> entities)
        {
            throw new NotImplementedException();
        }
    }
}
