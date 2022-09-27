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
using System.Net.Mail;

namespace movieapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string gonderilecekEmail;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            runQuery();
        }
        public static bool emailKontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                
                return false;
            }
        }
        private void runQuery()
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            string girilenEmail = txtEmail.Text;
            gonderilecekEmail = girilenEmail;
            string girilenSifre = txtSifre.Text;
            string firstQuery = $"SELECT k_mail,k_pwd FROM kullanici WHERE k_mail= '{girilenEmail}' AND k_pwd = '{girilenSifre}'";
            string secondQuery = $"SELECT k_mail FROM kullanici WHERE k_mail= '{girilenEmail}'";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command1 = new MySqlCommand(firstQuery, databaseConnection);
            MySqlCommand command = new MySqlCommand(secondQuery, databaseConnection);
            databaseConnection.Open();
            try
            { 
                MySqlDataReader myReader = command.ExecuteReader();
                if (myReader.HasRows)
                {
                    myReader.Close();
                    try
                    { 
                        myReader = command1.ExecuteReader();
                        if (myReader.HasRows)
                        {
                            MessageBox.Show("Başarıyla giriş yapıldı.","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Anasayfa anasayfa = new Anasayfa();
                            anasayfa.Show();
                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("Şifrenizi hatalı girdiniz, tekrar deneyiniz.","Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Hata.. Sebebi => " + e);
                    }
                }
                else if(emailKontrol(girilenEmail))
                {
                    MessageBox.Show("Girdiğiniz E-Posta veritabanında bulunamadı. Kayıt sayfasına yönlendiriliyorsunuz...","Yönlendiriliyor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KayitForm kayitForm = new KayitForm();
                    kayitForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Girilen e-mail formatı doğru değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata.. Sebebi => " + e);
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                runQuery();
            }

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                runQuery();
            }
        }
    }   
}
