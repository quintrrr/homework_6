namespace labs.Classes;

public class BankAccount2
{
    private static int nextAccountNumber = 1;
    private int accountNumber;
    private decimal balance;
    private AccountType accountType;
    public int AccountNumber { get => accountNumber; private set => accountNumber = value; }
    public decimal Balance { get => balance; set => balance = value; }
    public AccountType AccountType { get => accountType; set => accountType = value; }

    public BankAccount2(decimal balance, AccountType accountType)
    {
        AccountNumber = nextAccountNumber++;
        Balance = balance;
        AccountType = accountType;
    }
    
    public BankAccount2()
    {
        AccountNumber = nextAccountNumber++;
        Balance = default;
        AccountType = default;
    }

    public override string ToString()
    {
        return $"Номер счета: {AccountNumber}, Баланс: {Balance}, Тип счета: {AccountType}";
    }
}