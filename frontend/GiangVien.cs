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
        public GiangVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(3);
            dataGridView1.Rows[0].Cells[0].Value = "kien";
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(3);
        }
    }
}
