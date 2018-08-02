using System;

namespace month_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put in the number of a month");
            int bob =
            int.Parse(Console.ReadLine());

            Console.WriteLine(bob);
            if (bob == 2)
            {
                Console.WriteLine("February");
            }

            else if (bob == 3)
            {
                Console.WriteLine("March");
            }
            else if (bob == 4)
            {
                Console.WriteLine("April");
            }
            else
            {
                Console.WriteLine("hey dummy I wanted a 2");
            }

            Console.ReadLine();

        }
    }
}
