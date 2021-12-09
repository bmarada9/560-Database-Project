using System;

namespace PersonData.Models
{
   public class Job
   {
      public string Name { get; }
      public int MinimumSalary { get; }
      public int CompanyID { get; }
      public int JobID { get; }
      public string MajorAccepted { get; }
      public string SupervisorLastName { get; }
      public string JobType { get; }
        public int MaximumSalary { get; }


      public Job(string name, int minSalary, int companyId, int jobId, string majorAccpeted,
       string supervisorName, string type, int maxsalary)
      {
         Name = name;
         MinimumSalary = minSalary;
         CompanyID = companyId;
         JobID = jobId;
         MajorAccepted = majorAccpeted;
         SupervisorLastName = supervisorName;
         JobType = type;
            MaximumSalary = maxsalary;
      }
   }
}
