
namespace treciasPraktinis
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxP = new System.Windows.Forms.ComboBox();
            this.comboBoxQ = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFileRead = new System.Windows.Forms.Button();
            this.buttonFileSave = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.labelKeyPublic = new System.Windows.Forms.Label();
            this.labelKeyPrivate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Initial text:";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(713, 142);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 30);
            this.buttonDecrypt.TabIndex = 12;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(632, 142);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 30);
            this.buttonEncrypt.TabIndex = 11;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "p:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 100);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // comboBoxP
            // 
            this.comboBoxP.FormattingEnabled = true;
            this.comboBoxP.Location = new System.Drawing.Point(38, 146);
            this.comboBoxP.Name = "comboBoxP";
            this.comboBoxP.Size = new System.Drawing.Size(121, 24);
            this.comboBoxP.TabIndex = 15;
            // 
            // comboBoxQ
            // 
            this.comboBoxQ.FormattingEnabled = true;
            this.comboBoxQ.Location = new System.Drawing.Point(222, 146);
            this.comboBoxQ.Name = "comboBoxQ";
            this.comboBoxQ.Size = new System.Drawing.Size(121, 24);
            this.comboBoxQ.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "q:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Encrypted/Decrypted text:";
            // 
            // buttonFileRead
            // 
            this.buttonFileRead.Location = new System.Drawing.Point(542, 399);
            this.buttonFileRead.Name = "buttonFileRead";
            this.buttonFileRead.Size = new System.Drawing.Size(120, 30);
            this.buttonFileRead.TabIndex = 20;
            this.buttonFileRead.Text = "Import from file";
            this.buttonFileRead.UseVisualStyleBackColor = true;
            this.buttonFileRead.Click += new System.EventHandler(this.buttonFileRead_Click);
            // 
            // buttonFileSave
            // 
            this.buttonFileSave.Location = new System.Drawing.Point(668, 399);
            this.buttonFileSave.Name = "buttonFileSave";
            this.buttonFileSave.Size = new System.Drawing.Size(120, 30);
            this.buttonFileSave.TabIndex = 19;
            this.buttonFileSave.Text = "Save to file";
            this.buttonFileSave.UseVisualStyleBackColor = true;
            this.buttonFileSave.Click += new System.EventHandler(this.buttonFileSave_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 218);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(776, 168);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            // 
            // labelKeyPublic
            // 
            this.labelKeyPublic.AutoSize = true;
            this.labelKeyPublic.Location = new System.Drawing.Point(110, 389);
            this.labelKeyPublic.Name = "labelKeyPublic";
            this.labelKeyPublic.Size = new System.Drawing.Size(100, 17);
            this.labelKeyPublic.TabIndex = 22;
            this.labelKeyPublic.Text = "labelKeyPublic";
            // 
            // labelKeyPrivate
            // 
            this.labelKeyPrivate.AutoSize = true;
            this.labelKeyPrivate.Location = new System.Drawing.Point(110, 406);
            this.labelKeyPrivate.Name = "labelKeyPrivate";
            this.labelKeyPrivate.Size = new System.Drawing.Size(106, 17);
            this.labelKeyPrivate.TabIndex = 23;
            this.labelKeyPrivate.Text = "labelKeyPrivate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Public Key:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Private Key:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelKeyPrivate);
            this.Controls.Add(this.labelKeyPublic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFileRead);
            this.Controls.Add(this.buttonFileSave);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.comboBoxQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxP;
        private System.Windows.Forms.ComboBox comboBoxQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFileRead;
        private System.Windows.Forms.Button buttonFileSave;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label labelKeyPublic;
        private System.Windows.Forms.Label labelKeyPrivate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

