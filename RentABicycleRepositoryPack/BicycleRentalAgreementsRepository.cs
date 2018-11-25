using System;
using System.Collections.Generic;
using System.Text;
using RepositionAPIPack;
using IRentABicycleApi;
using System.Linq;

namespace RentABicycleRepositoryPack
{
    class BicycleRentalAgreementsRepository : IRepositor <IBicycleRentalAgreement>
    {
        private List<IBicycleRentalAgreement> _items = new List<IBicycleRentalAgreement>();
        public void Add(IBicycleRentalAgreement item)
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

        public List<IBicycleRentalAgreement> GetAll()
        {
            return _items;
        }

        public IBicycleRentalAgreement GetById(string itemId)
        {
            return _items.FirstOrDefault(x => x.Id == itemId);
        }

        public void Update(IBicycleRentalAgreement item)
        {
            if (_items.Any(x => x.Id == item.Id))
            {
                Delete(item.Id);
                _items.Add(item);
            }
            else _items.Add(item);
        }
    }
}
