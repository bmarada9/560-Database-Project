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
        
    }
}
