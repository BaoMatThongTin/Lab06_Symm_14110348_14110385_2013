using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnEncrypted_Click(object sender, EventArgs e)
        {
            if (this.radRC2.Checked)
            {
                //symmAthm.setKey(key);
                //symmAthm.setIV(iv);
                string plainText = "Nguyen Tuan Kiet";
                byte[] encrypted = symmAthm.encrypt(plainText, key, iv);
                this.txttextString.Text = BitConverter.ToString(encrypted);
                this.txtrecoveredplaintext.Text = symmAthm.decrypt(encrypted, key, iv);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
