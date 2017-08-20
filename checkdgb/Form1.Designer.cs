namespace checkdgb
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.başlangıcaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlangıçtanÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başlangıcaEkleToolStripMenuItem,
            this.başlangıçtanÇıkarToolStripMenuItem,
            this.programıKapatToolStripMenuItem,
            this.ayarYenileToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 136);
            // 
            // başlangıcaEkleToolStripMenuItem
            // 
            this.başlangıcaEkleToolStripMenuItem.Name = "başlangıcaEkleToolStripMenuItem";
            this.başlangıcaEkleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.başlangıcaEkleToolStripMenuItem.Text = "Başlangıca Ekle";
            this.başlangıcaEkleToolStripMenuItem.Click += new System.EventHandler(this.başlangıcaEkleToolStripMenuItem_Click);
            // 
            // başlangıçtanÇıkarToolStripMenuItem
            // 
            this.başlangıçtanÇıkarToolStripMenuItem.Name = "başlangıçtanÇıkarToolStripMenuItem";
            this.başlangıçtanÇıkarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.başlangıçtanÇıkarToolStripMenuItem.Text = "Başlangıçtan Çıkar";
            this.başlangıçtanÇıkarToolStripMenuItem.Click += new System.EventHandler(this.başlangıçtanÇıkarToolStripMenuItem_Click);
            // 
            // programıKapatToolStripMenuItem
            // 
            this.programıKapatToolStripMenuItem.Name = "programıKapatToolStripMenuItem";
            this.programıKapatToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.programıKapatToolStripMenuItem.Text = "Programı Kapat";
            this.programıKapatToolStripMenuItem.Click += new System.EventHandler(this.programıKapatToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // ayarYenileToolStripMenuItem
            // 
            this.ayarYenileToolStripMenuItem.Name = "ayarYenileToolStripMenuItem";
            this.ayarYenileToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ayarYenileToolStripMenuItem.Text = "Ayar Yenile";
            this.ayarYenileToolStripMenuItem.Click += new System.EventHandler(this.ayarYenileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 157);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check DGB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem başlangıcaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlangıçtanÇıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programıKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarYenileToolStripMenuItem;

    }
}

