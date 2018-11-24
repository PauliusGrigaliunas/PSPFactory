using System;
using System.Collections.Generic;
using IRentACarApiPack;
using RepositionAPIPack;

namespace RentACarRepositoryPack
{
    public class CarRepository : IRepositor<ICar>
    {
        public void Add(ICar item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string itemId)
        {
            throw new NotImplementedException();
        }

        public List<ICar> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICar GetById(string itemId)
        {
            throw new NotImplementedException();
        }
    }
}
