using PersonData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
    internal class CreateJobDelegate : NonQueryDataDelegate<Job>
    {
        public readonly string name;
        private readonly int minSalary;
        public readonly int companyId;
        public readonly int jobId;
        private readonly double gpa;
        public readonly string supervisorLastName;
        public readonly string jobType;
        private readonly DateTime appDueDate;
        public readonly int maxSalary;

        public CreatePersonDataDelegate(string name, int minSalary, int companyId, int jobId, double gpa,
            string supervisorLastName, string jobType, DateTime appDueDate, int maxSalary;)

           : base("Person.CreatePerson")
        {
            this.name = name;
            this.minSalary = minSalary;
            this.companyId = companyId;
            this.jobId = jobId; 
            this.gpa = gpa;
            this.supervisorLastName = supervisorLastName;
            this.jobType = jobType;
            this.appDueDate = appDueDate;
            this.maxSalary = maxSalary;
        }

    public override void PrepareCommand(SqlCommand command)
    {
        base.PrepareCommand(command);

        var p = command.Parameters.Add("Name", SqlDbType.NVarChar);
        p.Value = firstName;

        p = command.Parameters.Add("MinimumSalary", SqlDbType.INT);
        p.Value = lastName;

        p = command.Parameters.Add("CompanyID", SqlDbType.INT);
        p.Value = email;

        p = command.Parameters.Add("JobID", SqlDbType.Int);
        p.Direction = ParameterDirection.Output;

        p = command.Parameters.Add("GPA", SqlDbType.NUMERIC(3,2));
        p.Direction = ParameterDirection.Output;

        p = command.Parameters.Add("SupervisorLastName", SqlDbType.NVarChar);
        p.Direction = ParameterDirection.Output;

        p = command.Parameters.Add("JobType", SqlDbType.NVarChar);
        p.Direction = ParameterDirection.Output;

        p = command.Parameters.Add("AppDueDate", SqlDbType.DATETIMEOFFSET);
        p.Direction = ParameterDirection.Output;

        p = command.Parameters.Add("MaxSalary", SqlDbType.Int);
        p.Direction = ParameterDirection.Output;

    }

    public override Person Translate(SqlCommand command)
    {
        return new Person(name, minSalary(int)command.Parameters["CompanyId"].Value, jobId, gpa, supervisorLastName, jobType, appDueDate, maxSalary);
    }
}
}
