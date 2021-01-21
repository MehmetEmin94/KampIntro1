using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazilim gelistirme kursu";

            string kurs2 = "programlamaya baslangic";

            string kurs3 = "java";

            string[] kurslar = new string[] { "yazilim gelistirme kursu",
                                                "programlamaya baslangic",
                                              "java","python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs); 
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
