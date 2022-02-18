
using frontend.Properties;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace frontend
{
    partial class SinhVien
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
            try {
                var responce = await RestHelper.GetInfoSV(id);
                JavaScriptSerializer js = new JavaScriptSerializer();
                DataStudent[] persons = js.Deserialize<DataStudent[]>(responce);
                //textBox1.Text = RestHelper.BeautifyJson(responce);
                //var data_final = JsonConvert.DeserializeObject<SingleUser>(responce);

                Name.Text = persons[0].Name;
                Class.Text = persons[0].Class;
                ID.Text = persons[0].ID;
                Address.Text = persons[0].Address;
                Phone.Text = persons[0].Phone;
                Email.Text = persons[0].Email;
            }
            catch(Exception a)
            {
                MessageBox.Show("Lỗi nhận data về thông tin sinh viên: ");
            }
    
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private async void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.logOut = new CustomButton.VBButton();
            this.save = new CustomButton.VBButton();
            this.edit = new CustomButton.VBButton();
            this.changePassword = new CustomButton.VBButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeTai1 = new System.Windows.Forms.ComboBox();
            this.DeTai3 = new System.Windows.Forms.ComboBox();
            this.DeTai2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GV1 = new System.Windows.Forms.ComboBox();
            this.GV3 = new System.Windows.Forms.ComboBox();
            this.GV2 = new System.Windows.Forms.ComboBox();
            this.showTeacher = new CustomButton.VBButton();
            this.saveNV = new CustomButton.VBButton();
            this.editNV = new CustomButton.VBButton();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hocPhan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(149, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.logOut);
            this.tabPage1.Controls.Add(this.save);
            this.tabPage1.Controls.Add(this.edit);
            this.tabPage1.Controls.Add(this.changePassword);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cá nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.Class);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 328);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(457, 227);
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Size = new System.Drawing.Size(337, 31);
            this.Phone.TabIndex = 13;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(457, 277);
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Size = new System.Drawing.Size(337, 31);
            this.Email.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã số sinh viên";
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
            this.Name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(457, 177);
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Size = new System.Drawing.Size(337, 31);
            this.Address.TabIndex = 3;
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(457, 127);
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Size = new System.Drawing.Size(337, 31);
            this.Class.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(457, 77);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(337, 31);
            this.ID.TabIndex = 1;
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
            this.save.Click += new System.EventHandler(this.save_Click);
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
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.DeTai1);
            this.tabPage2.Controls.Add(this.DeTai3);
            this.tabPage2.Controls.Add(this.DeTai2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.GV1);
            this.tabPage2.Controls.Add(this.GV3);
            this.tabPage2.Controls.Add(this.GV2);
            this.tabPage2.Controls.Add(this.showTeacher);
            this.tabPage2.Controls.Add(this.saveNV);
            this.tabPage2.Controls.Add(this.editNV);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.hocPhan);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng kí hướng dẫn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 20;
            // 
            // DeTai1
            // 
            this.DeTai1.FormattingEnabled = true;
            this.DeTai1.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3",
            "Thực tập tốt nghiệp",
            "Đồ án tốt nghiệp"});
            this.DeTai1.Location = new System.Drawing.Point(490, 167);
            this.DeTai1.Name = "DeTai1";
            this.DeTai1.Size = new System.Drawing.Size(478, 31);
            this.DeTai1.TabIndex = 19;
            // 
            // DeTai3
            // 
            this.DeTai3.FormattingEnabled = true;
            this.DeTai3.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3",
            "Thực tập tốt nghiệp",
            "Đồ án tốt nghiệp"});
            this.DeTai3.Location = new System.Drawing.Point(490, 332);
            this.DeTai3.Name = "DeTai3";
            this.DeTai3.Size = new System.Drawing.Size(478, 31);
            this.DeTai3.TabIndex = 18;
            // 
            // DeTai2
            // 
            this.DeTai2.FormattingEnabled = true;
            this.DeTai2.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3",
            "Thực tập tốt nghiệp",
            "Đồ án tốt nghiệp"});
            this.DeTai2.Location = new System.Drawing.Point(490, 251);
            this.DeTai2.Name = "DeTai2";
            this.DeTai2.Size = new System.Drawing.Size(478, 31);
            this.DeTai2.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(655, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tên đề tài";
            // 
            // GV1
            // 
            this.GV1.FormattingEnabled = true;
            this.GV1.Items.AddRange(new object[] {
            "VST",
            "PVT",
            "PDT"});
            this.GV1.Location = new System.Drawing.Point(181, 167);
            this.GV1.Name = "GV1";
            this.GV1.Size = new System.Drawing.Size(277, 31);
            this.GV1.TabIndex = 15;
            this.GV1.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // GV3
            // 
            this.GV3.FormattingEnabled = true;
            this.GV3.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3",
            "Thực tập tốt nghiệp",
            "Đồ án tốt nghiệp"});
            this.GV3.Location = new System.Drawing.Point(181, 332);
            this.GV3.Name = "GV3";
            this.GV3.Size = new System.Drawing.Size(277, 31);
            this.GV3.TabIndex = 14;
            // 
            // GV2
            // 
            this.GV2.FormattingEnabled = true;
            this.GV2.Items.AddRange(new object[] {
            "Project 1",
            "Project 2",
            "Project 3",
            "Thực tập tốt nghiệp",
            "Đồ án tốt nghiệp"});
            this.GV2.Location = new System.Drawing.Point(181, 251);
            this.GV2.Name = "GV2";
            this.GV2.Size = new System.Drawing.Size(277, 31);
            this.GV2.TabIndex = 13;
            // 
            // showTeacher
            // 
            this.showTeacher.BackColor = System.Drawing.Color.DarkViolet;
            this.showTeacher.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.showTeacher.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.showTeacher.BorderRadius = 20;
            this.showTeacher.BorderSize = 0;
            this.showTeacher.FlatAppearance.BorderSize = 0;
            this.showTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showTeacher.ForeColor = System.Drawing.Color.White;
            this.showTeacher.Location = new System.Drawing.Point(77, 439);
            this.showTeacher.Name = "showTeacher";
            this.showTeacher.Size = new System.Drawing.Size(245, 40);
            this.showTeacher.TabIndex = 12;
            this.showTeacher.Text = "Hiển thị danh sách giảng vên";
            this.showTeacher.TextColor = System.Drawing.Color.White;
            this.showTeacher.UseVisualStyleBackColor = false;
            this.showTeacher.Click += new System.EventHandler(this.showTeacher_Click);
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
            this.saveNV.Location = new System.Drawing.Point(743, 439);
            this.saveNV.Name = "saveNV";
            this.saveNV.Size = new System.Drawing.Size(150, 40);
            this.saveNV.TabIndex = 11;
            this.saveNV.Text = "Lưu đăng kí";
            this.saveNV.TextColor = System.Drawing.Color.White;
            this.saveNV.UseVisualStyleBackColor = false;
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
            this.editNV.Location = new System.Drawing.Point(451, 439);
            this.editNV.Name = "editNV";
            this.editNV.Size = new System.Drawing.Size(150, 40);
            this.editNV.TabIndex = 10;
            this.editNV.Text = "Chỉnh sửa";
            this.editNV.TextColor = System.Drawing.Color.White;
            this.editNV.UseVisualStyleBackColor = false;
            this.editNV.Click += new System.EventHandler(this.editNV_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(99, 251);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(27, 31);
            this.textBox9.TabIndex = 6;
            this.textBox9.Text = "2";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(99, 332);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(27, 31);
            this.textBox8.TabIndex = 5;
            this.textBox8.Text = "3";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(99, 167);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(27, 31);
            this.textBox7.TabIndex = 4;
            this.textBox7.Text = "1";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Giảng viên hướng dẫn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nguyện vọng";
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
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Học phần";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kết quả học tập";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Image = global::frontend.Properties.Resources.Back;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1000, 100);
            this.label10.TabIndex = 1;
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
           
            this.Text = "SinhVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SinhVien_Close);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Class;
        private System.Windows.Forms.TextBox ID;
        private CustomButton.VBButton save;
        private CustomButton.VBButton edit;
        private CustomButton.VBButton changePassword;
        private CustomButton.VBButton logOut;
        private System.Windows.Forms.Label label7;
        private CustomButton.VBButton showTeacher;
        private CustomButton.VBButton saveNV;
        private CustomButton.VBButton editNV;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox hocPhan;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DeTai1;
        private System.Windows.Forms.ComboBox DeTai3;
        private System.Windows.Forms.ComboBox DeTai2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox GV1;
        private System.Windows.Forms.ComboBox GV3;
        private System.Windows.Forms.ComboBox GV2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}