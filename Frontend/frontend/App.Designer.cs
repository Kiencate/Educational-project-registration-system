
namespace frontend
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.hidePassword = new System.Windows.Forms.CheckBox();
            this.sinhVien = new System.Windows.Forms.RadioButton();
            this.giangVien = new System.Windows.Forms.RadioButton();
            this.giaoVu = new System.Windows.Forms.RadioButton();
            this.submit = new CustomButton.VBButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vbButton1 = new CustomButton.VBButton();
            this.vbButton2 = new CustomButton.VBButton();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.MistyRose;
            this.userName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.userName.Location = new System.Drawing.Point(151, 185);
            this.userName.Name = "userName";
            this.userName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userName.Size = new System.Drawing.Size(131, 26);
            this.userName.TabIndex = 1;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.MistyRose;
            this.password.Location = new System.Drawing.Point(151, 237);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(131, 26);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // hidePassword
            // 
            this.hidePassword.AutoSize = true;
            this.hidePassword.BackColor = System.Drawing.Color.Transparent;
            this.hidePassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hidePassword.ForeColor = System.Drawing.Color.OrangeRed;
            this.hidePassword.Location = new System.Drawing.Point(154, 279);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(128, 23);
            this.hidePassword.TabIndex = 3;
            this.hidePassword.Text = "Hiện mật khẩu";
            this.hidePassword.UseVisualStyleBackColor = false;
            this.hidePassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // sinhVien
            // 
            this.sinhVien.BackColor = System.Drawing.Color.Transparent;
            this.sinhVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sinhVien.ForeColor = System.Drawing.Color.OrangeRed;
            this.sinhVien.Location = new System.Drawing.Point(377, 178);
            this.sinhVien.Name = "sinhVien";
            this.sinhVien.Size = new System.Drawing.Size(112, 26);
            this.sinhVien.TabIndex = 4;
            this.sinhVien.TabStop = true;
            this.sinhVien.Text = "Sinh viên";
            this.sinhVien.UseVisualStyleBackColor = false;
            this.sinhVien.CheckedChanged += new System.EventHandler(this.sinhVien_CheckedChanged);
            // 
            // giangVien
            // 
            this.giangVien.BackColor = System.Drawing.Color.Transparent;
            this.giangVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giangVien.ForeColor = System.Drawing.Color.OrangeRed;
            this.giangVien.Location = new System.Drawing.Point(377, 219);
            this.giangVien.Name = "giangVien";
            this.giangVien.Size = new System.Drawing.Size(112, 26);
            this.giangVien.TabIndex = 5;
            this.giangVien.TabStop = true;
            this.giangVien.Text = "Giảng viên";
            this.giangVien.UseVisualStyleBackColor = false;
            this.giangVien.CheckedChanged += new System.EventHandler(this.giangVien_CheckedChanged);
            // 
            // giaoVu
            // 
            this.giaoVu.BackColor = System.Drawing.Color.Transparent;
            this.giaoVu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giaoVu.ForeColor = System.Drawing.Color.OrangeRed;
            this.giaoVu.Location = new System.Drawing.Point(377, 259);
            this.giaoVu.Name = "giaoVu";
            this.giaoVu.Size = new System.Drawing.Size(112, 26);
            this.giaoVu.TabIndex = 6;
            this.giaoVu.TabStop = true;
            this.giaoVu.Text = "Giáo vụ";
            this.giaoVu.UseVisualStyleBackColor = false;
            this.giaoVu.CheckedChanged += new System.EventHandler(this.giaoVu_CheckedChanged);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.LightSalmon;
            this.submit.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.submit.BorderColor = System.Drawing.SystemColors.Info;
            this.submit.BorderRadius = 12;
            this.submit.BorderSize = 0;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(227, 308);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 41);
            this.submit.TabIndex = 7;
            this.submit.Text = "SUBMIT";
            this.submit.TextColor = System.Drawing.Color.White;
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(176, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::frontend.Properties.Resources.Back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-2, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(881, 75);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.Transparent;
            this.vbButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.vbButton1.BackgroundImage = global::frontend.Properties.Resources.User_orange_icon;
            this.vbButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vbButton1.BorderColor = System.Drawing.Color.Violet;
            this.vbButton1.BorderRadius = 0;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(113, 183);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(31, 27);
            this.vbButton1.TabIndex = 11;
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.Transparent;
            this.vbButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.vbButton2.BackgroundImage = global::frontend.Properties.Resources.Key_icon;
            this.vbButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 0;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(108, 234);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(43, 35);
            this.vbButton2.TabIndex = 12;
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // App
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.giaoVu);
            this.Controls.Add(this.giangVien);
            this.Controls.Add(this.sinhVien);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.vbButton2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyDoAn";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox hidePassword;
        private System.Windows.Forms.RadioButton sinhVien;
        private System.Windows.Forms.RadioButton giangVien;
        private System.Windows.Forms.RadioButton giaoVu;
        private CustomButton.VBButton submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private CustomButton.VBButton vbButton1;
        private CustomButton.VBButton vbButton2;
    }
}

