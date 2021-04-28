using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulLog
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            jam1.Text = "07:15 - 09:15";
            jam2.Text = "10:00 - 12:00";
            jam3.Text = "13:00 - 15:30";
            jam4.Text = "15:30 - 17:30";       

            mk1.Text = "Fisika Teknik A";
            mk2.Text = "Metode Numeris A";
            mk3.Text = "";
            mk4.Text = "Praktikum Metode Numeris";

            dp1.Text = "Ir. Eka Firmansyah, S.T., M.Eng., Ph.D., IPM." + Environment.NewLine +
                       "Dzuhri Radityo Utomo, S.T., M.Sc., Ph.D.";
            dp2.Text = "Roni Irnawan, S.T., M.Sc., Ph.D., SMIEEE" + Environment.NewLine +
                       "Ir.Sarjiya, S.T., MT., Ph.D., IPU." + Environment.NewLine +
                       "Ir.Noor Akhmad Setiawan, S.T., M.T., Ph.D., IPM.";
            dp3.Text = "";
            dp4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jam1.Text = "07:15 - 09:15";
            jam2.Text = "10:00 - 12:00";
            jam3.Text = "13:00 - 15:30";
            jam4.Text = "15:30 - 17:00";

            mk1.Text = "";
            mk2.Text = "Pendidikan Pancasila";
            mk3.Text = "";
            mk4.Text = "Tutorial Metode Numeris";

            dp1.Text = "";
            dp2.Text = "Fitri Alfariz, S.Fil., M.Phil.";
            dp3.Text = "";
            dp4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jam1.Text = "07:15 - 09:15";
            jam2.Text = "10:00 - 12:00";
            jam3.Text = "13:00 - 15:30";
            jam4.Text = "15:30 - 17:00";

            mk1.Text = "Konsep Keteknikan Untuk Peradaban";
            mk2.Text = "Sistem Mikroprosesor";
            mk3.Text = "Arsitektur Komputer";
            mk4.Text = "Tutorial Fisika Teknik";

            dp1.Text = "Ir. Sujoko Sumaryono, M.T." + Environment.NewLine +
                       "Prof.Dr.Ir.Sasongko Pramonohadi, DEA." + Environment.NewLine +
                       "Ir.Tiyono, M.T." + Environment.NewLine +
                       "Dzuhri Radityo Utomo, S.T., M.Sc., Ph.D." + Environment.NewLine +
                       "Roni Irnawan, S.T., M.Sc., Ph.D., SMIEEE";
            dp2.Text = "Ir. Agus Bejo, S.T., M.Eng., D.Eng., IPM." + Environment.NewLine +
                       "Ir.Addin Suwastono, S.T., M.Eng., IPM.";
            dp3.Text = "Ir.Addin Suwastono, S.T., M.Eng., IPM.";
            dp4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jam1.Text = "07:15 - 09:15";
            jam2.Text = "10:00 - 12:00";
            jam3.Text = "13:00 - 15:30";
            jam4.Text = "15:30 - 17:00";

            mk1.Text = "Matematika Elektro A";
            mk2.Text = "Pemrograman Berorientasi Obyek";
            mk3.Text = "";
            mk4.Text = "Tutorial Matematika Elektro";

            dp1.Text = "Dr. Indah Soesanti, S.T., M.T." + Environment.NewLine +
                       "Dr.Eng.Ir.F.Danang Wijaya, S.T., M.T., IPM." + Environment.NewLine +
                       "Husni Rois Ali, S.T., M.Eng., Ph.D." + Environment.NewLine +
                       "Anugerah Galang Persada, S.T., M.Eng.";
            dp2.Text = "Dr. Ir. Ridi Ferdiana, S.T., M.T., IPM.";
            dp3.Text = "";
            dp4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            jam1.Text = "07:15 - 09:15";
            jam2.Text = "10:00 - 12:00";
            jam3.Text = "13:00 - 15:00";
            jam4.Text = "15:30 - 17:00";

            mk1.Text = "";
            mk2.Text = "";
            mk3.Text = "Praktikum Pemrograman Berorientasi Obyek";
            mk4.Text = "";

            dp1.Text = "";
            dp3.Text = "";
            dp4.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMenu kembali = new LoginMenu();
            kembali.Show();
        }
    }
}
