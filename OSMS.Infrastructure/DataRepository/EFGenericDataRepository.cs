using Microsoft.EntityFrameworkCore;
using OSMS.Infrastructure.DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSMS.Infrastructure.DataRepository
{
    public class EFGenericDataRepository<T> : IDataRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext context;
        private readonly DbSet<T> entities;

        public EFGenericDataRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public void Create(T model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));
            entities.Add(model);
        }

        public void Delete(T model)
        {
            entities.Remove(model);
        }

        public T Get(int id)
        {
            return entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }

        public void Update(T model)
        {
            entities.Update(model);
        }
    }
}
