using System.Collections.Generic;

namespace StudentSystem
{
    public class StudentsDataBase
    {
        private Dictionary<string, Student> CollectionOfStudents;

        public StudentsDataBase()
        {
            this.CollectionOfStudents = new Dictionary<string, Student>();
        }
        public void Add(string name, int age, double grade)
        {
            if (!this.CollectionOfStudents.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                CollectionOfStudents[name] = student;
            }
        }
        public Student Find(string name)
        {
            if (this.CollectionOfStudents.ContainsKey(name))
            {
                return this.CollectionOfStudents[name];
            }
            return null;
        }
    }
}
