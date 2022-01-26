using System;

namespace Metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            int OutSayi;
            bool sonuc =int.TryParse(sayi,out OutSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(OutSayi);
            }
            else{
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2,3,out int toplamSonucu);
             Console.WriteLine(toplamSonucu);

             //metotlar overloading

             int ifade = 999;
             instance.EkranaYazdir(Convert.ToString(ifade));
             instance.EkranaYazdir(ifade);
             instance.EkranaYazdir("Zikriye" + "Ürkmez");

            //Metot imzası
            //Metotadı + parametre sayisi + parametre
        }
    }
}

class Metotlar{
    public int Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
     public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
      public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}
