using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonData;
using System.IO;

namespace FindAJob
{

    public partial class Form1 : Form
    {
        public static bool created = false;
        public static PersonData.Models.Person mainPerson;
        public static displayPage display;

        public static List<PersonData.Models.Job> jobsList;
        public static List<PersonData.Models.Person> personList;
        public static List<PersonData.Models.Company> companyList;
        public static List<PersonData.Models.School> schoolList;

        //table of jobs
        //table of people
        public Form1()
        {
            InitializeComponent();

            var jreader = new StreamReader(File.OpenRead(@"CIS 560 Project Tables - Job.csv"));
            var preader = new StreamReader(File.OpenRead(@"CIS 560 Project Tables - Person.csv"));
            var creader = new StreamReader(File.OpenRead(@"CIS 560 Project Tables - Company.csv"));
            var sreader = new StreamReader(File.OpenRead(@"CIS 560 Project Tables - School.csv"));

            jobsList = new List<PersonData.Models.Job>();
            personList = new List<PersonData.Models.Person>();
            companyList = new List<PersonData.Models.Company>();
            schoolList = new List<PersonData.Models.School>();

            var line = jreader.ReadLine();
            var line2 = preader.ReadLine();
            var line3 = creader.ReadLine();
            var line4 = sreader.ReadLine();

            Random rd = new Random();

            while (!jreader.EndOfStream || !preader.EndOfStream || !creader.EndOfStream || !sreader.EndOfStream)
            {
                var jline = jreader.ReadLine();
                var jvalues = jline.Split(',');

                var pline = preader.ReadLine();
                var pvalues = pline.Split(',');

                var cline = creader.ReadLine();
                var cvalues = cline.Split(',');

                var sline = sreader.ReadLine();
                var svalues = sline.Split(',');

                int num = rd.Next(0, 19);
                string majorAccepted = objects.majors[num];

                PersonData.Models.Job job = new PersonData.Models.Job(jvalues[0], Int32.Parse(jvalues[1]), Int32.Parse(jvalues[2]), Int32.Parse(jvalues[3]), majorAccepted, jvalues[5], jvalues[6], Int32.Parse(jvalues[8]), jvalues[7]);
                jobsList.Add(job);

                bool grad;
                if (Int32.Parse(pvalues[5]) == 0)
                {
                    grad = false;
                }
                else
                {
                    grad = true;
                }

                PersonData.Models.Person person = new PersonData.Models.Person(Int32.Parse(pvalues[0]), pvalues[1], pvalues[2], Double.Parse(pvalues[3]), pvalues[4], pvalues[5], grad, pvalues[7], Int32.Parse(pvalues[8]), Int32.Parse(pvalues[9]), pvalues[10]);
                personList.Add(person);

                PersonData.Models.Company company = new PersonData.Models.Company(cvalues[0], Int32.Parse(cvalues[1]), Int32.Parse(cvalues[2]), cvalues[3], cvalues[4], cvalues[5], cvalues[6], Int32.Parse(cvalues[7]), Int32.Parse(cvalues[8]), cvalues[9]);
                companyList.Add(company);

                PersonData.Models.School school = new PersonData.Models.School(svalues[0], Int32.Parse(svalues[1]), Int32.Parse(svalues[2]), svalues[3], svalues[4], Int32.Parse(svalues[5]), svalues[6], svalues[7], Int32.Parse(svalues[8]), Int32.Parse(svalues[9]));
                schoolList.Add(school);

            }

            Console.WriteLine(personList.Count);
            Console.WriteLine(jobsList.Count);
            Console.WriteLine(companyList.Count);
            Console.WriteLine(schoolList.Count);
            Console.WriteLine(jobsList[9].Name);
            Console.WriteLine(personList[9].FirstName);
            Console.WriteLine(companyList[9].Name);
            Console.WriteLine(schoolList[9].Name);



        }

        private void createProfile_Click(object sender, EventArgs e)
        {
            createProfile cp = new createProfile();
            cp.Show();
        }

        private void addJob_Click(object sender, EventArgs e)
        {
            addJob aj = new addJob();
            aj.Show();

        }


        private void currentJobsButton_Click(object sender, EventArgs e)
        {
            display = new displayPage();
            display.Show();
        }

        public static void createPerson(PersonData.Models.Person p)
        {
            created = true;
            mainPerson = p;
            PersonData.DataDelegates.CreatePersonDelegate per = new PersonData.DataDelegates.CreatePersonDelegate(p.PersonId, p.FirstName, p.LastName, p.Gpa, p.Email, p.Major, p.Graduated, p.PhoneNum, p.SchoolID, p.ExpSalary, p.Comments);
            //add person to table
            personList.Add(p);
        }

        public static void createJob(PersonData.Models.Job j)
        {
            PersonData.DataDelegates.CreateJobDelegate jo = new PersonData.DataDelegates.CreateJobDelegate(j.Name, j.MinimumSalary, j.CompanyID, j.JobID, j.MajorAccepted, j.SupervisorLastName, j.JobType, j.MaximumSalary, j.ApplicationDueDate);
            //add job to table
            jobsList.Add(j);
        }

        public static void reportQuery(int tab, string filter)
        {
            int compId = findCompanyId(filter);
            //filter - the company name or the major
            switch (tab)
            {
                case 1:
                    //By Company aka NumberofJobs
                    PersonData.DataDelegates.NumberOfJobsDelegate nj = new PersonData.DataDelegates.NumberOfJobsDelegate(filter);

                    List<PersonData.Models.Job> j = new List<PersonData.Models.Job>();
                    for (int i = 0; i < jobsList.Count; i++)
                    {
                        if (jobsList[i].CompanyID == compId)
                        {
                            j.Add(jobsList[i]);
                        }
                    }
                    display.companyDisplay(j);
                    break;
                case 2:
                    //Popular Schools
                    PersonData.DataDelegates.FetchMostPopularSchoolDelegate fm = new PersonData.DataDelegates.FetchMostPopularSchoolDelegate(filter);
                    List<PersonData.Models.School> schools = new List<PersonData.Models.School>();
                    for (int i = 0; i < schoolList.Count; i++)
                    {
                        if (schoolList[i].SchoolID < compId/6)
                        {
                            schools.Add(schoolList[i]);
                        }
                    }
                    display.schoolDisplay(schools);
                    break;
                case 3:
                    //Best Candidates aka Candidates
                    PersonData.DataDelegates.FetchBestCandidateDelegate fb = new PersonData.DataDelegates.FetchBestCandidateDelegate(filter);
                    List<PersonData.Models.Person> candidates = new List<PersonData.Models.Person>();
                    List<PersonData.Models.Job> jobs = new List<PersonData.Models.Job>();

                    break;
                case 4:
                    //Best Salaries aka ListofJobs
                    PersonData.DataDelegates.FetchCompanyAndSalaryDelegate fc = new PersonData.DataDelegates.FetchCompanyAndSalaryDelegate(filter);
                    List<PersonData.Models.Job> jj = new List<PersonData.Models.Job>();
                    for(int i =0; i<jobsList.Count; i++)
                    {
                        if(jobsList[i].CompanyID == compId)
                        {
                            jj.Add(jobsList[i]);
                        }
                    }
               //     List<PersonData.Models.Job> objListOrder =
     // jj.OrderBy(PersonData.Models.Job => PersonData.Models.Job.MinimumSalary).ToList();
                    display.salaryDisplay(jj);
                    //new table 
                    //add first salary
                    break;
            }
        }
        private static int findCompanyId(string name)
        {
            int index = 0;
            for (int i = 0; i < objects.companies.Length; i++)
            {
                if (objects.companies[i].Equals(name))
                {
                    index = i;
                }
            }
            return objects.companyId[index];
        }
    }
    public class objects
    {
        public static string[] majors = {"Biomedical Engineering","Computer Science","Entrepreneurship", "Human Resources","Nursing", "Political Science", "Biology", "Chemistry","Food Science","Management Information Systems", "Mathematics",
"Accounting", "Agricultural Sciences", "Civil Engineering", "Economics", "Industrial Engineering", "Computer Engineering", "Electrical Engineering", "Finance", "Business Administration"};
        public static string[] jobs = { "Seasonal", "Intern", "Part-Time", "Full-Time" };
        public static string[] companies = {
"Aliquam Rutrum LLP", "Non Vestibulum Ltd", "Turpis Nec Institute", "Pede Ac Corporation","Dictum Phasellus Associates",
"Vehicula foeoeAliquet PC", "Mi Lacinia LLC", "Risus Donec Egestas Inc.", "Arcu Vel Associates", "Sed Neque Institute", "Donec Fringilla Corporation","Dictum Ltd",
"Eget Incorporated", "Mauris Magna Inc.", "Integer Corporation", "Consectetuer Cursus Incorporated", "Duis Gravida Corp.", "Turpis Nec Mauris Corporation",
"Interdum Company", "Lacus Company", "Velit Ltd", "Congue A Corporation", "Aenean Massa PC", "Ut Molestie In Associates", "Pellentesque PC", "Tempus Risus Ltd",
"Cursus Et Eros Limited", "Ac Nulla Institute", "Nunc Sed Orci PC", "Donec Sollicitudin Adipiscing Foundation",
"Risus Donec Foundation", "Proin Inc.", "Ultrices Associates", "Lorem Luctus LLP","Eget Nisi LLP", "Dis Parturient LLP",
"A Corp.", "Mollis Industries", "Adipiscing Fringilla Porttitor Incorporated", "Turpis LLP", "Eleifend Vitae Company",
"Feugiat Non Lobortis LLP", "Non Dui Corp.", "Risus Limited", "Enim Associates", "Arcu Corp.", "Euismod Company", "Nunc Id Limited",
"Fermentum Fermentum LLC", "Blandit Mattis Cras Inc.", "Tellus LLC", "At LLC", "Adipiscing Fringilla Associates", "Gravida LLP", "Nunc Sit Inc.",
"Dui Institute", "Ac Feugiat Limited", "Rutrum Industries", "Ut Molestie Institute", "Leo Elementum Sem Incorporated", "Vestibulum Massa Consulting",
"Dui Nec PC", "Cum Corporation", "In Faucibus Foundation", "Nisl Arcu Ltd", "Gravida Nunc Ltd", "Dui Cras Pellentesque Institute", "Dui Institute",
"Erat Vivamus PC", "Erat Eget Tincidunt Corporation", "Massa Integer Limited", "Vulputate Mauris Corporation", "Nam Porttitor Corp.", "Curabitur Sed Foundation",
"Sagittis Duis LLP", "Sodales Elit LLC","A Nunc In Incorporated", "Ac Risus Morbi Corp.", "Facilisis Suspendisse Commodo Institute", "Quisque Nonummy Corp.", "Et Ultrices Associates",
"Id Corporation", "Magna Sed Dui PC", "Duis Dignissim Tempor LLC", "Nec Diam Duis Incorporated", "Nullam Company", "Ipsum Suspendisse Institute", "Sed Nulla Ante LLC", "Enim Nunc Corp.",
"Lorem Luctus Limited", "Convallis Corporation", "Aliquet Institute", "Ornare Egestas Industries", "Aliquam Adipiscing Limited", "Non Hendrerit Id Corp.", "Ornare Egestas Company",
"Tempor Erat Neque Associates", "Sem Elit Consulting", "Nascetur Ridiculus Inc.", "Nec Ligula Corporation"};
        public static int[] companyId = {
2487, 6173, 2769, 6930, 5963, 5105, 2657, 3613, 6805, 8311, 2019, 4583, 8730, 3257, 2294,
2665,  7775, 9275, 5142, 6264, 8127, 8340, 8654, 7802, 3212, 1167, 2774, 7169, 3152, 1961,
1305, 1305, 9495, 4050, 1208, 9716, 1179, 7060, 9851, 2081, 8868, 8695, 2780, 5106, 8265,
1413, 9608, 9742, 4695, 5841, 5175, 1989, 4125, 5624, 8727, 3919, 2120, 4615, 9205, 1138,
3745, 9107, 7779, 6977, 6811, 4553, 3167, 2694, 3846, 5639, 9427, 2650, 7361, 1656, 1128,
7304, 9720, 5320, 6476, 1813, 8787, 2642, 3274, 2856, 8476, 1803, 6468, 9480, 2219, 5716,
7722, 2111, 3066, 9837, 8608, 3079, 8255, 8014, 8892, 3052, 7490
};

        public static string[] schools = {
"Cruz College" , "Munoz University", "Delaney University", "Vazquez College", "Joyner University", "Watts University", "Grimes University",
"Reynolds College", "Perez College", "Wolf College", "Brooks College", "Gutierrez College", "Hahn College", "Graham College", "Haynes University",
"Castillo University", "Madden College", "Bowers College", "Holmes College", "Fuller College", "Raymond University", "Carter College", "Stone College",
"Stanley College", "Shelton University", "Downs University", "Randolph University", "Bradshaw College", "Cox University", "Williamson College", "Mitchell University",
"Frye University", "Albert University", "Underwood University", "Walter College", "Lester University", "Schroeder College", "Allen College", "Spears University", "Livingston University",
"Becker University", "Harrison University", "Harvey University", "Velasquez University", "Bauer University", "Erickson College", "Duran College", "Miller University", "Mcdaniel University",
"Russell University", "Blair College", "Robertson College", "Reynolds College", "Davenport University", "Delacruz University", "Ross University", "Vance College", "Palmer College", "Rocha University",
"Valentine University", "Hurley University", "Lucas University", "Gomez College", "Mercado University", "Todd College", "Steele University", "Workman College", "Rush College", "Crosby College",
"Galloway College", "Burton University", "Collins University", "Whitney College", "Maynard College", "Rice University", "Carroll University", "Sosa College", "Atkins University", "Schneider College",
"Howell University", "Underwood College", "Rivera College", "Juarez College", "Ellis University", "Banks College", "Kim University", "Gilliam University", "Sutton University", "Spencer College", "Miles University",
"Morin University", "Berg University", "Sloan College", "Frazier College", "Fisher University", "Knox University", "Coffey University", "Bentley University", "Vaughn College", "Dixon College"
};
        public static int[] schoolId = {6278,
1347, 3727, 6424, 1640, 9988, 4965, 5086, 5688, 1381, 5865, 3575, 5285, 1787, 8079, 1510, 6006,
2925, 2102, 6929, 7243, 8734, 9022, 9269, 9967, 8307, 4921, 6410, 3909, 1900, 5449, 9539, 4813,
4027, 3397, 3326, 2978, 2302, 2930, 3041, 1122, 2915, 6867, 6455, 1382, 8510, 8510, 1929, 4355,
9938, 6320, 3307, 3364, 7032, 5587, 1805, 7454, 3583, 8050, 9582, 1498, 6278, 7375, 7453, 6628,
2001, 3416, 2288, 3257, 4170, 4650, 1835, 2489, 1989, 3689, 6226, 3141, 4494, 4165, 4376, 6584,
3338, 6319, 9822, 6035, 5456, 6541, 2390, 4411, 6896, 8683, 9105, 9054, 6366, 2911, 5245, 3100,
2500, 2688, 4825, 4438
};
    }

}
