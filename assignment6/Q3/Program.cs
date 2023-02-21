using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.assignment6.Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            Account cust = new Account(9083456, "AArti Jamdade", 500);

            cust.Deposit(4000);
            ZeroBalance z = new ZeroBalance(cust.ZeroBalance);
            del ub = new del(cust.UnderBalance);

            cust.Withdraw(400, ub, z);
        }
    }

}
    

