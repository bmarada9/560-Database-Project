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
            collegeDropDown.Items.AddRange(objects.schools);
            majorDropDown.Items.AddRange(objects.majors);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
                if (firstName != null && lastName != null && gpaBox != null && email != null && majorDropDown.SelectedIndex > -1 && phoneNumber != null && expectedSalary != null) {
                    if (Convert.ToDouble(gpaBox.Text) < 1.0 || Convert.ToDouble(gpaBox.Text) > 4.0)
                    {
                        gpaError.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        string salary = new String(expectedSalary.Text.Where(Char.IsDigit).ToArray());
                        int intsalary = Convert.ToInt32(salary);
                        PersonData.Models.Person p = new PersonData.Models.Person(generatePersonID(), firstName.Text, lastName.Text, Convert.ToDouble(gpaBox.Text), email.Text, majorDropDown.SelectedItem.ToString(), graduated.Checked, phoneNumber.Text, findSchoolID(collegeDropDown.SelectedItem.ToString()), intsalary, commentBox.Text);

                        Form1.createPerson(p);
                        this.Close();
                    }
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

        private int generatePersonID()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
        private int findSchoolID(string name)
        {
            int index = 0;
            for (int i = 0; i < objects.schools.Length; i++)
            {
                if (objects.schools[i].Equals(name))
                {
                    index = i;
                }
            }
            return objects.schoolId[index];
        }
    }
}