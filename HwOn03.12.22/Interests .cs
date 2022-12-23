using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwOn03._12._22
{
      public class Interests
    {
        public delegate void InterestsDelegate();
        public event InterestsDelegate Consert;
        public event InterestsDelegate Proga;
        public event InterestsDelegate Sleeping;
        public void Massage()

        {
            Console.WriteLine("Enter the next eventions : proga , consert , sleeping");
            string evention = Console.ReadLine();   
            switch(evention)
            {
                case "consert":
                Consert();
                    break;
                case "proga":
                    Proga();
                    break;
                case "sleeping":
                    Sleeping();
                    break;
                default:
                    Console.WriteLine($"Error" + "Please enter another evention\n");
                    break;
            }
        }
    }
}
