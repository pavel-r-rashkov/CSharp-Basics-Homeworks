using System;

class CompanyInformation
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter compnay name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter company address: ");
        string companyAdress = Console.ReadLine();
        Console.WriteLine("Enter company phone number : ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter fax number ");
        string fax = Console.ReadLine();
        if (fax == "")
        {
            fax = "(no fax)";
        }
        Console.WriteLine("Enter web site: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Enter manager first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter manager last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter manager age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
            companyName, companyAdress, phoneNumber, fax, webSite, firstName, lastName, age, managerPhone);

         
    }
}

