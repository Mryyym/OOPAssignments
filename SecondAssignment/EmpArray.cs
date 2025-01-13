using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondAssignment
{
    internal class EmpArray
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Permission Permission { get; set; }

        public EmpArray() : this(0, "Unknown", 0, Permission.None) { }

        public EmpArray(int id, string name, decimal salary, Permission permission)
        {
            ID = id >= 0 ? id : throw new ArgumentException("ID must be non-negative");
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentException("Name cannot be empty");
            Salary = salary >= 0 ? salary : throw new ArgumentException("Salary must be non-negative");
            Permission = permission;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Salary: {Salary:C}, Permissions: {Permission}";
        }
    }
}
