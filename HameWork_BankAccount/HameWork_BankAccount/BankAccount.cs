using System;

class BankAccount
{
    private int balance;

    public void Deposit(double amount)
    {
        balance += (int)amount;
        Console.WriteLine("The amount has been deposited into your account.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= (int)amount;
        }
        else
        {
            Console.WriteLine(".موجودی کافی نیست");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Your balance is {balance}.");
    }
}
