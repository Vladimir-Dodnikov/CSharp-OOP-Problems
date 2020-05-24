using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class Doctor
    {
        public Doctor(string firstName, string surName)
        {
            this.FirstName = firstName;
            this.Surname = surName;
            this.Patients = new List<Patient>();
        }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FullName => this.FirstName + " " + this.Surname;
        public List<Patient> Patients { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var patient in this.Patients.OrderBy(p=>p.Name))
            {
                sb.AppendLine(patient.Name);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
