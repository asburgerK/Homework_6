using System;
using System.Runtime.CompilerServices;
public enum Type
{
    Checking,
    Savings
}

public class  BankAccount
{

    private static  int counteId = 0;

    private int number;
    private double balance;
    private Type accountType;

    private static int GenerateNumber()
    {
        return ++counteId;
    }
    public BankAccount(double balance, Type type)
    {
        //this.number = number;
        this.number = GenerateNumber();
        this.balance = balance;
        this.accountType = type;
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
        BankAccount account1 = new BankAccount( 1000.0, Type.Checking);
        account1.Print();
        Console.WriteLine();
        BankAccount account2 = new BankAccount(5000.0, Type.Savings);
        account2.Print();
    }
}