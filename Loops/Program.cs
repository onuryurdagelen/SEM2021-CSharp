using System;

namespace Loops
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number = 24;
            string word;
            Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            //word = Console.ReadLine();

            for(int i = 0; i< number; i++)
            {
                Console.WriteLine("Hello world");
            }
            //1 den 10 a kadar olan sayilari saydiran program.
            Console.WriteLine("****************");
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            //1 den 20ye kadar 2 ser ser artan program
            Console.WriteLine("****************");

            for (int i = 1; i <= number; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("****************");
            //1 den 20 ye kadar 2 ye tam bolunen sayilar
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0 )
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("****************");
            for (int i = 1; i < number; i++)
            {
                if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("{0} can divided by 5 and 7",i);
                }
                else
                {
                    Console.WriteLine("{0} can't divided by 5 and 7", i);

                }
            }
            int total = 0;
            for (int i = 1; i <= number; i++)
            {
                total += i;
            }
            Console.WriteLine("1 den 10'a kadar olan sayilarin toplami: "+ total);
            //1 den kullaninin girdigi sayiya kadar olan sayilarin faktoriyeli
            Console.WriteLine("****************");
            int factoriel = 1;
            for (int i = 1; i <= number; i++)
            {
                factoriel = factoriel * i;
            }
            Console.WriteLine(factoriel);
            // Koronavirus 1 saate 2 defa bolunuyorsa 24 saatte kaca bolunur.
            int corona = 1;
            for (int i = 1; i <= number; i++)
            {
                corona  *= 2;
            }
            Console.WriteLine(corona);

            //1- Kullanicidan deger al
            //2 - Deger sayisi kadar '+'' desen yap.
            string design = "";
            for (int i = 0; i < number; i++)
            {

                for (int j = 0; j < number - i; j++)
                    Console.Write(" ");
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");
                Console.WriteLine("\n");
            }
            Console.WriteLine("****************");
            //break ==> sart saglandiginda donguyu kirar ve for disindan devam eder.
            for (int i = 0; i <=number; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("i is 5");
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("end of for");
            Console.WriteLine("***************");
            for (int i = 0; i <= number; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("i is 5");
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("***************");
            for (int i = 0; i <= number; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("i is 5");
                    return;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("end of for");
        }
    }
}
