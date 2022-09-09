
using frontend.Properties;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace frontend
{
    partial class GiangVien
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
        private async void updateInfo(string id)
        {
            try
            {
                var responce = await RestHelper.GetInfoGV(id);
                //textBox1.Text = RestHelper.BeautifyJson(responce);

                JavaScriptSerializer js = new JavaScriptSerializer();
                DataTeacher[] data_final = js.Deserialize<DataTeacher[]>(responce);

                Name.Text = data_final[0].Name;
                Email.Text = data_final[0].Email;
                Id.Text = data_final[0].ID;
                Phone.Text = data_final[0].Phone;
                Address.Text = data_final[0].Address;
                LabRoom.Text = data_final[0].LabRoom;
            }

            catch (Exception a)
            {
                MessageBox.Show("Lỗi nhận data về thông tin giảng viên ");
            }

        }
        private async void updateMark(string id)
        {
            string type = "projectFinal";
            listSV.Rows.Clear();
            var responce = await RestHelper.GetProjectTeacher(int.Parse(id), type, true);
            JavaScriptSerializer js = new JavaScriptSerializer();
            Project[] data_final = js.Deserialize<Project[]>(responce);

            for (int i = 0; i < 10; i++)
            {
                listSV.Rows.Add();
            }

            int Studentindex = 0;
            for (int i = 0; i < data_final.Length; i++)
            {
                

                var resuser1 = await RestHelper.GetStudentFromProject(data_final[i].ID.ToString());
                if (resuser1 != null)
                {
                    JavaScriptSerializer js2 = new JavaScriptSerializer();
                    DataUser[] data_final2 = js2.Deserialize<DataUser[]>(resuser1);
                    if (data_final2 != null)
                    {
                            for (int j = 0; j < data_final2.Length; j++)
                            {
                                listSV.Rows[Studentindex].Cells[0].Value = "Đồ án tốt nghiệp";
                                listSV.Rows[Studentindex].Cells[1].Value = data_final[i].name;
                                listSV.Rows[Studentindex].Cells[2].Value = data_final2[j].ID;
                                listSV.Rows[Studentindex].Cells[3].Value = data_final2[j].Name;
                                Studentindex += 1;
                            }
                    }
                }
            }
                

            //for (int i = 0; i < data_final.Length; i++)
            //{
            //    listPRJ.Rows[i].Cells[0].Value = "Đồ án tốt nghiệp";
            //    listPRJ.Rows[i].Cells[1].Value = data_final[i].name;
            //    listPRJ.Rows[i].Cells[1].Value = data_final[i].numStudent;
            //}
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabRoom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.logOut = new CustomButton.VBButton();
            this.save = new CustomButton.VBButton();
            this.edit = new CustomButton.VBButton();
            this.changePassword = new CustomButton.VBButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listPRJ = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.saveNV = new CustomButton.VBButton();
            this.editNV = new CustomButton.VBButton();
            this.hocPhan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vbButton2 = new CustomButton.VBButton();
            this.vbButton1 = new CustomButton.VBButton();
            this.listSV = new System.Windows.Forms.DataGridView();
            this.nameHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPRJ)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Image = global::frontend.Properties.Resources.Back;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1000, 100);
            this.label10.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(149, 50);
            this.tabControl1.Location = new System.Drawing.Point(-7, 104);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 620);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::frontend.Properties.Resources.Capture;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.logOut);
            this.tabPage1.Controls.Add(this.save);
            this.tabPage1.Controls.Add(this.edit);
            this.tabPage1.Controls.Add(this.changePassword);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1003, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cá nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.LabRoom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 328);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // LabRoom
            // 
            this.LabRoom.Location = new System.Drawing.Point(457, 268);
            this.LabRoom.Name = "LabRoom";
            this.LabRoom.ReadOnly = true;
            this.LabRoom.Size = new System.Drawing.Size(337, 31);
            this.LabRoom.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phòng Công Tác";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(457, 177);
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Size = new System.Drawing.Size(337, 31);
            this.Phone.TabIndex = 13;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(457, 227);
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Size = new System.Drawing.Size(337, 31);
            this.Email.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã giảng viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và tên";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(457, 30);
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Size = new System.Drawing.Size(337, 31);
            this.Name.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(457, 127);
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Size = new System.Drawing.Size(337, 31);
            this.Address.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(457, 77);
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Size = new System.Drawing.Size(337, 31);
            this.Id.TabIndex = 1;
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.Crimson;
            this.logOut.BackgroundColor = System.Drawing.Color.Crimson;
            this.logOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.logOut.BorderRadius = 20;
            this.logOut.BorderSize = 0;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.ForeColor = System.Drawing.Color.White;
            this.logOut.Location = new System.Drawing.Point(570, 475);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(220, 40);
            this.logOut.TabIndex = 17;
            this.logOut.Text = "Đăng xuất";
            this.logOut.TextColor = System.Drawing.Color.White;
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Tan;
            this.save.BackgroundColor = System.Drawing.Color.Tan;
            this.save.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.save.BorderRadius = 20;
            this.save.BorderSize = 0;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(570, 371);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(220, 40);
            this.save.TabIndex = 16;
            this.save.Text = "Lưu";
            this.save.TextColor = System.Drawing.Color.White;
            this.save.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.RoyalBlue;
            this.edit.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.edit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.edit.BorderRadius = 20;
            this.edit.BorderSize = 0;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.Color.White;
            this.edit.Location = new System.Drawing.Point(239, 371);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(220, 40);
            this.edit.TabIndex = 15;
            this.edit.Text = "Chỉnh sửa thông tin";
            this.edit.TextColor = System.Drawing.Color.White;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // changePassword
            // 
            this.changePassword.BackColor = System.Drawing.Color.OliveDrab;
            this.changePassword.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.changePassword.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.changePassword.BorderRadius = 20;
            this.changePassword.BorderSize = 0;
            this.changePassword.FlatAppearance.BorderSize = 0;
            this.changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassword.ForeColor = System.Drawing.Color.White;
            this.changePassword.Location = new System.Drawing.Point(239, 475);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(220, 40);
            this.changePassword.TabIndex = 14;
            this.changePassword.Text = "Đổi mật khẩu";
            this.changePassword.TextColor = System.Drawing.Color.White;
            this.changePassword.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = global::frontend.Properties.Resources.Capture;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.listPRJ);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.saveNV);
            this.tabPage2.Controls.Add(this.editNV);
            this.tabPage2.Controls.Add(this.hocPhan);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1003, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng kí đề tài";
            // 
            // listPRJ
            // 
            this.listPRJ.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listPRJ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listPRJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPRJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listPRJ.DefaultCellStyle = dataGridViewCellStyle2;
            this.listPRJ.Location = new System.Drawing.Point(36, 140);
            this.listPRJ.Name = "listPRJ";
            this.listPRJ.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listPRJ.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listPRJ.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.listPRJ.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.listPRJ.RowTemplate.Height = 25;
            this.listPRJ.Size = new System.Drawing.Size(902, 250);
            this.listPRJ.TabIndex = 18;
            this.listPRJ.Tag = "";
            this.listPRJ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Tên đề tài";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 650;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số sinh viên tối đa";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Danh sách đề tài";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // saveNV
            // 
            this.saveNV.BackColor = System.Drawing.Color.Tan;
            this.saveNV.BackgroundColor = System.Drawing.Color.Tan;
            this.saveNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveNV.BorderRadius = 20;
            this.saveNV.BorderSize = 0;
            this.saveNV.FlatAppearance.BorderSize = 0;
            this.saveNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNV.ForeColor = System.Drawing.Color.White;
            this.saveNV.Location = new System.Drawing.Point(623, 428);
            this.saveNV.Name = "saveNV";
            this.saveNV.Size = new System.Drawing.Size(230, 55);
            this.saveNV.TabIndex = 11;
            this.saveNV.Text = "Lưu đăng kí";
            this.saveNV.TextColor = System.Drawing.Color.White;
            this.saveNV.UseVisualStyleBackColor = false;
            this.saveNV.Click += new System.EventHandler(this.saveNV_Click);
            // 
            // editNV
            // 
            this.editNV.BackColor = System.Drawing.Color.RoyalBlue;
            this.editNV.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.editNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editNV.BorderRadius = 20;
            this.editNV.BorderSize = 0;
            this.editNV.FlatAppearance.BorderSize = 0;
            this.editNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNV.ForeColor = System.Drawing.Color.White;
            this.editNV.Location = new System.Drawing.Point(129, 428);
            this.editNV.Name = "editNV";
            this.editNV.Size = new System.Drawing.Size(241, 55);
            this.editNV.TabIndex = 10;
            this.editNV.Text = "Chỉnh sửa đề tài";
            this.editNV.TextColor = System.Drawing.Color.White;
            this.editNV.UseVisualStyleBackColor = false;
            this.editNV.Click += new System.EventHandler(this.editNV_Click);
            // 
            // hocPhan
            // 
            this.hocPhan.FormattingEnabled = true;
            this.hocPhan.Items.AddRange(new object[] {
            "project1",
            "project2",
            "project3",
            "projectFinal"});
            this.hocPhan.Location = new System.Drawing.Point(129, 38);
            this.hocPhan.Name = "hocPhan";
            this.hocPhan.Size = new System.Drawing.Size(228, 31);
            this.hocPhan.TabIndex = 1;
            this.hocPhan.SelectedIndexChanged += new System.EventHandler(this.hocPhan_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Học phần";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::frontend.Properties.Resources.Capture;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.vbButton2);
            this.tabPage3.Controls.Add(this.vbButton1);
            this.tabPage3.Controls.Add(this.listSV);
            this.tabPage3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1003, 562);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Điểm sinh viên";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.Tan;
            this.vbButton2.BackgroundColor = System.Drawing.Color.Tan;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 20;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(687, 459);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(230, 55);
            this.vbButton2.TabIndex = 12;
            this.vbButton2.Text = "Lưu điểm";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            this.vbButton2.Click += new System.EventHandler(this.vbButton2_Click);
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(81, 459);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(241, 55);
            this.vbButton1.TabIndex = 11;
            this.vbButton1.Text = "Chỉnh sửa điểm";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // listSV
            // 
            this.listSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listSV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.listSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameHP,
            this.detai,
            this.MSSV,
            this.nameSV,
            this.Mark});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listSV.DefaultCellStyle = dataGridViewCellStyle6;
            this.listSV.Location = new System.Drawing.Point(16, 33);
            this.listSV.Name = "listSV";
            this.listSV.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listSV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.listSV.RowHeadersWidth = 40;
            this.listSV.RowTemplate.Height = 25;
            this.listSV.Size = new System.Drawing.Size(952, 405);
            this.listSV.TabIndex = 0;
            // 
            // nameHP
            // 
            this.nameHP.HeaderText = "Tên học phần";
            this.nameHP.Name = "nameHP";
            this.nameHP.ReadOnly = true;
            this.nameHP.Width = 200;
            // 
            // detai
            // 
            this.detai.HeaderText = "Tên đề tài";
            this.detai.Name = "detai";
            this.detai.ReadOnly = true;
            this.detai.Width = 310;
            // 
            // MSSV
            // 
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 130;
            // 
            // nameSV
            // 
            this.nameSV.HeaderText = "Tên sinh viên";
            this.nameSV.Name = "nameSV";
            this.nameSV.ReadOnly = true;
            this.nameSV.Width = 200;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Điểm kết thúc";
            this.Mark.Name = "Mark";
            this.Mark.ReadOnly = true;
            this.Mark.Width = 70;
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frontend.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label10);
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            //this.Name = "GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiangVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GiangVien_Close);
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPRJ)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Id;
        private CustomButton.VBButton logOut;
        private CustomButton.VBButton save;
        private CustomButton.VBButton edit;
        private CustomButton.VBButton changePassword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private CustomButton.VBButton saveNV;
        private CustomButton.VBButton editNV;
        private System.Windows.Forms.ComboBox hocPhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView listPRJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView listSV;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton vbButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LabRoom;
        private DataGridViewTextBoxColumn nameHP;
        private DataGridViewTextBoxColumn detai;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn nameSV;
        private DataGridViewTextBoxColumn Mark;
    }
}