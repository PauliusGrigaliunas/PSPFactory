using System;
using System.Collections.Generic;
using System.Linq;
using IRentACarApiPack;
using RepositionAPIPack;

namespace RentACarRepositoryPack
{
    public class CarRentalAgreementsRepository : IRepositor<ICarRentalAgreement>
    {
        private List<ICarRentalAgreement> _items = new List<ICarRentalAgreement>();
        public void Add(ICarRentalAgreement item)
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
        public void Update(ICarRentalAgreement item)
        {
            if (_items.Any(x => x.Id == item.Id))
            {
                Delete(item.Id);
                _items.Add(item);
            }
            else _items.Add(item);
        }

        public List<ICarRentalAgreement> GetAll()
        {
            return _items;
        }

        public ICarRentalAgreement GetById(string itemId)
        {
            return _items.FirstOrDefault(x => x.Id == itemId);
        }
    }
}
