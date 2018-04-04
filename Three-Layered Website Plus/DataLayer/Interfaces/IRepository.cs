using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WebSite8.Data.Interfaces
{
    public interface IRepository<TDataSet> where TDataSet : class 
    {
        IQueryable<TDataSet> All();
        void Add(TDataSet data);
        void Add(IEnumerable<TDataSet> data);
        void Delete(TDataSet data);
        void Delete(IEnumerable<TDataSet> data);
    }
}