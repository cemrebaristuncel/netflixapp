using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace movieapp
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label1.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] {myReader["p_name"].ToString(),myReader["p_tip"].ToString(),myReader["p_bolumsayisi"].ToString(),myReader["p_uzunluk"].ToString(),myReader["p_puan"].ToString()};
                    dataGridView1.Rows.Add(row);
                    

                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label2.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label3.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label4.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label5.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label6.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label7.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label8.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label9.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label10.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label11.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
        private void label12_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = label12.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString() };
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string filmAdi = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Oynatma oynatmaForm = new Oynatma();
                oynatmaForm.label2.Text = filmAdi;
                oynatmaForm.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            try
            {
                dataGridView1.Rows.Clear();
                string secilen = textBox1.Text;
                string Query = $"SELECT DISTINCT p_name,p_tip,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND program.p_name LIKE '%" +textBox1.Text+ "%' ORDER BY program.p_puan DESC";
                MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader = command.ExecuteReader();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Program Adı";
                dataGridView1.Columns[1].Name = "Program Tipi";
                dataGridView1.Columns[2].Name = "Bölüm Sayısı";
                dataGridView1.Columns[3].Name = "Uzunluk";
                dataGridView1.Columns[4].Name = "Puan";
                string[] row;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "İzleme";
                btn.Text = "İzle";
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btn);
                foreach (DataGridViewColumn kolon in dataGridView1.Columns)
                {
                    kolon.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                while (myReader.Read())
                {
                    row = new string[] { myReader["p_name"].ToString(), myReader["p_tip"].ToString(), myReader["p_bolumsayisi"].ToString(), myReader["p_uzunluk"].ToString(), myReader["p_puan"].ToString()};
                    dataGridView1.Rows.Add(row);


                }
                myReader.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
            }
        }
    }
}
