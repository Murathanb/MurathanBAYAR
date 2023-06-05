using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class kiralanmışform : Form
    {
        public kiralanmışform()
        {
            InitializeComponent();
        }
        private void FILLDGV()
        {
            string query = "SELECT * From filmkira";
            SQLiteConnection con = new SQLiteConnection("data Source=C:\\Users\\murat\\Desktop\\veritabanı\\FilmKira.db;Version=3");
            con.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kiralanmışform_Load(object sender, EventArgs e)
        {
            FILLDGV();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilmKayıt f1 = new FilmKayıt();
            f1.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa f1 = new frmAnasayfa();
            f1.ShowDialog();
            this.Close();
        }
    }
}
