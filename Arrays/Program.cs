using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[3];

            renkler[0] = "blue";
            renkler[1] = "orange";
            renkler[2] = "red";

            for (int i = 0; i < renkler.Length; i++)
            {
                Console.WriteLine(renkler[i]);
            }

            Console.WriteLine("******************");
            int[] sayilar = new int[3];
            sayilar[0] = 4;
            sayilar[1] = 8;
            sayilar[2] = 12;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            string[] kisiler = { "Mehmet", "murat", "mesut", "ali", "cemil" };
            string[] students = new string[3] { "Ayseen", "Timur", "Mahmut" };

            string[] sehirler = new string[3];
            Console.WriteLine("3 sehir yaziniz: ");
            for (int i = 0; i < sehirler.Length; i++)
            {
                sehirler[i] = Console.ReadLine();
            }
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            /*
            int[] sayilar2 = new int[4];

            Console.WriteLine("********************");
            Console.WriteLine("4 Numara yazınız: ");

            
            for (int i = 0; i < sayilar2.Length; i++)
            {
                sayilar2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < sayilar2.Length; i++)
            {
                Console.WriteLine(sayilar[i]); 
            }
            */

            //En küçük sayıyı bulma programı

            int[] numbers = new int[6] { 45, 50, 60, 12, 15, 32 };

            int LowestNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (LowestNumber > numbers[i])
                {
                    numbers[i] = LowestNumber;
                }
            }
            Console.WriteLine("En düşük sayı: {0}",LowestNumber);

            //Multi dimension Arrays

            string[,] cities = new string[5, 3]
            {
                { "Ankara","Izmır","Tokat" },
                {"Samsun","Ordu","Kastamonu" },
                {"Sivas","Kayseri","Konya" },
                {"Van","Ardahan","Bayburt" },
                {"Aksaray","Yalova","Istanbul" },
            };
            Console.WriteLine(cities.GetUpperBound(0));
            Console.WriteLine(cities.GetUpperBound(1));

            // Çok boyutlu dizilerde GetUpperBound metodu kullanırken for döngüsünde üst limit küçük eşittir olmadılır.
            for (int i = 0; i <=cities.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= cities.GetUpperBound(1); j++)
                {
                    Console.Write(cities[i,j] + " ");
                   
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("********************");
            string[] colors = new string[3] { 
            "Orange","Yellow","Red"
            };

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
            
        }
        
    }
}
