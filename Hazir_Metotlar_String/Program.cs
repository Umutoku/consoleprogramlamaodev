using System;

namespace Hazir_metotlar
{
    class Result
    {
        static void Main(string[] args){

            string degisken ="Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 ="Dersimiz CSharp";
            //Lenght;
            Console.WriteLine(degisken.Length);
            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(string.Concat(degisken,"Merhaba"));

            //Compare, CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Contains

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));

            //IndexOf

            Console.WriteLine(degisken.IndexOf("C"));
            Console.WriteLine(degisken.LastIndexOf("i"));
            int a = degisken.IndexOf("C");

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba!, "));

            //Pad.Left, PadRight

            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30));

            //Remove

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));

            //Replace

            Console.WriteLine(degisken.Replace("Csharp", "C"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));



            

    }           
}
}
