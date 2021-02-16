using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210215_2
{
    public partial class FrmMain : Form
    {

        private string connectionString;

        public FrmMain()
        {
            connectionString =
                @"Server = (localdb)\MSSQLLocalDB;" +
                $"AttachDbFileName = {Program.dbFileLocation};";

            InitializeComponent();
        }

        #region teszt
        public void Test01()
        {
            using SqlConnection c = new(connectionString);
            c.Open();
            var r = new SqlCommand("SELECT TOP 1 nev FROM gyak_tanulo", c)
                .ExecuteReader();
            r.Read();
            Debug.WriteLine(r[0]);
        }
        #endregion
    }
}
