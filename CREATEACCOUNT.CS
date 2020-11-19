
using System;

class CreateAccount
{
    static void Main() 
    {


        BankAccount berts = NewBankAccount();
        Write(berts);
        TestDeposit(berts);
        Write(berts);

        BankAccount freds = NewBankAccount();
        Write(freds);
        TestDeposit(freds);
        Write(freds);

    }
    public static void TestDeposit(BankAccount acc)
    {
        try { 
        Console.Write("Enter amount to deposit: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (amount>0)
        acc.Deposit(amount);
        else
        { Console.WriteLine("Вы ввели отрицательное число"); }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
        }
    }

    static BankAccount NewBankAccount()
    {       
        BankAccount created = new BankAccount();
        
        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());
        
        created.Populate(balance);
        
        return created;
    }
    
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        Console.ReadLine();
    }
}
