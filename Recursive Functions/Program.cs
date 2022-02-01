using System;
using System.Threading;
namespace Recap1
{
    class Program
    {
        static void Main(string[] args)
        {
            char evetHayir;
            try
            {
                int secim = 0;
                int temp = 1;
                do
                {
                    Console.WriteLine("1-)Faktoriyel");
                    Console.WriteLine("2-)Us Alma");
                    Console.WriteLine("3-)Fibonacci");
                    Console.WriteLine("4-)Asal Kontrol");
                    Console.WriteLine("5-)Çıkış");
                    do
                    {
                        Console.WriteLine("Yukaridaki işlemlerden birini seçiniz :");
                        secim = Convert.ToInt32(Console.ReadLine());
                    } while (secim < 1 || secim > 5);
                    switch (secim)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("faktoriyel İşlemi");
                            Console.Write("Faktoriyel için sayi giriniz:");
                            int x = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("{0} sayisinin faktoriyeli {1} olarak hesaplanmıştır", x, faktoriyel(x));
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Us Alma işlemi");
                            Console.Write("Us Alma için taban sayisi giriniz:");
                            int taban = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Us Alma için us sayisi giriniz:");
                            int us = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("{0} ^ {1} işleminin sonucu {2} olarak hesaplanmıştır", taban, us, usAlma(taban, us));
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Fibonacci İşlemi");
                            Console.Write("Fibonacci için sayi giriniz:");
                            int f = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("{0}. sıradaki fibonacci değeri {1} olarak hesaplanmıştır.", f, fibonacci(f));
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Asal Sayi İşlemi");
                            Console.Write("Asal sayi işlemi için sayi giriniz:");
                            int a = Convert.ToInt32(Console.ReadLine());
                            asalKontrol(a);
                            break;
                        case 5:
                            temp = 2;
                            break;
                    }
                    if (temp == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Tekrar için e/h");
                        evetHayir = Convert.ToChar(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("İyi günler!");

                        return;
                    }
                } while (evetHayir == 'e' || evetHayir == 'E');
                Console.WriteLine();
                Console.WriteLine("iyi günler!");
                Thread.Sleep(2000);
            }
            catch
            {
                Console.WriteLine("Hatali giris. Program 3 saniye sonra kapanacak.");
                Thread.Sleep(3000);
            }
        }
        static int faktoriyel(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * faktoriyel(number - 1);
        }
        static int usAlma(int taban, int us)
        {
            if (us == 0)
                return 1;
            return taban * usAlma(taban, us - 1);
        }
        static int fibonacci(int sayi)
        {
            if (sayi < 1)
                return 0;
            else if (sayi == 1)
                return 1;
            else
                return fibonacci(sayi - 1) + fibonacci(sayi - 2);
        }
        static void asalKontrol(int sayi)
        {
            int memo = 0;
            if (sayi == 0 || sayi == 1)
                Console.WriteLine("En küçük asal sayı 2 dir");
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                        memo++;
                }
                if (memo >= 1)
                    Console.WriteLine("Girilen {0} sayısı Asal sayi değildir", sayi);
                else
                    Console.WriteLine("Girilen {0} sayisi asal sayıdır", sayi);
            }
        }
    }
}