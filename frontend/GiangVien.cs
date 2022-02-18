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
    public partial class GiangVien : Form
    {
        public string id;
        public GiangVien(string id)
        {
            this.id = id;
            InitializeComponent();
            updateInfo(id);
        }
        private void GiangVien_Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            listPRJ.Rows.Clear();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            listPRJ.Rows.Add(3);
            listPRJ.Rows[0].Cells[0].Value = "kien";
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(3);
        }

        private void GiangVien_Load(object sender, EventArgs e)
        {

        }

        private void editNV_Click(object sender, EventArgs e)
        {
            listPRJ.ReadOnly = false;
            saveNV.BackColor = System.Drawing.Color.ForestGreen; 
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            App app = new App();
            app.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveNV_Click(object sender, EventArgs e)
        {
            if (hocPhan.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn học phần");
            }
            else
            {
                int num = listPRJ.RowCount - 1;
                Project[] prj = new Project[num];
                for (int i = 0; i < num; i++)
                {
                    prj[i] = new Project();
                    prj[i].name = listPRJ.Rows[i].Cells[0].Value.ToString();
                    prj[i].type = hocPhan.SelectedItem.ToString();
                    prj[i].ID = id;
                }
                //var json = JsonConvert.SerializeObject(prj);
                var result = RestHelper.PostProject(prj);
                saveNV.BackColor = System.Drawing.Color.Tan;
                MessageBox.Show(result.ToString());
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
