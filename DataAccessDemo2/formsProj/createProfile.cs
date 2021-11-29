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
            
            majorDropDown.Items.AddRange(objects.majors);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(gpaBox.Text) < 1.0 || Convert.ToDouble(gpaBox.Text) > 4.0)
            {
                gpaError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (firstName != null && lastName != null && email != null && email != null && majorDropDown.SelectedIndex > -1 && phoneNumber != null && expectedSalary != null) {
                    string salary = new String(expectedSalary.Text.Where(Char.IsDigit).ToArray());
                    int intsalary = Convert.ToInt32(salary);
                    PersonData.Models.Person p = new PersonData.Models.Person(generatePersonID(), firstName.Text, lastName.Text, email.Text, majorDropDown.SelectedItem.ToString(), graduated.Checked, phoneNumber.Text, 0000, intsalary, commentBox.Text);
                    Form1.createPerson(p);
                    this.Close();
                }
                else
                {
                    fieldError.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int generatePersonID()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}