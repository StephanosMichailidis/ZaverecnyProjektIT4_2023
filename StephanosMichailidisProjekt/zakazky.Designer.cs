namespace StephanosMichailidisProjekt
{
    partial class zakazky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zakazky));
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnFiltr = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCas = new System.Windows.Forms.TextBox();
            this.txtZamestanec = new System.Windows.Forms.TextBox();
            this.txtZakaznik = new System.Windows.Forms.TextBox();
            this.txtPrace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Pink;
            this.btnHome.Location = new System.Drawing.Point(480, 424);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(99, 23);
            this.btnHome.TabIndex = 40;
            this.btnHome.Text = "Domovní stránka";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Pink;
            this.btnLogout.Location = new System.Drawing.Point(597, 424);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = "Odhlásit se";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Pink;
            this.btnShow.Location = new System.Drawing.Point(81, 375);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(172, 43);
            this.btnShow.TabIndex = 38;
            this.btnShow.Text = "Zobrazení zakázek";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnFiltr
            // 
            this.btnFiltr.BackColor = System.Drawing.Color.Pink;
            this.btnFiltr.Location = new System.Drawing.Point(81, 325);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(172, 23);
            this.btnFiltr.TabIndex = 37;
            this.btnFiltr.Text = "Filtrovat";
            this.btnFiltr.UseVisualStyleBackColor = false;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Pink;
            this.btnDel.Location = new System.Drawing.Point(81, 246);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(172, 23);
            this.btnDel.TabIndex = 36;
            this.btnDel.Text = "Smazat";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Pink;
            this.btnEdit.Location = new System.Drawing.Point(81, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(172, 23);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Spravovat";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.Location = new System.Drawing.Point(81, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Přidat";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Informace o Zakázce";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Čas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Zákazník:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Zaměstnanec:";
            // 
            // txtCas
            // 
            this.txtCas.BackColor = System.Drawing.Color.Pink;
            this.txtCas.Location = new System.Drawing.Point(81, 116);
            this.txtCas.Name = "txtCas";
            this.txtCas.Size = new System.Drawing.Size(172, 20);
            this.txtCas.TabIndex = 29;
            // 
            // txtZamestanec
            // 
            this.txtZamestanec.BackColor = System.Drawing.Color.Pink;
            this.txtZamestanec.Location = new System.Drawing.Point(81, 90);
            this.txtZamestanec.Name = "txtZamestanec";
            this.txtZamestanec.Size = new System.Drawing.Size(172, 20);
            this.txtZamestanec.TabIndex = 28;
            // 
            // txtZakaznik
            // 
            this.txtZakaznik.BackColor = System.Drawing.Color.Pink;
            this.txtZakaznik.Location = new System.Drawing.Point(81, 64);
            this.txtZakaznik.Name = "txtZakaznik";
            this.txtZakaznik.Size = new System.Drawing.Size(172, 20);
            this.txtZakaznik.TabIndex = 27;
            // 
            // txtPrace
            // 
            this.txtPrace.BackColor = System.Drawing.Color.Pink;
            this.txtPrace.Location = new System.Drawing.Point(81, 38);
            this.txtPrace.Name = "txtPrace";
            this.txtPrace.Size = new System.Drawing.Size(172, 20);
            this.txtPrace.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Práce:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 406);
            this.dataGridView1.TabIndex = 24;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Pink;
            this.txtID.Location = new System.Drawing.Point(81, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(172, 20);
            this.txtID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // zakazky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnFiltr);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCas);
            this.Controls.Add(this.txtZamestanec);
            this.Controls.Add(this.txtZakaznik);
            this.Controls.Add(this.txtPrace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "zakazky";
            this.Text = "zakazky";
            this.Load += new System.EventHandler(this.zakazky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCas;
        private System.Windows.Forms.TextBox txtZamestanec;
        private System.Windows.Forms.TextBox txtZakaznik;
        private System.Windows.Forms.TextBox txtPrace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}