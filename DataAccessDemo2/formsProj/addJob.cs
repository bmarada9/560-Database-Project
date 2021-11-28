using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAJob
{
    public partial class addJob : Form
    {
        public addJob()
        {
            InitializeComponent();
            string[] majors = {"Biomedical Engineering","Computer Science","Entrepreneurship", "Human Resources","Nursing", "Political Science", "Biology", "Chemistry","Food Science","Management Information Systems", "Mathematics",
"Accounting", "Agricultural Sciences", "Civil Engineering", "Economics", "Industrial Engineering", "Computer Engineering", "Electrical Engineering", "Finance", "Business Administration"};
            majorDropDown.Items.AddRange(majors);
            string[] jobs = { "Seasonal", "Intern", "Part-Time", "Full-Time" };
            jobType.Items.AddRange(jobs);
            
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
