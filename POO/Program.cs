using System;
using System.Threading.Tasks;

namespace POO
{
    

    public class Program
    {
        static void Main(string[] args)
        {
            bool estaEjecutando = true;

            while (estaEjecutando)
            {
                Utils.MostrarMenu();

                int opcionSeleccionada = Utils.LeerEntrada(Console.ReadLine());

                if (opcionSeleccionada < 0 && opcionSeleccionada > 5)
                {
                    estaEjecutando = false;
                    continue;
                }

                double num1 = Utils.TakeNumber("Ingrese el primer numero: ");
                double num2 = Utils.TakeNumber("Ingrese el segundo numero: ");

                string resultado = Utils.ObtenerResultado(opcionSeleccionada, num1, num2);

                Console.WriteLine(resultado);
            }
           
            Console.ReadKey();

        }
    }
}
