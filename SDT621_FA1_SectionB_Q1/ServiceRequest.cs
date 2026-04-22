using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDT621_FA1_SectionB_Q1
{
    public class ServiceRequest
    {
        public Resident Resident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public double EstimatedResolutionTime { get; set; }

        public ServiceRequest(Resident resident, string requestType, int priorityLevel, int severityLevel, double estimatedResolutionTime)
        {
            Resident = resident;
            RequestType = requestType;
            PriorityLevel = priorityLevel;
            SeverityLevel = severityLevel;
            EstimatedResolutionTime = estimatedResolutionTime;
        }
    }
}
