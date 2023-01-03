using Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account  = new BusinessAccount(8010,"bob brown",100.0,500.0);


            Console.WriteLine(account.Balance);

            Account acc = new Account(1001, "alex", 0.0);
            BusinessAccount bcc = new BusinessAccount(1002, "maria", 0.0, 500.0);


            // UpCasting

            Account acc1 =  bcc;
            Account acc2 = new BusinessAccount(1003, "bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "anna", 0.0, 0.01);

            // DownCasting

            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.0);

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount) acc3;
            }
        }


    }
}
