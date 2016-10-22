using System;
using System.Linq;


namespace arrayManipulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            var listIn = Console.ReadLine().Split(' ').ToList();
            var arr = Console.ReadLine().Split(' ').ToArray();
            string command = arr[0];
            while (command != "print")
            {
                if (command == "add")
                {
                    int index = int.Parse(arr[1]);
                    string value = arr[2];
                    listIn.Insert(index, value);
                }
                if (command == "addMany")
                {
                    int index = int.Parse(arr[1]);
                    listIn.InsertRange(index, arr.Skip(2));
                }
                if (command == "contains")
                {
                    Console.WriteLine(listIn.IndexOf(arr[1]));
                }
                if (command == "remove")
                {
                    int index = int.Parse(arr[1]);
                    listIn.RemoveAt(index);
                }
                if (command == "shift")
                {
                    int shift = int.Parse(arr[1]);
                    for (int i = 0; i < shift; i++)
                    {
                        var old = listIn[0];
                        listIn.RemoveAt(0);
                        listIn.Add(old);
                    }
                }
                if (command == "sumPairs")
                {
                    for (int i = 0; i < listIn.Count - 1; i++)
                    {
                        listIn[i] = (int.Parse(listIn[i]) + int.Parse(listIn[i + 1])).ToString();
                        listIn.RemoveAt(i + 1);
                    }
                }
                arr = Console.ReadLine().Split(' ').ToArray();
                command = arr[0];
            }//end while;
            Console.WriteLine("[" + string.Join(", ", listIn) + "]");
        }
    }
}