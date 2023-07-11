namespace UAS_PABD
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.opn = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.sve = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.idk = new System.Windows.Forms.TextBox();
            this.nmk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cls = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // opn
            // 
            this.opn.Location = new System.Drawing.Point(609, 82);
            this.opn.Name = "opn";
            this.opn.Size = new System.Drawing.Size(121, 34);
            this.opn.TabIndex = 0;
            this.opn.Text = "Open";
            this.opn.UseVisualStyleBackColor = true;
            this.opn.Click += new System.EventHandler(this.opn_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(609, 140);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 32);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sve
            // 
            this.sve.Location = new System.Drawing.Point(609, 203);
            this.sve.Name = "sve";
            this.sve.Size = new System.Drawing.Size(121, 39);
            this.sve.TabIndex = 2;
            this.sve.Text = "Save";
            this.sve.UseVisualStyleBackColor = true;
            this.sve.Click += new System.EventHandler(this.sve_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(609, 269);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(121, 37);
            this.clr.TabIndex = 3;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // idk
            // 
            this.idk.Location = new System.Drawing.Point(326, 168);
            this.idk.Name = "idk";
            this.idk.Size = new System.Drawing.Size(211, 26);
            this.idk.TabIndex = 5;
            // 
            // nmk
            // 
            this.nmk.Location = new System.Drawing.Point(326, 216);
            this.nmk.Name = "nmk";
            this.nmk.Size = new System.Drawing.Size(211, 26);
            this.nmk.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nama Kategori";
            // 
            // cls
            // 
            this.cls.Location = new System.Drawing.Point(609, 327);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(119, 41);
            this.cls.TabIndex = 9;
            this.cls.Text = "Close";
            this.cls.UseVisualStyleBackColor = true;
            this.cls.Click += new System.EventHandler(this.cls_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(287, 117);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmk);
            this.Controls.Add(this.idk);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.sve);
            this.Controls.Add(this.add);
            this.Controls.Add(this.opn);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opn;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sve;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox idk;
        private System.Windows.Forms.TextBox nmk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cls;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}