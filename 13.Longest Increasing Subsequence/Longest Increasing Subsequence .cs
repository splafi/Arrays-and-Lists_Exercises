using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Largest_Increasing_Subsequence
{
    class LargestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            // InputList - for TEST ONLY
            // string inputStr = "1";
            // string inputStr = "7 3 5 8 -1 0 6 7";
            // string inputStr = "1 2 5 3 5 2 4 1";
            // string inputStr = "0 10 20 30 30 40 1 50 2 3 4 5 6";
            // string inputStr = "11 12 13 3 14 4 15 5 6 7 8 7 16 9 8";

            string inputStr = Console.ReadLine();
            List<int> inputL = inputStr.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int countSeq = 0;
            int len = inputL.Count;
            int maxL = inputL.Max();
            int nextN = 1;
            int tempPos = 1;
            int pos;
            List<int> tempL = new List<int>();
            List<int> posIncSubseqL = new List<int>();

            //Console.WriteLine(string.Join(" ", inputL));
            //Console.WriteLine($"len = {len} --- InputL - MAXelement: {maxL}\n");

            // Search for Subsequences
            if (len == 1)
            {
                tempL.Add(inputL[0]);
                tempPos = 0;
                countSeq = 1;
            }
            else
            {
                for (int i = 0; i < len - 1; i++)
                {
                    tempL.Add(inputL[i]);
                    tempPos = i + 1;
                    do
                    {
                        for (int j = tempPos; j < len; j++)
                        {
                            if (inputL[j] == inputL[i] + nextN)
                            {
                                tempL.Add(inputL[j]);
                                // Console.WriteLine($"Finded NEXT Num --> {inputL[j]} --- Pos = {j}");
                                tempPos = j + 1;
                                break;
                            }
                            if ((inputL[i] + nextN) > maxL)
                            {
                                // Console.WriteLine($"BREAK at POS --> {j}");
                                break;
                            }
                        }
                        nextN++;
                    } while (nextN <= maxL);
                    posIncSubseqL.Add(i); // Record START POSition of current Subsequence
                    posIncSubseqL.Add(tempL.Count); // Record LENgth of current Subsequence

                    //Console.WriteLine("tempL:");
                    //Console.WriteLine(string.Join(" ", tempL));
                    //Console.WriteLine($"LENGTH tempL: {tempL.Count}");
                    //Console.WriteLine("CLEAR tempL !!!");

                    tempL.Clear(); // CLEAR tempL
                    nextN = 1; // CLEAR nextN

                } // End of FOR-i

                //Console.WriteLine("posIncSubseqL:");
                //Console.WriteLine(string.Join(" ", posIncSubseqL));

                for (int i = 1; i < posIncSubseqL.Count; i += 2)
                {
                    if (posIncSubseqL[i] > countSeq)
                    {
                        countSeq = posIncSubseqL[i];
                        tempPos = posIncSubseqL[i - 1];
                    }
                }
            } // End ELSE
              // Console.WriteLine($"\n MAX LENGTH: {countSeq} at POSition: {tempPos}");

            // Print Largest Increasing Subsequence (If several - print the LEFTmost)
            // Console.WriteLine($"POSITION if 1 ----> {tempPos}");
            pos = tempPos;
            tempL.Clear();
            tempL.Add(inputL[pos]);
            tempPos = pos + 1;
            nextN = 1;

            if (countSeq > 1)
            {
                do
                {
                    for (int j = tempPos; j < len; j++)
                    {
                        if (inputL[j] == inputL[pos] + nextN)
                        {
                            tempL.Add(inputL[j]);
                            // Console.WriteLine($"Finded NEXT Num --> {inputL[j]} --- Pos = {j}");
                            tempPos = j + 1;
                            break;
                        }
                    }
                    nextN++;
                } while (nextN <= maxL);
            }

            // Console.WriteLine("FINAL Subsequence:");

            Console.WriteLine(string.Join(" ", tempL));

            // Console.WriteLine($"LENGTH tempL: {tempL.Count}");


        } // End of Main
    }
}