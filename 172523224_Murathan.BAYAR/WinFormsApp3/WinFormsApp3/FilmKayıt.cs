﻿using SQLite;
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
    public partial class FilmKayıt : Form
    {
        public FilmKayıt()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            filmlistesi temp = new filmlistesi(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            var db = new SQLiteConnection(@"C:\Users\murat\Desktop\veritabanı\film_listesi.db");
            db.Insert(temp);

            db.Close();

            MessageBox.Show("Kayıt başarılı");
        }


        private void FilmKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnasayfa f1 = new frmAnasayfa();
            f1.ShowDialog();
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            kiralanmışform f1 = new kiralanmışform();
            f1.ShowDialog();
            this.Close();
        }
    }
}
