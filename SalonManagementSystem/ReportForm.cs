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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        AppointmentDetail appointment = new AppointmentDetail();
        private void ReportForm_Load(object sender, EventArgs e)
        {

            this.rvReportView.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Sp_Get_Appointment_ContactWiseTableAdapter.Fill(this.DS_SalonManagementSystem.Sp_Get_Appointment_ContactWise, Convert.ToInt64(txtContactNo.Text));
            this.rvReportView.RefreshReport();
            btnPrint.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == rvReportView.PrintDialog())
            {
                appointment.changeStatus(Convert.ToInt64(txtContactNo.Text), DateTime.Now, 'd');
            }
        }
    }
}
