using _2014214472_ENT.Entities;
using _2014214472_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_PER.Repositories
{
    public class CinturonRepository : Repository<Cinturon>, ICinturonRepository
    {
        private readonly EnsambladoraDbContext _Context;

        public CinturonRepository(EnsambladoraDbContext context)
        {
            // TODO: Complete member initialization
            _Context = context;
        }

        private CinturonRepository() : base()
        {

        }


        void IRepository<Cinturon>.Add(Cinturon entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.AddRange(IEnumerable<Cinturon> entities)
        {
            throw new NotImplementedException();
        }

        Cinturon IRepository<Cinturon>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Cinturon> IRepository<Cinturon>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Cinturon> IRepository<Cinturon>.Find(System.Linq.Expressions.Expression<Func<Cinturon, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.Update(Cinturon entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.UpdateRange(IEnumerable<Cinturon> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.Delete(Cinturon entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Cinturon>.DeleteRange(IEnumerable<Cinturon> entities)
        {
            throw new NotImplementedException();
        }
    }
}
