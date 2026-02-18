using System;
using System.Collections.Generic;
using System.Linq;

class NegativeBalanceException : Exception
{
    public NegativeBalanceException(string message) : base(message) { }
}
class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}
class AccountNotFoundException : Exception
{
    public AccountNotFoundException(string message) : base(message) { }
}

class Account
{
    public string? AccountNumber { get; set; }
    public string? HolderName { get; set; }
    public double Balance { get; set; }
    public Account(string AccountNumber, string HolderName, double Balance)
    {
        this.AccountNumber = AccountNumber;
        this.HolderName = HolderName;
        this.Balance = Balance;
    }
}
class Program
{
    public static SortedDictionary<double, List<Account>> Accounts = new SortedDictionary<double, List<Account>>();
    public static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            try
            {
                Console.WriteLine("\n--- Bank Account Management System ---");
                Console.WriteLine("1 → Display Accounts");
                Console.WriteLine("2 → Deposit");
                Console.WriteLine("3 → Withdraw");
                Console.WriteLine("4 → Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        DisplayAccounts();
                        break;

                    case "2":
                        Deposit();
                        break;

                    case "3":
                        Withdraw();
                        break;

                    case "4":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }
        }
    }
    static void DisplayAccounts()
    {
        if(Accounts.Count == 0)
        {
            Console.WriteLine("No Account Available!");
            return;
        }
        Console.WriteLine("\n---------------Account Details According To Balance(Low To High)----------------\n");
        // var result = Accounts.SelectMany(a => a);
        foreach(var group in Accounts)
        {
            Console.WriteLine($"\n\nAccounts with Balance {group.Key}\n");
            foreach(var acc in group.Value)
            {
                Console.WriteLine($"Account Number: {acc.AccountNumber} | Holer Name: {acc.HolderName} | Balance: {acc.Balance}");
            }
            Console.WriteLine("__________________________________");
        }
    }

    static void Deposit()
{
    Console.WriteLine("Enter AccountNumber HolderName Amount:");
    string[] input = (Console.ReadLine() ?? "").Split(" ");

    string accNo = input[0];
    string holder = input[1];
    double amount = Convert.ToDouble(input[2]);

    if (amount <= 0)
        throw new NegativeBalanceException("Deposit amount must be positive.");

    Account? account = null;
    double oldBalance = 0;

    foreach (var group in Accounts)
    {
        account = group.Value.FirstOrDefault(a => a.AccountNumber == accNo);
        if (account != null)
        {
            oldBalance = group.Key;
            break;
        }
    }

    if (account != null)
    {
        Accounts[oldBalance].Remove(account);
        if (Accounts[oldBalance].Count == 0)
            Accounts.Remove(oldBalance);

        account.Balance += amount;

        if (!Accounts.ContainsKey(account.Balance))
            Accounts[account.Balance] = new List<Account>();

        Accounts[account.Balance].Add(account);

        Console.WriteLine("Amount deposited successfully!");
    }
    else
    {
        Account newAccount = new Account(accNo, holder, amount);

        if (!Accounts.ContainsKey(amount))
            Accounts[amount] = new List<Account>();

        Accounts[amount].Add(newAccount);

        Console.WriteLine("Account created and amount deposited!");
    }
}


    static void Withdraw()
{
    Console.WriteLine("Enter Account Number and Amount to Withdraw:");
    string[] input = (Console.ReadLine() ?? "").Split(" ");

    string accNo = input[0];
    double amount = Convert.ToDouble(input[1]);

    Account? account = null;
    double oldBalance = 0;

    // Find account
    foreach (var group in Accounts)
    {
        account = group.Value.FirstOrDefault(a => a.AccountNumber == accNo);
        if (account != null)
        {
            oldBalance = group.Key;
            break;
        }
    }

    if (account == null)
        throw new AccountNotFoundException("Account not found.");

    if (amount > account.Balance)
        throw new InsufficientFundsException("Insufficient funds.");

    if (account.Balance - amount < 0)
        throw new NegativeBalanceException("Balance cannot be negative.");

    Accounts[oldBalance].Remove(account);
    if (Accounts[oldBalance].Count == 0)
        Accounts.Remove(oldBalance);

    account.Balance -= amount;

    if (!Accounts.ContainsKey(account.Balance))
        Accounts[account.Balance] = new List<Account>();

    Accounts[account.Balance].Add(account);

    Console.WriteLine("Amount withdrawn successfully!");
}

}
