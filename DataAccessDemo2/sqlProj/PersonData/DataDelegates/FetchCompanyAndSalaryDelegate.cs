using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class FetchCompanyAndSalaryDelegate : DataReaderDelegate<Company>
   {
      private readonly int Degree;

      public FetchPersonDataDelegate(int Degree)
         : base("Person.FetchPerson")
      {
         this.degree = Degree;
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
            throw new RecordNotFoundException(Degree);

         return new Person(
            reader.GetString("CompanyName"),
            reader.GetString("AverageSalary"),
            reader.GetString("JobType"));
      }
   }
}
