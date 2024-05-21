using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.Write("Ingrese una operación (+, -, *, /): ");
                string operacion = Console.ReadLine();

                double numero1 = LeerNumero("Ingrese el primer número: ");
                double numero2 = LeerNumero("Ingrese el segundo número: ");

                double resultado = RealizarOperacion(operacion, numero1, numero2);

                MostrarResultado(operacion, numero1, numero2, resultado);

                continuar = SeguirCalculando();
            }
        }

        static double LeerNumero(string mensaje)
        {
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write(mensaje);
            }
            return numero;
        }

        static double RealizarOperacion(string operacion, double numero1, double numero2)
        {
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                        resultado = numero1 / numero2;
                    else
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    break;
                default:
                    Console.WriteLine("Error: Operación no válida.");
                    break;
            }
            return resultado;
        }

        static void MostrarResultado(string operacion, double numero1, double numero2, double resultado)
        {
            if (resultado != 0)
                Console.WriteLine($"Resultado: {resultado}");
        }

        static bool SeguirCalculando()
        {
            Console.Write("Desea continuar? (S/N): ");
            string respuesta = Console.ReadLine().ToLower();
            while (respuesta != "s" && respuesta != "n")
            {
                Console.Write("Desea continuar? (S/N): ");
                respuesta = Console.ReadLine().ToLower();
            }
            return respuesta == "s";
        }
    }
}