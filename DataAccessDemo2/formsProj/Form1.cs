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
        
    }

}
