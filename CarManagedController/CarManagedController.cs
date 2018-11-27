using System;
using CarManagerControllerAPIPack;
using ICarManagerFasadePack;
using IRentACarApiPack;
using IRentACarFasadePack;

namespace CarManagedControllerPack
{
    public class CarManagerController : ICarManagerController
    {

        private ICar _car;
        private ICarManagerFasade _carManagerFasade;
        private ICarManagerView _view;

        public CarManagerController(ICarManagerFasade reportFacade, ICarManagerView view)
        {
            _carManagerFasade = reportFacade;
            _view = view;
            _view.AddController(this);
        }


        public void LoadView()
        {

        }
    }

}
