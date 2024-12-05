namespace labs.Classes;

public class BankAccount1
{
    private int accountNumber;
    private decimal balance;
    private AccountType accountType;

    public int AccountNumber { get => accountNumber; set => accountNumber = value; }
    public decimal Balance { get => balance; set => balance = value; }
    public AccountType AccountType { get => accountType; set => accountType = value; }

    public BankAccount1(int accountNumber, decimal balance, AccountType accountType)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        AccountType = accountType;
    }
    
    public BankAccount1()
    {
        AccountNumber = default;
        Balance = default;
        AccountType = default;
    }

    public override string ToString()
    {
        return $"Номер счета: {AccountNumber}, Баланс: {Balance}, Тип счета: {AccountType}";
    }
}