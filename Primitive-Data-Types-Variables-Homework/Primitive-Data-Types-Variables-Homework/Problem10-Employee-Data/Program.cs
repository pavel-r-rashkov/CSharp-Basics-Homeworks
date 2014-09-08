using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter gender: ");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter personal ID: ");
        string personalID = Console.ReadLine();
        Console.WriteLine("Enter employee number: ");
        string uniqueEmployeeNumber = Console.ReadLine();

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + personalID);
        Console.WriteLine("Employee Number: " + uniqueEmployeeNumber);
    }
}

