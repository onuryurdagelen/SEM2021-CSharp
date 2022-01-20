using System;

namespace WhileLoop
{
    //While Loop
    class Program
    {
        static void Main(string[] args)
        {
            int number = 53;
            bool IsPrime = true;
            while (number <= 20)
            {
                Console.WriteLine(number);
                number++;
            }
            do
            {
                Console.WriteLine(number);
            }
            while (number < 9);

            for (int i = 1; i <= 53; i++)
            {
                for (int j = 2; j < i -1; j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.WriteLine(i);
                }
                IsPrime = true;

            }
                
            }

        }

    }
        

      
    

