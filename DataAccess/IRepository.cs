using System;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IRepository<T>
    {
        public List<T> GetAll();
        public T GetById(int id);
        public T Add(T entity);
        public bool Update(T entity);
        public bool Delete(int id); 

    }
}
