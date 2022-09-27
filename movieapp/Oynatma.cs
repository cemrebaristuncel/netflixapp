using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieapp
{
    public partial class Oynatma : Form
    {
        public Oynatma()
        {
            InitializeComponent();
        }
        private void Oynatma_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.gonderilecekEmail;
        }
        int saat = 0; 
        int dakika = 0;
        int saniye = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            string firstQuery = $"SELECT p_id FROM program WHERE p_name = '{label2.Text}'";
            MySqlCommand command = new MySqlCommand(firstQuery, databaseConnection);
            MySqlDataReader myReader = command.ExecuteReader();
            DateTime date = DateTime.Now;
            int p_id = 0;
            while (myReader.Read())
            {
                p_id = (int)myReader[0];

            }
            myReader.Close();
            string email = Form1.gonderilecekEmail;
            string secondQuery = $"SELECT k_id FROM kullanici WHERE k_mail = '{email}'";
            MySqlCommand command1 = new MySqlCommand(secondQuery, databaseConnection);
            MySqlDataReader myReader1 = command1.ExecuteReader();
            int k_id = 0;
            while (myReader1.Read())
            {
               k_id = (int)myReader1[0];
               
            }
            myReader1.Close();
            string sorgu = $"SELECT * FROM kullaniciprogram WHERE p_id = {p_id} AND k_id = {k_id}";
            MySqlCommand command2 = new MySqlCommand(sorgu, databaseConnection);
            MySqlDataReader myReader2 = command2.ExecuteReader();
            if(myReader2.HasRows)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                timer1.Start();
            }
            else
            {
                try
                {
                    myReader2.Close();
                    string thirdQuery = $"INSERT INTO kullaniciprogram (izlemetarihi, izlemesuresi, guncelbolum, verilenpuan, p_id, k_id) VALUES ('{date}', '00:00:00', 1, '0', {p_id}, {k_id})";
                    MySqlCommand command3 = new MySqlCommand(thirdQuery, databaseConnection);
                    MySqlDataReader myReader3 = command3.ExecuteReader();
                    button1.Enabled = false;
                    button2.Enabled = true;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    timer1.Start();
                    myReader3.Close();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata!!! Sebebi =>", hata.Message);
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            string firstQuery = $"SELECT p_id FROM program WHERE p_name = '{label2.Text}'";
            MySqlCommand command4 = new MySqlCommand(firstQuery, databaseConnection);
            MySqlDataReader myReader4 = command4.ExecuteReader();
            DateTime date = DateTime.Now;
            int p_id = 0;
            while (myReader4.Read())
            {
                p_id = (int)myReader4[0];
            }
            myReader4.Close();
            string email = Form1.gonderilecekEmail;
            string izlemesuresi = label1.Text;
            string secondQuery = $"SELECT k_id FROM kullanici WHERE k_mail = '{email}'";
            MySqlCommand command5 = new MySqlCommand(secondQuery, databaseConnection);
            MySqlDataReader myReader5 = command5.ExecuteReader();
            int k_id = 0;
            while (myReader5.Read())
            {
                k_id = (int)myReader5[0];
            }
            myReader5.Close();
            string sorgu = $"UPDATE kullaniciprogram SET izlemetarihi = '{date}', izlemesuresi = '{izlemesuresi}', verilenpuan = '{comboBox1.Text}' WHERE p_id = {p_id} AND k_id = {k_id}";
            MySqlCommand command6 = new MySqlCommand(sorgu, databaseConnection);
            MySqlDataReader myReader6 = command6.ExecuteReader();
            button2.Enabled = false;
            button1.Enabled = true;
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            timer1.Stop();
            myReader6.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            databaseConnection.Open();
            string firstQuery = $"SELECT p_id FROM program WHERE p_name = '{label2.Text}'";
            MySqlCommand command7 = new MySqlCommand(firstQuery, databaseConnection);
            MySqlDataReader myReader7 = command7.ExecuteReader();
            DateTime date = DateTime.Now;
            int p_id = 0;
            while (myReader7.Read())
            {
                p_id = (int)myReader7[0];

            }
            myReader7.Close();
            string email = Form1.gonderilecekEmail;
            string secondQuery = $"SELECT k_id FROM kullanici WHERE k_mail = '{email}'";
            MySqlCommand command8 = new MySqlCommand(secondQuery, databaseConnection);
            MySqlDataReader myReader8 = command8.ExecuteReader();
            int k_id = 0;
            while (myReader8.Read())
            {
                k_id = (int)myReader8[0];

            }
            myReader8.Close();
            string sorgu = $"SELECT izlemesuresi FROM kullaniciprogram WHERE p_id = {p_id} AND k_id = {k_id}";
            MySqlCommand command9 = new MySqlCommand(sorgu, databaseConnection);
            MySqlDataReader myReader9 = command9.ExecuteReader();
            while (myReader9.Read())
            {

                string kaldigiYer = myReader9["izlemesuresi"].ToString();
                if (kaldigiYer != "00:00:00")
                {
                    string kaldigiSaat = kaldigiYer.Substring(0, 2);
                    int numberKaldigiSaat = Convert.ToInt32(kaldigiSaat);
                    string kaldigiDakika = kaldigiYer.Substring(3, 2);
                    int numberKaldigiDakika = Convert.ToInt32(kaldigiDakika);
                    string kaldigiSaniye = kaldigiYer.Substring(6, 2);
                    int numberKaldigiSaniye = Convert.ToInt32(kaldigiSaniye);
                    if (saniye == 0)
                    {
                        label1.Text = String.Format("{0:D2}", saat+ numberKaldigiSaat) + ":" + String.Format("{0:D2}", dakika+ numberKaldigiDakika) + ":" + String.Format("{0:D2}", saniye+ numberKaldigiSaniye);
                        saniye++;
                        saniye = numberKaldigiSaniye;
                        dakika = numberKaldigiDakika;
                        saat = numberKaldigiSaat;
                    }  
                    else if (saniye > 0)
                    {

                        if (saniye == 60)
                        {
                            saniye = 0;
                            dakika++;

                        }
                        if (dakika == 60)
                        {
                            dakika = 0;
                            saniye = 0;
                            saat++;
                        }
                        label1.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
                        saniye++;

                    }           
                }
                else
                {
                    if (saniye == 60)
                    {
                        saniye = 0;
                        dakika++;

                    }
                    if (dakika == 60)
                    {
                        dakika = 0;
                        saniye = 0;
                        saat++;
                    }
                    label1.Text = String.Format("{0:D2}", saat) + ":" + String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
                    saniye++;
                }
            }
            myReader9.Close();
        }

        private void Oynatma_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "Kaydedildi!";
        }
    }
}
