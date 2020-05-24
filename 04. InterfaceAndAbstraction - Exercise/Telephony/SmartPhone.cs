using System;
using System.Linq;

namespace Telephony
{
    public class SmartPhone : IBrowseble, ICallable
    {
        public void Browse(string URL)
        {
            if (URL.Any(x => char.IsDigit(x)))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {URL}!");
            }
        }

        public void Call(string number)
        {
            if (number.All(x => char.IsDigit(x)))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
