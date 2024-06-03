using System;

namespace Practica_Clase_3
{
    internal class Program
    {
        public void Sumar()
        {
            Console.Write("Digite el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = num1 + num2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");
            Console.WriteLine();
        }

        public void Restar()
        {
            Console.Write("Digite el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = num1 - num2;
            Console.WriteLine($"El resultado de la resta es: {resultado}");
            Console.WriteLine();
        }

        public void Dividir()
        {
            Console.Write("Digite el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo nmero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 != 0)
            {
                double resultado = (double)num1 / num2;
                Console.WriteLine($"El resultado de la division es: {resultado}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
                Console.WriteLine();
            }
        }

        public void Potencia()
        {
            Console.Write("Digite el numero base: ");
            int numBase = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el exponente: ");
            int exponente = Convert.ToInt32(Console.ReadLine());
            double resultado = Math.Pow(numBase, exponente);
            Console.WriteLine($"El resultado de {numBase} elevado a {exponente} es: {resultado}");
            Console.WriteLine();
        }

        public void AreaTriangulo()
        {
            Console.Write("Digite la base del triangulo: ");
            int baseTriangulo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite la altura del triangulo: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            double area = (double)(baseTriangulo * altura) / 2;
            Console.WriteLine($"El area del triangulo es: {area}");
            Console.WriteLine();
        }

        public void AreaCuadrado()
        {
            Console.Write("Digite el lado del cuadrado: ");
            int lado = Convert.ToInt32(Console.ReadLine());
            int area = lado * lado;
            Console.WriteLine($"El area del cuadrado es: {area}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program programa = new Program();
            string opcion;

            do
            {
                Console.WriteLine("Operaciones Basicas");
                Console.WriteLine();
                Console.WriteLine("1 - Sumar");
                Console.WriteLine("2 - Restar");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Potencia");
                Console.WriteLine("5 - Triangulo");
                Console.WriteLine("6 - Cuadrado");
                Console.WriteLine("7 - Salir");
                Console.WriteLine();
                Console.Write("Digite una opcion: ");
                opcion = Console.ReadLine().ToLower();

                switch (opcion)
                {
                    case "sumar":
                        programa.Sumar();
                        break;
                    case "restar":
                        programa.Restar();
                        break;
                    case "dividir":
                        programa.Dividir();
                        break;
                    case "potencia":
                        programa.Potencia();
                        break;
                    case "triangulo":
                        programa.AreaTriangulo();
                        break;
                    case "cuadrado":
                        programa.AreaCuadrado();
                        break;
                    case "salir":
                        Console.WriteLine();
                        Console.WriteLine("Cerrando el programa...");
                        break;
                    default:
                        Console.WriteLine("Esa opcion no esta disponible. Favor de intentar de nuevo");
                        Console.WriteLine();
                        break;
                }

            } while (opcion != "7" && opcion != "salir");
        }
    }
}
