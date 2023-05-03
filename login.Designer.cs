namespace WindowsFormsApp2
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.linkLabel_quenmatkhau = new System.Windows.Forms.LinkLabel();
            this.linkLabel_dangky = new System.Windows.Forms.LinkLabel();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.textBox1_taikhoan = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1_user = new System.Windows.Forms.PictureBox();
            this.textBox2_matkhau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_user)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_quenmatkhau
            // 
            this.linkLabel_quenmatkhau.AutoSize = true;
            this.linkLabel_quenmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_quenmatkhau.Location = new System.Drawing.Point(159, 437);
            this.linkLabel_quenmatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_quenmatkhau.Name = "linkLabel_quenmatkhau";
            this.linkLabel_quenmatkhau.Size = new System.Drawing.Size(151, 25);
            this.linkLabel_quenmatkhau.TabIndex = 5;
            this.linkLabel_quenmatkhau.TabStop = true;
            this.linkLabel_quenmatkhau.Text = "Quên mật khẩu ";
            this.linkLabel_quenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_quenmatkhau_LinkClicked);
            // 
            // linkLabel_dangky
            // 
            this.linkLabel_dangky.AutoSize = true;
            this.linkLabel_dangky.Location = new System.Drawing.Point(374, 437);
            this.linkLabel_dangky.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_dangky.Name = "linkLabel_dangky";
            this.linkLabel_dangky.Size = new System.Drawing.Size(79, 22);
            this.linkLabel_dangky.TabIndex = 6;
            this.linkLabel_dangky.TabStop = true;
            this.linkLabel_dangky.Text = "Đăng Ký";
            this.linkLabel_dangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.BackColor = System.Drawing.Color.BlueViolet;
            this.button_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangnhap.Location = new System.Drawing.Point(277, 466);
            this.button_dangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(102, 57);
            this.button_dangnhap.TabIndex = 7;
            this.button_dangnhap.Text = "Đăng Nhập";
            this.button_dangnhap.UseVisualStyleBackColor = false;
            this.button_dangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_taikhoan
            // 
            this.textBox1_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_taikhoan.Location = new System.Drawing.Point(257, 289);
            this.textBox1_taikhoan.Name = "textBox1_taikhoan";
            this.textBox1_taikhoan.Size = new System.Drawing.Size(210, 38);
            this.textBox1_taikhoan.TabIndex = 8;
            this.textBox1_taikhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.Icons8_Windows_8_Security_Password_2;
            this.pictureBox3.Location = new System.Drawing.Point(162, 355);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.user_icon_150670;
            this.pictureBox2.Location = new System.Drawing.Point(162, 278);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1_user
            // 
            this.pictureBox1_user.Image = global::WindowsFormsApp2.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1_user.Location = new System.Drawing.Point(162, 16);
            this.pictureBox1_user.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1_user.Name = "pictureBox1_user";
            this.pictureBox1_user.Size = new System.Drawing.Size(305, 236);
            this.pictureBox1_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_user.TabIndex = 0;
            this.pictureBox1_user.TabStop = false;
            // 
            // textBox2_matkhau
            // 
            this.textBox2_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_matkhau.Location = new System.Drawing.Point(257, 355);
            this.textBox2_matkhau.Name = "textBox2_matkhau";
            this.textBox2_matkhau.PasswordChar = '*';
            this.textBox2_matkhau.Size = new System.Drawing.Size(210, 38);
            this.textBox2_matkhau.TabIndex = 10;
            this.textBox2_matkhau.TextChanged += new System.EventHandler(this.textBox2_matkhau_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 536);
            this.Controls.Add(this.textBox2_matkhau);
            this.Controls.Add(this.textBox1_taikhoan);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.linkLabel_dangky);
            this.Controls.Add(this.linkLabel_quenmatkhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1_user);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_user;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel_quenmatkhau;
        private System.Windows.Forms.LinkLabel linkLabel_dangky;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.TextBox textBox1_taikhoan;
        private System.Windows.Forms.TextBox textBox2_matkhau;
    }
}