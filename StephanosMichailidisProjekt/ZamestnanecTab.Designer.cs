namespace StephanosMichailidisProjekt
{
    partial class ZamestnanecTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZamestnanecTab));
            this.button1 = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJobtype = new System.Windows.Forms.TextBox();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(216, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 45);
            this.button1.TabIndex = 53;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Pink;
            this.btnList.Location = new System.Drawing.Point(10, 373);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(158, 45);
            this.btnList.TabIndex = 52;
            this.btnList.Text = "Zobrazit data";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Pink;
            this.btnDel.Location = new System.Drawing.Point(10, 322);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(158, 45);
            this.btnDel.TabIndex = 51;
            this.btnDel.Text = "Odstranit Záznam";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.Location = new System.Drawing.Point(10, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 45);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Přidat záznam";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Druh práce:";
            // 
            // txtJobtype
            // 
            this.txtJobtype.BackColor = System.Drawing.Color.Pink;
            this.txtJobtype.Location = new System.Drawing.Point(114, 189);
            this.txtJobtype.Name = "txtJobtype";
            this.txtJobtype.Size = new System.Drawing.Size(172, 20);
            this.txtJobtype.TabIndex = 48;
            // 
            // txtCust
            // 
            this.txtCust.BackColor = System.Drawing.Color.Pink;
            this.txtCust.Location = new System.Drawing.Point(114, 88);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(172, 20);
            this.txtCust.TabIndex = 47;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.Pink;
            this.txtTime.Location = new System.Drawing.Point(114, 139);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(172, 20);
            this.txtTime.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Čas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Zákazník:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Zaměstnanecké ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Pink;
            this.txtID.Location = new System.Drawing.Point(114, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(172, 20);
            this.txtID.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 406);
            this.dataGridView1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "label5";
            // 
            // ZamestnanecTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJobtype);
            this.Controls.Add(this.txtCust);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZamestnanecTab";
            this.Text = "ZamestnanecTab";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJobtype;
        private System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}