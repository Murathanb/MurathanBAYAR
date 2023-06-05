using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace WinFormsApp3
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister f2 = new frmRegister();
            f2.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" && txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Boşlukları doldurun");
            }
            else
            {
                string query = "SELECT * From DBinfo Where column1= @txtusername AND column2 = @txtpassword";
                SQLiteConnection conn = new SQLiteConnection("data Source=C:\\Users\\murat\\Desktop\\veritabanı\\users2.db;Version=3");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@txtusername", txtUsername.Text);
                cmd.Parameters.AddWithValue("@txtpassword", txtPassword.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    frmAnasayfa f2 = new frmAnasayfa();
                    f2.ShowDialog();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("şifre yanlış");

                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Text = String.Empty;
            txtUsername.Text = String.Empty;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}