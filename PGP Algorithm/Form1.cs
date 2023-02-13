using PGP_Algorithm.PGP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGP_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_createKey_Click(object sender, EventArgs e)
        {
            PGP.KeysForPGPEncryptionDecryption.GenerateKey(txt_email.Text, txt_password.Text, Application.StartupPath + "\\");
            txt_privateKey.Text = File.ReadAllText("PGPPrivateKey.asc");
            txt_Publickey.Text = File.ReadAllText("PGPPublicKey.asc");
            MessageBox.Show("Create public key and private key successful!");
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {         
            PgpEncryptionKeys encryptionKeys = new PgpEncryptionKeys("PGPPublicKey.asc", "PGPPrivateKey.asc", txt_password.Text);
            PgpEncrypt encrypter = new PgpEncrypt(encryptionKeys);
            using (Stream outputStream = File.Create("EncryptData.txt"))
            {
                encrypter.EncryptAndSign(outputStream, new FileInfo(txt_file.Text));

            }
                txt_encrypt.Text = File.ReadAllText("EncryptData.txt");
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txt_file.Text = dlg.FileName;
                txt_input.Text = File.ReadAllText(dlg.FileName);
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            PGPDecrypt.Decrypt("EncryptData.txt", @"PGPPrivateKey.asc", txt_password.Text, "OriginalText.txt");
            txt_decrypt.Text = File.ReadAllText("OriginalText.txt");
        }
    }
}
