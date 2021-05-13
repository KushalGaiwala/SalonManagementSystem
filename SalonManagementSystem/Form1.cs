using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonManagementSystem
{
    public partial class Form1 : Form
    {
        Insert_Employee emp = null;
        ServicesForm services = null;
        HomeForm home = null;
        Insert_AppointmentForm insertAppoint = null;
        Customer customer = null;
        Appointment appoint = null;
        //RegistrationForm registration = null;


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
            if (home == null || home.IsDisposed == true)
            {
                home = new HomeForm();
            }
            home.Show();
            home.MdiParent = this;
            close_AllForm(1);
        }

        private void Closed_Form1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (insertAppoint == null || insertAppoint.IsDisposed == true)
            {
                insertAppoint = new Insert_AppointmentForm();
            }
            insertAppoint.Show();
            insertAppoint.MdiParent = this;
            close_AllForm(2);
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (services == null || services.IsDisposed == true)
            {
                services = new ServicesForm();
            }
            services.Show();
            services.MdiParent = this;
            close_AllForm(3);
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (emp == null || emp.IsDisposed == true)
            {
                emp = new Insert_Employee();
            }
            emp.Show();
            emp.MdiParent = this;
            close_AllForm(4);
        }

        public void cUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customer == null || customer.IsDisposed == true)
            {
                customer = new Customer();
            }
            customer.Show();
            customer.MdiParent = this;
            close_AllForm(5);
        }

        private void vIEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (appoint == null || appoint.IsDisposed == true)
            {
                appoint = new Appointment();
            }
            appoint.Show();
            appoint.MdiParent = this;
            close_AllForm(6);
        }

        void close_AllForm(int open)
        {
            if (home != null && open != 1)
            {
                home.Hide();
            }
            if (insertAppoint != null && open != 2)
            {
                insertAppoint.Hide();
            }
            if (services != null && open != 3)
            {
                services.Hide();
            }
            if (emp != null && open != 4)
            {
                emp.Hide();
            }
            if (customer != null && open != 5)
            {
                customer.Hide();
            }
            if (appoint != null && open != 6)
            {
                appoint.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(LoginForm.type != 'a')
            {
                employeeToolStripMenuItem1.Visible = false;
            }
            home = new HomeForm();
            home.Show();
            home.MdiParent = this;
        }
    }
}
