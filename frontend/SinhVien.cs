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
    public partial class SinhVien : Form
    {
        public SinhVien(string id)
        {
            InitializeComponent();
            

        }

        private void SinhVien_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void edit_Click(object sender, EventArgs e)
        {
            
            save.BackColor =  System.Drawing.Color.ForestGreen;
        }

        private void save_Click(object sender, EventArgs e)
        {
            save.BackColor = System.Drawing.Color.Tan;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void hocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mon = hocPhan.SelectedIndex;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void editNV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox3.SelectedItem.ToString());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gv = comboBox3.SelectedItem.ToString();
            comboBox6.Items.Clear();
            object[] detai = {"Project 1",
            "Project 2",
            "Project 3",
            "Thực tập tốt nghiệp",
            "Đồ án tốt nghiệp"};
            comboBox6.Items.AddRange(detai
            );
        }
    }
}
