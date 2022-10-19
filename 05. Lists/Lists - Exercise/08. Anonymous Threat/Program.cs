using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays =
                Console.ReadLine()
                .Split(' ')
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] inputs = input.Split(' ');
                string command = inputs[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(inputs[1]);
                    int endIndex = int.Parse(inputs[2]);
                    FixInvalidIndex(arrays, ref startIndex, ref endIndex);
                    MergeWords(arrays, startIndex, endIndex);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(inputs[1]);
                    int partitions = int.Parse(inputs[2]);

                    string word = arrays[index];
                    int substringsLenght = word.Length / partitions;
                    int lastSubstringLength = word.Length - ((partitions - 1) * substringsLenght);

                    List<string> partitionsList = new List<string>();

                    for (int i = 0; i < partitions; i++)
                    {
                        int desiredLength = substringsLenght;

                        if (i == partitions - 1)
                        {
                            desiredLength = lastSubstringLength;
                        }

                        char[] newPartitionsArr = word
                            .Skip(i * substringsLenght)
                            .Take(desiredLength).ToArray();
                        string newPartitions = string.Join(' ', newPartitionsArr);
                        partitionsList.Add(newPartitions);
                    }

                    arrays.RemoveAt(index);
                    arrays.InsertRange(index, partitionsList);
                }
            }

            Console.WriteLine(string.Join(' ', arrays)); ;
        }

        private static void MergeWords(List<string> arrays, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;

            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = arrays[startIndex];
                mergedText += currWord;
                arrays.RemoveAt(startIndex);
            }

            arrays.Insert(startIndex, mergedText);
        }

        private static void FixInvalidIndex(List<string> arrays, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex > arrays.Count - 1)
            {
                endIndex = arrays.Count - 1;
            }
        }
    }
}
