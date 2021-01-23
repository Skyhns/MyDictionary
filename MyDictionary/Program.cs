using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> icecekler = new MyDictionary<string>();
            icecekler.Add("Kola");
            icecekler.Add("Ayran");
            icecekler.Add("Fanta");
        }
    }
}
