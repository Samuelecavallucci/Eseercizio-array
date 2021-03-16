using System;
using System.Collections.Generic;
using System.Text;

namespace ARRAY
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] dati = new int[10];

            //leggere l'array
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dati[i]);
            }

            //stampa l'array
            foreach (var x in dati)
            {
                Console.WriteLine(x);
            }

            //copia i dati di un array in un'altro
            int[] copia_dati = new int[dati.Length];
            System.array.copy(dati, copia_dati, dati.Length);
        }

    }
}
