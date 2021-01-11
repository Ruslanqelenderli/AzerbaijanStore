namespace MyControls.Controls
{
    partial class RegisterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_Register = new System.Windows.Forms.GroupBox();
            this.lbl_RegisterSurname = new System.Windows.Forms.Label();
            this.lbl_RegisterWorkID = new System.Windows.Forms.Label();
            this.lbl_PasswordAgain = new System.Windows.Forms.Label();
            this.lbl_RegisterPassword = new System.Windows.Forms.Label();
            this.txb_RegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.txb_RegisterPassword = new System.Windows.Forms.TextBox();
            this.txb_RegisterWorkID = new System.Windows.Forms.TextBox();
            this.txb_RegisterSurname = new System.Windows.Forms.TextBox();
            this.txb_RegisterName = new System.Windows.Forms.TextBox();
            this.lbl_RegisterName = new System.Windows.Forms.Label();
            this.btn_RegisterInRegister = new System.Windows.Forms.Button();
            this.grb_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_Register
            // 
            this.grb_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grb_Register.Controls.Add(this.lbl_RegisterSurname);
            this.grb_Register.Controls.Add(this.lbl_RegisterWorkID);
            this.grb_Register.Controls.Add(this.lbl_PasswordAgain);
            this.grb_Register.Controls.Add(this.lbl_RegisterPassword);
            this.grb_Register.Controls.Add(this.txb_RegisterConfirmPassword);
            this.grb_Register.Controls.Add(this.txb_RegisterPassword);
            this.grb_Register.Controls.Add(this.txb_RegisterWorkID);
            this.grb_Register.Controls.Add(this.txb_RegisterSurname);
            this.grb_Register.Controls.Add(this.txb_RegisterName);
            this.grb_Register.Controls.Add(this.lbl_RegisterName);
            this.grb_Register.Controls.Add(this.btn_RegisterInRegister);
            this.grb_Register.Location = new System.Drawing.Point(0, 0);
            this.grb_Register.Name = "grb_Register";
            this.grb_Register.Size = new System.Drawing.Size(321, 379);
            this.grb_Register.TabIndex = 0;
            this.grb_Register.TabStop = false;
            this.grb_Register.Text = "Register";
            // 
            // lbl_RegisterSurname
            // 
            this.lbl_RegisterSurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RegisterSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_RegisterSurname.Location = new System.Drawing.Point(19, 68);
            this.lbl_RegisterSurname.Name = "lbl_RegisterSurname";
            this.lbl_RegisterSurname.Size = new System.Drawing.Size(182, 26);
            this.lbl_RegisterSurname.TabIndex = 14;
            this.lbl_RegisterSurname.Text = "Surname";
            this.lbl_RegisterSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_RegisterWorkID
            // 
            this.lbl_RegisterWorkID.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RegisterWorkID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_RegisterWorkID.Location = new System.Drawing.Point(19, 120);
            this.lbl_RegisterWorkID.Name = "lbl_RegisterWorkID";
            this.lbl_RegisterWorkID.Size = new System.Drawing.Size(182, 26);
            this.lbl_RegisterWorkID.TabIndex = 13;
            this.lbl_RegisterWorkID.Text = "Work ID";
            this.lbl_RegisterWorkID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PasswordAgain
            // 
            this.lbl_PasswordAgain.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PasswordAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_PasswordAgain.Location = new System.Drawing.Point(19, 219);
            this.lbl_PasswordAgain.Name = "lbl_PasswordAgain";
            this.lbl_PasswordAgain.Size = new System.Drawing.Size(182, 27);
            this.lbl_PasswordAgain.TabIndex = 12;
            this.lbl_PasswordAgain.Text = "Confirm Password";
            this.lbl_PasswordAgain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_PasswordAgain.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_RegisterPassword
            // 
            this.lbl_RegisterPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RegisterPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_RegisterPassword.Location = new System.Drawing.Point(19, 169);
            this.lbl_RegisterPassword.Name = "lbl_RegisterPassword";
            this.lbl_RegisterPassword.Size = new System.Drawing.Size(182, 26);
            this.lbl_RegisterPassword.TabIndex = 11;
            this.lbl_RegisterPassword.Text = "Password";
            this.lbl_RegisterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txb_RegisterConfirmPassword
            // 
            this.txb_RegisterConfirmPassword.Location = new System.Drawing.Point(51, 249);
            this.txb_RegisterConfirmPassword.Name = "txb_RegisterConfirmPassword";
            this.txb_RegisterConfirmPassword.Size = new System.Drawing.Size(131, 20);
            this.txb_RegisterConfirmPassword.TabIndex = 10;
            // 
            // txb_RegisterPassword
            // 
            this.txb_RegisterPassword.Location = new System.Drawing.Point(51, 196);
            this.txb_RegisterPassword.Name = "txb_RegisterPassword";
            this.txb_RegisterPassword.Size = new System.Drawing.Size(131, 20);
            this.txb_RegisterPassword.TabIndex = 9;
            // 
            // txb_RegisterWorkID
            // 
            this.txb_RegisterWorkID.Location = new System.Drawing.Point(51, 146);
            this.txb_RegisterWorkID.Name = "txb_RegisterWorkID";
            this.txb_RegisterWorkID.Size = new System.Drawing.Size(131, 20);
            this.txb_RegisterWorkID.TabIndex = 8;
            // 
            // txb_RegisterSurname
            // 
            this.txb_RegisterSurname.Location = new System.Drawing.Point(51, 97);
            this.txb_RegisterSurname.Name = "txb_RegisterSurname";
            this.txb_RegisterSurname.Size = new System.Drawing.Size(131, 20);
            this.txb_RegisterSurname.TabIndex = 7;
            // 
            // txb_RegisterName
            // 
            this.txb_RegisterName.Location = new System.Drawing.Point(51, 45);
            this.txb_RegisterName.Name = "txb_RegisterName";
            this.txb_RegisterName.Size = new System.Drawing.Size(131, 20);
            this.txb_RegisterName.TabIndex = 6;
            // 
            // lbl_RegisterName
            // 
            this.lbl_RegisterName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RegisterName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_RegisterName.Location = new System.Drawing.Point(19, 16);
            this.lbl_RegisterName.Name = "lbl_RegisterName";
            this.lbl_RegisterName.Size = new System.Drawing.Size(182, 26);
            this.lbl_RegisterName.TabIndex = 1;
            this.lbl_RegisterName.Text = "Name";
            this.lbl_RegisterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_RegisterInRegister
            // 
            this.btn_RegisterInRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_RegisterInRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RegisterInRegister.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_RegisterInRegister.Location = new System.Drawing.Point(152, 301);
            this.btn_RegisterInRegister.Name = "btn_RegisterInRegister";
            this.btn_RegisterInRegister.Size = new System.Drawing.Size(97, 31);
            this.btn_RegisterInRegister.TabIndex = 0;
            this.btn_RegisterInRegister.Text = "Register";
            this.btn_RegisterInRegister.UseVisualStyleBackColor = false;
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grb_Register);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(321, 379);
            this.grb_Register.ResumeLayout(false);
            this.grb_Register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox grb_Register;
        private System.Windows.Forms.Label lbl_RegisterSurname;
        private System.Windows.Forms.Label lbl_RegisterWorkID;
        private System.Windows.Forms.Label lbl_PasswordAgain;
        private System.Windows.Forms.Label lbl_RegisterPassword;
        public System.Windows.Forms.TextBox txb_RegisterConfirmPassword;
        public System.Windows.Forms.TextBox txb_RegisterPassword;
        public System.Windows.Forms.TextBox txb_RegisterWorkID;
        public System.Windows.Forms.TextBox txb_RegisterSurname;
        public System.Windows.Forms.TextBox txb_RegisterName;
        private System.Windows.Forms.Label lbl_RegisterName;
        public System.Windows.Forms.Button btn_RegisterInRegister;
    }
}
