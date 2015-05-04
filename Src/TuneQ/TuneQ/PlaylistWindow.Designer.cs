namespace TuneQ
{
    partial class PlaylistWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PlayTab = new System.Windows.Forms.TabPage();
            this.EditPlaylistSplit = new System.Windows.Forms.SplitContainer();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.EditPanelShow = new System.Windows.Forms.CheckBox();
            this.TwitchTab = new System.Windows.Forms.TabPage();
            this.TwitchLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TwitchListeningCheck = new System.Windows.Forms.CheckBox();
            this.TwitchOut = new System.Windows.Forms.RichTextBox();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFileLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFileLoadYT = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSongs = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSongsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSongsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxSongsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.TestBox = new System.Windows.Forms.TextBox();
            this.TestBtn = new System.Windows.Forms.Button();
            this.configControl1 = new ConfigControl();
            this.tabControl1.SuspendLayout();
            this.PlayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPlaylistSplit)).BeginInit();
            this.EditPlaylistSplit.Panel1.SuspendLayout();
            this.EditPlaylistSplit.Panel2.SuspendLayout();
            this.EditPlaylistSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.TwitchTab.SuspendLayout();
            this.TwitchLayout.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PlayTab);
            this.tabControl1.Controls.Add(this.TwitchTab);
            this.tabControl1.Controls.Add(this.ConfigTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 603);
            this.tabControl1.TabIndex = 1;
            // 
            // PlayTab
            // 
            this.PlayTab.Controls.Add(this.EditPlaylistSplit);
            this.PlayTab.Location = new System.Drawing.Point(4, 25);
            this.PlayTab.Name = "PlayTab";
            this.PlayTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayTab.Size = new System.Drawing.Size(1090, 574);
            this.PlayTab.TabIndex = 0;
            this.PlayTab.Text = "Play";
            this.PlayTab.UseVisualStyleBackColor = true;
            // 
            // EditPlaylistSplit
            // 
            this.EditPlaylistSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditPlaylistSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.EditPlaylistSplit.Location = new System.Drawing.Point(3, 3);
            this.EditPlaylistSplit.Name = "EditPlaylistSplit";
            this.EditPlaylistSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // EditPlaylistSplit.Panel1
            // 
            this.EditPlaylistSplit.Panel1.Controls.Add(this.DataGrid);
            // 
            // EditPlaylistSplit.Panel2
            // 
            this.EditPlaylistSplit.Panel2.Controls.Add(this.TestBtn);
            this.EditPlaylistSplit.Panel2.Controls.Add(this.TestBox);
            this.EditPlaylistSplit.Panel2.Controls.Add(this.EditPanelShow);
            this.EditPlaylistSplit.Size = new System.Drawing.Size(1084, 568);
            this.EditPlaylistSplit.SplitterDistance = 432;
            this.EditPlaylistSplit.TabIndex = 1;
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(1084, 432);
            this.DataGrid.TabIndex = 0;
            // 
            // EditPanelShow
            // 
            this.EditPanelShow.AutoSize = true;
            this.EditPanelShow.Location = new System.Drawing.Point(5, 3);
            this.EditPanelShow.Name = "EditPanelShow";
            this.EditPanelShow.Size = new System.Drawing.Size(64, 21);
            this.EditPanelShow.TabIndex = 0;
            this.EditPanelShow.Text = "Show";
            this.EditPanelShow.UseVisualStyleBackColor = true;
            // 
            // TwitchTab
            // 
            this.TwitchTab.Controls.Add(this.TwitchLayout);
            this.TwitchTab.Location = new System.Drawing.Point(4, 25);
            this.TwitchTab.Name = "TwitchTab";
            this.TwitchTab.Size = new System.Drawing.Size(1090, 574);
            this.TwitchTab.TabIndex = 2;
            this.TwitchTab.Text = "Twitch";
            this.TwitchTab.UseVisualStyleBackColor = true;
            // 
            // TwitchLayout
            // 
            this.TwitchLayout.ColumnCount = 1;
            this.TwitchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TwitchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TwitchLayout.Controls.Add(this.TwitchListeningCheck, 0, 0);
            this.TwitchLayout.Controls.Add(this.TwitchOut, 0, 1);
            this.TwitchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwitchLayout.Location = new System.Drawing.Point(0, 0);
            this.TwitchLayout.Name = "TwitchLayout";
            this.TwitchLayout.RowCount = 2;
            this.TwitchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TwitchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TwitchLayout.Size = new System.Drawing.Size(1090, 574);
            this.TwitchLayout.TabIndex = 0;
            // 
            // TwitchListeningCheck
            // 
            this.TwitchListeningCheck.AutoSize = true;
            this.TwitchListeningCheck.Location = new System.Drawing.Point(3, 3);
            this.TwitchListeningCheck.Name = "TwitchListeningCheck";
            this.TwitchListeningCheck.Size = new System.Drawing.Size(87, 21);
            this.TwitchListeningCheck.TabIndex = 0;
            this.TwitchListeningCheck.Text = "Listening";
            this.TwitchListeningCheck.UseVisualStyleBackColor = true;
            this.TwitchListeningCheck.CheckedChanged += new System.EventHandler(this.TwitchListeningCheck_CheckedChanged);
            // 
            // TwitchOut
            // 
            this.TwitchOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwitchOut.Location = new System.Drawing.Point(3, 33);
            this.TwitchOut.Name = "TwitchOut";
            this.TwitchOut.Size = new System.Drawing.Size(1084, 538);
            this.TwitchOut.TabIndex = 1;
            this.TwitchOut.Text = "";
            // 
            // ConfigTab
            // 
            this.ConfigTab.Controls.Add(this.configControl1);
            this.ConfigTab.Location = new System.Drawing.Point(4, 25);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigTab.Size = new System.Drawing.Size(1090, 574);
            this.ConfigTab.TabIndex = 1;
            this.ConfigTab.Text = "Config";
            this.ConfigTab.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxFile,
            this.ctxSongs});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 52);
            // 
            // ctxFile
            // 
            this.ctxFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxFileNew,
            this.ctxFileLoadFile,
            this.ctxFileLoadYT,
            this.ctxFileSaveAs});
            this.ctxFile.Name = "ctxFile";
            this.ctxFile.Size = new System.Drawing.Size(175, 24);
            this.ctxFile.Text = "File";
            // 
            // ctxFileNew
            // 
            this.ctxFileNew.Name = "ctxFileNew";
            this.ctxFileNew.Size = new System.Drawing.Size(170, 24);
            this.ctxFileNew.Text = "New";
            this.ctxFileNew.Click += new System.EventHandler(this.ctxFileNew_Click);
            // 
            // ctxFileLoadFile
            // 
            this.ctxFileLoadFile.Name = "ctxFileLoadFile";
            this.ctxFileLoadFile.Size = new System.Drawing.Size(170, 24);
            this.ctxFileLoadFile.Text = "Load File";
            // 
            // ctxFileLoadYT
            // 
            this.ctxFileLoadYT.Name = "ctxFileLoadYT";
            this.ctxFileLoadYT.Size = new System.Drawing.Size(170, 24);
            this.ctxFileLoadYT.Text = "Load Youtube";
            // 
            // ctxFileSaveAs
            // 
            this.ctxFileSaveAs.Name = "ctxFileSaveAs";
            this.ctxFileSaveAs.Size = new System.Drawing.Size(170, 24);
            this.ctxFileSaveAs.Text = "Save As";
            // 
            // ctxSongs
            // 
            this.ctxSongs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxSongsAdd,
            this.ctxSongsEdit,
            this.ctxSongsRemove});
            this.ctxSongs.Name = "ctxSongs";
            this.ctxSongs.Size = new System.Drawing.Size(175, 24);
            this.ctxSongs.Text = "Song Requests";
            // 
            // ctxSongsAdd
            // 
            this.ctxSongsAdd.Name = "ctxSongsAdd";
            this.ctxSongsAdd.Size = new System.Drawing.Size(132, 24);
            this.ctxSongsAdd.Text = "Add";
            // 
            // ctxSongsEdit
            // 
            this.ctxSongsEdit.Name = "ctxSongsEdit";
            this.ctxSongsEdit.Size = new System.Drawing.Size(132, 24);
            this.ctxSongsEdit.Text = "Edit";
            // 
            // ctxSongsRemove
            // 
            this.ctxSongsRemove.Name = "ctxSongsRemove";
            this.ctxSongsRemove.Size = new System.Drawing.Size(132, 24);
            this.ctxSongsRemove.Text = "Remove";
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(5, 30);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(468, 22);
            this.TestBox.TabIndex = 1;
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(397, 59);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(75, 23);
            this.TestBtn.TabIndex = 2;
            this.TestBtn.Text = "button1";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // configControl1
            // 
            this.configControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configControl1.Location = new System.Drawing.Point(3, 3);
            this.configControl1.Name = "configControl1";
            this.configControl1.Size = new System.Drawing.Size(1084, 568);
            this.configControl1.TabIndex = 0;
            // 
            // PlaylistWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 603);
            this.Controls.Add(this.tabControl1);
            this.Name = "PlaylistWindow";
            this.Text = "TuneQ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlaylistWindow_FormClosed);
            this.Load += new System.EventHandler(this.PlaylistWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.PlayTab.ResumeLayout(false);
            this.EditPlaylistSplit.Panel1.ResumeLayout(false);
            this.EditPlaylistSplit.Panel2.ResumeLayout(false);
            this.EditPlaylistSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditPlaylistSplit)).EndInit();
            this.EditPlaylistSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.TwitchTab.ResumeLayout(false);
            this.TwitchLayout.ResumeLayout(false);
            this.TwitchLayout.PerformLayout();
            this.ConfigTab.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ConfigTab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxFile;
        private System.Windows.Forms.ToolStripMenuItem ctxFileNew;
        private System.Windows.Forms.ToolStripMenuItem ctxFileLoadFile;
        private System.Windows.Forms.ToolStripMenuItem ctxFileLoadYT;
        private System.Windows.Forms.ToolStripMenuItem ctxFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem ctxSongs;
        private System.Windows.Forms.ToolStripMenuItem ctxSongsEdit;
        private System.Windows.Forms.ToolStripMenuItem ctxSongsRemove;
        private System.Windows.Forms.ToolStripMenuItem ctxSongsAdd;
        private System.Windows.Forms.TabPage PlayTab;
        private System.Windows.Forms.SplitContainer EditPlaylistSplit;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.CheckBox EditPanelShow;
        private ConfigControl configControl1;
        private System.Windows.Forms.TabPage TwitchTab;
        private System.Windows.Forms.TableLayoutPanel TwitchLayout;
        private System.Windows.Forms.CheckBox TwitchListeningCheck;
        private System.Windows.Forms.RichTextBox TwitchOut;
        private System.Windows.Forms.TextBox TestBox;
        private System.Windows.Forms.Button TestBtn;
    }
}

