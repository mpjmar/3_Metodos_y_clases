using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3_Metodos_y_clases
{
    internal class Program
    {
        static void Ejercicio1()
        {
            Console.WriteLine("Esta aplicación crea un array y muestra la suma y la media de sus valores");

            int length = 0;
            int sum = 0;

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


        static int Ejercicio2()
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


        static void Ejercicio3()
        {
            Console.WriteLine("Esta aplicación muestra el factorial de un número");
            int num = 0;

            do
            {
                Console.Write("Introduce un número entero: ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0);
            
            int factorial = CalculaFact(num);

            Console.WriteLine($"El factorial de {num} es {factorial}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static int CalculaFact(int num)
        {
            int fact = num;

            if (num <= 1)
            {
                return 1;
            } else
            {
                fact *= CalculaFact(--num);
            }

            return fact;
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Esta aplicación comprueba si un número entero es primo");

            Console.Write("Introduce un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool resul = EsPrimo(num);
            Console.WriteLine($"El número {num} " + (resul == true ? "" : "no ") + "es primo");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static bool EsPrimo(int number)
        {
            bool esPrimo = true;
            int i = 2;

            if (number <= 2)
            {
                if (number == 2)
                {
                    return true;
                } else
                {
                    return false;
                }
            }

            while (i < number && esPrimo)
            {
                esPrimo = number % i == 0 ? false : true;
                i++;
            }

            return esPrimo;
        }


        static void Ejercicio5()
        {
            Console.WriteLine("Esta aplicación calcula la potencia de un número positivo");

            Boolean correcto = false;
            int nb;
            int exp;

            do
            {
                Console.Write("Introduce la base: ");
                nb = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduce la potencia: ");
                exp = Convert.ToInt32(Console.ReadLine());
                correcto = nb > 0 && exp > 0;

                if (!correcto)
                    Console.WriteLine("Los valores introducidos no son correctos");
            } while(!correcto);

            Console.WriteLine($"Resultado iterativo: {CalcPotenciaIter(nb, exp)}");
            Console.WriteLine($"Resultado recursivo: {CalcPotenciaRecur(nb, exp)}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static int CalcPotenciaIter(int num, int exp)
        {
            int resul = 1;

            for (int i = 0; i < exp; i++)
            {
                resul *= num;
            }
            return resul;
        }

        static int CalcPotenciaRecur(int num1, int num2)
        {
            int resul = num1;

            if (num2 == 1)
            {
                return resul;
            }

            resul *= CalcPotenciaRecur(num1, --num2);

            return resul;
        }


        static void Ejercicio6()
        {
            bool correct = false;
            int count = 0;

            Console.WriteLine("Esta aplicación controla el login de un usuario");

            while (!correct && count < 3)
            {
                Console.Write("Introduce tu usuario: ");
                string user = Console.ReadLine();
                Console.Write("Introduce tu contraseña: ");
                string password = Console.ReadLine();
                Console.WriteLine();

                correct = ComprobarUsuario(user, password);
                count++;

                if (!correct)
                {
                    Console.WriteLine("Lo siento, las credenciales no son correctas. ¡Inténtalo de nuevo!");
                    Console.WriteLine($"Número de intentos: {count}/3");
                    Console.WriteLine();
                }
            }

            if (correct)
            {
                Console.WriteLine("¡Correcto!");
            } else
            {
                Console.WriteLine("Lo siento, has agotado el número de intentos");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static bool ComprobarUsuario(string user, string password)
        {
            return user == "usuarioDAM" && password == "pass2DAM";
        }


        static void Ejercicio7()
        {
            Console.WriteLine("Esta aplicación indica si dos números son múltiplos");

            Console.Write("Introduce el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            bool esMultiplo = EsMultiplo(num1, num2);
            Console.WriteLine($"{num1} " + (esMultiplo ? "" : "no ") + $"es múltiplo de {num2}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static bool EsMultiplo(int num1, int num2)
        {
            return num1 % num2 == 0;
        }


        static void Ejercicio8()
        {
            Console.WriteLine("Esta aplicación suma los dígitos de un número entero");

            Console.Write("Introduce un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"La suma de los dígitos de {num} es {SumaDigitos(num)}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static int SumaDigitos(int num)
        {
            int resul = 0;

            while (num > 0)
            {
                resul += num % 10;
                num /= 10;
            }

            return resul;
        }


        static void Ejercicio9()
        {
            Console.WriteLine("Esta aplicación indica la posición del número menor de un array");

            int[] array = { 1, 2, 3, 4, 5, 6 };

            Console.Write("Elementos del array: ");
            foreach (int nb in array)
            {
                Console.Write($"{nb} ");
            }
            Console.WriteLine();

            Console.WriteLine($"El número menor del array es: {BuscaMenor(array)}");

            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
        }

        static int BuscaMenor(int[] number)
        {
            int menor = int.MaxValue;

            foreach (int nb in number)
            {
                menor = menor > nb ? nb : menor;
            }

            return menor;
        }


        static void Main(string[] args)
        {
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
            Ejercicio6();
            Ejercicio7();
            Ejercicio8();
            Ejercicio9();
        }
    }
}
