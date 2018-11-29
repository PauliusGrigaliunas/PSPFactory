using System;
using System.Collections.Generic;
using System.Text;

namespace IRentControllerPack
{
    public interface IRentView
    {
        void AddController(IRentController controller);
        void ShowMenu();
    }
}
