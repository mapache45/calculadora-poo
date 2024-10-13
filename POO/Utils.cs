using System;

namespace POO
{
    public class Utils
    {
        public static double TakeNumber(string mensaje)
        {
            Console.Write(mensaje);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void MostrarMenu()
        {
            Console.WriteLine("Selecciona una opcion: ");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplicar");
            Console.WriteLine("5. Salir ");
        }

        public static int LeerEntrada(string input)
        {
            return Convert.ToInt32(input);
        }

        public static string ObtenerResultado(int opcion, double num1, double num2)
        {
            Calculadora calculadora = new Calculadora();

            switch (opcion)
            {
                case 1:
                    return "Resultado es: " + calculadora.Sumar(num1, num2);
                case 2:
                    return "Resultado es: " + calculadora.Restar(num1, num2);
                case 3:
                    return "Resultado es: " + calculadora.Dividir(num1, num2);
                case 4:
                    return "Resultado es: " + calculadora.Multiplicar(num1, num2);
                default:
                    return "No opcion valida";
            }
        }
    }
}
