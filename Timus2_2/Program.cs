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
            int n=1, max=-2000000000;
            int max_n = 0;
            int i, j;
            List<int> numbers = new List<int>();
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                numbers.Add(n);
                n = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < numbers.Count; i++)
                if (numbers[i] > max_n)
                    max_n = numbers[i];
            int[] mass = new int[max_n+1];
            mass[0] = 0;
            mass[1] = 1;
            for (i = 2; i < max_n+1; i++)
            { 
                mass[i] = (i % 2 == 0 ? mass[i / 2] : mass[(i - 1) / 2] + mass[(i + 1) / 2]);
            }
            for (i = 0; i < numbers.Count; i++)
            {
                for (j = 1; j <= numbers[i]; j++)
                {
                    if (mass[j] > max)
                        max = mass[j];
                }
                Console.WriteLine(max);
                max = 0;
            }
            Console.ReadKey();
        }
    }
}
