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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(580, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
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
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cls;
    }
}