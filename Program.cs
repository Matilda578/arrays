using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            int total = 0;
            foreach (int i in numbers)
            {
               total = total + i;

            }
            Console.WriteLine(total);
        }

    }
}

