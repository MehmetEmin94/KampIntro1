using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();

            kurs1.kursAdi = "c#";
            kurs1.egitmen = "engin demirog";
            kurs1.izlenmeOrani = 68;

            kurs kurs2 = new kurs();

            kurs2.kursAdi = "java";
            kurs2.egitmen = "kerem varis";
            kurs2.izlenmeOrani = 75;

            kurs kurs3 = new kurs();

            kurs3.kursAdi = "python";
            kurs3.egitmen = "seyfo";
            kurs3.izlenmeOrani = 752251;

            kurs kurs4 = new kurs();

            kurs4.kursAdi = "c++";
            kurs4.egitmen = "gofu";
            kurs4.izlenmeOrani = 1;

            //Console.WriteLine(kurs1.kursAdi + ":" + kurs1.egitmen + ":"+ kurs1.izlenmeOrani);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3,kurs4 } ;

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + ":" + kurs.egitmen + ":" + kurs.izlenmeOrani);
            }

        }
    }
    class kurs
    {
        public string kursAdi { get; set; }

        public string egitmen { get; set; }

        public int izlenmeOrani { get; set; }
    }


        /*{
            product product1 = new product();
            product1.productName = "Weider Premium Whey Protein Tozu 2300 Gr";
            product1.productPrize = 549;

            product product2 = new product();
            product2.productName = "Scitec Whey Professional Whey Protein 920 Gr";
            product2.productPrize = 169;

            product product3 = new product();
            product3.productName = "Big Joy Big Whey Classic Whey Protein 2376 Gr";
            product3.productPrize = 339;

            product[] products = new product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.productName + ":" + product.productPrize);
            }




        }
        class product
        {
            public string productName { get; set; }

            public int productPrize { get; set; }
        }
    }*/
}
