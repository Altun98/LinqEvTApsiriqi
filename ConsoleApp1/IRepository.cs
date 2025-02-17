using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetAllByID(int ID);
        void Add(T item);
        void Update(T item);
        void Delete(T Item);

    }
}
