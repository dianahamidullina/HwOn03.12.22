using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov11_12
{

    /// <summary>
    /// class is factory
    /// </summary>
    public abstract class Factory : IChooseShet//Fabric
    {
        public abstract void CreateAccount();
        public abstract void RemoveAccount();

      
    }

}
