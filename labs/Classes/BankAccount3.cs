namespace labs.Classes;

public class BankAccount3
{
    private static int nextAccountNumber = 1;
    private int accountNumber;
    private decimal balance;
    private AccountType accountType;
    public int AccountNumber { get => accountNumber; private set => accountNumber = value; }
    public decimal Balance { get => balance; set => balance = value; }
    public AccountType AccountType { get => accountType; set => accountType = value; }

    public BankAccount3(decimal balance, AccountType accountType)
    {
        AccountNumber = nextAccountNumber++;
        Balance = balance;
        AccountType = accountType;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("На счете недостаточно средств");
            return;
        }
    
        Balance -= amount;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public override string ToString()
    {
        return $"Номер счета: {AccountNumber}, Баланс: {Balance}, Тип счета: {AccountType}";
    }
}