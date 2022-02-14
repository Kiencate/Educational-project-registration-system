
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
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.hidePassword = new System.Windows.Forms.CheckBox();
            this.sinhVien = new System.Windows.Forms.RadioButton();
            this.giangVien = new System.Windows.Forms.RadioButton();
            this.giaoVu = new System.Windows.Forms.RadioButton();
            this.submit = new CustomButton.VBButton();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(255, 182);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(131, 26);
            this.userName.TabIndex = 1;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(255, 240);
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
            this.hidePassword.Location = new System.Drawing.Point(258, 283);
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
            this.sinhVien.ForeColor = System.Drawing.Color.Black;
            this.sinhVien.Location = new System.Drawing.Point(406, 183);
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
            this.giangVien.Location = new System.Drawing.Point(406, 215);
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
            this.giaoVu.Location = new System.Drawing.Point(406, 247);
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
            this.submit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.submit.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.submit.BorderColor = System.Drawing.SystemColors.Info;
            this.submit.BorderRadius = 12;
            this.submit.BorderSize = 0;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(334, 331);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(109, 42);
            this.submit.TabIndex = 7;
            this.submit.Text = "SUBMIT";
            this.submit.TextColor = System.Drawing.Color.Black;
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // App
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frontend.Properties.Resources.BackgroundApp3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.giaoVu);
            this.Controls.Add(this.giangVien);
            this.Controls.Add(this.sinhVien);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 556);
            this.MinimumSize = new System.Drawing.Size(800, 556);
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
    }
}

