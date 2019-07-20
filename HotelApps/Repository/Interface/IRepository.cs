using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApps.Repository
{
    public interface IRepository<T>
    {
        bool Add(T obj);
        List<T> GetList();
    }
}
