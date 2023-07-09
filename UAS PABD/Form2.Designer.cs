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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clr = new System.Windows.Forms.Button();
            this.idp = new System.Windows.Forms.TextBox();
            this.nmp = new System.Windows.Forms.TextBox();
            this.nhp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sve
            // 
            this.sve.Location = new System.Drawing.Point(562, 203);
            this.sve.Name = "sve";
            this.sve.Size = new System.Drawing.Size(115, 33);
            this.sve.TabIndex = 2;
            this.sve.Text = "Save";
            this.sve.UseVisualStyleBackColor = true;
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
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(562, 262);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(116, 38);
            this.clr.TabIndex = 4;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nhp);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.idp);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sve);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.TextBox idp;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.TextBox nhp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}