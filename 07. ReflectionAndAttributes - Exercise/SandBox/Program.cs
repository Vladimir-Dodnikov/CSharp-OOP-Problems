using System;

namespace SandBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            var type = Type.GetType("SandBox.Person");

            Console.WriteLine(type);

            Person person = new Person(null, -50);
        }
    }
}
