using System;

// Define the Employee class
public class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the equality operator (==)
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both objects are null or if their Id properties are equal
        return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
               !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) &&
               employee1.Id == employee2.Id;
    }

    // Overload the inequality operator (!=) to maintain consistency
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Compare the two Employee objects using overloaded operators
        if (employee1 == employee2)
        {
            Console.WriteLine("Employee 1 and Employee 2 are equal.");
        }
        else
        {
            Console.WriteLine("Employee 1 and Employee 2 are not equal.");
        }
    }
}
