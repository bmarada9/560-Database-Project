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
    public partial class welcomePage : Form
    {
        public welcomePage()
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

        private void button1_Click(object sender, EventArgs e)
        {
            displayPage display = new displayPage();
            display.Show();
        }
    }
}
