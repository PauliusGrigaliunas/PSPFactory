using System;
using System.Collections.Generic;

namespace RepositionAPIPack
{
    public interface IRepositor<T>
    {
        void Add(T item);
        void Delete(string itemId);
        T GetById(string itemId);
        List<T> GetAll();
    }
}
