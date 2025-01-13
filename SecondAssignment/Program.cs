using System.Security.Cryptography.X509Certificates;

namespace SecondAssignment
{
    #region Assignmnt part 01
    #region part01 enum
    /*
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

    */
    #endregion

    #region part02 enum


    //[Flags]
    //enum Permission : byte
    //{
    //    Delete = 1, Execute = 2, Read = 4, Write = 8
    //}

    #endregion
    #endregion

    #region Assignment part 02
    //[Flags]
    //public enum SecurityLevel : byte
    //{
    //    Guest = 1,
    //    Developer = 2,
    //    Secretary = 4,
    //    DBA = 8
    //}


    [Flags]
    enum Permission : byte
    {
        None = 0,
        Delete = 1,
        Execute = 2,
        Read = 4,
        Write = 8,
        Full = Delete | Execute | Read | Write
    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Assignment Part01
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
            /*
            Employeee emp= new Employeee();
            emp.ID = 1;
            emp.Name = "Mariam";
            emp.Salary = 5000;
            //emp.Permission = Permission.Read ;
            emp.Permission = (Permission)2 ;

            */
            #endregion


            #region part02 enum

            //Permission P = (Permission)3;
            //Console.WriteLine(P);


            /////to add another permission
            //P |= Permission.Read;
            //Console.WriteLine(P);


            ///// to delete / stop existiong prmission
            //P &= ~Permission.Read;
            //Console.WriteLine(P);


            /////to switch btween permssions
            //P^= Permission.Read;
            //Console.WriteLine(P);



            /////to check if prmission exists
            //if ((P & Permission.Delete) == Permission.Delete) Console.WriteLine("Delete exists");

            //else Console.WriteLine("Delete Not exists");

            #endregion


            #region Class

            //Car c1 = new Car(1,"BMW",270);

            //Console.WriteLine(c1.ToString());
            #endregion

            #region Inhertance

            //Parent P = new Parent(1,2);
            //Console.WriteLine(P);
            //Console.WriteLine(P.Product());

            //Child c= new Child(1,2,3);
            //Console.WriteLine(c);
            //Console.WriteLine(c.Product());


            #endregion


            #endregion


            #region  Assignment Part02
            #region Design and implement a Class for the employees in a company

            //try
            //{
            //    Employee emp = new Employee(
            //        id: 101,
            //        name: "John Doe",
            //        securityLevel: SecurityLevel.Developer | SecurityLevel.DBA,
            //        salary: 85000.75m,
            //        hireDate: new DateTime(2020, 10, 15),
            //        gender: 'M'
            //    );

            //    Console.WriteLine(emp.ToString());

            //    if ((emp.SecurityLevel & SecurityLevel.DBA) == SecurityLevel.DBA)
            //    {
            //        Console.WriteLine("The employee has DBA privileges.");
            //    }

            //    emp = new Employee(emp.ID, emp.Name, emp.SecurityLevel | SecurityLevel.Secretary, emp.Salary, emp.HireDate, emp.Gender);
            //    Console.WriteLine("Updated Security Level: " + emp.SecurityLevel);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            #endregion


            #region Develop a Class to represent the Hiring Date Data:

            //try
            //{
            //    HiringDate hiringDate = new HiringDate(15, 10, 2020);

            //    Console.WriteLine("Hiring Date: " + hiringDate.ToString());
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            #endregion


            #region Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr
           
            //EmpArray[] EmpArr = new EmpArray[3];

            //EmpArr[0] = new EmpArray(1, "DBA", 10000, Permission.Read | Permission.Write);
            //EmpArr[1] = new EmpArray(2, "Guest", 5000, Permission.Read);
            //EmpArr[2] = new EmpArray(3, "Security Officer", 15000, Permission.Full);

             
            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}


            #endregion


            #region Sort the employees based on their hire date then Print the sorted array.

            #endregion


            #endregion
        }
    }
}
