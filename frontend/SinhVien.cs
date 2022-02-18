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
    public partial class SinhVien : Form
    {
        public SinhVien(string id)
        {
            InitializeComponent();
            updateInfo(id);

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
            Phone.ReadOnly = false;
            Email.ReadOnly = false;
            Address.ReadOnly = false;
            save.BackColor =  System.Drawing.Color.ForestGreen;
        }

        private async void save_Click(object sender, EventArgs e)
        {
            var result = await RestHelper.EditInfoSV(ID.Text,Phone.Text, Email.Text, Address.Text);
            var final_result = JsonConvert.DeserializeObject<Project>(result);
            if(final_result.name=="true") MessageBox.Show("Cập nhật thành công","", MessageBoxButtons.OK);
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
            MessageBox.Show(GV1.SelectedItem.ToString());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gv = GV1.SelectedItem.ToString();
            DeTai1.Items.Clear();
            object[] detai = {"Project 1",
            "Project 2",
            "Project 3",
            "Thực tập tốt nghiệp",
            "Đồ án tốt nghiệp"};
            DeTai1.Items.AddRange(detai
            );
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showTeacher_Click(object sender, EventArgs e)
        {
            DataGridView listTeacher = new DataGridView();

        }
    }
}
