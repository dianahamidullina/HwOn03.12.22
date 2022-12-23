using System;
using System.Collections;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace tumakov11_12
{
    
    internal class BankAccaunt : IChooseShet
    {
        public int ID;
      
        public BankAccaunt(int ID)
        {
            this.ID = ID;

        }
        public void CreateAccount()
        {
            Random random = new Random();
            int ID = random.Next(1000000000);
           Console.WriteLine($"Your number of Shet:\n {ID}");
            BankAccaunt bank = new BankAccaunt(51111178);
            accounts[bank.ID] = bank;
            Console.WriteLine(bank);
        }
        public void RemoveAccount()
        {
           /* BankAccaunt bank1 = new BankAccaunt(51111178);
            accounts.Remove(accounts[ID]);
            Console.WriteLine(bank1);
           */
        }
        
        public Hashtable accounts = new Hashtable(); //hash- table
        

    }
}
