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
            majorDropDown.Items.AddRange(objects.majors);
            companyDropDown.Items.AddRange(objects.companies);
            jobType.Items.AddRange(objects.jobs);
            
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            if (jobTitle != null && minSalary!=null && companyDropDown.SelectedIndex>-1 && supLastName!=null && jobType.SelectedIndex>-1 && majorDropDown.SelectedIndex > -1)
            {
                string salary = new String(minSalary.Text.Where(Char.IsDigit).ToArray());
                int intsalary = Convert.ToInt32(salary);
                PersonData.Models.Job j = new PersonData.Models.Job(jobTitle.Text, intsalary, findCompanyId(companyDropDown.SelectedItem.ToString()), generateJobId(), majorDropDown.SelectedItem.ToString(), supLastName.Text, jobType.Text, intsalary, appDate.Value.ToString("MM/dd/yyyy"));
                Form1.createJob(j);
                this.Close();
            }
            else
            {
                fieldError.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int findCompanyId(string name)
        {
            int index = 0;
            for (int i = 0; i<objects.companies.Length; i++)
            {
                if (objects.companies[i].Equals(name))
                {
                    index = i;
                }
            }
            return objects.companyId[index];
        }
        private int generateJobId()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}
