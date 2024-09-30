using System;
    internal class Program
    {
        static void Main()
        {
        int num = Convert.ToInt16(Console.ReadLine());
        int first = 0, second = 1,next;
        Console.WriteLine("Fibonacci series:");

        for (int i = 0; i < num-2; i++)
        {
            if (i<=1)
               next = i;
            else
            {
                next = first + second;
                first=second;
                second = next;
            }
            Console.WriteLine(next);
        }
    }
        
    }

