namespace SandBox
{
    using System.ComponentModel.DataAnnotations;

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //attribute
        [Required]
        public string Name { get; set; }

        //another type of attribute
        //check built-in attributes!!!
        [Range(18, 56)]
        public int Age { get; set; }
    }
}
