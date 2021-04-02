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
    public partial class Display_ServicesForm : Form
    {
        public Display_ServicesForm()
        {
            InitializeComponent();
        }

        private void Display_ServicesForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KUSHAL\MSSQLSERVER01;Initial Catalog=DB_SalonManagementSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Sp_View_Packages", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            
        }
    }
}
