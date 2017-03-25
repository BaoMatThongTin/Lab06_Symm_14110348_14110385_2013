namespace Lab06_Symm_14110348_14110385_2013
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtByteArray = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtrecoveredplaintext = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txttextString = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtplaintex = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.bntInitVector = new System.Windows.Forms.Button();
            this.bntKey = new System.Windows.Forms.Button();
            this.radRC2 = new System.Windows.Forms.RadioButton();
            this.radRijndael = new System.Windows.Forms.RadioButton();
            this.radTripleDES = new System.Windows.Forms.RadioButton();
            this.radDES = new System.Windows.Forms.RadioButton();
            this.txtinitVector = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtByteArray
            // 
            this.txtByteArray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtByteArray.Location = new System.Drawing.Point(22, 22);
            this.txtByteArray.Multiline = true;
            this.txtByteArray.Name = "txtByteArray";
            this.txtByteArray.ReadOnly = true;
            this.txtByteArray.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtByteArray.Size = new System.Drawing.Size(400, 53);
            this.txtByteArray.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDecrypt.Location = new System.Drawing.Point(680, 252);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(77, 26);
            this.btnDecrypt.TabIndex = 20;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtrecoveredplaintext
            // 
            this.txtrecoveredplaintext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrecoveredplaintext.Location = new System.Drawing.Point(22, 19);
            this.txtrecoveredplaintext.Multiline = true;
            this.txtrecoveredplaintext.Name = "txtrecoveredplaintext";
            this.txtrecoveredplaintext.ReadOnly = true;
            this.txtrecoveredplaintext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtrecoveredplaintext.Size = new System.Drawing.Size(400, 54);
            this.txtrecoveredplaintext.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtrecoveredplaintext);
            this.groupBox4.Location = new System.Drawing.Point(3, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(442, 79);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recovered Plaintext";
            // 
            // txttextString
            // 
            this.txttextString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttextString.Location = new System.Drawing.Point(22, 22);
            this.txttextString.Multiline = true;
            this.txttextString.Name = "txttextString";
            this.txttextString.ReadOnly = true;
            this.txttextString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txttextString.Size = new System.Drawing.Size(400, 53);
            this.txttextString.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txttextString);
            this.groupBox3.Location = new System.Drawing.Point(3, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 77);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ciphertext displayed as Text String";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEncrypt.Location = new System.Drawing.Point(680, 82);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(77, 26);
            this.btnEncrypt.TabIndex = 17;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtplaintex
            // 
            this.txtplaintex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtplaintex.Location = new System.Drawing.Point(22, 19);
            this.txtplaintex.Multiline = true;
            this.txtplaintex.Name = "txtplaintex";
            this.txtplaintex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtplaintex.Size = new System.Drawing.Size(400, 53);
            this.txtplaintex.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtByteArray);
            this.groupBox5.Location = new System.Drawing.Point(3, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 77);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ciphertext Displayed as Byte Array";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtplaintex);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 77);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plain Text";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(5, 153);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(216, 51);
            this.txtKey.TabIndex = 14;
            // 
            // bntInitVector
            // 
            this.bntInitVector.Location = new System.Drawing.Point(49, 219);
            this.bntInitVector.Name = "bntInitVector";
            this.bntInitVector.Size = new System.Drawing.Size(134, 26);
            this.bntInitVector.TabIndex = 13;
            this.bntInitVector.Text = "New Random Init Vector";
            this.bntInitVector.UseVisualStyleBackColor = true;
            this.bntInitVector.Click += new System.EventHandler(this.bntInitVector_Click);
            // 
            // bntKey
            // 
            this.bntKey.Location = new System.Drawing.Point(49, 120);
            this.bntKey.Name = "bntKey";
            this.bntKey.Size = new System.Drawing.Size(134, 26);
            this.bntKey.TabIndex = 12;
            this.bntKey.Text = "New Random Key";
            this.bntKey.UseVisualStyleBackColor = true;
            this.bntKey.Click += new System.EventHandler(this.bntKey_Click);
            // 
            // radRC2
            // 
            this.radRC2.AutoSize = true;
            this.radRC2.Location = new System.Drawing.Point(137, 42);
            this.radRC2.Name = "radRC2";
            this.radRC2.Size = new System.Drawing.Size(46, 17);
            this.radRC2.TabIndex = 3;
            this.radRC2.TabStop = true;
            this.radRC2.Text = "RC2";
            this.radRC2.UseVisualStyleBackColor = true;
            this.radRC2.CheckedChanged += new System.EventHandler(this.radRC2_CheckedChanged);
            // 
            // radRijndael
            // 
            this.radRijndael.AutoSize = true;
            this.radRijndael.Location = new System.Drawing.Point(8, 42);
            this.radRijndael.Name = "radRijndael";
            this.radRijndael.Size = new System.Drawing.Size(63, 17);
            this.radRijndael.TabIndex = 2;
            this.radRijndael.TabStop = true;
            this.radRijndael.Text = "Rijndael";
            this.radRijndael.UseVisualStyleBackColor = true;
            this.radRijndael.CheckedChanged += new System.EventHandler(this.radRijndael_CheckedChanged);
            // 
            // radTripleDES
            // 
            this.radTripleDES.AutoSize = true;
            this.radTripleDES.Location = new System.Drawing.Point(137, 19);
            this.radTripleDES.Name = "radTripleDES";
            this.radTripleDES.Size = new System.Drawing.Size(76, 17);
            this.radTripleDES.TabIndex = 1;
            this.radTripleDES.TabStop = true;
            this.radTripleDES.Text = "Triple DES";
            this.radTripleDES.UseVisualStyleBackColor = true;
            this.radTripleDES.CheckedChanged += new System.EventHandler(this.radTripleDES_CheckedChanged);
            // 
            // radDES
            // 
            this.radDES.AutoSize = true;
            this.radDES.Location = new System.Drawing.Point(9, 19);
            this.radDES.Name = "radDES";
            this.radDES.Size = new System.Drawing.Size(47, 17);
            this.radDES.TabIndex = 0;
            this.radDES.TabStop = true;
            this.radDES.Text = "DES";
            this.radDES.UseVisualStyleBackColor = true;
            this.radDES.CheckedChanged += new System.EventHandler(this.radDES_CheckedChanged);
            // 
            // txtinitVector
            // 
            this.txtinitVector.Location = new System.Drawing.Point(5, 252);
            this.txtinitVector.Multiline = true;
            this.txtinitVector.Name = "txtinitVector";
            this.txtinitVector.ReadOnly = true;
            this.txtinitVector.Size = new System.Drawing.Size(216, 51);
            this.txtinitVector.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRC2);
            this.groupBox1.Controls.Add(this.radRijndael);
            this.groupBox1.Controls.Add(this.radTripleDES);
            this.groupBox1.Controls.Add(this.radDES);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symmetric Algorithms";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(225, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 334);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 356);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.bntInitVector);
            this.Controls.Add(this.bntKey);
            this.Controls.Add(this.txtinitVector);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symmetric Algorithms";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtByteArray;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtrecoveredplaintext;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txttextString;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtplaintex;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button bntInitVector;
        private System.Windows.Forms.Button bntKey;
        private System.Windows.Forms.RadioButton radRC2;
        private System.Windows.Forms.RadioButton radRijndael;
        private System.Windows.Forms.RadioButton radTripleDES;
        private System.Windows.Forms.RadioButton radDES;
        private System.Windows.Forms.TextBox txtinitVector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

