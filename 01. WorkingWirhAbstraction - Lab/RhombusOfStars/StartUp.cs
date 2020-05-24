using System;
using System.Text;

namespace RhombusOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            RhombusDrawerAsString rhombus = new RhombusDrawerAsString();
            var rhombusDraw = rhombus.Draw(n);
            Console.WriteLine(rhombusDraw.ToString());
        }
        
    }
}
