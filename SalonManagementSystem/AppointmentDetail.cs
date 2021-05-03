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
    public partial class AppointmentDetail : Form
    {
        public AppointmentDetail()
        {
            InitializeComponent();
        }

        int change = 0;

        private void AppointmentDetail_Load(object sender, EventArgs e)
        {
            dgvAppointmentDisplay();
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

        }

        void dgvAppointmentDisplay()
        {
            CString.cmd = new SqlCommand("Sp_Get_AllAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@ContactNo", txtSearchContactNo.Text);
            CString.cmd.Parameters.AddWithValue("@Date", dtpSearchDate.Value);
            
            if (cbSearch.Text == "Customer")
            {
                CString.cmd.Parameters.AddWithValue("@type", 1);
            }
            else if (cbSearch.Text == "Date")
            {
                CString.cmd.Parameters.AddWithValue("@type", 2);
            }
            else
            {
                CString.cmd.Parameters.AddWithValue("@type", 0);
            }
            
            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();
            
            DataTable dt = new DataTable();
            adp.Fill(dt);
            
            dgvAppointmentDetail.DataSource = dt;
        }

        private void cbSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbSearch.Text == "All")
            {
                btnSearchGet.Visible = false;
                txtSearchContactNo.Text = null;
                dtpSearchDate.Text = null;
                lblSearchContactNo.Visible = false;
                txtSearchContactNo.Visible = false;
                lblSearchDate.Visible = false;
                dtpSearchDate.Visible = false;
                dgvAppointmentDisplay();
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
            dgvAppointmentDisplay();
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
            dgvAppointmentDisplay();
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
    }
}
