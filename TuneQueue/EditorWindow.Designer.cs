namespace TuneQueue
{
    partial class EditorWindow
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
            this.EditorMenuScript = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SongRequestControl = new TuneQueue.SongRequestControl();
            this.BrowseSplit = new System.Windows.Forms.SplitContainer();
            this.PlaylistTabs = new System.Windows.Forms.TabControl();
            this.EditorMenuScript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrowseSplit)).BeginInit();
            this.BrowseSplit.Panel1.SuspendLayout();
            this.BrowseSplit.Panel2.SuspendLayout();
            this.BrowseSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorMenuScript
            // 
            this.EditorMenuScript.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.EditorMenuScript.Location = new System.Drawing.Point(0, 0);
            this.EditorMenuScript.Name = "EditorMenuScript";
            this.EditorMenuScript.Size = new System.Drawing.Size(840, 28);
            this.EditorMenuScript.TabIndex = 0;
            this.EditorMenuScript.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.CreateNewPlaylist);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // SongRequestControl
            // 
            this.SongRequestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongRequestControl.Location = new System.Drawing.Point(0, 0);
            this.SongRequestControl.Name = "SongRequestControl";
            this.SongRequestControl.SelectedPlaylist = null;
            this.SongRequestControl.Size = new System.Drawing.Size(840, 316);
            this.SongRequestControl.TabIndex = 0;
            // 
            // BrowseSplit
            // 
            this.BrowseSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowseSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.BrowseSplit.Location = new System.Drawing.Point(0, 28);
            this.BrowseSplit.Name = "BrowseSplit";
            this.BrowseSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BrowseSplit.Panel1
            // 
            this.BrowseSplit.Panel1.Controls.Add(this.PlaylistTabs);
            // 
            // BrowseSplit.Panel2
            // 
            this.BrowseSplit.Panel2.Controls.Add(this.SongRequestControl);
            this.BrowseSplit.Size = new System.Drawing.Size(840, 459);
            this.BrowseSplit.SplitterDistance = 139;
            this.BrowseSplit.TabIndex = 1;
            // 
            // PlaylistTabs
            // 
            this.PlaylistTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaylistTabs.Location = new System.Drawing.Point(0, 0);
            this.PlaylistTabs.Name = "PlaylistTabs";
            this.PlaylistTabs.SelectedIndex = 0;
            this.PlaylistTabs.Size = new System.Drawing.Size(840, 139);
            this.PlaylistTabs.TabIndex = 0;
            this.PlaylistTabs.TabIndexChanged += new System.EventHandler(this.TabsChanged);
            // 
            // EditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 487);
            this.Controls.Add(this.BrowseSplit);
            this.Controls.Add(this.EditorMenuScript);
            this.Name = "EditorWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditorWindow_Load);
            this.EditorMenuScript.ResumeLayout(false);
            this.EditorMenuScript.PerformLayout();
            this.BrowseSplit.Panel1.ResumeLayout(false);
            this.BrowseSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BrowseSplit)).EndInit();
            this.BrowseSplit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip EditorMenuScript;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private SongRequestControl SongRequestControl;
        private System.Windows.Forms.SplitContainer BrowseSplit;
        private System.Windows.Forms.TabControl PlaylistTabs;

    }
}

