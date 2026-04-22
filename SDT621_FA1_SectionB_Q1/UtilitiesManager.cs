using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDT621_FA1_SectionB_Q1
{
    public class UtilitiesManager
    {
        public double CalculateUrgencyLevel(ServiceRequest serviceRequest)
        {
            double urgencyLevel = 0;

            urgencyLevel = serviceRequest.PriorityLevel * serviceRequest.SeverityLevel;
            return urgencyLevel;
        }

        public void GenerateServiceReport(Resident resident, ServiceRequest serviceRequests)
        {
            Console.WriteLine("=== Service Report ===");
            Console.WriteLine("Resident: " + resident.Name);
            Console.WriteLine("Service Type: " + serviceRequests.RequestType);
            double urgencyLevel = CalculateUrgencyLevel(serviceRequests);
            Console.WriteLine("Urgency Score: " + urgencyLevel);
            Console.WriteLine("Estimated Resolution Time: " + serviceRequests.EstimatedResolutionTime + " hours");
            double houseImpact = urgencyLevel * serviceRequests.EstimatedResolutionTime;
            Console.WriteLine($"House Impact Score: {houseImpact:F2}" );
        }
    }
}
