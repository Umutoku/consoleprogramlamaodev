using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
        //Sort
        int[] sayidizisi ={2,12,4,86,72,3,11,17};
        Console.WriteLine("***Sırasız Dizi***");
        foreach (var sayi in sayidizisi)
       Console.WriteLine(sayi);

       Console.WriteLine("*** Sıralı Dizi ***");
       Array.Sort(sayidizisi);

        foreach (var sayi in sayidizisi)
       Console.WriteLine(sayi);


        //Clear
        Console.WriteLine("*** Array Clear ***");
        //Sayı dizisi elemanlarını kullanarak ikinci indexten itibaren iki elemanı sıfırlar
        Array.Clear(sayidizisi,2,2);

            foreach (var sayi in sayidizisi)
       Console.WriteLine(sayi);

       //Reverse
       Console.WriteLine("*** Array Reverse ***");
       Array.Reverse(sayidizisi);

         foreach (var sayi in sayidizisi)
       Console.WriteLine(sayi);

       //Indexof
       Console.WriteLine("*** Array IndexOf ***");
      Console.WriteLine(Array.IndexOf(sayidizisi,23));

      

      //Resize
      Console.WriteLine("*** Array Resize ***");
      Array.Resize int(ref sayidizisi,9));
      sayidizisi[8] = 99;

      foreach(var sayi in sayidizisi)
      Console.WriteLine(sayi);

                }
    }
}