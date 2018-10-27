using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Trial
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = 0;
            for (int i = 0; i < 365; i++)
            {
                k += (1 - 0.01 * i);
            }

            Console.Write("K = {0}", k);

            Console.ReadLine();
        }
    }
}
