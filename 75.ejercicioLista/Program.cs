using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75.ejercicioLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabras;
            int numero;

            ArrayList Lista = new ArrayList();

            Console.WriteLine("ingrese una palabra");
            palabras= Console.ReadLine();

            while (palabras != "")
            {
                Lista.Add(palabras); 
                Console.WriteLine("ingresa otra palabra: ");
                palabras = Console.ReadLine();
            }

            Console.WriteLine("ingrese la posicion de la palabra que quiere ver: ");
            numero = int.Parse (Console.ReadLine());

            while (numero != 0)
            {
                if (numero <= Lista.Count && numero > 0)
                {
                    numero--;
                    Console.WriteLine((string)Lista[numero]);
                    Console.WriteLine("Ingrese la posición de la palabra que quiere ver: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("La posición NO existe. Ingrese otra posición");
                    numero = Convert.ToInt32(Console.ReadLine());
                }
            }

        }
    }
}
