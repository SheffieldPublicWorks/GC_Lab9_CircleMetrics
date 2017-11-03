using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable10_Lab9_CircleMetrics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/************************************/");
            Console.WriteLine("/*       Circles of Fury v1.0       */");
            Console.WriteLine("/************************************/");
            Console.WriteLine();

            double radius;
            bool continueProcessing = true;
            while (continueProcessing)
            {
                bool valid = false;
                while (!valid)
                {
                    Console.Write("Please enter the radius of a circle to calculate it's area and circumference: ");

                    valid = Double.TryParse(Console.ReadLine(), out radius);
                    if (!valid || radius <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("ERROR: Please enter a valid number for the radius.");
                    }
                    else
                    {
                        Circle userCircle = new Circle(radius);
                        Console.WriteLine($"The circumference is: {userCircle.GetFormattedCircumference()}");
                        Console.WriteLine($"The area is: {userCircle.GetFormattedArea()}");
                        Console.WriteLine();
                        valid = true;
                    }
                }

                Console.Write("Do you want to continue entering radii for circles? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    continueProcessing = true;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Thanks for using Circles of Fury. You created {0} circles", Circle.circCount);
                    Console.WriteLine("Hope to see you soon.");
                    continueProcessing = false;
                }
            }
        }
    }
}
