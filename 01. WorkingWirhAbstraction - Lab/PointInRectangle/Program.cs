using System;
using System.Linq;

namespace PointInRectangle
{
    class Program
    {
        static void Main()
        {
            int[] coordinates = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int topLeftX = coordinates[0];
            int topLeftY = coordinates[1];
            int bottomRightX = coordinates[2];
            int bottomRightY = coordinates[3];

            var topleftPoint = new Point(topLeftX, topLeftY);
            var bottomRigthPoint = new Point(bottomRightX, bottomRightY);

            Rectangle rectangle = new Rectangle(topleftPoint, bottomRigthPoint);

            int count = int.Parse(Console.ReadLine());

            while (count > 0)
            {
                int[] coodinateOfPoint = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int pointX = coodinateOfPoint[0];
                int pointY = coodinateOfPoint[1];

                var point = new Point(pointX, pointY);

                if (rectangle.Contains(point))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
                count--;
            }

        }
    }
}
