namespace Miniproj
{
    partial class WebBrowserfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowserfrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tnew = new System.Windows.Forms.ToolStripMenuItem();
            this.newwindow = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Back_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.forword_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.url_TextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.Search_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.refresh_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.bookmark_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.home_toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.historyToolStripMenuItem,
            this.bookmarkToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tnew,
            this.newwindow,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // tnew
            // 
            this.tnew.Name = "tnew";
            this.tnew.Size = new System.Drawing.Size(145, 22);
            this.tnew.Text = "New Tab";
            this.tnew.Click += new System.EventHandler(this.tnew_Click);
            // 
            // newwindow
            // 
            this.newwindow.Name = "newwindow";
            this.newwindow.Size = new System.Drawing.Size(145, 22);
            this.newwindow.Text = "New Window";
            this.newwindow.Click += new System.EventHandler(this.newwindow_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "&History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // bookmarkToolStripMenuItem
            // 
            this.bookmarkToolStripMenuItem.Name = "bookmarkToolStripMenuItem";
            this.bookmarkToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.bookmarkToolStripMenuItem.Text = "&Bookmark";
            this.bookmarkToolStripMenuItem.Click += new System.EventHandler(this.bookmarkToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Back_toolStripButton1,
            this.forword_toolStripButton1,
            this.url_TextBox1,
            this.Search_toolStripButton1,
            this.refresh_toolStripButton1,
            this.ProgressBar1,
            this.bookmark_toolStripButton1,
            this.home_toolStripButton1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1068, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Back_toolStripButton1
            // 
            this.Back_toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Back_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("Back_toolStripButton1.Image")));
            this.Back_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back_toolStripButton1.Name = "Back_toolStripButton1";
            this.Back_toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.Back_toolStripButton1.ToolTipText = "Backword";
            this.Back_toolStripButton1.Click += new System.EventHandler(this.Back_toolStripButton1_Click);
            // 
            // forword_toolStripButton1
            // 
            this.forword_toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forword_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("forword_toolStripButton1.Image")));
            this.forword_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forword_toolStripButton1.Name = "forword_toolStripButton1";
            this.forword_toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.forword_toolStripButton1.ToolTipText = "Forward";
            this.forword_toolStripButton1.Click += new System.EventHandler(this.forword_toolStripButton1_Click);
            // 
            // url_TextBox1
            // 
            this.url_TextBox1.Name = "url_TextBox1";
            this.url_TextBox1.Size = new System.Drawing.Size(500, 25);
            // 
            // Search_toolStripButton1
            // 
            this.Search_toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Search_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("Search_toolStripButton1.Image")));
            this.Search_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_toolStripButton1.Name = "Search_toolStripButton1";
            this.Search_toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.Search_toolStripButton1.ToolTipText = "Search";
            this.Search_toolStripButton1.Click += new System.EventHandler(this.Search_toolStripButton1_Click);
            // 
            // refresh_toolStripButton1
            // 
            this.refresh_toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refresh_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("refresh_toolStripButton1.Image")));
            this.refresh_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh_toolStripButton1.Name = "refresh_toolStripButton1";
            this.refresh_toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.refresh_toolStripButton1.ToolTipText = "Refresh";
            this.refresh_toolStripButton1.Click += new System.EventHandler(this.refresh_toolStripButton1_Click);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 22);
            this.ProgressBar1.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // bookmark_toolStripButton1
            // 
            this.bookmark_toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmark_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("bookmark_toolStripButton1.Image")));
            this.bookmark_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmark_toolStripButton1.Name = "bookmark_toolStripButton1";
            this.bookmark_toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.bookmark_toolStripButton1.ToolTipText = "Bookmark";
            this.bookmark_toolStripButton1.Click += new System.EventHandler(this.bookmark_toolStripButton1_Click);
            // 
            // home_toolStripButton1
            // 
            this.home_toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.home_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("home_toolStripButton1.Image")));
            this.home_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home_toolStripButton1.Name = "home_toolStripButton1";
            this.home_toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.home_toolStripButton1.ToolTipText = "Save Home";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 334);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tab_control);
            // 
            // tabPage1
            // 
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1060, 308);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1060, 308);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "New +";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // WebBrowserfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 383);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WebBrowserfrm";
            this.Load += new System.EventHandler(this.WebBrowserfrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tnew;
        private System.Windows.Forms.ToolStripMenuItem newwindow;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Back_toolStripButton1;
        private System.Windows.Forms.ToolStripButton forword_toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox url_TextBox1;
        private System.Windows.Forms.ToolStripButton Search_toolStripButton1;
        private System.Windows.Forms.ToolStripButton refresh_toolStripButton1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar1;
        private System.Windows.Forms.ToolStripButton bookmark_toolStripButton1;
        private System.Windows.Forms.ToolStripButton home_toolStripButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}