using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov11_12
{
    internal class FactoryOfShet1 : Factory // sbershet
    {
        public override void CreateAccount()
        {
            Console.WriteLine("Now u have opened a new sber shet");
            BankAccaunt bankAccaunt =  new BankAccaunt(1208284);
            bankAccaunt.CreateAccount();
        }
        public override void RemoveAccount()
        {
            BankAccaunt bankaccount1 = new BankAccaunt(2084384);
          //  bankaccount1.RemoveAccount();
        }
    }
}
