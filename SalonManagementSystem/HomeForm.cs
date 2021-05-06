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
    public partial class HomeForm : Form
    {
        AppointmentDetail appointment = new AppointmentDetail();
        
        public HomeForm()
        {
            InitializeComponent();
        }
        
        private void HomeForm_Load(object sender, EventArgs e)
        {
            getAllAppointmentDetails();
        }

        void getAllAppointmentDetails()
        {
            CString.cmd = new SqlCommand("Sp_Get_UpcommingAppointment", CString.con);
            CString.cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter(CString.cmd);
            CString.con.Open();
            CString.cmd.ExecuteNonQuery();
            CString.con.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgvAppointmentDetail.DataSource = dt;
        }
    }
}
