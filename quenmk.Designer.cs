namespace WindowsFormsApp2
{
    partial class quenmk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quenmk));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_emaildangky = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_laylaimatkhau = new System.Windows.Forms.Button();
            this.pictureBox1_user = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(27, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email đăng ký:";
            // 
            // textBox_emaildangky
            // 
            this.textBox_emaildangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emaildangky.Location = new System.Drawing.Point(237, 252);
            this.textBox_emaildangky.Name = "textBox_emaildangky";
            this.textBox_emaildangky.Size = new System.Drawing.Size(197, 30);
            this.textBox_emaildangky.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(27, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả:";
            // 
            // button_laylaimatkhau
            // 
            this.button_laylaimatkhau.BackColor = System.Drawing.Color.BlueViolet;
            this.button_laylaimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_laylaimatkhau.ForeColor = System.Drawing.Color.SeaShell;
            this.button_laylaimatkhau.Location = new System.Drawing.Point(148, 390);
            this.button_laylaimatkhau.Name = "button_laylaimatkhau";
            this.button_laylaimatkhau.Size = new System.Drawing.Size(166, 33);
            this.button_laylaimatkhau.TabIndex = 4;
            this.button_laylaimatkhau.Text = "Lấy lại mật khẩu";
            this.button_laylaimatkhau.UseVisualStyleBackColor = false;
            this.button_laylaimatkhau.Click += new System.EventHandler(this.button_laylaimatkhau_Click);
            // 
            // pictureBox1_user
            // 
            this.pictureBox1_user.Image = global::WindowsFormsApp2.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1_user.Location = new System.Drawing.Point(113, 26);
            this.pictureBox1_user.Name = "pictureBox1_user";
            this.pictureBox1_user.Size = new System.Drawing.Size(246, 191);
            this.pictureBox1_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1_user.TabIndex = 0;
            this.pictureBox1_user.TabStop = false;
            //this.pictureBox1_user.Click += new System.EventHandler(this.);
            // 
            // quenmk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.button_laylaimatkhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_emaildangky);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "quenmk";
            this.Text = "quenmk";
            //this.Load += new System.EventHandler(this.quenmk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_emaildangky;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_laylaimatkhau;
    }
}