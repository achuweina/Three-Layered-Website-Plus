using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebSite8.Data.Interfaces;

namespace $safeprojectname$
{
    public class Repository<TData> : IRepository<TData> where TData : class 
    {

        private DbSet<TData> _data;

        public Repository(DbSet<TData> data)
        {
            _data = data;
        }

        public IQueryable<TData> All()
        {
            return _data.AsQueryable();
        }

        public void Add(TData data)
        {
            _data.Add(data);
        }

        public void Add(IEnumerable<TData> data)
        {
            _data.AddRange(data);
        }

        public void Delete(TData data)
        {
            _data.Remove(data);
        }

        public void Delete(IEnumerable<TData> data)
        {
            _data.RemoveRange(data);
        }
    }
}
