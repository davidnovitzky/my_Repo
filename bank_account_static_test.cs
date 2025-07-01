BankAccount acc1 = new();

Console.WriteLine($"{acc1.AccountBalance} is your balance");

acc1.DepositMoney(4501);
acc1.WithdrawMoney(5000);

Console.WriteLine($"{acc1.AccountBalance} is your balance");

string accountWord = BankAccount.TotalAccountsCreated == 1 ? "account" : "accounts";
Console.WriteLine($"There are {BankAccount.TotalAccountsCreated} {accountWord} created ");

acc1.AccountBalance = 5000000; // not allowed since the setter is private
acc1.WithdrawMoney(500000000); // is allowed but the method checks if sufficient funds
BankAccount.TotalAccountsCreated = 6; // not allowed to change this since its private


public class BankAccount
{
    //private static int _totalAccountsCreated; // fields not needed
    //private int _accountBalance; // not needed

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
    public bool WithdrawMoney(int withdrawAmount)
    {
        if (AccountBalance < withdrawAmount)
        {
            Console.WriteLine("Insufficient funds");
            return false;
        }
        AccountBalance -= withdrawAmount;
        return true;
    }
}

// total number of accounts is shared info about the whole class
// it belongs to the bank system, not any single account
// so it has to be static
