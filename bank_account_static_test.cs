BankAccount acc1 = new();
//acc1.Accountbalance = 50000000; // not allowed
Console.WriteLine($"{acc1.AccountBalance} is your balance");
acc1.DepositMoney(4501);
acc1.WithdrawMoney(5000);
Console.WriteLine($"{acc1.AccountBalance} is your balance");
string accountWord = BankAccount.DisplayTotalAccounts() == 1 ? "account" : "accounts";
Console.WriteLine($"There are {BankAccount.DisplayTotalAccounts()} {accountWord} created ");

//BankAccount.TotalAccountsCreated = 5;

public class BankAccount
{
    //private static int _totalAccountsCreated;
    //private int _accountBalance;

    public int AccountBalance
    {
        get;
        private set;
    }
    public static int TotalAccountsCreated { get; private set; }

    public BankAccount()
    {
        TotalAccountsCreated++;
    }
    public void DepositMoney(int depositAmount)
    {
        AccountBalance += depositAmount;
    }
    public void WithdrawMoney(int withdrawAmount)
    {
        if (AccountBalance < withdrawAmount)
        {
            Console.WriteLine("Insufficient funds");
            return;
        }
        AccountBalance -= withdrawAmount;
    }
    public static int DisplayTotalAccounts()
    {
        return TotalAccountsCreated;
    }
}

// total number of accounts is shared info about the whole class
// it belongs to the bank system, not any single account
