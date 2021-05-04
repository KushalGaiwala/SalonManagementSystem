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
    public partial class HomeForm : Form
    {
        AppointmentDetail appointment = new AppointmentDetail();
        
        public HomeForm()
        {
            InitializeComponent();
        }
        
        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        void getAllAppointmentDetails()
        {
            appointment.getAllDetail(0, DateTime.Today,"All") ;
        }

        private void btnGoToAppointment_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
            form.cUSTOMERToolStripMenuItem_Click(sender, e);
        }
    }
}
