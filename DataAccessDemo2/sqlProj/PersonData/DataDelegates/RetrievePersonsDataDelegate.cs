using DataAccess;
using PersonData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   public class RetrievePersonsDataDelegate : DataReaderDelegate<IReadOnlyList<Person>>
   {
      public RetrievePersonsDataDelegate()
         : base("Person.RetrievePersons")
      {
      }

      public override IReadOnlyList<Person> Translate(SqlCommand command, IDataRowReader reader)
      {
         var persons = new List<Person>();

         while (reader.Read())
         {
                persons.Add(new Person(
                   reader.GetInt32("PersonId"),
                   reader.GetString("FirstName"),
                   reader.GetString("LastName"),
                   reader.GetValue<double>("gpa"),
                   reader.GetString("Email"),
                   reader.GetString("Major"),
                   reader.Equals("Grad"),
                   reader.GetString("phoneNum"),
                   reader.GetInt32("schoolID"),
                   reader.GetInt32("salary"),
                   reader.GetString("Comments")));
         }

         return persons;
      }
   }
}