using PersonData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System;

namespace PersonData.DataDelegates
{
    public class CreateJobDelegate : NonQueryDataDelegate<Job>
    {

        public readonly string name;
        private readonly int minSalary;
        public readonly int companyId;
        public readonly int jobId;
        private readonly string major;
        public readonly string supervisorLastName;
        public readonly string jobType;
        private readonly string appDueDate;
        public readonly int maxSalary;

        public CreateJobDelegate(string name, int minSalary, int companyId, int jobId, string major,
            string supervisorLastName, string jobType, int maxSalary, string appDueDate)

           : base("Person.CreateJob")
        {
            this.name = name;
            this.minSalary = minSalary;
            this.companyId = companyId;
            this.jobId = jobId; 
            this.major = major;
            this.supervisorLastName = supervisorLastName;
            this.jobType = jobType;
            this.appDueDate = appDueDate;
            this.maxSalary = maxSalary;
        }

    public override void PrepareCommand(SqlCommand command)
    {
        base.PrepareCommand(command);

        var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
        p.Value = "firstName";

        p = command.Parameters.Add("MinimumSalary", SqlDbType.Int);
        p.Value = "lastName";

        p = command.Parameters.Add("CompanyID", SqlDbType.Int);
        p.Value = "email";

        p = command.Parameters.Add("JobID", SqlDbType.Int);
        p.Direction = ParameterDirection.Output;

        p = command.Parameters.Add("GPA", SqlDbType.Decimal);
        p.Direction = ParameterDirection.Output;

        p = command.Parameters.Add("SupervisorLastName", SqlDbType.NVarChar);
        p.Direction = ParameterDirection.Output;

        p = command.Parameters.Add("JobType", SqlDbType.NVarChar);
        p.Direction = ParameterDirection.Output;

        p = command.Parameters.Add("MaxSalary", SqlDbType.Int);
        p.Direction = ParameterDirection.Output;
            p = command.Parameters.Add("ApplicationDueDate", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;

        }

    public override Job Translate(SqlCommand command)
    {
        return new Job(name, minSalary,companyId, jobId, major,supervisorLastName,jobType, maxSalary,appDueDate);
    }
}
}
