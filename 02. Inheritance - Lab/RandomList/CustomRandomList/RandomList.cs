using System;
using System.Collections.Generic;

namespace RandomLists.CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random element = new Random();
        public string RandomString()
        {
            var elementIndex = element.Next(0, this.Count);

            return base[elementIndex];
        }
        public string RemoveRandomString()
        {
            var elementIndex = this.element.Next(0, this.Count);
            var element = this[elementIndex];
            this.RemoveAt(elementIndex);

            return element;
        }
    }
}
