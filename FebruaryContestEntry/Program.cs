using System;

namespace FebruaryContestEntry
{
    class Program
    {
        const char block = '▓';
        const int columns = 30;
        const int rows = 15;

        static void Main(string[] args)
        {
            // The solution implementation goes here
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.ForegroundColor = GetConsoleForegroundColor(i, j);
                    Console.Write(block);
                }
                Console.WriteLine();
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Yay, a colorful shape!");
            Console.ReadLine();
        }
        private static ConsoleColor GetConsoleForegroundColor(
            int row,
            int column)
          => (row == 0 ||
              row == rows - 1 ||
              column == 0 ||
              column == columns - 1)
              ? ConsoleColor.Green
              : ConsoleColor.Yellow;
    }
}
