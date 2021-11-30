using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   public class FetchBestCandidateDelegate : DataReaderDelegate<Person>
   {
      private readonly string companyName;

      public FetchBestCandidateDelegate(string CompanyName)
         : base("Person.FetchPerson")
      {
         this.companyName = CompanyName;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
         p.Value = companyName;
      }

      public override Person Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            throw new RecordNotFoundException(companyName);

         return new Person(
             reader.GetInt32("PersonId"),
             reader.GetString("FirstName"),
             reader.GetString("LastName"),
             reader.GetValue<double>("GPA"),
             reader.GetString("Email"),
             reader.GetString("Major"),
             reader.Equals("Grad"),
             reader.GetString("phoneNum"),
             reader.GetInt32("schoolID"),
             reader.GetInt32("salary"),
             reader.GetString("comments"));

        }
   }
}
