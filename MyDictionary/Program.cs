using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> myDictionary = new MyDictionary<string,int>();
            myDictionary.Add("Elma", 5);
            myDictionary.Add("Karpuz", 20);
            myDictionary.Add("Çilek", 15);

            myDictionary.Key("Elma");

          
            }

        }
}
class MyDictionary<TKey, TValue>
{
    List<TKey> _keys;
    List<TValue> _values;

    public MyDictionary()
    {
        _keys = new List<TKey>();
        _values = new List<TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        _keys.Add(key);
        _values.Add(value);
    }

    public void Key(TKey key)
    {
        Console.WriteLine("1 kg fiyatı " + _values[_keys.IndexOf(key)] + "tl olan ürün eklendi.");
    }
}
