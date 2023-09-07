// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");


            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 5)
            {
                break;
            }

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el primer número: ");
                    double numero1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double numero2 = double.Parse(Console.ReadLine());
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    Console.Write("Ingrese el primer número: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    numero2 = double.Parse(Console.ReadLine());
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    Console.Write("Ingrese el primer número: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresse el segundo número: ");
                    numero2 = double.Parse(Console.ReadLine());
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    Console.Write("Ingrese el dividendo: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el divisor: ");
                    numero2 = double.Parse(Console.ReadLine());
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine(" No se puede dividir entre cero pe causa.");
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Seleccione una operacióna la operacion que desea");
                    continue;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
