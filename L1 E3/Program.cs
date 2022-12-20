using System;

namespace L1_E3
{
    /*E3. Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la 
          tastaura*/

    class Program
    {
        static void Main(string[] args)
        {
            int numar;

            Console.WriteLine("Introduceti un numar");
            numar = int.Parse(Console.ReadLine());
            int ultimulNumar = numar % 10;

            Console.WriteLine("Ultima cifra a numarului introdus este:" + ultimulNumar);
        }
    }
}
