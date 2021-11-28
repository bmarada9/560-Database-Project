﻿using System;

namespace PersonData.Models
{
   public class Person
   {
      public int PersonId { get; }
      public string FirstName { get; }
      public string LastName { get; }
      public string Email { get; }
      public string Major { get; }
      public bool Graduated { get; }
      public int PhoneNum { get; }
      public int SchoolID { get; }
      public int ExpSalary { get; }
      public string Comments { get; }

      public Person(int personId, string firstName, string lastName, string email, string major,
       bool grad, int phoneNum, int schoolID, int salary, string comments)
      {
         PersonId = personId;
         FirstName = firstName;
         LastName = lastName;
         Email = email;
         Major = major;
         Graduated = grad;
         PhoneNum = phoneNum;
         SchoolID = schoolID;
         ExpSalary = salary;
         Comments = comments;
      }
   }
}