using System;
using System.Linq;

namespace JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rowsCount = matrixSize[0];
            int colsCount = matrixSize[1];

            int[,] matrix = new int[rowsCount, colsCount];

            InitializeMatrix(matrix);

            long sum = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Let the Force be with you")
                {
                    break;
                }

                int[] playerCoordinates = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int[] evilCoordinates = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int rowCoordinateOfPlayer = playerCoordinates[0];
                int colCoordinateOfPlayer = playerCoordinates[1];

                int rowCoordinateOfEvil = evilCoordinates[0];
                int colCoordinateOfEvil = evilCoordinates[1];

                while (rowCoordinateOfEvil >= 0 && colCoordinateOfEvil >= 0)
                {
                    if (rowCoordinateOfEvil >= 0 && rowCoordinateOfEvil < matrix.GetLength(0) &&
                        colCoordinateOfEvil >= 0 && colCoordinateOfEvil < matrix.GetLength(1))
                    {
                        matrix[rowCoordinateOfEvil, colCoordinateOfEvil] = 0;
                    }
                    rowCoordinateOfEvil--;
                    colCoordinateOfEvil--;
                }
                while (rowCoordinateOfPlayer >= 0 && colCoordinateOfPlayer < matrix.GetLength(1))
                {
                    if (rowCoordinateOfPlayer >= 0 && rowCoordinateOfPlayer < matrix.GetLength(0) &&
                        colCoordinateOfPlayer >= 0 && colCoordinateOfPlayer < matrix.GetLength(1))
                    {
                        sum += matrix[rowCoordinateOfPlayer, colCoordinateOfPlayer];
                    }

                    rowCoordinateOfPlayer--;
                    colCoordinateOfPlayer++;
                }
            }

            Console.WriteLine(sum);
        }

        private static void InitializeMatrix(int[,] matrix)
        {
            int value = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = value++;
                }
            }
        }
    }
}
