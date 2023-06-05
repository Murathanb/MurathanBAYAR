using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;




namespace WinFormsApp3
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();


        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Users\murat\Desktop\veritabanı\users2.db"))
            { }

            //do nothing
            else
            {
                var db = new SQLiteConnection(@"C:\Users\murat\Desktop\veritabanı\users2.db");
                db.CreateTable<DBinfo>();

                db.Close();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBinfo temp = new DBinfo(txtUsername.Text, txtPassword.Text);
            var db = new SQLiteConnection(@"C:\Users\murat\Desktop\veritabanı\users2.db");
            db.Insert(temp);

            db.Close();

            MessageBox.Show("Kayıt başarılı");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f1 = new frmLogin();
            f1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Text = String.Empty;
            txtUsername.Text = String.Empty;
        }
    }
}
