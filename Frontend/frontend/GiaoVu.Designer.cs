
using frontend.Properties;
using Nancy.Json;

namespace frontend
{
    partial class GiaoVu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private async void view_project()
        {
            var responce = await RestHelper.GetAllProject();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Project[] data_final = js.Deserialize<Project[]>(responce);
            for (int i=0; i<data_final.Length;i++)
            {
                listPRJ.Rows.Add();
            }
            for (int i = 0; i < data_final.Length; i++)
            {

                listPRJ.Rows[i].Cells[0].Value = data_final[i].name;
                listPRJ.Rows[i].Cells[3].Value = data_final[i].numStudent.ToString();
                var resuser = await RestHelper.GetTeacherFromProject(data_final[i].ID.ToString());
                JavaScriptSerializer js1 = new JavaScriptSerializer();
                DataUser[] data_final1 = js1.Deserialize<DataUser[]>(resuser);
                listPRJ.Rows[i].Cells[1].Value = data_final1[0].Name;
                
                var resuser1 = await RestHelper.GetStudentFromProject(data_final[i].ID.ToString());
                if (resuser1 != null)
                {
                    JavaScriptSerializer js2 = new JavaScriptSerializer();
                    DataUser[] data_final2 = js2.Deserialize<DataUser[]>(resuser1);
                    if (data_final2!= null) {
                        if (data_final2.Length < 2) listPRJ.Rows[i].Cells[2].Value += data_final2[0].Name;
                        else
                        for (int j = 0; j<data_final2.Length; j++)
                        {
                            listPRJ.Rows[i].Cells[2].Value += data_final2[j].Name + ", ";
                        }
                    }
                }


            }
        }
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tenhp = new System.Windows.Forms.TextBox();
            this.mahp = new System.Windows.Forms.TextBox();
            this.hocki = new System.Windows.Forms.TextBox();
            this.vbButton1 = new CustomButton.VBButton();
            this.saveNV = new CustomButton.VBButton();
            this.editNV = new CustomButton.VBButton();
            this.PRJLIST = new System.Windows.Forms.DataGridView();
            this.HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listPRJ = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRJLIST)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPRJ)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(-5, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 625);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::frontend.Properties.Resources.Capture;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tenhp);
            this.tabPage2.Controls.Add(this.mahp);
            this.tabPage2.Controls.Add(this.hocki);
            this.tabPage2.Controls.Add(this.vbButton1);
            this.tabPage2.Controls.Add(this.saveNV);
            this.tabPage2.Controls.Add(this.editNV);
            this.tabPage2.Controls.Add(this.PRJLIST);
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mở Môn Học";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên học phần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Học kì";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Danh sách môn học đã mở";
            // 
            // tenhp
            // 
            this.tenhp.Location = new System.Drawing.Point(476, 78);
            this.tenhp.Name = "tenhp";
            this.tenhp.Size = new System.Drawing.Size(447, 31);
            this.tenhp.TabIndex = 17;
            // 
            // mahp
            // 
            this.mahp.Location = new System.Drawing.Point(273, 78);
            this.mahp.Name = "mahp";
            this.mahp.Size = new System.Drawing.Size(149, 31);
            this.mahp.TabIndex = 16;
            // 
            // hocki
            // 
            this.hocki.Location = new System.Drawing.Point(88, 78);
            this.hocki.Name = "hocki";
            this.hocki.Size = new System.Drawing.Size(112, 31);
            this.hocki.TabIndex = 15;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.Crimson;
            this.vbButton1.BackgroundColor = System.Drawing.Color.Crimson;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(397, 415);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(241, 55);
            this.vbButton1.TabIndex = 14;
            this.vbButton1.Text = "Xoá môn học";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
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
            this.saveNV.Location = new System.Drawing.Point(722, 415);
            this.saveNV.Name = "saveNV";
            this.saveNV.Size = new System.Drawing.Size(230, 55);
            this.saveNV.TabIndex = 13;
            this.saveNV.Text = "Lưu thay đổi";
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
            this.editNV.Location = new System.Drawing.Point(48, 415);
            this.editNV.Name = "editNV";
            this.editNV.Size = new System.Drawing.Size(241, 55);
            this.editNV.TabIndex = 12;
            this.editNV.Text = "Thêm môn học";
            this.editNV.TextColor = System.Drawing.Color.White;
            this.editNV.UseVisualStyleBackColor = false;
            // 
            // PRJLIST
            // 
            this.PRJLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PRJLIST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HK,
            this.ID,
            this.Name});
            this.PRJLIST.Location = new System.Drawing.Point(79, 180);
            this.PRJLIST.Name = "PRJLIST";
            this.PRJLIST.RowTemplate.Height = 25;
            this.PRJLIST.Size = new System.Drawing.Size(844, 229);
            this.PRJLIST.TabIndex = 0;
            // 
            // HK
            // 
            this.HK.HeaderText = "Học kì";
            this.HK.Name = "HK";
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã học phần";
            this.ID.Name = "ID";
            this.ID.Width = 200;
            // 
            // Name
            // 
            this.Name.HeaderText = "Tên học phần";
            this.Name.Name = "Name";
            this.Name.Width = 500;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::frontend.Properties.Resources.Capture;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.listPRJ);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 579);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Phân công đề tài";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 33);
            this.label5.TabIndex = 20;
            this.label5.Text = "ĐỒ ÁN TỐT NGHIỆP";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listPRJ
            // 
            this.listPRJ.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listPRJ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listPRJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPRJ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.GV,
            this.SV,
            this.max});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listPRJ.DefaultCellStyle = dataGridViewCellStyle2;
            this.listPRJ.Location = new System.Drawing.Point(4, 60);
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
            this.listPRJ.Size = new System.Drawing.Size(978, 496);
            this.listPRJ.TabIndex = 19;
            this.listPRJ.Tag = "";
            this.listPRJ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPRJ_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "Tên đề tài";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 290;
            // 
            // GV
            // 
            this.GV.HeaderText = "GV hướng dẫn";
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.Width = 200;
            // 
            // SV
            // 
            this.SV.HeaderText = "SV đăng ký";
            this.SV.Name = "SV";
            this.SV.ReadOnly = true;
            this.SV.Width = 375;
            // 
            // max
            // 
            this.max.HeaderText = "max";
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Width = 60;
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
            // GiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            //this.Name = "GiaoVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoVu";
            this.Load += new System.EventHandler(this.GiaoVu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PRJLIST)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPRJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView PRJLIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private CustomButton.VBButton vbButton1;
        private CustomButton.VBButton saveNV;
        private CustomButton.VBButton editNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenhp;
        private System.Windows.Forms.TextBox mahp;
        private System.Windows.Forms.TextBox hocki;
        private System.Windows.Forms.DataGridView listPRJ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SV;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
    }
}