using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{

    public partial class frmMain : Form
    {
        frmPatient paitent = new frmPatient();

        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWatch.Text = "Date And Time :" + DateTime.Now.ToString();
        }


        private void patientEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (paitent.IsDisposed)
                paitent = new frmPatient();

            paitent.Show();
            paitent.MdiParent = this;
            paitent.BringToFront();

            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPatient newpaitent = new frmNewPatient();

            if (newpaitent.IsDisposed)
                newpaitent = new frmNewPatient();

            newpaitent.Show();
            newpaitent.BringToFront();
            newpaitent.MdiParent = this;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void doctorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctor newdoctor = new frmDoctor();

            if (newdoctor.IsDisposed)
                newdoctor = new frmDoctor();

            newdoctor.Show();
            newdoctor.BringToFront();
            newdoctor.MdiParent = this;
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatientHistory ph = new frmPatientHistory();

            if (ph.IsDisposed)
                ph = new frmPatientHistory();

            ph.Show();
            ph.BringToFront();
            ph.MdiParent = this;

        }

        private void doctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDoctorHistory dh = new frmDoctorHistory();
            dh.Show();
            dh.MdiParent = this;
            dh.BringToFront();

            if (dh.IsDisposed)
            {
                dh = new frmDoctorHistory();
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
        }

        private void searchMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedicine fmd = new frmMedicine();
            fmd.BringToFront();
            fmd.MdiParent = this;
            fmd.Show();

            if (fmd.IsDisposed)

                fmd = new frmMedicine();
        }

        private void addMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMedicine fmda = new frmAddMedicine();
            fmda.Show();
            fmda.BringToFront();
            fmda.MdiParent = this;

            if (fmda.IsDisposed)

                fmda = new frmAddMedicine();
        }

    }
}
