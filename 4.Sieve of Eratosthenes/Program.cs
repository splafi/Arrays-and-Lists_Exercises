using System;
using System.Collections.Generic;
using System.Linq;

namespace TheSieveOfEratosthenes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var my = new TheSieveOfEratosphene();
            my.FillList();
            my.DeleteNonPrimeNums();
            my.ShowList();
        }

        private class TheSieveOfEratosphene
        {
            private readonly List<int> _nums = new List<int>(new int[500]);

            public void FillList()
            {
                for (int i = 0; i < _nums.Count(); i++)
                    _nums[i] = i + 1;
            }

            public void ShowList()
            {
                var n = int.Parse(Console.ReadLine());
                foreach (var i in _nums)
                    if (i != 1 && i <= Math.Abs(n)) Console.Write("{0} ", i);
            }

            public void DeleteNonPrimeNums()
            {
                for (int i = 1; i < _nums.Count(); i++)
                {
                    for (int x = i; x < _nums.Count() - 1; x++)
                    {
                        if (_nums[x + 1] % _nums[i] == 0) _nums.RemoveAt(x + 1);
                    }
                }
            }
        }
    }
}