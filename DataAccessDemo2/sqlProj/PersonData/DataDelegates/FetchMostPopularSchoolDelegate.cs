using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   public class FetchMostPopularSchoolDelegate : DataReaderDelegate<School>
   {
      private readonly string companyName;

      public FetchMostPopularSchoolDelegate(string companyName)
         : base("Person.FetchPerson")
      {
         this.companyName = companyName;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("Degree", SqlDbType.NVarChar);
         p.Value = companyName;
      }

      public override School Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            throw new RecordNotFoundException(companyName);

         return new School(
            reader.GetString("Name"),
            reader.GetInt32("SchoolID"),
            reader.GetInt32("Size"),
            reader.GetString("City"),
            reader.GetString("State"),
            reader.GetInt32("GraduateRate"),
            reader.GetString("Mascot"),
            reader.GetString("TypeOfSchool"),
            reader.GetInt32("YearlyAvgTuitionInState"),
            reader.GetInt32("YearlyAvgTuitionOutState"));
      }
   }
}
