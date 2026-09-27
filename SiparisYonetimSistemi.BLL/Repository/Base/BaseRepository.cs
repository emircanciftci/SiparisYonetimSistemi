using SiparisYonetimSistemi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SiparisYonetimSistemi.DAL.DB;

namespace SiparisYonetimSistemi.BLL.Repository.Base
{
    public class BaseRepository<T> where T : class
    {
        private SiparisDBEntities db;
        protected DbSet<T> table;

        public BaseRepository()
        {
            db = new SiparisDBEntities();
            table = db.Set<T>();
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public virtual void Insert(T entity)
        {
            table.Add(entity);
            Save();
        }
        public List<T> GetAll()
        {
            return table.ToList();
        }
        public T Find(long ID)
        {
            return table.Find(ID);
        }
    }
}
