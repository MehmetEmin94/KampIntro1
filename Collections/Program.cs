using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "mehmet", "emin", "seyfo", "burhos" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "gofu";
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> { "mehmet", "emin", "seyfo", "burhos" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("gofu");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }

        
    }
}
