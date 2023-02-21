using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.assignment3
{
    class MarketingExecutive : Employee
    {
        double Km_Travel;
        double Tel_A;
        double Tour_A;
        double gs;

        public new void CalculateGross()
        {
            Console.WriteLine("Enter Travel distance in KM:");
            Km_Travel = Convert.ToInt32(Console.ReadLine()); ;

            Tel_A = 1000;

            Tour_A = Km_Travel * 5;

            base.CalculateGross();
            gs = GROSSSALARY;

            GROSSSALARY = GROSSSALARY + Tel_A + Tour_A;

        }
        public override void CalculateSalary()
        {

            PF1 = gs / 10;

            TDS1 = gs / 18;

            NETSALARY = gs - (PF1 + TDS1);



        }
        /* public new void display()
         {
             Console.WriteLine("\nThe Emp NO is      :  " + EMPNO);
             Console.WriteLine("\nThe Emp Name is    :  " + EMPNAME);
             Console.WriteLine("\nThe salary is      :  " + SALARY);
             Console.WriteLine("\n_____________________________________");
            // Console.WriteLine("\nThe Petrol allowance is:  " + Km_Travel);
             Console.WriteLine("\nThe telephone allowance is  :  " + Tel_A);
             Console.WriteLine("\nThe Tour allowance is:  " + Tour_A);
             Console.WriteLine("\nThe  HRA is        :  " + HRA1);
             Console.WriteLine("\nThe TA is          :  " + TA1);
             Console.WriteLine("\nThe  DA is         :  " + DA1);
             Console.WriteLine("\nThe Gross Salary is:  " + GROSSSALARY);
             Console.WriteLine("\nThe  PF is         :  " + PF1);
             Console.WriteLine("\nThe TDS is         :  " + TDS1);
             Console.WriteLine("\nThe  Net Salary is :  " + NETSALARY);
             Console.WriteLine("\n-----------------------------------------");
             Console.WriteLine("\n-----------------------------------------");
         }*/
    }
}
    

