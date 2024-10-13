using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Dividi
    {
        public double Supra(double x, double y)
        {
            

            if (x == 0 && y == 0)
            {
                Console.WriteLine(" en 0 no se divide");
                return 0;
            }
            return x / y;

        }
    }
}
