using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root_Geron
{
    public class Square_Root
    {
        public double Formula_Gerona(double x, int k)
        {
            double E = 1.0E-2;
            double y = 3;
            double z = 0;

            int i = 0;

            while (Math.Abs(z - y) >= E)
            {

                Console.WriteLine(z - y);
                Console.Write("y = ");
                Console.WriteLine(y);
                z = y;
                y = (y + x / y) / 2;
                i++;
                if (i == k)
                    break;
            }
            Console.Write("k = ");
            Console.WriteLine(k);
            return y;
        }
    }
}
