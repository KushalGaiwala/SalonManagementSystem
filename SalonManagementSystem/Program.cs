using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
    public static class CString
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=KUSHAL\MSSQLSERVER01;Initial Catalog=DB_SalonManagementSystem;Integrated Security=True");
        public static SqlCommand cmd;
    }
}
