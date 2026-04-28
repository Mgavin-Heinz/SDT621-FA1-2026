using SDT621_FA1_SectionB_Q1;

public class Program
{
    public static void Main(string[] args)
    {
        List<Resident> residents = new List<Resident>();
        List<ServiceRequest> serviceRequests = new List<ServiceRequest>();
        List<ServiceRequest> processedRequests = new List<ServiceRequest>();
        UtilitiesManager manager = new UtilitiesManager();

        Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");
        int residentCount = GetValidIntegerInput("How many residents do you want to register? ");

        for (int i = 0; i < residentCount; i++)
        {
            Console.WriteLine($"\n--- Resident {i + 1} ---");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Account Number: ");
            string accountNumber = Console.ReadLine();
            double monthlyUtilityUsage = GetValidDoubleInput("Monthly Utility Usage (kWh or litres): ");
            residents.Add(new Resident(name, address, accountNumber, monthlyUtilityUsage));
        }
        // Service request logging
        int requestCount = GetValidIntegerInput("\nHow many service requests do you want to log? ");

        for (int i = 0; i < requestCount; i++)
        {
            Console.WriteLine($"\nService Request {i + 1}");
            for (int j = 0; j < residents.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {residents[j].Name}");
            }
            int residentChoice = GetValidIntegerInput("Select resident by number: ", 1, residents.Count);
            Resident selectedResident = residents[residentChoice - 1];
            Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
            string requestType = Console.ReadLine();
            int priorityLevel = GetValidIntegerInput("Priority Level (1-5): ", 1, 5);
            int severityLevel = GetValidIntegerInput("Severity Level (1-10): ", 1, 10);
            double estimatedResolutionTime = GetValidDoubleInput("Estimated Resolution Hours: ");
            serviceRequests.Add(new ServiceRequest(selectedResident, requestType, priorityLevel, severityLevel, estimatedResolutionTime));

        }

        // Processing loop
        while (serviceRequests.Count > 0)
        {
            Console.WriteLine("\n==== PENDING SERVICE REQUESTS ====");
            for (int i = 0; i < serviceRequests.Count; i++)
            {
                ServiceRequest r = serviceRequests[i];
                double urgency = manager.CalculateUrgencyLevel(r);
                Console.WriteLine($"{i + 1}. {r.RequestType} - Resident: {r.Resident.Name} - Urgency Score: {urgency}");
            }

            int choice = GetValidIntegerInput("Select a request to process: ", 1, serviceRequests.Count);
            ServiceRequest selected = serviceRequests[choice - 1];

            manager.GenerateServiceReport(selected.Resident, selected);
            processedRequests.Add(selected);
            serviceRequests.Remove(selected);
        }

        // Final summary
        Console.WriteLine("\n==== FINAL MUNICIPAL SUMMARY ====");
        ServiceRequest highest = processedRequests[0];
        foreach (ServiceRequest r in processedRequests)
        {
            Console.WriteLine($"- {r.RequestType} for {r.Resident.Name} - Urgency: {manager.CalculateUrgencyLevel(r)}");
            if (manager.CalculateUrgencyLevel(r) > manager.CalculateUrgencyLevel(highest))
                highest = r;
        }

        Console.WriteLine("\n==== Highest Priority Issue ====");
        Console.WriteLine($"Resident: {highest.Resident.Name}");
        Console.WriteLine($"Service Type: {highest.RequestType}");
        Console.WriteLine($"Urgency Score: {manager.CalculateUrgencyLevel(highest)}");
        Console.WriteLine($"Adjusted Resolution: {highest.EstimatedResolutionTime} hours");
        Console.WriteLine($"Household Impact Score: {manager.CalculateUrgencyLevel(highest) * highest.EstimatedResolutionTime:F2}");

        Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
    }

    static int GetValidIntegerInput(string prompt, int min = 1, int max = int.MaxValue)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                return value;
            Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
        }
    }

    static double GetValidDoubleInput(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}