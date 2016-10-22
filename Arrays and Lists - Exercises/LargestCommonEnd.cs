using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists___Exercises
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            List<string> arr1 = new List<string>(Console.ReadLine().Split());
            List<string> arr2 = new List<string>(Console.ReadLine().Split());
            var max = 0;
            if (arr1[0] == arr2[0])
            {
                for (int i = 0; i < Math.Min(arr1.Count, arr2.Count); i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        max++;
                    }
                }
                Console.WriteLine(max);
            }

            else if (arr1[arr1.Count - 1] == arr2[arr2.Count - 1])
            {
                for (int i =  0; i < Math.Min(arr1.Count, arr2.Count); i++)
                {
                    if (arr1[(arr1.Count-1)-i] == arr2[(arr2.Count-1)-i])
                    {
                        max++;
                    }
                }
                Console.WriteLine(max);
            }

            else
            {
                Console.WriteLine(max);
            }
        }
    }
}
