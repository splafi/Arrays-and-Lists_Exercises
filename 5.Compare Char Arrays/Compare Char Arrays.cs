using System;
class CompareTwoCharArraysLetterByLetter
{
    static void Main()
    {

        string[] firstInputChars = Console.ReadLine().Split();
        string[] secondInputChars = Console.ReadLine().Split();

        //Input the chars from the 2 strings into 2 arrays
        char[] arrayOne = new char[firstInputChars.Length];
        char[] arrayTwo = new char[secondInputChars.Length];

        for (int i = 0; i < arrayOne.Length; i++)
        {
            arrayOne[i] = char.Parse(firstInputChars[i]);
        }
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            arrayTwo[i] = char.Parse(secondInputChars[i]);
        }

        for (int i = 0; i < Math.Min(arrayOne.Length, arrayTwo.Length); i++)
        {
            if (arrayOne[i] <= arrayTwo[i])
            {
                for (int j = 0; j < arrayOne.Length; j++)
                {
                    Console.Write(arrayOne[j]);
                }
                Console.WriteLine();
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    Console.Write(arrayTwo[j]);
                }
                break;
            }
            else
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    Console.Write(arrayTwo[j]);
                }
                Console.WriteLine();
                for (int j = 0; j < arrayOne.Length; j++)
                {
                    Console.Write(arrayOne[j]);
                }
                break;
            }
        }
    }
}