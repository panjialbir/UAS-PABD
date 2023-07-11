namespace UAS_PABD
{
    partial class Form4
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
            this.idk = new System.Windows.Forms.TextBox();
            this.nmk = new System.Windows.Forms.TextBox();
            this.idc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.opn = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sve = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idk
            // 
            this.idk.Location = new System.Drawing.Point(185, 108);
            this.idk.Name = "idk";
            this.idk.Size = new System.Drawing.Size(216, 26);
            this.idk.TabIndex = 2;
            // 
            // nmk
            // 
            this.nmk.Location = new System.Drawing.Point(185, 156);
            this.nmk.Name = "nmk";
            this.nmk.Size = new System.Drawing.Size(215, 26);
            this.nmk.TabIndex = 3;
            // 
            // idc
            // 
            this.idc.Location = new System.Drawing.Point(185, 204);
            this.idc.Name = "idc";
            this.idc.Size = new System.Drawing.Size(211, 26);
            this.idc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Karyawan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Karyawan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Cabang";
            // 
            // opn
            // 
            this.opn.Location = new System.Drawing.Point(161, 312);
            this.opn.Name = "opn";
            this.opn.Size = new System.Drawing.Size(112, 41);
            this.opn.TabIndex = 8;
            this.opn.Text = "Open";
            this.opn.UseVisualStyleBackColor = true;
            this.opn.Click += new System.EventHandler(this.opn_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(301, 316);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(95, 37);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sve
            // 
            this.sve.Location = new System.Drawing.Point(436, 317);
            this.sve.Name = "sve";
            this.sve.Size = new System.Drawing.Size(106, 36);
            this.sve.TabIndex = 10;
            this.sve.Text = "Save";
            this.sve.UseVisualStyleBackColor = true;
            this.sve.Click += new System.EventHandler(this.sve_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(580, 316);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(90, 37);
            this.clr.TabIndex = 11;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(465, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(302, 166);
            this.dataGridView1.TabIndex = 12;
            // 
            // cls
            // 
            this.cls.Location = new System.Drawing.Point(373, 390);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(92, 33);
            this.cls.TabIndex = 13;
            this.cls.Text = "Close";
            this.cls.UseVisualStyleBackColor = true;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.sve);
            this.Controls.Add(this.add);
            this.Controls.Add(this.opn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idc);
            this.Controls.Add(this.nmk);
            this.Controls.Add(this.idk);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idk;
        private System.Windows.Forms.TextBox nmk;
        private System.Windows.Forms.TextBox idc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button opn;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sve;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cls;
    }
}