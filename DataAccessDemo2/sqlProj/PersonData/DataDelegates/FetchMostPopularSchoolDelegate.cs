using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class FetchMostPopularSchoolDelegate : DataReaderDelegate<School>
   {
      private readonly int companyName;

      public FetchMostPopularSchoolDelegate(int CompanyName)
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
            reader.GetString("Mascot"),
            reader.GetString("EstablishmentType"));
      }
   }
}
