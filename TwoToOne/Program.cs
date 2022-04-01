using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 1, 3, 1 };
            int[] secondArray = new int[] { 1, 2, 2 };

            List<int> onlyUniqueValue = new List<int>();

            AddToList(firstArray, onlyUniqueValue);
            AddToList(secondArray, onlyUniqueValue);

            Console.WriteLine($"имеются два массива чисел:\n{string.Join(", ", firstArray)}\n{string.Join(", ", secondArray)}");
            Console.WriteLine($"\nобъединенная коллекция с уникальными значениями:\n{string.Join(", ", onlyUniqueValue)}");
        }

        static void AddToList(int[] array, List<int> onlyUniqueValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];

                if (onlyUniqueValue.Contains(value) == false)
                    onlyUniqueValue.Add(value);
            }
        }
    }
}
