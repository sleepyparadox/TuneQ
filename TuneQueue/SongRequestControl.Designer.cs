namespace TuneQueue
{
    partial class SongRequestControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoSongName = new System.Windows.Forms.TextBox();
            this.InfoComment = new System.Windows.Forms.TextBox();
            this.InfoRequestedBy = new System.Windows.Forms.ComboBox();
            this.InfoUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddNext = new System.Windows.Forms.Button();
            this.BtnAddLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoSongName
            // 
            this.InfoSongName.Location = new System.Drawing.Point(106, 3);
            this.InfoSongName.Name = "InfoSongName";
            this.InfoSongName.Size = new System.Drawing.Size(286, 22);
            this.InfoSongName.TabIndex = 0;
            // 
            // InfoComment
            // 
            this.InfoComment.Location = new System.Drawing.Point(106, 31);
            this.InfoComment.Name = "InfoComment";
            this.InfoComment.Size = new System.Drawing.Size(286, 22);
            this.InfoComment.TabIndex = 1;
            // 
            // InfoRequestedBy
            // 
            this.InfoRequestedBy.FormattingEnabled = true;
            this.InfoRequestedBy.Location = new System.Drawing.Point(106, 59);
            this.InfoRequestedBy.Name = "InfoRequestedBy";
            this.InfoRequestedBy.Size = new System.Drawing.Size(286, 24);
            this.InfoRequestedBy.TabIndex = 2;
            this.InfoRequestedBy.Text = "Streamer";
            // 
            // InfoUrl
            // 
            this.InfoUrl.Location = new System.Drawing.Point(106, 89);
            this.InfoUrl.Name = "InfoUrl";
            this.InfoUrl.Size = new System.Drawing.Size(286, 22);
            this.InfoUrl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Song Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Comment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Requested By";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Url";
            // 
            // BtnAddNext
            // 
            this.BtnAddNext.Location = new System.Drawing.Point(271, 152);
            this.BtnAddNext.Name = "BtnAddNext";
            this.BtnAddNext.Size = new System.Drawing.Size(121, 23);
            this.BtnAddNext.TabIndex = 8;
            this.BtnAddNext.Text = "Add Next";
            this.BtnAddNext.UseVisualStyleBackColor = true;
            this.BtnAddNext.Click += new System.EventHandler(this.BtnAddNext_Click);
            // 
            // BtnAddLast
            // 
            this.BtnAddLast.Location = new System.Drawing.Point(144, 152);
            this.BtnAddLast.Name = "BtnAddLast";
            this.BtnAddLast.Size = new System.Drawing.Size(121, 23);
            this.BtnAddLast.TabIndex = 9;
            this.BtnAddLast.Text = "Add Last";
            this.BtnAddLast.UseVisualStyleBackColor = true;
            this.BtnAddLast.Click += new System.EventHandler(this.BtnAddLast_Click);
            // 
            // SongRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAddLast);
            this.Controls.Add(this.BtnAddNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoUrl);
            this.Controls.Add(this.InfoRequestedBy);
            this.Controls.Add(this.InfoComment);
            this.Controls.Add(this.InfoSongName);
            this.Name = "SongRequestControl";
            this.Size = new System.Drawing.Size(521, 255);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InfoSongName;
        private System.Windows.Forms.TextBox InfoComment;
        private System.Windows.Forms.ComboBox InfoRequestedBy;
        private System.Windows.Forms.TextBox InfoUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAddNext;
        private System.Windows.Forms.Button BtnAddLast;
    }
}
