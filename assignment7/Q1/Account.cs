using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp8.assignment7.Q1
{
    class Account
    {
        static void Main(String[] args)
        {

            string file = @"C:\Users\AARAJEND\source\repos\ConsoleApp8\ConsoleApp8\assignment7";
            Console.WriteLine("Enter Customer Details....");
            Console.WriteLine("Enter Account Number:");
            int Acc_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            string Customer_Name = Console.ReadLine();
            Console.WriteLine("Enter Balance:");
            int Balance = Convert.ToInt32(Console.ReadLine());


            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Write("Customer Name:" + Customer_Name + "\nAccount Number:" + Acc_Number + "\nBalance:" + Balance);
            }
            Console.WriteLine("Saved");

            Console.WriteLine("\n\nReading Text File:::");

            using (StreamReader reader = new StreamReader(file))
            {
                Console.WriteLine(reader.ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}
    
