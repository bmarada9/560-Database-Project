using System;

namespace PersonData.Models
{
   public class Person
   {
      public int PersonId { get; }
      public string FirstName { get; }
      public string LastName { get; }
      public double Gpa { get; }
      public string Email { get; }
      public string Major { get; }
      public bool Graduated { get; }
      public string PhoneNum { get; }
      public int SchoolID { get; }
      public int ExpSalary { get; }
      public string Comments { get; }

      public Person(int personId, string firstName, string lastName, double gpa, string email, string major,
       bool grad, string phoneNum, int schoolID, int salary, string comments)
      {
         PersonId = personId;
         FirstName = firstName;
         LastName = lastName;
         Gpa = gpa;
         Email = email;
         Major = major;
         Graduated = grad;
         PhoneNum = phoneNum;
         SchoolID = schoolID;
         ExpSalary = salary;
         Comments = comments;
      }

       public Person()
        {
            PersonId = 0000;
            FirstName = "";
            LastName = "";
            Gpa = 0.0;
            Email = "";
            Major = "";
            Graduated = false;
            PhoneNum = "";
            SchoolID = 0000;
            ExpSalary = 0000;
            Comments = "";
        }
   }
}
