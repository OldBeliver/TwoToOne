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
            
            List<int> onlyOne = new List<int>();

            GetUniqueValues(firstArray, ref onlyOne);
            GetUniqueValues(secondArray, ref onlyOne);

            Console.WriteLine($"имеются два массива чисел:\n{string.Join(", ", firstArray)}\n{string.Join(", ", secondArray)}");
            Console.WriteLine($"\nобъединенная коллекция с уникальными значениями:\n{string.Join(", ", onlyOne)}");
        }

        static void GetUniqueValues(int[] array, ref List<int> onlyOne)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];

                if (!onlyOne.Contains(value))
                    onlyOne.Add(value);
            }
        }
    }
}
