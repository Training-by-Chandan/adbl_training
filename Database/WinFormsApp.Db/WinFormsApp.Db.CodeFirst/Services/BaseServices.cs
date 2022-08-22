using Microsoft.EntityFrameworkCore;
using WinFormsApp.Db.CodeFirst.Data;

namespace WinFormsApp.Db.CodeFirst.Services
{
    public abstract class BaseServices<T>
        where T : class
    {
        protected DefaultContext db = new DefaultContext();
        protected DbSet<T> dbset;

        public BaseServices()
        {
            dbset = db.Set<T>();
        }

        public virtual (bool, string) Create(T model)
        {
            try
            {
                dbset.Add(model);
                db.SaveChanges();
                return (true, "Created Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public virtual List<T> GetAll()
        {
            return dbset.ToList();
        }
    }
}