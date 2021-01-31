using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class MyDictionaryList<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionaryList()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            TKey[] tempKey = keys; 
            TValue[] tempValue = values;  
            keys = new TKey[tempKey.Length+1];   
            values = new TValue[tempValue.Length+1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length-1] = key;
            values[values.Length-1] = value;

        }
        public int Length { get{ return keys.Length;} }
        public TKey[] Keys { get{ return keys;} }
        public TValue[] Values { get{ return values;} }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryList<int,string> myDictionaryList = new MyDictionaryList<int, string>();
            myDictionaryList.Add(1,"h");
            myDictionaryList.Add(2,"a");
            myDictionaryList.Add(3,"d");
            myDictionaryList.Add(4,"c");
            myDictionaryList.Add(5,"x");
            System.Console.WriteLine(myDictionaryList.Length);
            foreach(var item in myDictionaryList.Keys)
            {
                System.Console.WriteLine(item);
            }
            foreach(var item in myDictionaryList.Values)
            {
                System.Console.WriteLine(item);
            }


            // KeyCollection Özelliği , ValueCollection da kullanılabilir.
            // Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            // Ogrenci.Add(134, "Tolga Demirer");
            // Ogrenci.Add(158, "Ümit Özkan");
            // Ogrenci.Add(115, "Kadir Aydemir");
            // Ogrenci.Add(174, "Cemal Çiftçi");
            // Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys;
            // foreach (int Anahtar in AnahtarListesi)
            //     Console.WriteLine(Anahtar);





            // TryGetValue(a ,out b) Metodu
            // Koleksiyon içerisinde “a” anahtarını mevcutsa; “a” anahtarı ile ilişkili Değeri “b” değişkenine aktarıp TRUE döndürmektedir. Anahtar mevcut değilse FALSE döndürecektir.
            // Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            // Ogrenci.Add(134, "Tolga Demirer");
            // Ogrenci.Add(158, "Ümit Özkan");
            // Ogrenci.Add(115, "Kadir Aydemir");
            // Ogrenci.Add(174, "Cemal Çiftçi");
            // Console.Write("Öğrenci No Giriniz:");
            // int No = int.Parse(Console.ReadLine());
            // string isim = " ";
            // if (Ogrenci.TryGetValue(No, out isim))
            //     Console.WriteLine(isim);
            // else
            //     Console.WriteLine("Öğrenci Bulunamadı.");



            //KeyValuePair yapısı
            // Dictionary<int,string> Ogrenci = new Dictionary<int,string>();
            // Ogrenci.Add(134, "Tolga Demirer");
            // Ogrenci.Add(158, "Ümit Özkan");
            // Ogrenci.Add(115, "Kadir Aydemir");
            // Ogrenci.Add(174, "Cemal Çiftçi");
            // foreach (KeyValuePair<int, string> veri in Ogrenci)
            //     Console.WriteLine("Numara:{0} - İsim:{1}", veri.Key, veri.Value);
            
        }
    }
}
