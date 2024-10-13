using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;

            while (continua)
            {
                Console.WriteLine(" Selecciona una opcion: ");
                Console.WriteLine(" 1.Sumar ");
                Console.WriteLine(" 2.resta ");
                Console.WriteLine(" 3.Division ");
                Console.WriteLine(" 4.Multiplicar ");
                Console.WriteLine(" 5.Salir ");

                int GaleriaOpciones = Convert.ToInt32(Console.ReadLine());

                if (GaleriaOpciones == 5)
                {
                    continua = false;
                    break;
                }

                double num1 = TakeNumber("Ingrese el primer numero: ");
                double num2 = TakeNumber("Ingrese el segundo numero: ");

                switch (GaleriaOpciones) 
                {
                    case 1:
                        suma suma = new suma();
                        Console.WriteLine(" resultado es: " + suma.Supra(num1, num2));
                        break;
                    case 2:
                        Multiplica multiplica = new Multiplica();
                        Console.WriteLine("resultado es: " + multiplica.Supra(num1, num2));
                        break;
                    case 3:
                        Dividi division = new Dividi();
                        Console.WriteLine("resultado es: " + division.Supra(num1, num2));
                        break;
                    default:
                        Console.WriteLine(" no opcion valida.");
                        break;
                 }
                

            }
           
            Console.ReadKey();

        }
        static double TakeNumber(string mensaje)
        {
            Console.Write(mensaje);
            return Convert.ToDouble(Console.ReadLine());
        }

     
    }
}
