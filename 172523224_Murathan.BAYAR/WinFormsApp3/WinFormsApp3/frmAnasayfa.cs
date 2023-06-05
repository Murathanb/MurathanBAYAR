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
using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }



        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            FILLDGV();




        }


        private void FILLDGV()
        {
            string query = "SELECT * From filmlistesi";
            SQLiteConnection con = new SQLiteConnection("data Source=C:\\Users\\murat\\Desktop\\veritabanı\\film_listesi.db;Version=3");
            con.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admingiriş f2 = new admingiriş();
            f2.ShowDialog();
            this.Close();
        }

        private void veriyap()
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filmkiralamavt f1 = new Filmkiralamavt();
            f1.ShowDialog();
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}
