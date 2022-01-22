using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("Lütfen bir sayı giriniz: ");
            //while
            //1den başlayarak consoledan girilen sayıya kadar ortalama hesaplama
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayi)
            {
               toplam += sayac;
               sayac ++;

            }
Console.WriteLine(toplam/sayi);

//'a'dan 'z' ye kadar tüm harfleri console a yazdır.
char character = 'a';
while(character < 'z')
{
    Console.WriteLine(character);
    character++;
}

Console.WriteLine("Foreach: ");
string[] arabalar = {"BMW", "Ford", "Toyota","Nissan"};
foreach(var araba in arabalar)
{
Console.WriteLine(araba);
}
        }
    }
}