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
    public partial class Appointment : Form
    {
        private int appId;
        private int pckChange = 0;
        private AppointmentDetail appointment = new AppointmentDetail();
        public Appointment()
        {
            InitializeComponent();
        }

        private void AppointmentDetail_Load(object sender, EventArgs e)
        {
            
            dgvAppointmentDetail.DataSource = appointment.getAllDetail();
            // Appointment ID must not be visible to User
            dgvAppointmentDetail.Columns["aid"].Visible = false;
            CString.cmd = new SqlCommand("Sp_Get_Packages", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;

            CString.con.Open();
            SqlDataReader reader = CString.cmd.ExecuteReader();
            while (reader.Read())
            {
                cbPackage.Items.Add(reader.GetValue(0).ToString());
            }
            reader.Close();
            CString.con.Close();

            // If Combo Box is used for Customer Contact No:
            //CString.cmd = new SqlCommand("Sp_Get_AllCustomer", CString.con);
            //CString.cmd.CommandType = CommandType.StoredProcedure;
            //CString.con.Open();
            //reader = CString.cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    // Retriving Customer Contact No at column 4
            //    cbSearchContactNo.Items.Add(reader.GetValue(3).ToString());
            //}
            //CString.con.Close();
            
        }

        void reset_AllControls()
        {
            cbStatus.Text = null;
            txtTotalAmount.Text = null;
            txtSearchContactNo.Text = null;
            txtCustContactNo.Text = null;
            cbPackage.Text = null;
        }

        private void cbSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Customer")
            {
                lblSearchDate.Visible = false;
                dtpSearchDate.Visible = false;
                lblSearchContactNo.Visible = true;
                txtSearchContactNo.Visible = true;
            }
            else if (cbSearch.Text == "Date")
            {
                lblSearchContactNo.Visible = false;
                txtSearchContactNo.Visible = false;
                lblSearchDate.Visible = true;
                dtpSearchDate.Visible = true;
            }
            else
            {
                lblSearchContactNo.Visible = false;
                txtSearchContactNo.Visible = false;
                lblSearchDate.Visible = false;
                dtpSearchDate.Visible = false;
                dgvAppointmentDetail.DataSource = appointment.getAllDetail();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            char status = ' ';
            if(cbStatus.Text == "Remaining")
            {
                status = 'r';
            }
            else if(cbStatus.Text == "Cancel")
            {
                status = 'c';
            }
            else if(cbStatus.Text == "Done")
            {
                status = 'd';
            }
            appointment.updateDetail(appId, cbPackage.Text, Convert.ToDateTime(cbAppointmentTime.Text), dtpAppointmentDate.Value, status);
            dgvAppointmentDetail.DataSource = appointment.getAllDetail();
        }

        void calTotalAmount()
        {
            CString.cmd = new SqlCommand("Sp_View_TotalPackageAmount", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@pckName", cbPackage.Text);

            CString.con.Open();
            SqlDataReader reader1 = CString.cmd.ExecuteReader();
            while (reader1.Read())
            {
                txtTotalAmount.Text = reader1.GetValue(0).ToString();
            }
            CString.con.Close();
        }

        private void cbPackage_SelectedValueChanged(object sender, EventArgs e)
        {
            if (pckChange != 0)
            {
                calTotalAmount();
            }
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            dgvAppointmentDetail.DataSource = appointment.getAllDetail(dtpSearchDate.Value);
        }

        private void cbSearchContactNo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "All")
            {
                dgvAppointmentDetail.DataSource = appointment.getAllDetail();
            }
            else if (cbSearch.Text == "Customer")
            {
                dgvAppointmentDetail.DataSource = appointment.getAllDetail(Convert.ToInt64(txtSearchContactNo.Text));
            }
            else if (cbSearch.Text == "Date")
            {
                dgvAppointmentDetail.DataSource = appointment.getAllDetail(dtpSearchDate.Value);
            }
        }

        private void dgvAppointmentDetail_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                appId = Convert.ToInt32(dgvAppointmentDetail.SelectedRows[0].Cells["aid"].Value);
                txtCustName.Text = dgvAppointmentDetail.SelectedRows[0].Cells["Customer Name"].Value.ToString();
                txtCustContactNo.Text = dgvAppointmentDetail.SelectedRows[0].Cells["Contact No"].Value.ToString();
                pckChange = 1;
                cbPackage.Text = dgvAppointmentDetail.SelectedRows[0].Cells["Package"].Value.ToString();
                dtpAppointmentDate.Value = Convert.ToDateTime(dgvAppointmentDetail.SelectedRows[0].Cells["date"].Value);
                cbAppointmentTime.Text = dgvAppointmentDetail.SelectedRows[0].Cells["time"].Value.ToString();
                cbStatus.Text = dgvAppointmentDetail.SelectedRows[0].Cells["status"].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
