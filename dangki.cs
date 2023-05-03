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
    public partial class dangki : Form
    {
        public dangki()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void button_dangky_Click(object sender, EventArgs e)
        {
            string tentk = textBox1_tendangnhap.Text;
            string matkhau = textBox2_matkhau.Text;
            string xnmatkhau = textBox3_xnmatkhau.Text;
            string email = textBox4_email.Text;
            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản từ 6 đến 24 kí tự,với các kí tự chữ và số , chữ hoa chữ thường"); return; }
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập matkhau từ 6 đến 24 kí tự,với các kí tự chữ và số , chữ hoa chữ thường"); return; }
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("vui lòng nhập đúng dịnh dạng email!"); return; }
            if (modify.TaiKhoans("select * from TaiKhoan where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký vui lòng đăng ký email khác!"); return; }
            try
            {
                string query = "insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if(MessageBox.Show("Đăng ký thành công! bạn có muốn đăng nhập luôn không","thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
                

            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí,vui lòng đăng kí tên tài khoản khác!");
            }

        }
    }
}
