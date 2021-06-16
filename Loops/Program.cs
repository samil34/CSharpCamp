using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıc için temel kurs";
            string kurs3 = "Java";

            //diziler tanımlamamız gereklidir
            //array - dizi

            string[] kurslar = new string[] { "Yazılımcı geliştirici yetiştirme kampı", 
                "Programlamaya başlangiç için temel kurs",
                "Java", "Jython"};

            //Ekranımızı dinamikleştirmeye çalıştık
            for (int i = 0; i < kurslar.Length; i++)
            {

                Console.WriteLine(kurslar[i]);
            }

            //dizilere uygulanır
            //dizileri tek tek dolaşmaya yarar
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
