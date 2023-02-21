using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.assignment3
{
    class Manager : Employee
    {
        double Petrol_A;

        double Food_A;

        double Other_A;

        double gs;

        public new void CalculateGross()
        {
            Petrol_A = SALARY / 8;
            Food_A = SALARY / 13;
            Other_A = SALARY / 3;

            base.CalculateGross();
            gs = GROSSSALARY;

            GROSSSALARY = GROSSSALARY + Petrol_A + Food_A + Other_A;

        }
        public override void CalculateSalary()
        {

            PF1 = gs / 10;

            TDS1 = gs / 18;

            NETSALARY = gs - (PF1 + TDS1);



        }
        /*public new void display()
        {
            Console.WriteLine("\nThe Emp NO is      :  " + EMPNO);
            Console.WriteLine("\nThe Emp Name is    :  " + EMPNAME);
            Console.WriteLine("\nThe salary is      :  " + SALARY);
            Console.WriteLine("\n_____________________________________");
            Console.WriteLine("\nThe Petrol allowance is:  " + Petrol_A);
            Console.WriteLine("\nThe Food allowance is  :  " + Food_A);
            Console.WriteLine("\nThe Other allowance is:  " + Other_A);
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
    

