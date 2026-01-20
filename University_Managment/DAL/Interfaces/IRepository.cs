using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IRepository<T>
    {
        bool Create(T s);
        T Get(int id);
        List<T> Get();
        bool Update(T s);
        bool Delete(int id);
        object PaymentStatus(int id);
    }
}
