using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   public class NumberOfJobsDelegate : DataReaderDelegate<Job>
   {
      private readonly string CompName;

      public NumberOfJobsDelegate(string CompName)
         : base("Person.GetNumJobs")
      {
         this.CompName = CompName;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
         p.Value = CompName;
      }

       public override Job Translate(SqlCommand command, IDataRowReader reader)
      {
          if (!reader.Read())
            throw new RecordNotFoundException(CompName);

         return new Job(
             reader.GetString("Name"),
             reader.GetInt32("MinimumSalary"),
             reader.GetInt32("CompanyID"),
             reader.GetInt32("JobID"),
             reader.GetString("MajorAccepted"),
             reader.GetString("SupervisorLastName"),
             reader.GetString("JobType"));

        }
    }
}