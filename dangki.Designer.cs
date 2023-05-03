namespace WindowsFormsApp2
{
    partial class dangki
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1_tendangnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_matkhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3_xnmatkhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4_email = new System.Windows.Forms.TextBox();
            this.button_dangnhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(171, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1_tendangnhap
            // 
            this.textBox1_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_tendangnhap.Location = new System.Drawing.Point(270, 241);
            this.textBox1_tendangnhap.Name = "textBox1_tendangnhap";
            this.textBox1_tendangnhap.Size = new System.Drawing.Size(286, 30);
            this.textBox1_tendangnhap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu:";
            // 
            // textBox2_matkhau
            // 
            this.textBox2_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_matkhau.Location = new System.Drawing.Point(270, 293);
            this.textBox2_matkhau.Name = "textBox2_matkhau";
            this.textBox2_matkhau.PasswordChar = '*';
            this.textBox2_matkhau.Size = new System.Drawing.Size(286, 30);
            this.textBox2_matkhau.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(12, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // textBox3_xnmatkhau
            // 
            this.textBox3_xnmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_xnmatkhau.Location = new System.Drawing.Point(270, 338);
            this.textBox3_xnmatkhau.Name = "textBox3_xnmatkhau";
            this.textBox3_xnmatkhau.PasswordChar = '*';
            this.textBox3_xnmatkhau.Size = new System.Drawing.Size(286, 30);
            this.textBox3_xnmatkhau.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(12, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // textBox4_email
            // 
            this.textBox4_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_email.Location = new System.Drawing.Point(270, 388);
            this.textBox4_email.Name = "textBox4_email";
            this.textBox4_email.Size = new System.Drawing.Size(286, 30);
            this.textBox4_email.TabIndex = 8;
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.BackColor = System.Drawing.Color.BlueViolet;
            this.button_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangnhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_dangnhap.Location = new System.Drawing.Point(196, 451);
            this.button_dangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(191, 69);
            this.button_dangnhap.TabIndex = 10;
            this.button_dangnhap.Text = "Đăng Ký";
            this.button_dangnhap.UseVisualStyleBackColor = false;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangky_Click);
            // 
            // dangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 652);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3_xnmatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_matkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_tendangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Name = "dangki";
            this.Text = "dangki";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1_tendangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_matkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3_xnmatkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4_email;
        private System.Windows.Forms.Button button_dangnhap;
    }
}