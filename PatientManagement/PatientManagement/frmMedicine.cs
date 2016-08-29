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
    public partial class frmMedicine : Form
    {
        public frmMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
                cn.ConnectionString = PatientManagement.Properties.Settings.Default.MyCon;
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select name,type,subgroup,medication,price from medicine";

                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
                cn.Close();

                dgvMedicine.DataSource = ds.Tables[0];
        }
    }
}
