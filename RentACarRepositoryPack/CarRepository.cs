using System;
using System.Collections.Generic;
using System.Linq;
using IRentACarApiPack;
using RepositionAPIPack;

namespace RentACarRepositoryPack
{
    public class CarRepository : IRepositor<ICar>
    {
        private List<ICar> _items = new List<ICar>();
        public void Add(ICar item)
        {
            if (!_items.Any(x => x.Id == item.Id))
            {
                
            }
            else
            {
                throw new Exception("This accountant record already exists.");
            }
        }

        public void Delete(string itemId)
        {
            _items.RemoveAll(x => x.Id == itemId);
        }

        public void Update(ICar item)
        {
            if (_items.Any(x => x.Id == item.Id))
            {
                Delete(item.Id);
                _items.Add(item);
            }
            else _items.Add(item);
        }

        public List<ICar> GetAll()
        {
            return _items;
        }

        public ICar GetById(string itemId)
        {
            return _items.FirstOrDefault(x => x.Id == itemId);
        }


    }
}
