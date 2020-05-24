using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class Hospital
    {
        public Hospital()
        {
            this.Doctors = new List<Doctor>();
            this.Departments = new List<Department>();
        }
        public List<Doctor> Doctors { get; set; }
        public List<Department> Departments { get; set; }
        public void AddDoctor(string firstName, string surName)
        {
            if (!this.Doctors.Any(d => d.FirstName == firstName && d.Surname == surName))
            {
                this.Doctors.Add(new Doctor(firstName, surName));
            }
        }
        public void AddDepartment(string departmentName)
        {
            if (!this.Departments.Any(d=>d.Name == departmentName))
            {
                this.Departments.Add(new Department(departmentName));
            }
        }
        public void AddPatient(string departmentName, string fullName, string patientName)
        {
            var department = this.Departments.FirstOrDefault(d => d.Name == departmentName);

            var doctor = this.Doctors.FirstOrDefault(d => d.FullName == fullName);

            var patient = new Patient(patientName);

            if (department.AddPatientToRoom(patient))
            {
                doctor.Patients.Add(patient);
            }
        }
    }
}
