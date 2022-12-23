using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tumakov11_12
{
    internal class FactoryOfShet2: Factory // notsber
    {
        public override void CreateAccount()
        {
            Console.WriteLine("Now u have opened notsbershet");
            BankAccaunt bankAccaunt = new BankAccaunt(20848394);
            bankAccaunt.CreateAccount();
        }
        public override void RemoveAccount()
        {
            BankAccaunt bankaccount2 = new BankAccaunt(349083474);
          //  bankaccount2.RemoveAccount();
        }

    }
}
