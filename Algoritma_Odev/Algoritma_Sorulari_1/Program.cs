using System;

namespace algoritma_sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
           int sayi=0;
            Console.Write("Sayı Girin : ");
            sayi = Convert.ToInt32(Console.ReadLine());  
            int [] dizi = new int[sayi];
             for (int i = 0; i < sayi; i++){
                    
                Console.WriteLine("Sayı Giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
                
             }
             for(int i=0;i < dizi.Length;i++)
             {
                 if(dizi[i]%2 == 0)
                 {
                     System.Console.WriteLine("Çift Sayı: "+dizi[i]);
                     
                 }
                 else{
                     System.Console.WriteLine(dizi[i]+" Sayısı Çift Değildir.");
                 }
             }
             foreach (var item in dizi) {
                 if(item %2 == 0){
  Console.WriteLine("Çift sayılar: " +item);
                 }
              
             }
}
            }
        }
        
        
        
