using System;
using RepositionAPIPack;
using IRentABicycleApi;
using System.Collections.Generic;
using System.Linq;

namespace RentABicycleRepositoryPack
{
    public class BicycleRepository : IRepositor<IBicycle>
    {

        private List<IBicycle> _items = new List<IBicycle>();
        public void Add(IBicycle item)
        {
            if (!_items.Any(x => x.Id == item.Id))
            {
                _items.Add(item);
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
        public void Update(IBicycle item)
        {
            if (_items.Any(x => x.Id == item.Id))
            {
                Delete(item.Id);
                _items.Add(item);
            }
            else _items.Add(item);
        }
        public List<IBicycle> GetAll()
        {
            return _items;
        }

        public IBicycle GetById(string itemId)
        {
            return _items.FirstOrDefault(x => x.Id == itemId);
        }


    }
}
