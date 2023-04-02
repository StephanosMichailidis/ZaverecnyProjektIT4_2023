namespace StephanosMichailidisProjekt
{
    partial class editUzivatel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editUzivatel));
            this.btnFiltr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJmeno = new System.Windows.Forms.TextBox();
            this.txtHeslo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltr
            // 
            this.btnFiltr.BackColor = System.Drawing.Color.Pink;
            this.btnFiltr.Location = new System.Drawing.Point(37, 128);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(75, 23);
            this.btnFiltr.TabIndex = 31;
            this.btnFiltr.Text = "Filtrovat";
            this.btnFiltr.UseVisualStyleBackColor = false;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(137, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 329);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Pink;
            this.btnShow.Location = new System.Drawing.Point(37, 186);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 40);
            this.btnShow.TabIndex = 29;
            this.btnShow.Text = "Zobrazení uživatelů";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Pink;
            this.btnHome.Location = new System.Drawing.Point(415, 411);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(99, 23);
            this.btnHome.TabIndex = 28;
            this.btnHome.Text = "Domovní stránka";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Pink;
            this.btnLogout.Location = new System.Drawing.Point(520, 411);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 27;
            this.btnLogout.Text = "Odhlasit se";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Pink;
            this.btnEdit.Location = new System.Drawing.Point(37, 157);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Spravovat";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Práce s uživateli";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Pink;
            this.btnDel.Location = new System.Drawing.Point(37, 99);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 24;
            this.btnDel.Text = "Smazat ";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Heslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Jmeno:";
            // 
            // txtJmeno
            // 
            this.txtJmeno.BackColor = System.Drawing.Color.Pink;
            this.txtJmeno.Location = new System.Drawing.Point(191, 20);
            this.txtJmeno.Name = "txtJmeno";
            this.txtJmeno.Size = new System.Drawing.Size(100, 20);
            this.txtJmeno.TabIndex = 21;
            // 
            // txtHeslo
            // 
            this.txtHeslo.BackColor = System.Drawing.Color.Pink;
            this.txtHeslo.Location = new System.Drawing.Point(363, 20);
            this.txtHeslo.Name = "txtHeslo";
            this.txtHeslo.Size = new System.Drawing.Size(100, 20);
            this.txtHeslo.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(37, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Přidat";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Pink;
            this.txtID.Location = new System.Drawing.Point(84, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 17;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.BackColor = System.Drawing.Color.Pink;
            this.chkAdmin.Location = new System.Drawing.Point(484, 23);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(55, 17);
            this.chkAdmin.TabIndex = 16;
            this.chkAdmin.Text = "Admin";
            this.chkAdmin.UseVisualStyleBackColor = false;
            this.chkAdmin.CheckedChanged += new System.EventHandler(this.chkAdmin_CheckedChanged);
            // 
            // editUzivatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 447);
            this.Controls.Add(this.btnFiltr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJmeno);
            this.Controls.Add(this.txtHeslo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.chkAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editUzivatel";
            this.Text = "editUzivatel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJmeno;
        private System.Windows.Forms.TextBox txtHeslo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkAdmin;
    }
}