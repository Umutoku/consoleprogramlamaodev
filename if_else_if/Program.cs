using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time <= 18)
            {
                Console.WriteLine("İyi günler");


            }

else if(time >=6 && time <11)
{
    Console.WriteLine("Günaydın");
}



            else



            {
                Console.WriteLine("İyi geceler");
            }

string sonuc = time <=18 ? "İyi Günler" : "İyi geceler";

        sonuc = time >=6 && time <= 11 ? "İyi Günler" : time <=18 ? "İyi günler": "İyi geceler";
        Console.WriteLine(sonuc);
        }
    }
}