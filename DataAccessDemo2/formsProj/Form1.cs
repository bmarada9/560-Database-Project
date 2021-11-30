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
                    //By Company
                    break;
                case 2:
                    //Popular Schools
                    break;
                case 3:
                    //Best Candidates
                    break;
                case 4:
                    //Best Salaries
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
        public static int[] companyId = { };
        public static string[] schools = { };
        public static int[] schoolId = { };
    }

}
