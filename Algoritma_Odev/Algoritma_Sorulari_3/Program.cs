using System;

namespace Algortima_Sorulari_3
{
    class Result
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("N Sayısı Girin:");
            int n= int.Parse(Console.ReadLine());
            string[] dizi = new string[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("{0}. Kelimeyi Girin:",i+1);
                dizi[i] = Console.ReadLine();
            }
           
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                System.Console.WriteLine(item);
            }



           





        }
    }
}