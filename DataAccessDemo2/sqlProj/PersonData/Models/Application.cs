using System;

namespace PersonData.Models
{
   public class Application
   {
      public int AppID { get; }
      public int JobID { get; }
      public int PersonID { get; }
      public DateTime DateApply { get; }
      public DateTime AppDueDate { get; }
      public int GPA { get; }
      public string Major { get; }
      public bool Graduated { get; }

      public Application(int appId, int jobId, int personId, DateTime date, DateTime dueDate,
       int gpa, string major, bool graduated)
      {
         AppID = appId;
         JobID = jobId;
         PersonID = personId;
         DateApply = date;
         AppDueDate = dueDate;
         GPA = gpa;
         Major = major;
         Graduated = graduated;
      }
   }
}
