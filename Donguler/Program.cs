﻿using System;

class Donguler
{
    public static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
        string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
        string kurs3 = "Java";
        string kurs4 = "Python";

        //array = dizi

        string[] kurslar = new string[]
        { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java", "Python" };


        for (int i = 0; i < kurslar.Length; i++)   //i++ = 1 1 arttırır. i=i+2 = 2 2 arttırır.
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("For bitti");

        foreach (string kurs in kurslar)  //foreach dizilere uygulanır.
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("Sayfa Sonu - footer");
    }
}
