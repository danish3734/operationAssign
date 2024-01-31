using System;

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

        // Compare the two Employee objects using the overloaded operators
        bool areEqual = employee1 == employee2;

        // Display the comparison result
        Console.WriteLine($"Are the two employees equal? {areEqual}");
    }
}
