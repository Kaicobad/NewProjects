using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PatientManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = PatientManagement.Properties.Settings.Default.MyCon;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from login where name = '" + txtName.Text + "' and password = '" + txtPass.Text + "'";

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            int er = 0;
            while (dr.Read())
            {
                er ++;
            }
            if (er==1)
            {
                MessageBox.Show("LogedIn");
                frmMain fm = new frmMain();
                fm.Show();
            }
            else if (er == 0)
            {
                MessageBox.Show("overitted");
            }
            else
            {
                MessageBox.Show("incorrect");
            }

            txtName.Clear();
            txtPass.Clear();

            cn.Close();
             
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

        }
        
    }
}
