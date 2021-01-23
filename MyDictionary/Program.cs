using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, double> urunler = new MyDictionary<string, double>();
            urunler.Add("su", 1);
            urunler.Add("ekmek", 1.5);
            urunler.Add("biskuvi", 4);
            urunler.Add("sut", 4);
            urunler.GetList();
        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
       

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];

        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tkeys = keys;
            TValue[] tvalues = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tkeys.Length; i++)
            {
                keys[i] = tkeys[i];
            }
            for (int j = 0; j < tvalues.Length; j++)
            {
                values[j] = tvalues[j];
            }


            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }


        public void GetList()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Urun: " + keys[i] + "      Fiyat(TL): " + values[i]);
            }
        }
    }
}
