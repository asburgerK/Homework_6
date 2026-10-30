using System;
public enum Type
{
    Checking,
    Savings
}

public class  BankAccount
{
    private int number;
    private double balance;
    private Type accountType;

    public BankAccount(int number, double balance, Type type)
    { 
        this.number = number;
        this.balance = balance;
        this.accountType = type;
    }


    public void SetNumber(int number)
    {
        this.number = number;
    }

    public int GetNumber()
    {
        return this.number;
    }

    public void SetBalance(double balance) {
        this.balance = balance;
    }

    public double GetBalance()
    {
        return this.balance;
    }

    public void SetType(Type accountType)
    {
        this.accountType = accountType;
    }

    public Type GetType()
    {
        return this.accountType;
    }

    public void Print()
    {
        Console.WriteLine("Account Number: " + this.number);
        Console.WriteLine("Account Balance: " + this.balance);
        Console.WriteLine("Account Type: " + this.accountType);
    }


}


public class Program
{
    public static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount(12345, 1000.0, Type.Checking);
        account1.Print();
        Console.WriteLine();
        BankAccount account2 = new BankAccount(67890, 5000.0, Type.Savings);
        account2.Print();
    }
}