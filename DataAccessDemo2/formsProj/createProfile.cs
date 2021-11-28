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
    public partial class createProfile : Form
    {
        public createProfile()
        { 
            InitializeComponent();
            string[] majors = {"Biomedical Engineering","Computer Science","Entrepreneurship", "Human Resources","Nursing", "Political Science", "Biology", "Chemistry","Food Science","Management Information Systems", "Mathematics",
"Accounting", "Agricultural Sciences", "Civil Engineering", "Economics", "Industrial Engineering", "Computer Engineering", "Electrical Engineering", "Finance", "Business Administration"};
            majorDropDown.Items.AddRange(majors);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(gpaBox.Text) < 1.0 || Convert.ToDouble(gpaBox.Text) > 4.0)
            {
                gpaError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}