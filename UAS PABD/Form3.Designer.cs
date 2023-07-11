namespace UAS_PABD
{
    partial class Form3
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
            this.mbj = new System.Windows.Forms.TextBox();
            this.idk = new System.Windows.Forms.TextBox();
            this.hrg = new System.Windows.Forms.TextBox();
            this.idb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sve = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.opn = new System.Windows.Forms.Button();
            this.ukr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mbj
            // 
            this.mbj.Location = new System.Drawing.Point(389, 230);
            this.mbj.Name = "mbj";
            this.mbj.Size = new System.Drawing.Size(171, 26);
            this.mbj.TabIndex = 0;
            // 
            // idk
            // 
            this.idk.Location = new System.Drawing.Point(391, 357);
            this.idk.Name = "idk";
            this.idk.Size = new System.Drawing.Size(170, 26);
            this.idk.TabIndex = 1;
            // 
            // hrg
            // 
            this.hrg.Location = new System.Drawing.Point(391, 315);
            this.hrg.Name = "hrg";
            this.hrg.Size = new System.Drawing.Size(170, 26);
            this.hrg.TabIndex = 2;
            // 
            // idb
            // 
            this.idb.Location = new System.Drawing.Point(391, 196);
            this.idb.Name = "idb";
            this.idb.Size = new System.Drawing.Size(170, 26);
            this.idb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Baju";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Merk Baju";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ukuran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Harga Sewa";
            // 
            // sve
            // 
            this.sve.Location = new System.Drawing.Point(639, 202);
            this.sve.Name = "sve";
            this.sve.Size = new System.Drawing.Size(92, 34);
            this.sve.TabIndex = 14;
            this.sve.Text = "Save";
            this.sve.UseVisualStyleBackColor = true;
            this.sve.Click += new System.EventHandler(this.sve_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(639, 257);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(87, 37);
            this.clr.TabIndex = 15;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(639, 153);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(92, 26);
            this.add.TabIndex = 16;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // opn
            // 
            this.opn.Location = new System.Drawing.Point(639, 102);
            this.opn.Name = "opn";
            this.opn.Size = new System.Drawing.Size(92, 32);
            this.opn.TabIndex = 17;
            this.opn.Text = "Open";
            this.opn.UseVisualStyleBackColor = true;
            this.opn.Click += new System.EventHandler(this.opn_Click);
            // 
            // ukr
            // 
            this.ukr.FormattingEnabled = true;
            this.ukr.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.ukr.Location = new System.Drawing.Point(391, 273);
            this.ukr.Name = "ukr";
            this.ukr.Size = new System.Drawing.Size(99, 28);
            this.ukr.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID Kategori";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(208, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(353, 152);
            this.dataGridView1.TabIndex = 20;
            // 
            // cls
            // 
            this.cls.Location = new System.Drawing.Point(639, 313);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(87, 38);
            this.cls.TabIndex = 21;
            this.cls.Text = "Close";
            this.cls.UseVisualStyleBackColor = true;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ukr);
            this.Controls.Add(this.opn);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.sve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idb);
            this.Controls.Add(this.hrg);
            this.Controls.Add(this.idk);
            this.Controls.Add(this.mbj);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mbj;
        private System.Windows.Forms.TextBox idk;
        private System.Windows.Forms.TextBox hrg;
        private System.Windows.Forms.TextBox idb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sve;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button opn;
        private System.Windows.Forms.ComboBox ukr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cls;
    }
}