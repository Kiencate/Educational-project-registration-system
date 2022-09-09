using frontend.Properties;
using Nancy.Json;
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
        string type_project;
        public string id;
        public SinhVien(string id)
        {
            this.id = id;
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

        private async void hocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            type_project = hocPhan.SelectedItem.ToString();
            var responce = await RestHelper.GetNameGV();
            JavaScriptSerializer js = new JavaScriptSerializer();
            DataTeacher[] data_final = js.Deserialize<DataTeacher[]>(responce);
            GV1.Items.Clear();
            GV2.Items.Clear();
            GV3.Items.Clear();
            for (int i =0; i< data_final.Length; i++)
            {
                GV1.Items.Add(data_final[i].Name);
                GV2.Items.Add(data_final[i].Name);
                GV3.Items.Add(data_final[i].Name);
            }

            var project = await RestHelper.GetProjectStudent(id, type_project);
            JavaScriptSerializer js1 = new JavaScriptSerializer();
            Project_Teacher[] data_project = js1.Deserialize<Project_Teacher[]>(project);

            if (data_project.Length > 0) 
            { 
                GV1.SelectedIndex = data_project[0].teacherId - 1;
                int idgv = data_project[0].teacherId;
                DeTai1.Items.Clear();
                var responce1 = await RestHelper.GetProjectTeacher(idgv, type_project, false);
                JavaScriptSerializer js2 = new JavaScriptSerializer();
                Project[] data_final1 = js2.Deserialize<Project[]>(responce1);
                for (int i = 0; i < data_final1.Length; i++)
                {
                    if (data_final1[i].ID == data_project[0].projectId)
                        DeTai1.SelectedIndex = i;
                }

            }
            if (data_project.Length > 1)
            {
                GV2.SelectedIndex = data_project[1].teacherId - 1;
                int idgv1 = data_project[1].teacherId;
                DeTai2.Items.Clear();
                var responce2 = await RestHelper.GetProjectTeacher(idgv1, type_project, false);
                JavaScriptSerializer js2 = new JavaScriptSerializer();
                Project[] data_final2 = js2.Deserialize<Project[]>(responce2);
                for (int i = 0; i < data_final2.Length; i++)
                {
                    if (data_final2[i].ID == data_project[1].projectId)
                        DeTai2.SelectedIndex = i;
                }
            }
            if (data_project.Length > 2)
            {
                GV3.SelectedIndex = data_project[2].teacherId - 1;
                int idgv2 = data_project[2].teacherId;
                DeTai3.Items.Clear();
                var responce3 = await RestHelper.GetProjectTeacher(idgv2, type_project, false);
                JavaScriptSerializer js3 = new JavaScriptSerializer();
                Project[] data_final3 = js3.Deserialize<Project[]>(responce3);
                for (int i = 0; i < data_final3.Length; i++)
                {
                    if (data_final3[i].ID == data_project[1].projectId)
                        DeTai2.SelectedIndex = i;
                }
            }

            //var final_result = JsonConvert.DeserializeObject<String>(teacher);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void editNV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GV1.SelectedItem.ToString());
        }

        private async void GV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idgv = GV1.SelectedIndex + 1;
            DeTai1.Items.Clear();
            var responce = await RestHelper.GetProjectTeacher(idgv,type_project,false);
            JavaScriptSerializer js = new JavaScriptSerializer();
            Project[] data_final = js.Deserialize<Project[]>(responce);
            for (int i = 0; i < data_final.Length; i++)
            {
                if (data_final[i]!= null)
                DeTai1.Items.Add(data_final[i].name);
            }
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

        private void SinhVien_Load(object sender, EventArgs e)
        {

        }

        private void DeTai1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void GV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idgv = GV2.SelectedIndex + 1;
            DeTai2.Items.Clear();
            var responce = await RestHelper.GetProjectTeacher(idgv, type_project, false);
            JavaScriptSerializer js = new JavaScriptSerializer();
            Project[] data_final = js.Deserialize<Project[]>(responce);
            for (int i = 0; i < data_final.Length; i++)
            {
                if (data_final[i] != null)
                    DeTai2.Items.Add(data_final[i].name);
            }
        }

        private async void saveNV_Click(object sender, EventArgs e)
        {
            if (type_project != null)
            {           
                int numNV = 0;
                if (GV1.SelectedIndex >= 0 && DeTai1.SelectedIndex >= 0) numNV += 1;
                if (GV2.SelectedIndex >= 0 && DeTai2.SelectedIndex >= 0) numNV += 1;
                if (GV3.SelectedIndex >= 0 && DeTai3.SelectedIndex >= 0) numNV += 1;

               
                if (numNV > 0)
                {
                    Project_Student[] prj = new Project_Student[numNV];

                    int i = 0;
                    if (GV1.SelectedIndex >= 0 && DeTai1.SelectedIndex >= 0)
                    {
                        int idgv = GV1.SelectedIndex + 1;
                        var responce = await RestHelper.GetProjectTeacher(idgv, type_project, false);
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        Project[] data_final = js.Deserialize<Project[]>(responce);
                        prj[i] = new Project_Student();
                        prj[i].IDstudent = int.Parse(id);
                        prj[i].IDproject = data_final[DeTai1.SelectedIndex].ID;
                        i++;
                    }
                    if (GV2.SelectedIndex >= 0 && DeTai2.SelectedIndex >= 0)
                    {
                        int idgv = GV2.SelectedIndex + 1;
                        var responce = await RestHelper.GetProjectTeacher(idgv, type_project, false);
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        Project[] data_final = js.Deserialize<Project[]>(responce);
                        prj[i] = new Project_Student();
                        prj[i].IDstudent = int.Parse(id);
                        prj[i].IDproject = data_final[DeTai2.SelectedIndex].ID;
                        i++;
                    }
                    if (GV3.SelectedIndex >= 0 && DeTai3.SelectedIndex >= 0)
                    {
                        int idgv = GV3.SelectedIndex + 1;
                        var responce = await RestHelper.GetProjectTeacher(idgv, type_project, false);
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        Project[] data_final = js.Deserialize<Project[]>(responce);
                        prj[i] = new Project_Student();
                        prj[i].IDstudent = int.Parse(id);
                        prj[i].IDproject = data_final[DeTai3.SelectedIndex].ID;
                        i++;
                    }
                    //var json = JsonConvert.SerializeObject(prj);
                    var result = RestHelper.student_assign_project(prj);
                    saveNV.BackColor = System.Drawing.Color.Tan;
                    MessageBox.Show("Đăng ký thành công");

                }
                else
                {
                    Project_Student[] prj = new Project_Student[1];
                    prj[0] = new Project_Student();
                    prj[0].IDstudent = int.Parse(id);
                    var result = RestHelper.student_assign_project(prj);
                    saveNV.BackColor = System.Drawing.Color.Tan;
                    MessageBox.Show("Xoá nguyện vọng thành công");

                }


            }
            
        }
            

        private async void GV3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idgv = GV3.SelectedIndex + 1;
            DeTai3.Items.Clear();
            var responce = await RestHelper.GetProjectTeacher(idgv, type_project, false);
            JavaScriptSerializer js = new JavaScriptSerializer();
            Project[] data_final = js.Deserialize<Project[]>(responce);
            for (int i = 0; i < data_final.Length; i++)
            {
                if (data_final[i] != null)
                    DeTai3.Items.Add(data_final[i].name);
            }
        }
    }
}
