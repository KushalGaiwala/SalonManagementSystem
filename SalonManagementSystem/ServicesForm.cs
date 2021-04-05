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
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }
        
        private void ServicesForm_Load(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_View_tblPackage", CString.con);
            //CString.cmd.CommandType = CommandType.StoredProcedure;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            CString.cmd = new SqlCommand("Sp_Insert_tblService", CString.con);
        }
    }
}
