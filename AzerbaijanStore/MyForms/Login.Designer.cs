namespace AzerbaijanStore
{
    partial class LoginForm
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
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_WorkId = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_RegisterInLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Linen;
            this.btn_Login.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Login.Location = new System.Drawing.Point(57, 195);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(182, 28);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Name.Location = new System.Drawing.Point(64, 79);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.lbl_Name.Size = new System.Drawing.Size(166, 25);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Work Id";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Password.Location = new System.Drawing.Point(60, 130);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(165, 22);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(64, 155);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(166, 20);
            this.txb_Password.TabIndex = 3;
            // 
            // txb_WorkId
            // 
            this.txb_WorkId.Location = new System.Drawing.Point(64, 107);
            this.txb_WorkId.Name = "txb_WorkId";
            this.txb_WorkId.Size = new System.Drawing.Size(166, 20);
            this.txb_WorkId.TabIndex = 4;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("New Century Schoolbook", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Padding = new System.Windows.Forms.Padding(100, 15, 0, 0);
            this.lbl_Title.Size = new System.Drawing.Size(324, 63);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "Login";
            // 
            // btn_RegisterInLogin
            // 
            this.btn_RegisterInLogin.BackColor = System.Drawing.Color.Linen;
            this.btn_RegisterInLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RegisterInLogin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_RegisterInLogin.Location = new System.Drawing.Point(167, 240);
            this.btn_RegisterInLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_RegisterInLogin.Name = "btn_RegisterInLogin";
            this.btn_RegisterInLogin.Size = new System.Drawing.Size(100, 27);
            this.btn_RegisterInLogin.TabIndex = 6;
            this.btn_RegisterInLogin.Text = "Register =>";
            this.btn_RegisterInLogin.UseVisualStyleBackColor = false;
            this.btn_RegisterInLogin.Click += new System.EventHandler(this.btn_RegisterInLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(324, 327);
            this.Controls.Add(this.btn_RegisterInLogin);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txb_WorkId);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Login);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_WorkId;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_RegisterInLogin;
    }
}

