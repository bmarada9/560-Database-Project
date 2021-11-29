using System;

namespace PersonData.Models
{
   public class School
   {
      public string Name { get; }
      public int SchoolID { get; }
      public int Size { get; }
      public string City { get; }
      public string State { get; }
      public int GraduateRate { get; }
      public string Mascot { get; }
      public string TypeOfSchool { get; }
      public int YearlyAvgTuitionInState { get; }
      public int YearlyAvgTuitionOutState { get; }

      public School(string name, int schoolId, int size, string city, string state,
       int gradRate, string mascot, string type, int tuitionIn, int tuitionOut)
      {
         Name = name;
         SchoolID = schoolId;
         Size = size;
         City = city;
         State = state;
         GraduateRate = gradRate;
         Mascot = mascot;
         TypeOfSchool = type;
         YearlyAvgTuitionInState = tuitionIn;
         YearlyAvgTuitionOutState = tuitionOut;
      }
   }
}
