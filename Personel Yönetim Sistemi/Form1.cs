using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Yönetim_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkSifreyiGosterGizle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreyiGosterGizle.Checked)
            {
                txtSifre.PasswordChar = '\0'; // Şifreyi göster
            }
            else
            {
                txtSifre.PasswordChar = '*'; // Şifreyi gizle
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // Girilen şifreyi kontrol et ve doğruysa Form2'yi aç
            if (txtSifre.Text == "isyeri123")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); // Form1'i gizle
            }
            else
            {
                MessageBox.Show("Hatalı şifre! Lütfen tekrar deneyin.");
            }
        }
    }
}


