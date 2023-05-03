using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangki dangky = new dangki();
            dangky.ShowDialog();


        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox1_taikhoan.Text;
            string matkhau = textBox2_matkhau.Text;
            if(tentk.Trim()=="") { MessageBox.Show("vui long nhap tên tài khoản!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else if(matkhau.Trim()=="") { MessageBox.Show("vui long nhap mật khẩu!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);  }
            else
            {
                string query = "Select * from TaiKhoan where tendangnhap = '" + tentk + "' and matkhau = '" + matkhau + "' ";
                if (modify.TaiKhoans(query).Count !=0)
                {
                    MessageBox.Show("Đăng Nhập thành công!","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Home home = new Home(); 
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tai khoan va mat khau không hợp lệ!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenmk quenmatkhau = new quenmk();
            quenmatkhau.ShowDialog();
        }

        private void textBox2_matkhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
