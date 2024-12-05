using System;
using labs.Classes;

public class Program
{
    public static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }

    static void Task1()
    {
        // Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
        // банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
        // доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
        // вывести информацию об объекте класса на печать.
        Console.WriteLine("Упражнение 7.1");
        BankAccount1 account1 = new BankAccount1(6, 4000, AccountType.Current);
        BankAccount1 account2 = new BankAccount1(17, 180000, AccountType.Savings);
        BankAccount1 account3 = new BankAccount1();
        account3.AccountNumber = 12;
        account3.Balance = 8642;
        account3.AccountType = AccountType.Current;
        Console.WriteLine(account1);
        Console.WriteLine(account2);
        Console.WriteLine(account3);
    }

    static void Task2()
    {
        // Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
        // номер счета генерировался сам и был уникальным. Для этого надо создать в классе
        // статическую переменную и метод, который увеличивает значение этого переменной.
        Console.WriteLine("Упражнение 7.2");
        BankAccount2 account1 = new BankAccount2(4000, AccountType.Current);
        BankAccount2 account2 = new BankAccount2(180000, AccountType.Savings);
        BankAccount2 account3 = new BankAccount2();
        account3.Balance = 8642;
        account3.AccountType = AccountType.Current;
        Console.WriteLine(account1);
        Console.WriteLine(account2);
        Console.WriteLine(account3);
    }

    static void Task3()
    {
        // Добавить в класс счет в банке два метода: снять со счета и положить на
        // счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
        // положительного результата изменяет баланс.
        Console.WriteLine("Упражнение 7.3");
        BankAccount3 account3 = new BankAccount3(111111, AccountType.Current);
        account3.Withdraw(100000);
        Console.WriteLine(account3);
        account3.Deposit(300);
        Console.WriteLine(account3);
        account3.Withdraw(20000);
    }

    static void Task4()
    {
        try
        {
            Building[] buildings =
            {
                new(10, 3, 120, 4),
                new(23, 4, 96, 2),
                new(45, 20, 240, 2)
            };

            foreach (Building building in buildings)
            {
                Console.WriteLine(building.ToString());
                building.FloorHeight();
                building.ApartmentsPerEntrance();
                building.AparartmentsPerFloor();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}