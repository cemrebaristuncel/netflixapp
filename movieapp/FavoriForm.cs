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
    public partial class FavoriForm : Form
    {
        public FavoriForm()
        {
            InitializeComponent();
        }

        public int checkboxSayac = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {
            listBox1.Items.Clear();
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            listBox1.Items.Add("FAVORİ TÜRLERİNİZE GÖRE YAPIMLAR");

            if (checkBox1.Checked)
            {
                
                try
                {
                    string secilen = checkBox1.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    listBox1.Items.Add("****************************************");
                    while (myReader.Read())
                    {
                        
                        listBox1.Items.Add("Program Adı: "+myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: "+myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: "+myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString()+" dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>",e.Message);
                }
                
            }
            if (checkBox2.Checked)
            {
                try
                {
                    string secilen = checkBox2.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
            if (checkBox3.Checked)
            {
                try
                {
                    string secilen = checkBox3.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
            if (checkBox4.Checked)
            {
                try
                {
                    string secilen = checkBox4.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
            if (checkBox5.Checked)
            {
                try
                {
                    string secilen = checkBox5.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
            if (checkBox6.Checked)
            {
                try
                {
                    string secilen = checkBox6.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
            if (checkBox7.Checked)
            {
                try
                {
                    string secilen = checkBox7.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
            if (checkBox8.Checked)
            {
                try
                {
                    string secilen = checkBox8.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
            if (checkBox9.Checked)
            {
                try
                {
                    string secilen = checkBox9.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
            if (checkBox10.Checked)
            {
                try
                {
                    string secilen = checkBox10.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }

            }
            if (checkBox11.Checked)
            {
                try
                {
                    string secilen = checkBox11.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
            if (checkBox12.Checked)
            {
                try
                {
                    string secilen = checkBox12.Text;
                    string Query = $"SELECT DISTINCT p_name,p_tip,t_name,p_bolumsayisi,p_uzunluk,p_puan FROM program,tur,turprogram WHERE program.p_id = turprogram.p_id AND tur.t_id = turprogram.t_id AND tur.t_name = '{secilen}' ORDER BY program.p_puan DESC LIMIT 2";
                    MySqlCommand command = new MySqlCommand(Query, databaseConnection);
                    MySqlDataReader myReader = command.ExecuteReader();
                    
                    while (myReader.Read())
                    {

                        listBox1.Items.Add("Program Adı: " + myReader["p_name"].ToString());
                        listBox1.Items.Add("Program Tipi: " + myReader["p_tip"].ToString());
                        listBox1.Items.Add("Program Türü: " + myReader["t_name"].ToString());
                        listBox1.Items.Add("Bölüm Sayısı: " + myReader["p_bolumsayisi"].ToString());
                        listBox1.Items.Add("Uzunluğu: " + myReader["p_uzunluk"].ToString() + " dakika");
                        listBox1.Items.Add("Puanı: " + myReader["p_puan"].ToString());
                        listBox1.Items.Add("****************************************");

                    }
                    myReader.Close();
                }
                catch (Exception e)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", e.Message);
                }
            }
        }

        private void FavoriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox2.Checked = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox3.Checked = false;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox4.Checked = false;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox5.Checked = false;
            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox7.Checked = false;
            }
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox8.Checked = false;
            }
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox9.Checked = false;
            }
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox10.Checked = false;
            }
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox11.Checked = false;
            }
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox12.Checked = false;
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                checkboxSayac++;
            else
                checkboxSayac--;
            if (checkboxSayac > 3)
            {
                MessageBox.Show("En fazla 3 adet tür seçebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox6.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
