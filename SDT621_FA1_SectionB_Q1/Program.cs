using SDT621_FA1_SectionB_Q1;

public class Program
{
    
    public static void Main(string[] args)
    {
        List<Resident> residents = new List<Resident>();
        List<ServiceRequest> serviceRequests = new List<ServiceRequest>();

        Console.WriteLine("=== Welcome to Emfuleni Municipality Service Management System ===");
        int residentCount = GetValidIntegerInput("How many residents do you want to add? ");
        for (int i = 0; i < residentCount; i++)
        {
            Console.WriteLine($"Enter details for Resident {i + 1}:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Account Number: ");
            string accountNumber = Console.ReadLine();
            Console.Write("Monthly Utility Usage (kWh): ");
            double monthlyUtilityUsage = double.Parse(Console.ReadLine());
            Resident resident = new Resident(name, address, accountNumber, monthlyUtilityUsage);
            residents.Add(resident);

        }
    }

    static int GetValidIntegerInput(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
