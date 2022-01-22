using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayac = int.Parse(Console.ReadLine());
            for(int i = 1;i <= sayac; i++)
            {
                if(i%2 ==1)
                {
                    Console.WriteLine(i);
                }
            }
            //1 ile 1000 arasındaki tek ve çift sayıların toplamı 
            int tektoplam = 0;
            int cifttoplam = 0;
            for(int i = 1;i <= 1000; i++)
            {
               if(i%2 ==1)
                
                    tektoplam +=i;
                    
                
                else if(i%2 ==0)
                
                    cifttoplam +=i;
                    
                 
               
            }
             Console.WriteLine("Tek toplam: "+tektoplam);
                Console.WriteLine("çift toplam: "+cifttoplam);

                //break, continue

                for(int i = 1;i <= 10; i++)
                {
                    if(i==4)
                    break;
                     Console.WriteLine(i);
                }
                 for(int i = 1;i <= 10; i++)
                {
                    if(i==4)
                    continue;
                     Console.WriteLine(i);
                }
        }
    }
}