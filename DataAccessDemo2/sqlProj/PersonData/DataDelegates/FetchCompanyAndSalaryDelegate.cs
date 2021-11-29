using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class FetchCompanyAndSalaryDelegate : DataReaderDelegate<Company>
   {
      private readonly string Degree;

      public FetchCompanyAndSalaryDelegate(string Degree)
         : base("Person.FetchPerson")
      {
         this.Degree = Degree;
      }
 
        public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("Degree", SqlDbType.NVarChar);
         p.Value = Degree;
      }

      public override Company Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            throw new RecordNotFoundException(Degree);

         return new Company(
            reader.GetString("CompanyName"),
            reader.GetInt32("CompanyID"),
            reader.GetInt32("Size"),
            reader.GetString("State"), 
            reader.GetString("Country"),
            reader.GetString("CeoFirstName"),
            reader.GetString("CeoLastName"),
            reader.GetInt32("YearEstablished"),
            reader.GetInt32("NetWorth"),
            reader.GetString("JobType"));
       }
   }
}
