using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpressWindowsFormApp1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string username = UsernameTextEdit.Text;

            if (username.Length < 3)
            {
                MessageBox.Show("Kullanıcı adınız en az 3 karakterden oluşmalıdır. ", "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (username.Length > 20)
            {
                MessageBox.Show("Kullanıcı adınız en falza 20 karakterden oluşmalıdır. ", "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Regex.IsMatch(username, "^[a-zA-Z0-9ğüşıöçĞÜŞİÖÇ]+$")) // bu kısım semboller hariç tüm karakterlere izin verir. regex kullanarak yapıyoruz.
            {
                MessageBox.Show("Kullanıcı adınız sembol/özel karakter içermemelidir. ", "Geçersiz Kullanıcı Adı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string eposta = EpostaTextEdit.Text;

            if (!Regex.IsMatch(eposta, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Geçersiz E-posta girdiniz! ", "Geçersiz E-posta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }








            string password = PasswordTextEdit.Text;
            string passwordAgain = PasswordAgainTextEdit.Text;

            if (password != passwordAgain)
            {
                MessageBox.Show("Hayır şifreler uyuşmuyor!", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordAgain))
            {

                MessageBox.Show("Şifre boş olamaz.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (password.Length < 10 || password.Length > 25)
            {

                MessageBox.Show("Şifreniz 10 karakterden kısa, 25 karakterden uzun olmamalıdır.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hesap başarıyla oluşturuldu.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            DateTime birthDateTime = BirthDateEdit.DateTime;

            if (birthDateTime == DateTime.MinValue)
            {
                MessageBox.Show("Lütfen bir doğum tarihi seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime onSekizYilOncesi = DateTime.Today.AddYears(-18);

            if(birthDateTime >= onSekizYilOncesi)
            {
                MessageBox.Show("18 yaşından büyük olmalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            using (var context = new AppDbContext()) 
            {
                var yeniKullanici = new Kullanici
                {
                    KullaniciAdi = username, 
                    EPosta = eposta,
                    Sifre = password,
                    DogumTarihi = birthDateTime
                };
                context.Kullanicilar.Add(yeniKullanici); 
                context.SaveChanges(); 
            }
            
            MessageBox.Show("Hesap başarıyla oluşturuldu ve veritabanına kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        

        private void labelControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void EpostaTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
