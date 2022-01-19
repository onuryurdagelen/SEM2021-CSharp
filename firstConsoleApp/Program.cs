using System;

namespace firstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:
            /*
            Comment Lines


             */
            //Veri tipleri
            
            object a = 50; // Object veri tipi icin herhangi veri tipi yazilabilir
            object b = "Bu bir string degerdir.";
            int postaKodu;
            float piSayisi = 3.14F; //Kesirli sayilar
            decimal decimalSayi = 5M;//Ondalikli sayilar
            double doubleSayi = 3.13322343d; //8 byte buyuk kesirli sayilar
            bool IsEven = true; // 1 ya da 0 deger yazilir.

            byte sayi1 = 43; //255e kadar olan sayilar
            sbyte eksiDeger = -70;// -128,127 kadar olan sayilar
            uint positifDeger = 5; //4 byte pozitif tam sayilar
            byte sayi2 = 20;
            long kapsamliSayi = -123123123213; // 8 byte (+) ve (-) isaretli tam sayilar
            ulong kapsamliPozitifSayi = 123213123123; // 8byte pozitif tam sayilar.
            int UskpostalCode = 34700;//4byte Positif ve negatif tam sayilar
            int IstPostalCode = 32500;
            string kelime = "deger: "; // Karakter dizileri icin kullanilir.
            string stringSonuc;
            char harf = 'K';//Tek bir harakter kullanmak icin yazilir.

            byte sonuc;

            sonuc = (byte)(sayi1 + sayi2);
            stringSonuc = sonuc.ToString();
            Console.WriteLine("Bu sonuctur: "+sonuc);
            Console.WriteLine("Sonuc degerinin turu: " + sonuc.GetType());
            Console.WriteLine("String sonuc: "+stringSonuc);
            Console.WriteLine("String sonucun turu : "+ stringSonuc.GetType());
            Console.WriteLine("The values you declared on above: ");
            Console.WriteLine(UskpostalCode);
            Console.WriteLine(IstPostalCode);
            Console.WriteLine(kelime);
            Console.WriteLine("the values of Pi "+ piSayisi);
            Console.WriteLine("the values of Usk postal code "+ kelime +" " + UskpostalCode);
            Console.WriteLine("the values of Ist postal code "+ kelime+ " " +IstPostalCode);
            Console.WriteLine("the values of object a: "+ kelime + " "+a);
            Console.WriteLine("the values of object b: "+ kelime + " "+b);
            Console.WriteLine("the type of object a: "+ kelime + " "+a.GetType());
            Console.WriteLine("the type of object b: "+ kelime + " "+b.GetType());

            Console.WriteLine("*********************..");
            Console.WriteLine("the value of object a: {0}, the type of object a: {1} ",a,a.GetType());
            Console.WriteLine("the value of object a: {0}, the type of object b: {1} ",b,b.GetType());
            Console.WriteLine(harf);
            printAnything(5);
        }

        static void printAnything(int numb1)
        {           
            Console.WriteLine(numb1);
        }
        
    }
}
