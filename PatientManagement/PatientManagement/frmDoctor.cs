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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;

            string msg = "";

            if (txtName.Text == "")
            {
                er++;
                msg += "Name is Required\n"; 
            }
            if (txtContact.Text == "")
            {
                er++;
                msg += "Cantact Required\n";
            }
            if (txtAddress.Text == "")
            {
                er++;
                msg += "Address Required\n";
            }
            if (txtEmail.Text == "")
            {
                er++;
                msg += "Email is required";
            }
            if (txtType.Text == "")
            {
                er++;
                msg += "Please insert the type";
            }

            if (er == 0)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = PatientManagement.Properties.Settings.Default.MyCon;
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into doctor(name,contact,address,email,type) values('"+txtName.Text+"','"+txtContact.Text+"','"+txtAddress.Text+"','"+txtEmail.Text+"','"+txtType.Text+"')";

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Doctor Added!!");

                    txtName.Text = "";
                    txtName.Focus();

                    txtContact.Text = "";
                    txtContact.Focus();

                    txtAddress.Text = "";
                    txtAddress.Focus();

                    txtEmail.Text = "";
                    txtEmail.Focus();

                    txtType.Text = "";
                    txtType.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                MessageBox.Show(msg);
            }
        }
    }
}
