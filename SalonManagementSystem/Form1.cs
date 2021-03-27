using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            login.MdiParent = this;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            home.MdiParent = this;
        }

        private void Closed_Form1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
