using System;

class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();                      //example: Ivan 
        Console.WriteLine("Enter middle name: ");
        string middleName = Console.ReadLine();                     //example: Petrov
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();                       //example: Ivanov
        Console.WriteLine("Enter balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());        //example: 10313123123.12
        Console.WriteLine("Enter bank name: ");
        string bankName = Console.ReadLine();                       //example: My Bank
        Console.WriteLine("Enter IBAN: ");
        string IBAN = Console.ReadLine();                           //example: IT96W0598718376123847384726
        Console.WriteLine("Enter first credit card: ");
        string firstCreditCard = Console.ReadLine();                //example: 0234123412341234
        Console.WriteLine("Enter second credit card: ");
        string secondCreditCard = Console.ReadLine();               //example: 0234123412341234
        Console.WriteLine("Enter third credit card: ");
        string thirdCreditCard = Console.ReadLine();                //example: 0234123412341234   

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Middle name: " + middleName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("balance: " + balance);
        Console.WriteLine("Bank: " + bankName);
        Console.WriteLine("IBAN: " + IBAN);
        Console.WriteLine("First credit card: " + firstCreditCard);
        Console.WriteLine("Second credit card: " + secondCreditCard);
        Console.WriteLine("Third credit card: " + thirdCreditCard);
    }
}

