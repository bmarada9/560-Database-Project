using PersonData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
    internal class CreatePersonDataDelegate : NonQueryDataDelegate<Person>
    {
        public readonly int personId;
        public readonly string firstName;
        private readonly string lastName;
        public readonly double gpa;
        public readonly string email;
        private readonly string major;
        public readonly bool graduate;
        public readonly int phoneNum;
        private readonly int schoolId;
        public readonly int salary;
        public readonly string comments;

        public CreatePersonDataDelegate(int personId, string firstName, string lastName, double gpa, string email, 
            string major, bool graduate, int phoneNum, int schoolId, int salary, string comments)

           : base("Person.CreatePerson")
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gpa = gpa; 
            this.email = email;
            this.major = major;
            this.graduate = graduate;
            this.phoneNum = phoneNum;
            this.schoolId = schoolId;
            this.salary = salary;
            this.comments = comments;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("FirstName", SqlDbType.NVarChar);
            p.Value = firstName;

            p = command.Parameters.Add("LastName", SqlDbType.NVarChar);
            p.Value = lastName;

            p = command.Parameters.Add("Email", SqlDbType.NVarChar);
            p.Value = email;

            p = command.Parameters.Add("PersonID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("GPA", SqlDbType.Decimal);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("Major", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("Graduated", SqlDbType.Bit);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("PhoneNumber", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("SchoolID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("ExpectedSalary", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("Comments", SqlDbType.NVarChar);
            p.Direction = ParameterDirection.Output;


    }

    public override Person Translate(SqlCommand command)
        {
            return new Person((int)command.Parameters["PersonId"].Value, firstName, lastName, gpa, email, major, 
                graduate, phoneNum.ToString(), schoolId, salary, comments);
        }
    }
}
