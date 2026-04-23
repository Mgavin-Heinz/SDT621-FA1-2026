using SDT621_FA1_SectionB_Q1;

public class Program
{

    public static void Main(string[] args)
    {
        List<Resident> residents = new List<Resident>();
        List<ServiceRequest> serviceRequests = new List<ServiceRequest>();
        UtilitiesManager manager = new UtilitiesManager();

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
            double monthlyUtilityUsage = GetValidDoubleInput("Monthly Utility Usage (kWh): ");
            Resident resident = new Resident(name, address, accountNumber, monthlyUtilityUsage);
            residents.Add(resident);

        }

        int requestCount = GetValidIntegerInput("How many service requests do you want to add? ");

        for (int i = 0; i < requestCount; i++)
        {
            Console.WriteLine($"Enter details for Service Request {i + 1}:");

            for (int j = 0; j < residents.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {residents[j].Name} - {residents[j].Address}");
            }

            int residentChoice = GetValidIntegerInput("Select resident by number: ", 1, residentCount);
            Resident selectedResident = residents[residentChoice - 1];

            Console.WriteLine("Enter request type(Water outage, Burst Pipe, etc): ");
            string requestType = Console.ReadLine();
            int priorityLevel = GetValidIntegerInput("Enter priority level(1-5): ", 1, 5);
            int severityLevel = GetValidIntegerInput("SeverityLevel(1-10): ", 1, 10);
            double estimatedResolutionTime = GetValidDoubleInput("EstimatedResolutionTime: ");
            Console.WriteLine();

            ServiceRequest serviceRequest = new ServiceRequest(selectedResident, requestType, priorityLevel, severityLevel, estimatedResolutionTime);
            serviceRequests.Add(serviceRequest);

        }

        Console.WriteLine("Pending service requests:");
        for (int i = 0; i < serviceRequests.Count; i++)
        {
            ServiceRequest request = serviceRequests[i];
            double urgencyScore = manager.CalculateUrgencyLevel(request);
            Console.WriteLine($"{i + 1}. {request.RequestType} for {request.Resident.Name} - Priority: {request.PriorityLevel}, Severity: {request.SeverityLevel}, Urgency Score: {urgencyScore}, Estimated Resolution Time: {request.EstimatedResolutionTime} hours");
        }
        Console.WriteLine();



    }

    static int GetValidIntegerInput(string prompt, int min = 1, int max = int.MaxValue)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
            {
                return value;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static double GetValidDoubleInput(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
