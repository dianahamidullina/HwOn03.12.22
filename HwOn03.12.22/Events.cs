using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HwOn03._12._22
{
    public class Events
    {
      
        public string events;

        public Events(string events)
        {
          this.events= events;

        }
        public Events()
        {

        }
       public string Print()
        {
            return $"{events}";
        }
    }
}
