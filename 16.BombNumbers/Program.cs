using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication24
{
    class Program
    {
        public static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] m = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = m[0];
            int power = m[1];

            for (int i = 0; i < n.Count; i++)
            {
                if (n[i] == number)
                {
                    n[i] = 0;
                    for (int j = 1; j <= power; j++)
                    {
                        if (i + j >= n.Count)
                        {
                            break;
                        }
                        else
                        {
                            n[i + j] = 0; ;
                        }
                    }

                    for (int k = 1; k <= power; k++)
                    {
                        if (i - k < 0)
                        {
                            break;
                        }
                        else
                        {
                            n[i - k] = 0;
                        }
                    }
                }
            }
            int result = 0;
            for (int i = 0; i < n.Count; i++)
            {
                result += n[i];
            }
            Console.WriteLine(result);
        }
    }
}