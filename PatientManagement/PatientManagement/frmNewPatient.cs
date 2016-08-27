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
    public partial class frmNewPatient : Form
    {
        public frmNewPatient()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int er = 0;

            string msg = "";

            if(txtName.Text == "")
            {
                er++;
                msg += "Name required\n";
            }
            if (txtContact.Text == "")
            {
                er++;
                msg += "Please enter the contac";
            }
            if (txtEmail.Text == "")
            {
                er++;
                msg += "please enter the email";
            }
            if (txtAddress.Text == "")
            {
                er++;
                msg += "Enter the  Address";
            }
            if (txtOccupation.Text == "")
            {
                er++;
                msg += "enter the occupation";
            }
            if (txtHistory.Text == "")
            {
                er++;
                msg += "enter the History";
            }
            if (txtComboBox.Text == "")
            {
                er++;
                msg += "Please Select Doctor!!";
            }

            if (er == 0)
            {

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = PatientManagement.Properties.Settings.Default.MyCon;
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into patient(name,contact,email,address,occupation,history) values('" + txtName.Text + "','"+txtContact.Text+"','"+txtEmail.Text+"','"+txtAddress.Text+"','"+txtOccupation.Text+"','"+txtHistory.Text+"','"+txtComboBox.Text+"')";

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New patient has been registered");

                    txtName.Text = "";
                    txtName.Focus();

                    txtContact.Text = "";
                    txtContact.Focus();

                    txtEmail.Text = "";
                    txtEmail.Focus();

                    txtAddress.Text = "";
                    txtAddress.Focus();

                    txtOccupation.Text = "";
                    txtOccupation.Focus();

                    txtHistory.Text = "";
                    txtHistory.Focus();

                    txtComboBox.Text = "";
                    txtComboBox.Focus();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                cn.Close();
                /*finally
                {
                       cn.Close();
                }*/

            }
            else
            {
                MessageBox.Show(msg);
            }

        }

        private void txtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int er = 0;
            string msg = "Doctor needed";

            if (txtComboBox.Text == "")
            {
                er++;
                MessageBox.Show(msg);
            }

            if (er == 0)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = PatientManagement.Properties.Settings.Default.MyCon;
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "select * from doctor(name)";

                SqlDataReader dr = cmd.ExecuteReader();
                
                try
                {
                    dr.Read();
                    
                    txtComboBox.Items.Add(dr.GetString(1));
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                cn.Close();
            }
        }
    }
}
