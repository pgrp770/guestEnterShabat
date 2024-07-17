using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guestEnterShabat.Repositories
{
    internal interface IRepositories<T>
    {
        public void Create(T category);
        public void Update(T category);
        public void DeleteByID(int id);
        public void DeleteAll();
        public T GetById(int id);
        public List<T> GetAll();
    }
}
