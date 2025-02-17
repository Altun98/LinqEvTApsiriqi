using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _db;
        private DbSet<T> _ds;
        public BaseRepository()
        {
            _db = new AppDbContext();
            _ds = _db.Set<T>();

        }
        public void Add(T item)
        {
            _ds.Add(item);
            _db.SaveChanges();
        }

        public void Delete(T item)
        {
            _ds.Remove(item);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _ds.ToList();
        }

        public T GetAllByID(int ID)
        {
            return _ds.Find(ID);
        }

        public void Update(T item)
        {
            _ds.Update(item);
            _db.SaveChanges();
        }
    }
}
