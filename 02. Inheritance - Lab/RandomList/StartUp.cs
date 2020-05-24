using System;
using RandomLists.CustomRandomList;

namespace RandomLists
{
    class StartUp
    {
        static void Main()
        {
            var randomList = new RandomList();
            randomList.Add("Bay");
            randomList.Add("May");
            randomList.Add("Kay");
            randomList.Add("KAy");
            randomList.Add("KaY");
            randomList.RemoveRandomString();
            randomList.RemoveRandomString();
            randomList.RemoveRandomString();
            randomList.RemoveRandomString();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(randomList.RandomString());
            }
        }
    }
}
