using System.Security.Cryptography.X509Certificates;

namespace SecondAssignment
{
    #region part01 enum

    [Flags]
    enum Permission :byte
    {
        Delete = 1, Execute =2, Read=4, Write=8
    }
    class Employeee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Permission Permission { get; set; }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region with getter and settr
            /*
            PhoneBook Note = new PhoneBook(3);
            Note.AddPerson(0, "Ahmed", 123);
            Note.AddPerson(1, "Anas", 456);
            Note.AddPerson(2, "Aya", 789);
            #endregion
            
             
          Console.WriteLine( Note.getPersonNum("Aya"));
            Note.setPrsonNum("Aya",102030);
            */
            #endregion

            #region INDEXER

            PhoneBook Note = new PhoneBook(3);
            Note.AddPerson(0, "Ahmed", 123);
            Note.AddPerson(1, "Anas", 456);


            /*
             Note.AddPerson(2, "Aya", 789);
            Note["Ahmed"] = 2025;
            Console.WriteLine(Note["Ahmed"]);
            */


            //
            // Console.WriteLine(Note[1]);
            #endregion


            #region part01 enum
            Employeee emp= new Employeee();
            emp.ID = 1;
            emp.Name = "Mariam";
            emp.Salary = 5000;
            //emp.Permission = Permission.Read ;
            emp.Permission = (Permission)2 ;
            #endregion

            #endregion


            #region Part02
            #region Design and implement a Class for the employees in a company

            #endregion


            #region Develop a Class to represent the Hiring Date Data:

            #endregion


            #region Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr

            #endregion


            #region Sort the employees based on their hire date then Print the sorted array.

            #endregion


            #endregion
        }
    }
}
