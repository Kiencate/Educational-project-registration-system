using frontend.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{

    public partial class App : Form
    {
        private int chucVu = 0;
        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hidePassword.Checked)
                password.UseSystemPasswordChar = false;
            else
                password.UseSystemPasswordChar= true;
        }
        private async void submit_Click(object sender, EventArgs e)
        {
            if (chucVu == 0) MessageBox.Show("Chưa chọn chức vụ", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (userName.Text == "") MessageBox.Show("Tên đăng nhập trống", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (password.Text == "") MessageBox.Show("Mật khẩu trống", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    var Result = await RestHelper.Submit(userName.Text, password.Text);
                    var data_final = JsonConvert.DeserializeObject<ResultSubmit>(Result);
                    if (data_final.checking == "true")
                    {
                        switch (chucVu)
                        {
                            case 1:
                                SinhVien sinhvien = new SinhVien(data_final.id);
                                sinhvien.Show();
                                this.Hide();
                                break;
                            case 2:
                                GiangVien giangvien = new GiangVien(data_final.id);
                                giangvien.Show();
                                this.Hide();
                                break;
                            case 3:
                                GiaoVu giaovu = new GiaoVu();
                                giaovu.Show();
                                this.Hide();
                                break;
                        }
                    }
                    else { MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                catch (Exception a)
                {
                    MessageBox.Show("Server không phản hồi");
                }
            }
        }
        private void sinhVien_CheckedChanged(object sender, EventArgs e)
        {
            chucVu = 1;
        }

        private void giangVien_CheckedChanged(object sender, EventArgs e)
        {
            chucVu = 2;
        }

        private void giaoVu_CheckedChanged(object sender, EventArgs e)
        {
            chucVu = 3;
        }
    }
}
