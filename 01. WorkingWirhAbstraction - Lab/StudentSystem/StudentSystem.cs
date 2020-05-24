using System;

namespace StudentSystem
{
    public class StudentSystem
    {
        private StudentsDataBase students;
        public StudentSystem()
        {
            this.students = new StudentsDataBase();
        }
        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();

            string commandName = args[0];
            if (commandName == "Create")
            {
                Create(args);
            }
            else if (commandName == "Show")
            {
                Show(args);

            }
            else if (commandName == "Exit")
            {
                Environment.Exit(0);
            }
        }

        private void Show(string[] args)
        {
            var name = args[1];
            var student = this.students.Find(name);
            if (student != null)
            {
                Console.WriteLine(student);
            }
        }

        private void Create(string[] args)
        {
            var name = args[1];
            var age = int.Parse(args[2]);
            var grade = double.Parse(args[3]);
            this.students.Add(name, age, grade);
        }
    }
}
