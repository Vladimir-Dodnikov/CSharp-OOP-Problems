namespace BorderControl
{
    public class Citizen : IIdentitiable
    {
        private string name;
        private int age;
        private string id;
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }
        public string Name
        {
            get => name;
            private set => name = value;
        }
        public int Age
        {
            get => age;
            private set => age = value;
        }
        public string ID
        {
            get => id;
            private set => id = value;
        }
    }
}
