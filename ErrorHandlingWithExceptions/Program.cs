using System;

namespace ErrorHandlingWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sayi1 = 1;
                int sayi2 = 0;
                int sonuc;
                sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }
            catch(FormatException error)
            {
                throw error;
            }
            catch (DivideByZeroException error)
            {

                throw error;
            }
            catch(System.Exception error)
            {
                throw error;
            }
            finally
            {
                Console.WriteLine("Finally kod blogu");
            }
        }
    }
}
