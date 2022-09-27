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
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
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

        public static bool sifreKontrol(string sifre)
        {
            if (sifre.Length > 5 && sifre.Length < 21)
            {
                return true;
            }
            else
            {
                
                return false;
            }
                
        }
        private void runQuery()
        {
            string MySQLConnectionString = "Datasource=127.0.0.1;port=3306;username=root;password=;database=netflixdb;";
            string girilenAd = txtAd.Text;
            string girilenEmail = txtEmail.Text;
            string girilenSifre = txtSifre.Text;
            string girilenDogumTarihi = txtDogum.Text;
            string Query = $"INSERT INTO `kullanici` (`k_name`, `k_mail`, `k_pwd`, `k_birthday`) VALUES ('{girilenAd}', '{girilenEmail}', '{girilenSifre}', '{girilenDogumTarihi}');";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(Query, databaseConnection);
            databaseConnection.Open();

            try
            {
                emailKontrol(girilenEmail);
                sifreKontrol(girilenSifre);
                if (emailKontrol(girilenEmail) && sifreKontrol(girilenSifre))
                {
                    MySqlDataReader myReader = command.ExecuteReader();
                    MessageBox.Show("Başarıyla kayıt oldunuz! Favori tür seçme ekranına yönlendiriliyorsunuz...","Kayıt Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    FavoriForm favoriForm = new FavoriForm();
                    favoriForm.Show();
                    this.Hide();
                }
                else if(emailKontrol(girilenEmail) == true && sifreKontrol(girilenSifre) == false)
                {
                    MessageBox.Show("Şifreniz en az 6, en fazla 20 karakterden oluşmalıdır.","Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (emailKontrol(girilenEmail) == false && sifreKontrol(girilenSifre) == true)
                {
                    MessageBox.Show("Girdiğiniz e-mail doğru formatta değil !","Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("E-Posta ve şifreniz belirlenen kriterleri karşılamıyor.","Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch 
            {

                MessageBox.Show("Girilen e-mail zaten kayıtlı !","Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void KayitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            txtDogum.Text = monthCalendar1.SelectionStart.ToString().Substring(0,10);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                monthCalendar1.Visible = true;
            }
            else
            {
                monthCalendar1.Visible = false;
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
