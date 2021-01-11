namespace AzerbaijanStore.MyForms
{
    partial class Register
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
            this.registerControl1 = new MyControls.Controls.RegisterControl();
            this.SuspendLayout();
            // 
            // registerControl1
            // 
            this.registerControl1.Location = new System.Drawing.Point(1, -1);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(321, 379);
            this.registerControl1.TabIndex = 0;
            this.registerControl1.Load += new System.EventHandler(this.registerControl1_Load);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 355);
            this.Controls.Add(this.registerControl1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.Controls.RegisterControl registerControl1;
    }
}