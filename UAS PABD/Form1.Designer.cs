namespace UAS_PABD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataPenyewaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBajuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCabangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPenyewaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPenyewaToolStripMenuItem,
            this.dataBajuToolStripMenuItem,
            this.dataKaryawanToolStripMenuItem,
            this.dataKategoriToolStripMenuItem,
            this.dataCabangToolStripMenuItem,
            this.dataPenyewaanToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // dataPenyewaToolStripMenuItem
            // 
            this.dataPenyewaToolStripMenuItem.Name = "dataPenyewaToolStripMenuItem";
            this.dataPenyewaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataPenyewaToolStripMenuItem.Text = "Data Penyewa";
            this.dataPenyewaToolStripMenuItem.Click += new System.EventHandler(this.dataPenyewaToolStripMenuItem_Click);
            // 
            // dataBajuToolStripMenuItem
            // 
            this.dataBajuToolStripMenuItem.Name = "dataBajuToolStripMenuItem";
            this.dataBajuToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataBajuToolStripMenuItem.Text = "Data Baju";
            // 
            // dataKaryawanToolStripMenuItem
            // 
            this.dataKaryawanToolStripMenuItem.Name = "dataKaryawanToolStripMenuItem";
            this.dataKaryawanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataKaryawanToolStripMenuItem.Text = "Data Karyawan";
            // 
            // dataKategoriToolStripMenuItem
            // 
            this.dataKategoriToolStripMenuItem.Name = "dataKategoriToolStripMenuItem";
            this.dataKategoriToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataKategoriToolStripMenuItem.Text = "Data Kategori";
            // 
            // dataCabangToolStripMenuItem
            // 
            this.dataCabangToolStripMenuItem.Name = "dataCabangToolStripMenuItem";
            this.dataCabangToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataCabangToolStripMenuItem.Text = "Data Cabang";
            // 
            // dataPenyewaanToolStripMenuItem
            // 
            this.dataPenyewaanToolStripMenuItem.Name = "dataPenyewaanToolStripMenuItem";
            this.dataPenyewaanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dataPenyewaanToolStripMenuItem.Text = "Data Penyewaan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataPenyewaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBajuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataCabangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPenyewaanToolStripMenuItem;
    }
}

