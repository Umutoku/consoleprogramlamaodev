﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_List
{
    class Result
    {
        static void Main(string[] args){
            //System.Collections namespace
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //İçerisindeki verilere erişim
            Console.WriteLine(liste[1]);

            foreach(var item in liste)
            Console.WriteLine(item);

            //AddRange
            Console.WriteLine("---------addrange-----------");
            string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach(var item in liste)
            Console.WriteLine(item);

            //sort
            Console.WriteLine("--------sort-----------");
            liste.Sort();

            foreach(var item in liste)
            Console.WriteLine(item);

            //Binary Search
            Console.WriteLine("*********Binary Search*********");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("*********Reverse*********");
            liste.Reverse();

            foreach(var item in liste)
            Console.WriteLine(item);

        //Clear
            Console.WriteLine("*********Clear*********");
            liste.Clear();
             foreach(var item in liste)
            Console.WriteLine(item);
        }
    }
}