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
    public partial class Insert_AppointmentForm : Form
    {
        public Insert_AppointmentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Insert tblCustomer
                // Start
                string Gender = null;
                if (rbMale.Checked)
                {
                    Gender = "M";
                }
                else if (rbFemale.Checked)
                {
                    Gender = "F";
                }
                else
                {
                    Gender = null;
                }

                CString.cmd = new SqlCommand("Sp_Insert_tblCustomer", CString.con);
                CString.cmd.CommandType = CommandType.StoredProcedure;
                CString.cmd.Parameters.AddWithValue("@CustName", txtCustName.Text.ToLower()); // Userd Lowercase in Customer Name
                CString.cmd.Parameters.AddWithValue("@Area", txtCustArea.Text);
                CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToDouble(txtCustContactNo.Text));
                CString.cmd.Parameters.AddWithValue("@Gender", Gender);

                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                CString.con.Close();
                // Insert tblCustomer
                // End

                // Insert tblAppointment
                // Start
                CString.cmd = new SqlCommand("Sp_Insert_tblAppointment", CString.con);
                CString.cmd.CommandType = CommandType.StoredProcedure;
                CString.cmd.Parameters.AddWithValue("@CName", txtCustName.Text);
                CString.cmd.Parameters.AddWithValue("@PName", cbPackages.Text);
                CString.cmd.Parameters.AddWithValue("@Time", Convert.ToDateTime(dtpAppointmentTime.Text));
                CString.cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(dtpAppointmentDate.Text));

                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                reset_AllFields();
                MessageBox.Show("Appointment successfully Generated!");
                CString.con.Close();
                // Insert tblAppointment
                // End
            }
            catch (Exception ex)
            {
                MessageBox.Show("  Enter Details Properly!  "+ex.Message);
            }
            
        }
        void Insert_tblCustomer()
        {
            
        }

        void Insert_tblAppointment()
        {  
            
            
        }

        void reset_AllFields()
        {
            txtCustArea.Text = null;
            txtCustContactNo.Text = null;
            txtCustName.Text = null;
            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        private void Insert_AppointmentForm_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            // For ComboBox
            // Start
            CString.cmd = new SqlCommand("Sp_View_NoOfPackage", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            
            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();
            
            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);
            adp.Fill(dt);
            int pckCnt = Convert.ToInt32(dt.Rows[0][0]);
            dt.Reset();

            for (int i = 1; i <= pckCnt; ++i)
            {
                CString.cmd = new SqlCommand("Sp_View_Packages", CString.con);
                CString.cmd.CommandType = CommandType.StoredProcedure;

                CString.cmd.Parameters.AddWithValue("@pck", i);

                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                CString.con.Close();

                adp = new SqlDataAdapter(CString.cmd);
                
                adp.Fill(dt);

                cbPackages.Items.Add(dt.Rows[i-1][0].ToString());
            }
            // ComboBox
            // End

            // for total price
            /*for (int i = 1; i <= pckCnt; ++i)
            {
                CString.cmd = new SqlCommand("Sp_View_TotalPackageAmount", CString.con);
                CString.cmd.CommandType = CommandType.StoredProcedure;

                CString.cmd.Parameters.AddWithValue("@pckId", i);

                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                CString.con.Close();

                adp = new SqlDataAdapter(CString.cmd);

                adp.Fill(dt);
            }
            dgvPackages.DataSource = dt;*/
        }

        private void selectedValueChanged_cbPackages(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_View_AllPackages", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@pckName", cbPackages.Text);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            dgvPackages.DataSource = dt;

            CString.cmd = new SqlCommand("Sp_View_TotalPackageAmount", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            CString.cmd.Parameters.AddWithValue("@pckName", cbPackages.Text);

            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

            adp = new SqlDataAdapter(CString.cmd);
            DataTable totalAmount = new DataTable();
            adp.Fill(totalAmount);
            txtTotalPrice.Text = totalAmount.Rows[0][0].ToString();
        }
    }
}
