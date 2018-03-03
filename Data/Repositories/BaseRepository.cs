using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public abstract class BaseRepository<T> where T: BaseEntity
    {
        private EventManagerDbContext DbContext { get; set; }

        private DbSet<T> Items { get; set; }   

        public BaseRepository()
        {
            DbContext = new EventManagerDbContext();
            Items = DbContext.Set<T>();
        }

        public BaseRepository(UnitOfWork unitOfWork)
        {
            DbContext = unitOfWork.DbContext;
            Items = DbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return Items.Where(i => i.Id == id).FirstOrDefault();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = Items;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();
        }

        public void Insert(T item)
        {
            Items.Add(item);
            DbContext.SaveChanges();
        }

        public void Delete(T item)
        {
            Items.Remove(item);
            DbContext.SaveChanges();
        }

        public void Update(T item)
        {
            DbContext.Entry(item).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}
