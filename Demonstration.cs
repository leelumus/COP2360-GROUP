
using System;
using System.Collections.Generic;

namespace ContractorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Subcontractor> subcontractors = new List<Subcontractor>();

            while (true)
            {
                Console.WriteLine("Enter subcontractor details:");
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Number: ");
                string number = Console.ReadLine();
                
                Console.Write("Start Date (yyyy-MM-dd): ");
                DateTime startDate;
                while (!DateTime.TryParse(Console.ReadLine(), out startDate))
                {
                    Console.Write("Invalid date. Please enter the start date (yyyy-MM-dd): ");
                }
                
                Console.Write("Shift (1 for Day, 2 for Night): ");
                int shift;
                while (!int.TryParse(Console.ReadLine(), out shift) || (shift != 1 && shift != 2))
                {
                    Console.Write("Invalid shift. Please enter 1 for Day or 2 for Night: ");
                }
                
                Console.Write("Hourly Pay Rate: ");
                double hourlyPayRate;
                while (!double.TryParse(Console.ReadLine(), out hourlyPayRate) || hourlyPayRate < 0)
                {
                    Console.Write("Invalid pay rate. Please enter a positive number: ");
                }

                Subcontractor subcontractor = new Subcontractor(name, number, startDate, shift, hourlyPayRate);
                subcontractors.Add(subcontractor);

                Console.WriteLine("Subcontractor added.");
                
                Console.WriteLine("Do you want to add another subcontractor? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }

            Console.WriteLine("\nSubcontractor Details:");
            foreach (var sub in subcontractors)
            {
                sub.DisplayInfo();
                Console.WriteLine($"Computed Pay for 40 hours: {sub.ComputePay(40):C}");
                Console.WriteLine();
            }
        }
    }
}
