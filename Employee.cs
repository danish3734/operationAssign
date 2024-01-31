using System;

public class Employee
{
    // Properties of the Employee class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the "==" operator to compare Employee objects based on their Id property
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check for nullity to avoid null reference exceptions
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If either object is null, or their Id properties are not equal, return false
        if (emp1 is null || emp2 is null || emp1.Id != emp2.Id)
            return false;

        // Otherwise, the objects are considered equal
        return true;
    }

    // Overloading the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Utilize the overloaded "==" operator to avoid code duplication
        return !(emp1 == emp2);
    }
}
