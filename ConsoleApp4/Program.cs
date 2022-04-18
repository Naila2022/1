using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 48;
            for (int i = 0; i < number; i++)
            {
                if (number <= 50)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (number > 50 && number < 100)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
                else if (number > 100)
                {
                    if (i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
    }
}
