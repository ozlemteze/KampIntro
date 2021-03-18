using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici Yetiştirme Kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            //array= dizi

            string[] kurslar = new string[] {" Yazılım geliştirici Yetiştirme Kampı", "programlamaya başlangıç için temel kurs", "java" };



            for (int i = 0; i < kurslar.Lenght; i++)
            {
                //biz alt satırda kurslar[i] sekinde yazarsak kac tane urun oldugunu bilemesyiz ama kurslar.Lenght diye yazarsak o getirir lenght demek eleman sayısıdır
                Console.WriteLine(kurslar[i]);
            }
            // üstteki for yerine alttaki foreach gibi de yazabiiliriz
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)

            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu= footer");
        }
    }
}
