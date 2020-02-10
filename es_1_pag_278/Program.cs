using System;
using System.Collections.Generic;

namespace es_1_pag_278
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quanti numeri vuoi inserire?");
            int n = int.Parse(Console.ReadLine());
            List<int> numeri = new List<int>();
            List<int> copie = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Inserisci un numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (numeri.Contains(numero))
                    copie.Add(numero);
                numeri.Add(numero);
            }
            for (int i = 0; i < copie.Count; i++)
            {
                Console.WriteLine($"Il numero {copie[i]} è doppione.");
            }
            Console.ReadLine();
        }
    }
}
