using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SmartPhone smartfhone = new SmartPhone();

            string[] inputNumbers = Console.ReadLine().Split();
            string[] inputURLs = Console.ReadLine().Split();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                smartfhone.Call(inputNumbers[i]);
            }

            for (int i = 0; i < inputURLs.Length; i++)
            {
                smartfhone.Browse(inputURLs[i]);
            }
        }
    }
}
