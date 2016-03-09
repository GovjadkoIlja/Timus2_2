using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timus2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m=-2000000000;
            n=Convert.ToInt32( Console.ReadLine());
            int[] mass = new int[n+1];
            mass[0] = 0;
            mass[1] = 1;
            for (int i=2; i< n+1; i++)
            {
                mass[i] = (i % 2 == 0 ? mass[i / 2] : mass[(i - 1) / 2] + mass[(i + 1) / 2]);
                if (mass[i] > m)
                    m = mass[i];
            }
            Console.Write(m);
            Console.ReadKey();
        }
    }
}
