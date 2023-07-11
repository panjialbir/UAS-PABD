namespace UAS_PABD
{
    partial class Form2
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
            this.opn = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clr = new System.Windows.Forms.Button();
            this.idp = new System.Windows.Forms.TextBox();
            this.nmp = new System.Windows.Forms.TextBox();
            this.nhp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // opn
            // 
            this.opn.Location = new System.Drawing.Point(562, 81);
            this.opn.Name = "opn";
            this.opn.Size = new System.Drawing.Size(116, 33);
            this.opn.TabIndex = 0;
            this.opn.Text = "Open";
            this.opn.UseVisualStyleBackColor = true;
            this.opn.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(562, 146);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 35);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button2_Click);
            // 
            // sve
            // 
            this.sve.Location = new System.Drawing.Point(562, 203);
            this.sve.Name = "sve";
            this.sve.Size = new System.Drawing.Size(115, 33);
            this.sve.TabIndex = 2;
            this.sve.Text = "Save";
            this.sve.UseVisualStyleBackColor = true;
            this.sve.Click += new System.EventHandler(this.sve_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(466, 190);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(562, 262);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(116, 38);
            this.clr.TabIndex = 4;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // idp
            // 
            this.idp.Location = new System.Drawing.Point(265, 273);
            this.idp.Name = "idp";
            this.idp.Size = new System.Drawing.Size(264, 26);
            this.idp.TabIndex = 5;
            // 
            // nmp
            // 
            this.nmp.Location = new System.Drawing.Point(265, 316);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(263, 26);
            this.nmp.TabIndex = 6;
            // 
            // nhp
            // 
            this.nhp.Location = new System.Drawing.Point(266, 363);
            this.nhp.Name = "nhp";
            this.nhp.Size = new System.Drawing.Size(262, 26);
            this.nhp.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Penyewa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama Penyewa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "No.HP";
            // 
            // cls
            // 
            this.cls.Location = new System.Drawing.Point(562, 322);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(119, 34);
            this.cls.TabIndex = 11;
            this.cls.Text = "Close";
            this.cls.UseVisualStyleBackColor = true;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nhp);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.idp);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sve);
            this.Controls.Add(this.add);
            this.Controls.Add(this.opn);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opn;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.TextBox idp;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.TextBox nhp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cls;
    }
}