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

namespace SchedulLog
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Desktop\Project Individu OOP\SchedulLog\SchedulLog\dbLogin.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from Login where Username = '" + tbUsername.Text + "' and Password = '" + tbPassword.Text + "'", koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MenuUtama panggil = new MenuUtama();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Mohon isi username dan password dengan benar!");
            }
        }
    }
}
