namespace PGP_Algorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_createKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_privateKey = new System.Windows.Forms.TextBox();
            this.txt_Publickey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_encrypt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_decrypt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.btn_browser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password key: ";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(120, 68);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(284, 20);
            this.txt_email.TabIndex = 2;
            this.txt_email.Text = "ThaoMeo";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(120, 99);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(284, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.Text = "laptrinhvb";
            // 
            // btn_createKey
            // 
            this.btn_createKey.Location = new System.Drawing.Point(421, 67);
            this.btn_createKey.Name = "btn_createKey";
            this.btn_createKey.Size = new System.Drawing.Size(142, 56);
            this.btn_createKey.TabIndex = 4;
            this.btn_createKey.Text = "Generate Key";
            this.btn_createKey.UseVisualStyleBackColor = true;
            this.btn_createKey.Click += new System.EventHandler(this.btn_createKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Private key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Public key:";
            // 
            // txt_privateKey
            // 
            this.txt_privateKey.Location = new System.Drawing.Point(589, 320);
            this.txt_privateKey.Multiline = true;
            this.txt_privateKey.Name = "txt_privateKey";
            this.txt_privateKey.Size = new System.Drawing.Size(392, 212);
            this.txt_privateKey.TabIndex = 7;
            // 
            // txt_Publickey
            // 
            this.txt_Publickey.Location = new System.Drawing.Point(588, 86);
            this.txt_Publickey.Multiline = true;
            this.txt_Publickey.Name = "txt_Publickey";
            this.txt_Publickey.Size = new System.Drawing.Size(392, 212);
            this.txt_Publickey.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Input Text:";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(25, 162);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(538, 102);
            this.txt_input.TabIndex = 10;
            // 
            // txt_encrypt
            // 
            this.txt_encrypt.Location = new System.Drawing.Point(25, 295);
            this.txt_encrypt.Multiline = true;
            this.txt_encrypt.Name = "txt_encrypt";
            this.txt_encrypt.Size = new System.Drawing.Size(538, 102);
            this.txt_encrypt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Encrypt Text:";
            // 
            // txt_decrypt
            // 
            this.txt_decrypt.Location = new System.Drawing.Point(25, 428);
            this.txt_decrypt.Multiline = true;
            this.txt_decrypt.Name = "txt_decrypt";
            this.txt_decrypt.Size = new System.Drawing.Size(538, 102);
            this.txt_decrypt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Decrypt Text:";
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(488, 270);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 15;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(488, 401);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_decrypt.TabIndex = 16;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(382, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "PGP Algorithm C#";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PGP_Algorithm.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(29, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PGP_Algorithm.Properties.Resources.PGP_Encryption_300x140;
            this.pictureBox1.Location = new System.Drawing.Point(725, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(120, 135);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(284, 20);
            this.txt_file.TabIndex = 20;
            // 
            // btn_browser
            // 
            this.btn_browser.Location = new System.Drawing.Point(421, 133);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(75, 23);
            this.btn_browser.TabIndex = 21;
            this.btn_browser.Text = "Browser...";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btn_browser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 534);
            this.Controls.Add(this.btn_browser);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.txt_decrypt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_encrypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Publickey);
            this.Controls.Add(this.txt_privateKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_createKey);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Encrypt and Decrypt with PGP Algorithm C# - https://laptrinhvb.net";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_createKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_privateKey;
        private System.Windows.Forms.TextBox txt_Publickey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_encrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_decrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Button btn_browser;
    }
}

