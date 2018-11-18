using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobHuntOnline.DAL.Repositories
{
    public class GenericRepository <T> where T : class
    {
        DbContext dbContext;
        DbSet<T> dbSet;
        public GenericRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<T>();
        }
        public void Insert(T entityToAdd)
        {
            dbSet.Add(entityToAdd);
        }
        public void EntityToDlete(object Id)
        {
            T entityToDelete = dbSet.Find(Id);
            dbSet.Remove(entityToDelete);
        }
        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }
        public List<T> Find(Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter).ToList();
        }
        public bool Exist(Expression<Func<T, bool>> filter)
        {
            return dbSet.Any(filter);
        }
        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }

    }
}
