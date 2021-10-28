using System;
using System.Collections.Generic;

namespace DictionaryMy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(101, "Mert");
            bool varmi = dictionary.ContainsKey(154);

            if (varmi == true)
            {
                Console.WriteLine("01 indeksli eleman koleksiyonda mevcuttur.");
            }
            else
            {
                Console.WriteLine("01 indeksli eleman koleksiyonda mevcut değildir.");
            }

            Console.WriteLine("-----------------");

            Mydictionary<int, string> isimler = new Mydictionary<int, string>();
            isimler.Add(52, "Mert");
            isimler.Add(53, "Murat");
            isimler.Add(54, "Ahmet");
            isimler.Add(55, "Ayşe");
            isimler.Add(56, "Sinem");

            Console.WriteLine(isimler.Count);

        }
    }

    public class Mydictionary<T, D>
    {
        T[] _tArray;
        T[] _tTempArray;

        D[] _dArray;
        D[] _dTempArray;
        public Mydictionary()
        {
            _tArray = new T[0];
            _dArray = new D[0];
        }
        public void Add(T Key, D Value)
        {
            _tTempArray = _tArray;
            _dTempArray = _dArray;

            _tArray = new T[_tTempArray.Length + 1];
            _dArray = new D[_dTempArray.Length + 1];
            for (int i = 0; i < _tTempArray.Length -1; i++)
            {
                _tArray[i] = _tTempArray[i];
                
            }
            for (int j = 0; j < _dTempArray.Length; j++)
            {
                _dArray[j] = _dTempArray[j];
            }
            _tArray[_tArray.Length - 1] = Key;
            _dArray[_dArray.Length - 1] = Value;
            
        }

        public int Count
        {
            get { return _tArray.Length; }
        }

    }


}
