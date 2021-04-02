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

        private SqlConnection con = new SqlConnection(@"Data Source=KUSHAL\MSSQLSERVER01;Initial Catalog=DB_SalonManagementSystem;Integrated Security=True");
        private SqlCommand cmd;
        
        private void btnCustInsert_Click(object sender, EventArgs e)
        {
            try
            {

                char Gender = 'F';
                if (rbMale.Checked)
                {
                    Gender = 'M';
                }
                else if(rbFemale.Checked)
                {
                    Gender = 'F';
                }

                cmd = new SqlCommand("Sp_Insert_tblCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustName", txtCustName.Text);
                cmd.Parameters.AddWithValue("@Area", txtCustArea.Text);
                cmd.Parameters.AddWithValue("@ContactNo", Convert.ToDouble(txtCustContactNo.Text));
                cmd.Parameters.AddWithValue("@Gender", Gender);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data successfully Inserted!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Details Properly!");
            }
        }

        private void Insert_AppointmentForm_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Sp_View_tblServicePackages", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            DataTable dt = new DataTable();

            adp.Fill(dt);
            dgvAppointmentPackages.DataSource = dt;
            
        }
    }
}
