using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Metodos_y_clases
{
    internal class Program
    {
        static void ejercicio1()
        {
            Console.WriteLine("Esta aplicación crea un array y muestra la suma y la media de sus valores");

            int length = 0;
            int sum = 0;
            int average = 0;

            do
            {
                Console.Write("Introduce el tamaño del array: ");
                length = Convert.ToInt32(Console.ReadLine());
                if (length <= 0)
                {
                    Console.WriteLine("El tamaño del array debe ser mayor que 0");
                }
            } while (length <= 0);

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Introduce el valor {i + 1}: ");
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
                sum += value;
            }

            Console.WriteLine($"La suma total de los valores del array es: {sum}");
            Console.WriteLine($"La media de los valores del array es: {sum / length}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }


        static int ejercicio2()
        {
            int length = 0;

            Console.WriteLine("Esta aplicación cuenta el número de espacios de un string");
            Console.Write("Introduce un cadena de texto: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    length++;
                }
            }

            Console.WriteLine($"Hay {length} espacios en blanco.");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            return length;
        }


        static void ejercicio3()
        {
            Console.WriteLine("Esta aplicación muestra el factorial de un número");
            int num = 0;

            do
            {
                Console.Write("Introduce un número entero: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0);
            
            int factorial = calculaFact(num);

            Console.WriteLine($"El factorial de {num} es {factorial}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static int calculaFact(int num)
        {
            int fact = num;

            if (num <= 1)
            {
                return 1;
            } else
            {
                fact *= calculaFact(--num);
            }

            return fact;
        }


        static void Main(string[] args)
        {
            /* ejercicio1();
            ejercicio2(); */
            ejercicio3();
            /* ejercicio4();
            ejercicio5();
            ejercicio6();
            ejercicio7();
            ejercicio8();
            ejercicio9(); */
        }
    }
}
