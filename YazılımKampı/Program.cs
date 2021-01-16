using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //type safety = tip güvenliği -- Metinsel içerikler çift tırnak ile yapılır. ";" zorunlu. //Console.WriteLine ("Hello World");
        //Do not repeat yourself. = Kendini tekrarlama.
        //alias = değer 

        string kategoriEtiketi = "Kategoriler";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;  //ondalıklı sayı
        bool sistemeGirisYapmisMi = true;
        double dolarDun = 7.35;
        double dolarBugun = 7.45;

        if (dolarDun > dolarBugun)
        {
            Console.WriteLine("Azalış butonu");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış butonu");
        }
        else
        {
            Console.WriteLine("Değişmedi butonu");
        }

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }

        Console.WriteLine(kategoriEtiketi);
    }
}
