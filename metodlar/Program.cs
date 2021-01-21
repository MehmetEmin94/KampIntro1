using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elmasi";

            string[] meyveler = new string[] {};

            Product product1 = new Product();
            product1.Adi = "elma";
            product1.Fiyati = 15;
            product1.Aciklama = "amasya elmasi";

            Product product2 = new Product();
            product2.Adi = "karpuz";
            product2.Fiyati = 50;
            product2.Aciklama = "diyarbakir karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products )
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------");
            }





            Console.WriteLine("------metotlar--------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            /*sepetManager.Ekle2("arm", "yes arm", 12);
            sepetManager.Ekle2("elma", "yes elma", 13);
            sepetManager.Ekle2("karp", "diy karp", 15);*/



        }
    }
}
