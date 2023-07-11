namespace UAS_PABD
{
    partial class Form7
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
            this.clr = new System.Windows.Forms.Button();
            this.idb = new System.Windows.Forms.TextBox();
            this.idpa = new System.Windows.Forms.TextBox();
            this.idp = new System.Windows.Forms.TextBox();
            this.hrg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsw = new System.Windows.Forms.DateTimePicker();
            this.tkm = new System.Windows.Forms.DateTimePicker();
            this.cls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // opn
            // 
            this.opn.Location = new System.Drawing.Point(651, 102);
            this.opn.Name = "opn";
            this.opn.Size = new System.Drawing.Size(106, 35);
            this.opn.TabIndex = 0;
            this.opn.Text = "Open";
            this.opn.UseVisualStyleBackColor = true;
            this.opn.Click += new System.EventHandler(this.opn_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(651, 160);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(106, 35);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sve
            // 
            this.sve.Location = new System.Drawing.Point(651, 210);
            this.sve.Name = "sve";
            this.sve.Size = new System.Drawing.Size(106, 35);
            this.sve.TabIndex = 2;
            this.sve.Text = "Save";
            this.sve.UseVisualStyleBackColor = true;
            this.sve.Click += new System.EventHandler(this.sve_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(651, 268);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(106, 35);
            this.clr.TabIndex = 3;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // idb
            // 
            this.idb.Location = new System.Drawing.Point(375, 248);
            this.idb.Name = "idb";
            this.idb.Size = new System.Drawing.Size(232, 26);
            this.idb.TabIndex = 4;
            // 
            // idpa
            // 
            this.idpa.Location = new System.Drawing.Point(375, 164);
            this.idpa.Name = "idpa";
            this.idpa.Size = new System.Drawing.Size(232, 26);
            this.idpa.TabIndex = 5;
            // 
            // idp
            // 
            this.idp.Location = new System.Drawing.Point(375, 210);
            this.idp.Name = "idp";
            this.idp.Size = new System.Drawing.Size(232, 26);
            this.idp.TabIndex = 6;
            // 
            // hrg
            // 
            this.hrg.Location = new System.Drawing.Point(375, 375);
            this.hrg.Name = "hrg";
            this.hrg.Size = new System.Drawing.Size(232, 26);
            this.hrg.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Penyewaan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Penyewa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID Baju";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tgl Sewa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tgl Kembali";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Harga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(463, 134);
            this.dataGridView1.TabIndex = 16;
            // 
            // tsw
            // 
            this.tsw.Location = new System.Drawing.Point(375, 290);
            this.tsw.Name = "tsw";
            this.tsw.Size = new System.Drawing.Size(172, 26);
            this.tsw.TabIndex = 17;
            // 
            // tkm
            // 
            this.tkm.Location = new System.Drawing.Point(375, 333);
            this.tkm.Name = "tkm";
            this.tkm.Size = new System.Drawing.Size(172, 26);
            this.tkm.TabIndex = 18;
            // 
            // cls
            // 
            this.cls.Location = new System.Drawing.Point(651, 325);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(106, 41);
            this.cls.TabIndex = 19;
            this.cls.Text = "Close";
            this.cls.UseVisualStyleBackColor = true;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.tkm);
            this.Controls.Add(this.tsw);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hrg);
            this.Controls.Add(this.idp);
            this.Controls.Add(this.idpa);
            this.Controls.Add(this.idb);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.sve);
            this.Controls.Add(this.add);
            this.Controls.Add(this.opn);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opn;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sve;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.TextBox idb;
        private System.Windows.Forms.TextBox idpa;
        private System.Windows.Forms.TextBox idp;
        private System.Windows.Forms.TextBox hrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker tsw;
        private System.Windows.Forms.DateTimePicker tkm;
        private System.Windows.Forms.Button cls;
    }
}