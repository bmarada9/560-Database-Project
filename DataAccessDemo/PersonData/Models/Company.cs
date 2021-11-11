using System;

namespace PersonData.Models
{
   public class Company
   {
      public string Name { get; }
      public int CompanyID { get; }
      public int Size { get; }
      public string State { get; }
      public string Country { get; }
      public string CEOFirstName { get; }
      public string CEOLastName { get; }
      public int YearEstablished { get; }
      public int NetWorth { get; }
      public string URL { get; }

      public Company(string name, int companyId, int size, string state, string country,
       string ceoFirst, string ceoLast, int yearEstablished, int netWorth, string url)
      {
         Name = name;
         CompanyID = companyId;
         Size = size;
         State = state;
         Country = country;
         CEOFirstName = ceoFirst;
         CEOLastName = ceoLast;
         YearEstablished = yearEstablished;
         NetWorth = netWorth;
         URL = url;
      }
   }
}
