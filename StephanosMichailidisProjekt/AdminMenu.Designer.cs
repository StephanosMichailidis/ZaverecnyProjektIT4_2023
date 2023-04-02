namespace StephanosMichailidisProjekt
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.btnUzi = new System.Windows.Forms.Button();
            this.btnZam = new System.Windows.Forms.Button();
            this.btnZakaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUzi
            // 
            this.btnUzi.BackColor = System.Drawing.Color.Pink;
            this.btnUzi.Location = new System.Drawing.Point(12, 27);
            this.btnUzi.Name = "btnUzi";
            this.btnUzi.Size = new System.Drawing.Size(170, 23);
            this.btnUzi.TabIndex = 9;
            this.btnUzi.Text = "Správa uživatelů";
            this.btnUzi.UseVisualStyleBackColor = false;
            this.btnUzi.Click += new System.EventHandler(this.btnUzi_Click);
            // 
            // btnZam
            // 
            this.btnZam.BackColor = System.Drawing.Color.Pink;
            this.btnZam.Location = new System.Drawing.Point(12, 56);
            this.btnZam.Name = "btnZam";
            this.btnZam.Size = new System.Drawing.Size(170, 23);
            this.btnZam.TabIndex = 8;
            this.btnZam.Text = "Zaměstnanci";
            this.btnZam.UseVisualStyleBackColor = false;
            this.btnZam.Click += new System.EventHandler(this.btnZam_Click);
            // 
            // btnZakaz
            // 
            this.btnZakaz.BackColor = System.Drawing.Color.Pink;
            this.btnZakaz.Location = new System.Drawing.Point(13, 85);
            this.btnZakaz.Name = "btnZakaz";
            this.btnZakaz.Size = new System.Drawing.Size(170, 23);
            this.btnZakaz.TabIndex = 7;
            this.btnZakaz.Text = "Zakázky";
            this.btnZakaz.UseVisualStyleBackColor = false;
            this.btnZakaz.Click += new System.EventHandler(this.btnZakaz_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 142);
            this.Controls.Add(this.btnUzi);
            this.Controls.Add(this.btnZam);
            this.Controls.Add(this.btnZakaz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUzi;
        private System.Windows.Forms.Button btnZam;
        private System.Windows.Forms.Button btnZakaz;
    }
}