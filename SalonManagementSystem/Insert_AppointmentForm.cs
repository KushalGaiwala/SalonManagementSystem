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

                char Gender = 'F';
                if (rbMale.Checked)
                {
                    Gender = 'M';
                }
                else if (rbFemale.Checked)
                {
                    Gender = 'F';
                }

                CString.cmd = new SqlCommand("Sp_Insert_tblCustomer", CString.con);
                CString.cmd.CommandType = CommandType.StoredProcedure;
                CString.cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                CString.cmd.Parameters.AddWithValue("@Area", txtCustArea.Text);
                CString.cmd.Parameters.AddWithValue("@ContactNo", Convert.ToDouble(txtCustContactNo.Text));
                CString.cmd.Parameters.AddWithValue("@Gender", Gender);

                CString.con.Open();
                CString.cmd.ExecuteNonQuery();
                reset_AllFields();
                MessageBox.Show("Data successfully Inserted!");
                CString.con.Close();

                CString.cmd = new SqlCommand("Sp_Insert_tblAppointment", CString.con);







            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Details Properly!");
            }
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

            CString.cmd = new SqlCommand("Sp_View_AllPackages", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            
            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();

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
            // End
            dgvPackages.DataSource = dt;

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
    }
}
