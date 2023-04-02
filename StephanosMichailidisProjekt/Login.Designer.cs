namespace StephanosMichailidisProjekt
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.Lable1 = new System.Windows.Forms.Label();
            this.Lable = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Pink;
            this.btnLogin.Location = new System.Drawing.Point(77, 83);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Přihlásit";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Lable1
            // 
            this.Lable1.AutoSize = true;
            this.Lable1.Location = new System.Drawing.Point(18, 43);
            this.Lable1.Name = "Lable1";
            this.Lable1.Size = new System.Drawing.Size(37, 13);
            this.Lable1.TabIndex = 13;
            this.Lable1.Text = "Heslo:";
            // 
            // Lable
            // 
            this.Lable.AutoSize = true;
            this.Lable.Location = new System.Drawing.Point(18, 15);
            this.Lable.Name = "Lable";
            this.Lable.Size = new System.Drawing.Size(41, 13);
            this.Lable.TabIndex = 12;
            this.Lable.Text = "Jméno:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Pink;
            this.txtPassword.Location = new System.Drawing.Point(65, 40);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtNames
            // 
            this.txtNames.BackColor = System.Drawing.Color.Pink;
            this.txtNames.Location = new System.Drawing.Point(65, 12);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(100, 20);
            this.txtNames.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 146);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Lable1);
            this.Controls.Add(this.Lable);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label Lable1;
        private System.Windows.Forms.Label Lable;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNames;
    }
}