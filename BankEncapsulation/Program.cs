using System.Security.Principal;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount userAccount = new BankAccount();

            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Check balance");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter deposit amount: ");
                    if (double.TryParse(Console.ReadLine(), out double amount))
                    {
                        userAccount.Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "2":
                    Console.WriteLine($"Current balance is {userAccount.GetBalance():C}.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    break;
            }
        }
    }
}
