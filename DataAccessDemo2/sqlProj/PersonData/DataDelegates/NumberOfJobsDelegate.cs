using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class NumberOfJobsDelegate : DataReaderDelegate<Job>
   {
      private readonly string CompName;

      public NumberOfJobsDelegate(int personId)
         : base("Person.GetNumJobs")
      {
         this.Name = CompName;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("Name", SqlDbType.NVARCHAR);
         p.Value = CompName;
      }

       public override Job Translate(SqlCommand command, IDataRowReader reader)
      {
          if (!reader.Read())
            throw new RecordNotFoundException(personId.ToString());

         return new Person(
             reader.GetString("Name"),
             CompName,
             reader.GetString("CompanyID"));
         ;
      }
   }
}