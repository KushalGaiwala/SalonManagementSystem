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
        private AppointmentDetail appointment = new AppointmentDetail();
        public Appointment()
        {
            InitializeComponent();
        }

        private int change = 0;

        private void AppointmentDetail_Load(object sender, EventArgs e)
        {
            dgvAppointmentDisplay(0, DateTime.Today, null);
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
        }

        void reset_AllControls()
        {
            txtStatus.Text = null;
            txtTotalAmount.Text = null;
            txtSearchContactNo.Text = null;
            txtGetDetail.Text = null;
            txtCustContactNo.Text = null;
            txtAppointmentId.Text = null;
            cbPackage.Text = null;
        }

        void dgvAppointmentDisplay(long contactno, DateTime date, string search)
        {   
            dgvAppointmentDetail.DataSource = appointment.getAllDetail(contactno, date, search);
        }

        private void cbSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbSearch.Text == "All")
            {
                btnSearchGet.Visible = false;
                lblSearchContactNo.Visible = false;
                txtSearchContactNo.Visible = false;
                lblSearchDate.Visible = false;
                dtpSearchDate.Visible = false;
                // "1" and "DateTime.Today" are just for "not null" values
                dgvAppointmentDisplay(1, DateTime.Today, cbSearch.Text); 
            }
            if (cbSearch.Text == "Customer")
            {

                lblSearchDate.Visible = false;
                dtpSearchDate.Visible = false;
                lblSearchContactNo.Visible = true;
                txtSearchContactNo.Visible = true;
                btnSearchGet.Visible = true;
            }
            else if(cbSearch.Text == "Date")
            {
                lblSearchContactNo.Visible = false;
                txtSearchContactNo.Visible = false;
                lblSearchDate.Visible = true;
                dtpSearchDate.Visible = true;
                btnSearchGet.Visible = true;
            }
        }

        private void btnSearchGet_Click(object sender, EventArgs e)
        {
            dgvAppointmentDisplay(Convert.ToInt64(txtSearchContactNo.Text), dtpSearchDate.Value, cbSearch.Text);
        }

        private void txtGetDetail_Click(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_Get_Appointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Appid", Convert.ToInt32(txtAppointmentId.Text));

            CString.con.Open();
            SqlDataReader reader = CString.cmd.ExecuteReader();
            while (reader.Read())
            {
                change = 0;
                txtCustContactNo.Text = reader.GetValue(1).ToString();
                cbPackage.Text = reader.GetValue(2).ToString();
                cbAppointmentTime.Text = reader.GetValue(3).ToString();
                dtpAppointmentDate.Text = reader.GetValue(4).ToString();
                txtStatus.Text = reader.GetValue(5).ToString();
            }
            CString.con.Close();
            change = 1;
            calTotalAmount();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateAppointment(txtStatus.Text);
        }

        void updateAppointment(string status)
        {
            CString.cmd = new SqlCommand("Sp_Update_tblAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Appid", Convert.ToInt32(txtAppointmentId.Text));
            CString.cmd.Parameters.AddWithValue("@Pname", cbPackage.Text);
            CString.cmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(cbAppointmentTime.Text));
            CString.cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dtpAppointmentDate.Text));
            CString.cmd.Parameters.AddWithValue("@Status", status);

            DialogResult result = MessageBox.Show("Do you really want to Update?", "Appointment Updation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == result)
            {
                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Updated!");
                CString.con.Close();
            }
            dgvAppointmentDisplay(Convert.ToInt64(txtSearchContactNo.Text), dtpSearchDate.Value, cbSearch.Text);
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
            if (change != 0)
            {
                calTotalAmount();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateAppointment("canceled");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            updateAppointment("done");
        }

        private void dtpSearchDate_ValueChanged(object sender, EventArgs e)
        {
            dgvAppointmentDisplay(Convert.ToInt64(txtSearchContactNo.Text), dtpSearchDate.Value, cbSearch.Text);
        }

        private void txtAppointmentId_Leave(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_Get_Appointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@Appid", Convert.ToInt32(txtAppointmentId.Text));

            CString.con.Open();
            SqlDataReader reader = CString.cmd.ExecuteReader();
            while (reader.Read())
            {
                change = 0;
                txtCustContactNo.Text = reader.GetValue(1).ToString();
                cbPackage.Text = reader.GetValue(2).ToString();
                cbAppointmentTime.Text = reader.GetValue(3).ToString();
                dtpAppointmentDate.Text = reader.GetValue(4).ToString();
                txtStatus.Text = reader.GetValue(5).ToString();
            }
            CString.con.Close();
            change = 1;
            calTotalAmount();
        }

        private void txtSearchContactNo_Leave(object sender, EventArgs e)
        {
            dgvAppointmentDisplay(Convert.ToInt64(txtSearchContactNo.Text), dtpSearchDate.Value, cbSearch.Text);
        }
    }
}
