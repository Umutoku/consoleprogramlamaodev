using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = {"Kırmızı", "Mavi","Sarı"};
            string[] hayvanlar = new string[5];

int[] dizi ;
dizi = new int[5];

//Dizilere değer atama ve erişim
hayvanlar[0] = "Rodi";
dizi[3] = 10;

Console.WriteLine(dizi[3]);
Console.WriteLine(hayvanlar[0]);
Console.WriteLine(renkler[2]);


//Döngüler dizi kullanımı
//klavyeden girilen n tane sayının ortalamasını hesaplayan program
Console.Write("Lütfen dizinin eleman sayınısı giriniz: ");

int diziuzunlugu = int.Parse(Console.ReadLine());
int[] sayidizisi = new int[diziuzunlugu];

for(int i = 0;i < diziuzunlugu;i++)
{
    Console.Write("Lütfen {0}. elemanı giriniz: ", i+1);
    sayidizisi[i] = int.Parse(Console.ReadLine());

}
int toplam = 0;
foreach(var sayi in sayidizisi)

toplam += sayi;
Console.WriteLine("Ortalama: "+ toplam/diziuzunlugu);

        }
    }
}
