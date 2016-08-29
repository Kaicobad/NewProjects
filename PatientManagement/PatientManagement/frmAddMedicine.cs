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
    public partial class frmAddMedicine : Form
    {
        public frmAddMedicine()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er=0;

            string msg = "";

            if (txtName.Text == "")
            {
                er++;
                msg += "Medicine Name Required";
            }
            if (txtType.Text == "")
            {
                er++;
                msg += "EnterType\n";
            }
            if(txtSubgroup.Text=="")
            {
                er++;
                msg += "Enter Group";
            }
            if (txtPrice.Text == "")
            {
                er++;
                msg += "enter Price";
            }

            if (er == 0)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = PatientManagement.Properties.Settings.Default.MyCon;
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into medicine(name,type,subgroup,medication,price) values ('" + txtName.Text + "','" + txtType.Text + "','" + txtSubgroup.Text + "','" + txtMedication.Text + "','" + txtPrice.Text + "')";

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Medicine is been Registered!!");

                    txtName.Text = "";
                    txtName.Focus();

                    txtType.Text = "";
                    txtType.Focus();

                    txtSubgroup.Text = "";
                    txtSubgroup.Focus();

                    txtMedication.Text = "";
                    txtMedication.Focus();

                    txtPrice.Text = "";
                    txtPrice.Focus();
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
