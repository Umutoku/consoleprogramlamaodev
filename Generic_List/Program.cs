using System;

namespace Generic_List
{
    class Result
    {
        static void Main(string[] args){
            //List<T> class
            //System.Collentions.Generic
            //T -> object türündedir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);
           
           List<string> renkListesi = new List<string>();

        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        foreach(var sayi in sayiListesi)
        
            Console.WriteLine(sayi);
        
        foreach(var renk in renkListesi)
        
            Console.WriteLine(renk);
        

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        sayiListesi.ForEach(renk => Console.WriteLine(renk));

        //Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Mavi");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        //Liste içerisinde arama
        if(sayiListesi.Contains(10))
        Console.WriteLine("Liste içinde bulundu");

        //Eleman ile index'e erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        //Diziyi listeye çevirme
        string[] hayvanlar = {"kedi","köpek","kuş"};
        List<string> hayvanlistesi = new List<string>(hayvanlar);

        //Listeyi nasıl temizleriz
        hayvanlistesi.Clear();

        //Liste içerisinde nesne tutma
        List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
        Kullanıcılar kullanıcı1 = new Kullanıcılar();
        kullanıcı1.Isim = "Ayşe";
        kullanıcı1.Soyisim = "Yılmaz";
        kullanıcı1.Yas = 26;

        Kullanıcılar kullanıcı2 = new Kullanıcılar();
        kullanıcı1.Isim = "Banu";
        kullanıcı1.Soyisim = "ÖzYılmaz";
        kullanıcı1.Yas = 21;

        Kullanıcılar kullanıcı3 = new Kullanıcılar();
        kullanıcı1.Isim = "Umut";
        kullanıcı1.Soyisim = "Oku";
        kullanıcı1.Yas = 41;
        
        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);
        kullanıcıListesi.Add(kullanıcı3);
        
        List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

        yeniListe.Add(new Kullanıcılar(){
            Isim="Deniz",
            Soyisim ="Arda",
            Yas =24
        });

        foreach(var kullanıcı in kullanıcıListesi)
        {
            Console.WriteLine("Kullanıcı Adı:"+ kullanıcı.Isim);
            Console.WriteLine("Kullanıcı SoyAdı:"+ kullanıcı.Soyisim);
            Console.WriteLine("Kullanıcı Yaş:"+ kullanıcı.Yas);
        }

        yeniListe.Clear();

        }
    }
    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

         public string Isim { get => isim; set => isim = value; }
         public string Soyisim { get => soyisim; set => soyisim = value; }
         public int Yas { get => yas; set => yas = value; }
    }
}