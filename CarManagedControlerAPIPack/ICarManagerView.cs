using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagerControllerAPIPack
{
    public interface ICarManagerView
    {
        void AddController(ICarManagerController controller);
    }
}

