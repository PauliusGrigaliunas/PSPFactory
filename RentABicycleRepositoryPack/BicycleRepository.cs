using System;
using RepositionAPIPack;
using IRentABicycleApi;
using System.Collections.Generic;

namespace RentABicycleRepositoryPack
{
    public class BicycleRepository : IRepositor<IBicycle>
    {
        public void Add(IBicycle item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string itemId)
        {
            throw new NotImplementedException();
        }

        public List<IBicycle> GetAll()
        {
            throw new NotImplementedException();
        }

        public IBicycle GetById(string itemId)
        {
            throw new NotImplementedException();
        }
    }
}
