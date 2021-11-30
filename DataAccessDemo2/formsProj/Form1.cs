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

namespace FindAJob
{
    
    public partial class Form1 : Form
    {
        public static bool created = false;
        public static PersonData.Models.Person mainPerson;
        public Form1()
        {
            InitializeComponent();
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
            displayPage display = new displayPage();
            display.Show();
        }

        public static void createPerson(PersonData.Models.Person p)
        {
            created = true;
            mainPerson = p;
        }

        public static void createJob(PersonData.Models.Job j )
        {

        }

        public static void reportQuery(int tab, string filter)
        {
            //filter - the company name or the major
            switch (tab)
            {
                case 1:
                    //By Company aka NumberofJobs
                    PersonData.DataDelegates.NumberOfJobsDelegate nj = new PersonData.DataDelegates.NumberOfJobsDelegate(filter);
                    break;
                case 2:
                    //Popular Schools
                    PersonData.DataDelegates.FetchMostPopularSchoolDelegate fm = new PersonData.DataDelegates.FetchMostPopularSchoolDelegate(filter);
                    break;
                case 3:
                    //Best Candidates aka Candidates
                    PersonData.DataDelegates.FetchBestCandidateDelegate fb = new PersonData.DataDelegates.FetchBestCandidateDelegate(filter);
                    break;
                case 4:
                    //Best Salaries aka ListofJobs
                    PersonData.DataDelegates.FetchCompanyAndSalaryDelegate fc = new PersonData.DataDelegates.FetchCompanyAndSalaryDelegate(filter);
                    break;
            }
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
