using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //rekürsif - Öz yinelemeli
            //3^4 = 3x3x3x3

            int result = 1;
            for(int i = 1;i<5;i++)
            result = result *3;
            Console.WriteLine(result);

            islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));


            //extension metotlar
            string ifade = "Zikriye üzmez cengiz";
            
            Console.WriteLine(ifade.CheckSpaces());
            bool sonuc =ifade.CheckSpaces();

            if(sonuc){
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            if(sonuc){
                Console.WriteLine(ifade.MakeUpperChase());
                
            }
            int [] dizi = {1,2,3,4,5,6};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEven());

            string kelime = "Naber";
            Console.WriteLine(kelime.GetFirstCharacter());   
                 }
    }

    public class islemler{
        public int Expo(int sayi,int üs)
        {
            if(üs<2)
            return sayi;
            return Expo(sayi,üs-1)*sayi;
        }

      }
        public static class Extension{
            public static bool CheckSpaces(this string param)
            {
                return param.Contains(" ");
            }

            public static string RemoveWhiteSpaces(this string param)
            {
                string[] dizi = param.Split(" ");
                return string.Join("",dizi);  
            }

                public static string MakeUpperChase(this string param)
            {
                return param.ToUpper();
            }
                public static int[] SortArray(this int[] param)
            {
                Array.Sort(param);
                return param;
            }
                 public static void EkranaYazdir(this int[] param)
            {
                foreach (int item in param)
                Console.WriteLine(item);
            }
                 public static bool IsEven(this int param)
            {
                return param %2==0;
            }
            public static string GetFirstCharacter(this string param)
            {
                return param.Substring(0,1);
            }
    }
    }

}