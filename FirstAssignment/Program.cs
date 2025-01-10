namespace FirstAssignment
{
    ///1.
    //enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    //////////
    ///2.
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    // Constructor for easier initialization
    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}

    //////////
    ///3.
    //public enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter
    //}


    //////////
    ///4.
    //[Flags] 
    //public enum Permissions
    //{
    //    None = 0,       
    //    Read = 1,      
    //    Write = 2,      
    //    Delete = 4,     
    //    Execute = 8     
    //}

    //////////
    ///5.
    //public enum Colors
    //{
    //    Red,
    //    Green,
    //    Blue
    //}
    //////////
    ///6.
    //struct Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }
    //}

    //////////
    ///7.
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //ANSWER

            /*
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
           */
            #endregion

            #region 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //ANSWER 
            /*
            Person[] persons = new Person[3];
            persons[0] = new Person("Alice", 25);
            persons[1] = new Person("Bob", 30);
            persons[2] = new Person("Charlie", 35);

            // Display the details of all persons
            foreach (Person person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            */
            #endregion

            #region 3.	Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            ///ANSWER
            /*
            Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();

            try
            {
                Season selectedSeason = (Season)Enum.Parse(typeof(Season), input, true);

                switch (selectedSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            catch (Exception X)
            {
                Console.WriteLine("Please enter valid season name");
            }
            */
            #endregion

            #region 4.	Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. ⮚	Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //ANSWER

            /*
            Permissions userPermissions = Permissions.None;

            // Add permissions
            userPermissions = AddPermission(userPermissions, Permissions.Read);
            userPermissions = AddPermission(userPermissions, Permissions.Write);

            // Display current permissions
            Console.WriteLine($"Current Permissions: {userPermissions}");

            // Check for specific permission
            Console.WriteLine($"Has Read Permission: {HasPermission(userPermissions, Permissions.Read)}");
            Console.WriteLine($"Has Execute Permission: {HasPermission(userPermissions, Permissions.Execute)}");

            // Remove a permission
            userPermissions = RemovePermission(userPermissions, Permissions.Read);
            Console.WriteLine($"Permissions after removing Read: {userPermissions}");
        }

        // Method to add a permission
        static Permissions AddPermission(Permissions current, Permissions permissionToAdd)
        {
            return current | permissionToAdd; // Use bitwise OR to add permission
        }

        // Method to remove a permission
        static Permissions RemovePermission(Permissions current, Permissions permissionToRemove)
        {
            return current & ~permissionToRemove; // Use bitwise AND with NOT to remove permission
        }

        // Method to check if a permission exists
        static bool HasPermission(Permissions current, Permissions permissionToCheck)
        {
            return (current & permissionToCheck) == permissionToCheck; // Use bitwise AND to check permission
        }

         */
            #endregion

            #region 5.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            ////ANSWER
            /*
            Console.WriteLine("Enter a color name:");
            string input = Console.ReadLine();

            try
            {
                Colors selectedColor = (Colors)Enum.Parse(typeof(Colors), input, true);

                Console.WriteLine($"{selectedColor} is a primary color.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{input} is not a primary color.");
            }

            */
            #endregion

            #region 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            ////ANSWER
            /*
            static double CalculateDistance(Point p1, Point p2)
            {
                double deltaX = p2.X - p1.X;
                double deltaY = p2.Y - p1.Y;
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
            try
            {
                Console.WriteLine("\nEnter the coordinates of two points to calculate the distance:");

                Point point1 = new Point(); 
                while (true)
                {
                    try
                    {
                        Console.Write("Enter X1: ");
                        point1.X = double.Parse(Console.ReadLine());
                        Console.Write("Enter Y1: ");
                        point1.Y = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Please enter numeric values");
                    }
                }

                Point point2 = new Point(); ;
                while (true)
                {
                    try
                    {
                        Console.Write("Enter X2: ");
                        point2.X = double.Parse(Console.ReadLine());
                        Console.Write("Enter Y2: ");
                        point2.Y = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine(" Please enter numeric values ");
                    }
                }

                double distance = CalculateDistance(point1, point2);
                Console.WriteLine($"Distance between the two points is: {distance}");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            */

            #endregion

            #region 7.	Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person

            ////ANSWER
            /*
            
            try
            {
                Person[] persons = new Person[3];
                for (int i = 0; i < persons.Length; i++)
                {
                    Console.WriteLine($"Enter details for person {i + 1}:");
                    string name;
                    while (true)
                    {
                        Console.Write("Name: ");
                        name = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(name) && IsString(name))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid name without numbers or spaces.");
                        }
                    }

                    int age;
                    while (true)
                    {
                        Console.Write("Age: ");
                        if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid age");
                        }
                    }

                    persons[i] = new Person { Name = name, Age = age };
                }

                Person oldestPerson = persons[0];
                foreach (var person in persons)
                {
                    if (person.Age > oldestPerson.Age)
                    {
                        oldestPerson = person;
                    }
                }

                Console.WriteLine("\nThe oldest person is:");
                Console.WriteLine($"Name: {oldestPerson.Name}");
                Console.WriteLine($"Age: {oldestPerson.Age}");
            }
            catch (Exception x)
            {

                Console.WriteLine(x.Message);
            }
            static bool IsString(string input)
            {
                foreach (char c in input)
                {
                    if (!char.IsLetter(c) )
                    {
                        return false;
                    }
                }
                return true;
            }
            */

            #endregion



        }
    }
}
