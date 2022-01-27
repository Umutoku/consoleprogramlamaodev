using System;

namespace algoritma_sorulari_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("N Sayısını Giriniz");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("M Sayısını Giriniz");
            int m = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            for (int i = 0; i < dizi.Length; i++)
            {
                System.Console.WriteLine("{0}. Sayıyı Giriniz",i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if(dizi[i]%m == 0)
                    System.Console.WriteLine(dizi[i]+"M Sayısına Tam Bölünmektedir.");
                else if (dizi[i]==m)
                {
                    System.Console.WriteLine(dizi[i]+"M Sayısına Eşittir.");
                }
                else
                {
                    System.Console.WriteLine(dizi[i]+"M Sayısına Tam Bölünmemektedir veya Eşit Değildir.");
                }
            }
        }
    }
}