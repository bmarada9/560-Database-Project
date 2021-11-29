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
            
            jobType.Items.AddRange(objects.jobs);
            
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            if (jobTitle != null && minSalary!=null && companyDropDown.SelectedIndex>-1 && supLastName!=null && jobType.SelectedIndex>-1 && majorDropDown.SelectedIndex > -1)
            {
                //PersonData.Models.Job j = new PersonData.Models.Job()
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
