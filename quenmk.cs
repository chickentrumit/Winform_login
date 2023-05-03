using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class quenmk : Form
    {
        public quenmk()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();

        private void button_laylaimatkhau_Click(object sender, EventArgs e)
        {
            string email = textBox_emaildangky.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui Lòng nhập email đăng kí!:"); }
            else
            {
                string query = "select * from TaiKhoan where Email = '" + email + "' ";
                if(modify.TaiKhoans(query).Count() != 0) {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật Khẩu: " + modify.TaiKhoans(query)[0].Matkhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng kí";
                }
            }

        }
    }
}
