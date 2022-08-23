using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicación de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[7] Conversion de celsius a fahrenheit");
                Console.WriteLine("[8] Conversion de fahrenheit a celsius");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Cargando...");
                        Nprimos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Ccelcius();
                        Console.ReadKey();
                        break;
                    case "8":
                        Cfahrenheit();
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int c, int d)
        {
            return c - d;
        }
        static int Multiplicacion(int e, int f)
        {
            return e * f;
        }
        static int Division(int g, int h)
        {
            return g / h;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static void Nprimos()
        {
            int numero = 2, divisible = 0;
            while (numero<=30)
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero%i==0)
                    {
                        divisible++;
                    }
                    if (divisible>2)
                    {
                        break;
                    }
                }
                if (divisible==2)
                {
                    Console.WriteLine("{0} es primo", numero);
                }
                divisible = 0;
                numero++;
            }
        }

        static void Ccelcius()
        {
            Console.WriteLine("Ingrese el grado celcius correspondiente:");
            double Cel = Convert.ToDouble(Console.ReadLine());
            double Fahren = (Cel * 9) / 5 + 32;
            Console.WriteLine("La temperatura en grados Fahrenheit es: " + Fahren);
            Console.ReadLine();
        }
        static void Cfahrenheit()
        {
            Console.WriteLine("Ingrese el grado fahrenheit correspondiente:");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            double Celcius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("La temperatura en grados Celcius es: " + Celcius);
            Console.ReadLine();
        }
    }
}
