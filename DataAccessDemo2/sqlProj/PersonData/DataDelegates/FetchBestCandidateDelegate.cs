using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class FetchBestCandidateDelegate : DataReaderDelegate<Person>
   {
      private readonly int companyName;

      public FetchBestCandidateDelegate(int CompanyName)
         : base("Person.FetchPerson")
      {
         this.Name = CompanyName;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("Degree", SqlDbType.NVARCHAR);
         p.Value = Degree;
      }

      public override Person Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            throw new RecordNotFoundException(companyName);

         return new Person(
            reader.GetString("Name"),
            reader.GetString("FirstName"),
            reader.GetString("LastName"),
            reader.GetString("Major"),
            reader.GetString("GPA"));

      }
   }
}
