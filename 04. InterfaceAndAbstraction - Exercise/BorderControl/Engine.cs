using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Engine
    {
        private List<IIdentitiable> creatures;
        public Engine()
        {
            this.creatures = new List<IIdentitiable>();
        }
        public void Run()
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split();
                if (inputArgs.Length == 2)
                {
                    string model = inputArgs[0];
                    string id = inputArgs[1];

                    IIdentitiable robot = new Robot(model, id);

                    this.creatures.Add(robot);
                }
                else
                {
                    string name = inputArgs[0];
                    int age = int.Parse(inputArgs[1]);
                    string id = inputArgs[2];

                    IIdentitiable citizen = new Citizen(name, age, id);
                    this.creatures.Add(citizen);
                }
            }

            string fakeId = Console.ReadLine();

            foreach (var item in this.creatures.Where(x => x.ID.EndsWith(fakeId)))
            {
                Console.WriteLine(item.ID);
            }
            this.creatures.RemoveAll(x => x.ID.EndsWith(fakeId));
        }
    }
}
