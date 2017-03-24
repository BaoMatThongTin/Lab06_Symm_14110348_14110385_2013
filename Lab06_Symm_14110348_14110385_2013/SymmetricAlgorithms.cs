using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Symm_14110348_14110385_2013
{
    public partial class Form1 : Form
    {
        ISymmetricAthm symmAthm;
        byte[] key;
        byte[] iv;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = "Nguyễn Tuấn Kiệt";
            byte[] encrypted = symmAthm.encrypt(plainText, key, iv);
            foreach (byte b in encrypted)
            {
                this.txttextString.Text += b.ToString() + " ";
            }
            //this.txttextString.Text = System.Text.Encoding.Unicode.GetString(encrypted);
            this.txtByteArray.Text = BitConverter.ToString(encrypted);
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptText = this.txtByteArray.Text;
            string[] tempt = encryptText.Split('-');
            byte[] encrypted = new byte[tempt.Length];
            int i = 0;
            foreach (string s in tempt)
            {
                encrypted[i] = Convert.ToByte(Convert.ToInt32(s, 16));
                i++;
            }
            this.txtrecoveredplaintext.Text = symmAthm.decrypt(encrypted, key, iv);
        }

        private void bntKey_Click(object sender, EventArgs e)
        {
            if (this.radRC2.Checked)
            {
                symmAthm = new RC2();
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(symmAthm.getKey());
            }
        }

        private void bntInitVector_Click(object sender, EventArgs e)
        {
            if (this.radRC2.Checked)
            {
                symmAthm = new RC2();
                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(symmAthm.getIV());
            }
        }

        private void radRC2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radRC2.Checked)
            {
                symmAthm = new RC2();
                iv = symmAthm.getIV();
                this.txtinitVector.Text = BitConverter.ToString(symmAthm.getIV());
                key = symmAthm.getKey();
                this.txtKey.Text = BitConverter.ToString(symmAthm.getKey());
            }
        }


    }
}
