using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Grimiş olduğunuz sayı: "+ sayi);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Hata: "+ ex.Message.ToString());
            }
            catch(FormatException fex)
            {
                Console.WriteLine("Hata: "+ fex.Message.ToString());
            }

            finally
            {
                Console.Write("İşlem Tamamlandı");
            }

        }
    }
}