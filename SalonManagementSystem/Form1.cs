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

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
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

        private void sERVICESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert_AppointmentForm insertAppoint = new Insert_AppointmentForm();
            insertAppoint.Show();
            insertAppoint.MdiParent = this;
        }

        private void sERVICESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ServicesForm services = new ServicesForm();
            services.Show();
            services.MdiParent = this;
        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insert_Employee emp = new Insert_Employee();
            emp.Show();
            emp.MdiParent = this;
        }
    }
}
