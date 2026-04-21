public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====");
        Console.WriteLine();
        Console.WriteLine("HI , WHAT IS YOUR NAME?");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"WELCOME {name}!");
        double balance = GetPositiveDouble("Enter account balance: ");
        double amountToWithdraw = GetPositiveDouble("Enter withdrawal amount: ");
        Console.WriteLine();
        while (amountToWithdraw > balance)
        {
            Console.WriteLine("Insufficient funds. Please enter a smaller amount.");
            amountToWithdraw = GetPositiveDouble("Enter withdrawal amount: ");
        }
        balance -= amountToWithdraw;
        Console.WriteLine();
        Console.WriteLine("Withdrawal successful!");
        Console.WriteLine($"Updated Balance: {balance:F2}");
        Console.WriteLine($"Transaction Time: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
    }
    public static double GetPositiveDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value) && value >= 0)
                return value;
            else
                Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}