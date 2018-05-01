using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Both the if single-selection statement and the while repetition statement do 1 or more actions if a condition is true or false. If the while repetition statement is used then the action will be performed repeatedly while the condition remains true. If the if single-selection statement is used then the action is done once.

            // Question 2:
            int speedLimit = 35;
            int speed = 42;

            if (speed >= speedLimit)
            {
                Console.WriteLine("SLOW DOWN");
            }

            // Question 3:
            bool isTrue = true;

            if (isTrue = true)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            if (isTrue = false)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            // Question 4:
            double celsius;
            Console.Write("Enter temperature");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;

            if (fahrenheit < 40)
            {
                Console.WriteLine("It is cold");
            }
            else if (fahrenheit > 90)
            {
                Console.WriteLine("It is hot");
            }

            // Question 5:
            int i = 1;

            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }

            // Question 6:
            int n = 61;

            while (n-- > 20)
            {
                Console.WriteLine(n);
            }

            // Question 7:
            int c = 9;

            while (c++ < 20)
            {
                Console.WriteLine(c);
            }
        }
    }
}
