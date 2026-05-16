using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressWindowsFormApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void EpostaTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string eposta = EpostaTextEdit.Text;
            string sifre = PasswordTextEdit.Text;


            var context = new AppDbContext();

            var kullanici = context.Kullanicilar.FirstOrDefault(k => k.EPosta == eposta);

            if (kullanici != null)
            {
                
                if (kullanici.Sifre == sifre)
                {
                    MessageBox.Show("Giriş Başarılı! Hoşgeldiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Şifre hatalı! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
            }
            else
            {
                
                MessageBox.Show("Böyle bir e-posta adresi sistemde bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }





        }

        private void PasswordTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
