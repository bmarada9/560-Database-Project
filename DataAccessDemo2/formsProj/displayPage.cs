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
            while (companyTable.Controls.Count > 0)
            {
                companyTable.Controls[0].Dispose();
            }
            for (int i =0; i < jobs.Count; i++)
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
                if (Form1.created == true)
                {
                    Button apply = new Button();
                    apply.Text = "Apply";
                    apply.Click += applyButtonClick;
                    companyTable.Controls.Add(apply, 4, i);
                }
                
            }
            
        }

        public void schoolDisplay(List<PersonData.Models.School> schools)
        {
            while (schoolTable.Controls.Count > 0)
            {
                schoolTable.Controls[0].Dispose();
            }
            int max = 6;
            int min = 4;

            for (int i = 0; i < schools.Count; i++)
            {
                
                Label sname = new Label();
                sname.Text = schools[i].Name;
                schoolTable.Controls.Add(sname, 0, i);

                Label smascot = new Label();
                smascot.Text = schools[i].Mascot;
                schoolTable.Controls.Add(smascot, 1, i);

                Label stype = new Label();
                if (schools[i].TypeOfSchool.Equals("1"))
                {
                    stype.Text = "Private";
                }
                else { stype.Text = "Public"; }
                schoolTable.Controls.Add(stype, 2, i);

                Label sapplicants = new Label();
                Random rd = new Random();
                sapplicants.Text = rd.Next(min, max).ToString();
                schoolTable.Controls.Add(sapplicants, 3, i);
                if (min > 1)
                {
                    min--;
                    max--;
                }
            }
        }
        public void candidateDisplay(List<PersonData.Models.Person> persons, List<PersonData.Models.Job> jobs)
        {
            while (candidateTable.Controls.Count > 0)
            {
                candidateTable.Controls[0].Dispose();
            }
            for (int i = 0; i < jobs.Count; i++)
            {
                Label jname = new Label();
                jname.Text = jobs[i].Name;
                candidateTable.Controls.Add(jname, 0, i);

                Label jmajor = new Label();
                jmajor.Text = jobs[i].MajorAccepted;
                candidateTable.Controls.Add(jmajor, 1, i);

                Label pgpa = new Label();
                pgpa.Text = persons[i].Gpa.ToString();
                candidateTable.Controls.Add(pgpa, 2, i);

                Label pname = new Label();
                pname.Text = persons[i].FirstName;
                candidateTable.Controls.Add(pname, 3, i);

                Label plname = new Label();
                plname.Text = persons[i].LastName;
                candidateTable.Controls.Add(plname, 4, i);

            }
        }
        public void salaryDisplay(List<PersonData.Models.Job> jobs)
        {
            while (salaryTable.Controls.Count > 0)
            {
                salaryTable.Controls[0].Dispose();
            }
            for (int i = 0; i < jobs.Count; i++)
            {
                Label jname = new Label();
                jname.Text = findCompanyName(jobs[i].CompanyID).ToString();
                salaryTable.Controls.Add(jname, 0, i);

                Label jsalary = new Label();
                jsalary.Text = jobs[i].MinimumSalary.ToString();
                salaryTable.Controls.Add(jsalary, 1, i);

                Label jtitle = new Label();
                jtitle.Text = jobs[i].Name;
                salaryTable.Controls.Add(jtitle, 2, i);

                Label jgpa = new Label();
                string[] gpa = { "2.0", "2.5", "3.0", "3.5" };
                Random rd = new Random();
                jgpa.Text = gpa[rd.Next(0,4)];
                salaryTable.Controls.Add(jgpa, 3, i);

            }
        }

        private int findCompanyName(int id)
        {
            int index = 0;
            for (int i = 0; i < objects.companyId.Length; i++)
            {
                if (objects.companyId[i].Equals(id))
                {
                    index = i;
                }
            }
            return objects.companyId[index];
        }
        
    }
}
