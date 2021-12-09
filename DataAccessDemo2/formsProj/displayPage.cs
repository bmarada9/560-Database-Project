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
    public partial class displayPage : Form
    {
        public List<Button> applyButtons = new List<Button>();
        public displayPage()
        {
            InitializeComponent();
            companyDropDown.Items.AddRange(objects.companies);
            schoolDropDown.Items.AddRange(objects.companies);
            candidateDropDown.Items.AddRange(objects.companies);
            salaryDropDown.Items.AddRange(objects.majors);
            if (Form1.created == true)
            {
                nameDisplay.Text = "Hello, " + Form1.mainPerson.FirstName;
            }

        }

        private void candidateChangeClick(object sender, EventArgs e)
        {
            Form1.reportQuery(3, candidateDropDown.SelectedItem.ToString());
        }

        private void companyChangeClick(object sender, EventArgs e)
        {
            Form1.reportQuery(1, companyDropDown.SelectedItem.ToString());

            //Apply Column
            if (Form1.created == true)
            {
                for (int i = 0; i < applyButtons.Count; i++)
                {
                    applyButtons.ElementAt(i).Click += applyButtonClick;
                    companyTable.Controls.Add(applyButtons.ElementAt(i), 4, i);
                }
            }
        }

        private void schoolChangeClick(object sender, EventArgs e)
        {
            Form1.reportQuery(2, schoolDropDown.SelectedItem.ToString());
        }

        private void salaryChangeClick(object sender, EventArgs e)
        {
            Form1.reportQuery(4, salaryDropDown.SelectedItem.ToString());
        }
        private void applyButtonClick(object sender, EventArgs e)
        {

            PersonData.Models.Application app = new PersonData.Models.Application(0000,
                //Need to know how to get table items
                0000,
                Form1.mainPerson.PersonId,
                DateTime.Now,
                //Need to know how to get table items
                DateTime.Now,
                Form1.mainPerson.Gpa,
                Form1.mainPerson.Major,
                Form1.mainPerson.Graduated
                );
        }
        public void companyDisplay(List<PersonData.Models.Job> jobs)
        {
            for(int i =0; i < jobs.Count; i++)
            {
                Label jname = new Label();
                jname.Text = jobs[i].Name;
                companyTable.Controls.Add(jname, 0, i);

                Label jtype = new Label();
                jtype.Text = jobs[i].JobType;
                companyTable.Controls.Add(jtype, 1, i);

                Label jmajor = new Label();
                jmajor.Text = jobs[i].MajorAccepted;
                companyTable.Controls.Add(jmajor, 2, i);

                Label jduedate = new Label();
                jduedate.Text = jobs[i].ApplicationDueDate;
                companyTable.Controls.Add(jduedate,3,i);
            }
            
        }

        public void schoolDisplay(List<PersonData.Models.Person> persons)
        {

        }
        public void candidateDisplay(List<PersonData.Models.Person> persons)
        {

        }
        public void salaryDisplay(List<PersonData.Models.Job> jobs)
        {

        }
        
    }
}
