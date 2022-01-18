using System;

namespace degisken
{
    class Program
    {
static void Main(string[] args)
{
    int deger = 2;


     Console.WriteLine();
    String degisken = ("");

    byte b = 5; //1 byte
    sbyte c= 5; //1 byte

    short s = 5; //2 byte
    ushort us = 5; //2 byte

    Int16 i16 = 2; //2 byte 
    int i = 2; //4 byte
    Int32 i32 = 2; //4 byte
    Int64 i64 = 2; //8 byte

    uint ui = 2; //4 byte
    long l = 4; //8 byte
    ulong ul= 4; //8 byte

    float f = 5; //4 byte
    double d = 5; //8 byte
    decimal dc = 5; //16 byte

    char chac = '2'; //2 byte
    string str = "Zikriye"; //Sınırsız

    bool bl = true; 

    DateTime dt = DateTime.Now;
    Console.WriteLine(dt);

    object o1 = "a";

    


}

    }
}