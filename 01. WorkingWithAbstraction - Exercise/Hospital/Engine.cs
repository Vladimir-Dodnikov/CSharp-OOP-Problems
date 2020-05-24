using System;
using System.Linq;

namespace Hospital
{
    public class Engine
    {
        private Hospital hospital;
        public Engine()
        {
            this.hospital = new Hospital();
        }
        public void Run()
        {
            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] arguments = command.Split();
                var departament = arguments[0];
                var firstName = arguments[1];
                var surName = arguments[2];
                var patient = arguments[3];
                var fullName = firstName + " " + surName;

                this.hospital.AddDoctor(firstName, surName);
                this.hospital.AddDepartment(departament);
                this.hospital.AddPatient(departament, fullName, patient);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    var departmentName = args[0];
                    var department = this.hospital.Departments.FirstOrDefault(d => d.Name == departmentName);

                    Console.WriteLine(department);
                }
                else
                {
                    bool isRoom = int.TryParse(args[1], out int resulRoom);
                   
                    if (isRoom)
                    {
                        var departmentName = args[0];
                        var department = this.hospital.Departments.FirstOrDefault(de => de.Name == departmentName);

                        var currentRoom = department.Rooms[resulRoom - 1];

                        Console.WriteLine(currentRoom);
                    }
                    else
                    {
                        string firstName = args[0];
                        string surName = args[1];
                        string fullName = firstName + " " + surName;
                        var doctorName = this.hospital.Doctors.FirstOrDefault(d => d.FullName == fullName);

                        Console.WriteLine(doctorName);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
