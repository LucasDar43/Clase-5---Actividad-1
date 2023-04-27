using System.Numerics;
using System.Runtime.Intrinsics;

namespace actividad1
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            1 – Usando como modelo el ejemplo de la página 2, escribir un programa que 
            permita cargar un arreglo de 10 posiciones enteras y realice las siguientes operaciones:
            1.1	Averigüe el acumulado de todo el arreglo (sume todos sus elementos).
            1.2	Averigüe qué elemento es el más grande. 
            1.3	Averigüe qué elemento es el más chico.
            1.4	Imprima por pantalla el arreglo pero desde el último elemento al primero.
            */
            
            int[] Vector = new int[10];

            Console.WriteLine("Ingrese los elementos del vector.");
            for (int i = 0; i < 10; i++)
            {
                string strValor = Console.ReadLine(); // Se ingresa por teclado

                int valor;
                if (int.TryParse(strValor, out valor))
                {
                    Vector[i] = valor; // Se asigna el valor entero al vector
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es un número entero. Inténtelo de nuevo.");
                    i--; // Decrementar el contador para repetir la iteración
                }
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Elementos del arreglo");

            // Se itera por los diez elementos del arreglo
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vector[{0}] = {1}", i, Vector[i]);
            }

            //Sumar Elementos
            int acumulado = 0; // Variable para almacenar la suma

            for (int i = 0; i < Vector.Length; i++)
            {
                acumulado += Vector[i]; // Sumar el elemento actual al acumulador
            }

            Console.WriteLine("\nLa suma de los elementos del vector es: " + acumulado);

            //Cual es el Mayor
            int nMayor = Vector[0];

            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] > nMayor)
                {
                    nMayor = Vector[i];
                }
            }
            Console.WriteLine("\nEl mayor número del vector es: " + nMayor);

            //Cual es el Menor
            int nMenor = Vector[0];

            for (int i = 0; i < Vector.Length; i++)
            {
                if (Vector[i] < nMenor)
                {
                    nMenor = Vector[i];
                }
            }
            Console.WriteLine("\nEl menor número del vector es: " + nMenor);

            //Orden Inverso
            Console.WriteLine("\nVector de atrás hacia adelante:");

            for (int i = Vector.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Vector[{0}] = {1}", i, Vector[i]);
            }

            //Orden Inverso 2

            Array.Reverse(Vector); // Invertir el orden de los elementos del vector

            foreach (int elemento in Vector)
            {
                Console.WriteLine(elemento);
            }

        }

    }
}
