using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class Employee
    {

        public int ID { get; private set; }
        public string Name { get; private set; }
        public SecurityLevel SecurityLevel { get; private set; }
        public decimal Salary { get; private set; }
        public DateTime HireDate { get; private set; }

        private char _gender;
        public char Gender
        {
            get => _gender;
            private set
            {
                if (value == 'M' || value == 'F')
                {
                    _gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be 'M' (Male) or 'F' (Female).\n");
                }
            }
        }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate, char gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender; 
        }

        public override string ToString()
        {
            return string.Format(
                "Employee ID: {0}\nName: {1}\nSecurity Level: {2}\nSalary: {3:C}\nHire Date: {4:yyyy-MM-dd}\nGender: {5}",
                ID, Name, SecurityLevel, Salary, HireDate, Gender == 'M' ? "Male" : "Female"
            );
        }
    }
}
