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

            List<int> tempoArray = new List<int>();
            List<int> onlyOne = new List<int>();

            tempoArray.AddRange(firstArray);
            tempoArray.AddRange(secondArray);

            for (int i = 0; i < tempoArray.Count; i++)
            {
                bool isContains = onlyOne.Contains(tempoArray[i]);

                if (!isContains)
                    onlyOne.Add(tempoArray[i]);
            }

            Console.WriteLine($"имеются два массива чисел:\n{string.Join(", ", firstArray)}\n{string.Join(", ", secondArray)}");
            Console.WriteLine($"\nобъединенная коллекция с уникальными значениями:\n{string.Join(", ", onlyOne)}");
        }
    }
}
