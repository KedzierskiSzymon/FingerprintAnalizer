using DatabaseModel.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModel.Interfaces
{
    public interface IRepository<T> 
        where T : BaseRecord
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        int Add(T item);
        void Delete(int id);
        T Update(T item);
    }
}
