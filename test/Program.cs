using System;
using System.Collections.Generic;
using System.Linq;

namespace ColorCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[] {
                "FF0000", "00FF00", "0000FF", "FFFF00", "FF00FF", "00FFFF",
                "800000", "008000", "000080", "808000", "800080", "008080",
                "C00000", "00C000", "0000C0", "C0C000", "C000C0", "00C0C0",
                "400000", "004000", "000040", "404000", "400040", "004040",
                "200000", "002000", "000020", "202000", "200020", "002020",
                "600000", "006000", "000060", "606000", "600060", "006060",
                "A00000", "00A000", "0000A0", "A0A000", "A000A0", "00A0A0",
                "E00000", "00E000", "0000E0", "E0E000", "E000E0", "00E0E0",
                "000000", "808080", "C0C0C0", "FFFFFF"
            };

            // Получаем все возможные комбинации цветов
            List<string[]> combinations = GetColorCombinations(colors);

            // Получаем максимально возможное количество уникальных комбинаций
            int maxUniqueCombinations = combinations.Count();

            Console.WriteLine($"Максимально возможное количество уникальных комбинаций: {maxUniqueCombinations}");

            // Получаем порядковый номер каждой уникальной комбинации цветов
            for (int i = 0; i < maxUniqueCombinations; i++)
            {
                string[] combination = combinations[i];
                Console.WriteLine($"Порядковый номер комбинации [{string.Join(",", combination)}]: {i + 1}");
            }

            Console.ReadKey();
        }

        static List<string[]> GetColorCombinations(string[] colors)
        {
            List<string[]> combinations = new List<string[]>();

            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = i + 1; j < colors.Length; j++)
                {
                    for (int k = j + 1; k < colors.Length; k++)
                    {
                        combinations.Add(new string[] { colors[i], colors[j], colors[k] });
                    }
                }
            }

            return combinations;
        }
    }
}
