using System;

namespace Algortima_Sorulari_4
{
    class Result
    {
        static void Main(string[] args)
        {
            int harfsayisi = 0;
            System.Console.WriteLine("Lütfen bir cümle giriniz");
            string cumle = Console.ReadLine();
            string[] kelime = cumle.Split(" ");
            System.Console.WriteLine("Cümlede {0} kelime vardır.",kelime.Length);
            for (int i = 0; i < kelime.Length; i++)
            {
                 char[] harfsayi = kelime[i].ToCharArray();
                harfsayisi += harfsayi.Length;
            }
            System.Console.WriteLine("Verilen cümlede {0} harf vardır.",harfsayisi);


        }
    }
}