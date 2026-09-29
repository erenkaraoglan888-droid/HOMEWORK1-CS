using System;

class Program
{
    static void Main()
    {
        // hello C#

        Console.WriteLine("hello C#");
        Console.WriteLine();

        // ad , bölüm, sınıf
        Console.WriteLine("EREN KARAOĞLAN");
        Console.WriteLine("BİLGİSAYAR MÜHENSİSİ");
        Console.WriteLine("2.SINIF");
        Console.WriteLine();

        // tarih ve saat

        Console.WriteLine("MEVCUT TARİH VE SAAT :");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine();

        // celsius --> Fahrenheit

        Console.WriteLine("Celsius değerini gir :");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine("Fahrenheit değeri : " + fahrenheit);
    }
}