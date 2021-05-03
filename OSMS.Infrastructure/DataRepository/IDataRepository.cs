using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSMS.Infrastructure.DataRepository
{
    public interface IDataRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T model);
        void Update(T model);
        void Delete(T model);
        int SaveChanges();

    }
}
