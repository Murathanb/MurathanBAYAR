using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp3
{
    public partial class Filmkiralamavt : Form
    {
        public Filmkiralamavt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa f1 = new frmAnasayfa();
            f1.ShowDialog();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                filmkira temp = new filmkira(textBox1.Text, textBox2.Text);
                var db = new SQLiteConnection(@"C:\Users\murat\Desktop\veritabanı\FilmKira.db");
                db.Insert(temp);
                db.Close();

                MessageBox.Show("Film Kiralandı");
            }
        }
    }
}
