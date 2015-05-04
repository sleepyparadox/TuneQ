namespace TuneQ
{
    partial class ConfigControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.TwitchDisplayName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TwitchChannel = new System.Windows.Forms.TextBox();
            this.TwitchOAuth = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.70348F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.29652F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TwitchDisplayName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TwitchChannel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TwitchOAuth, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 433);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Twitch Token (include\"oath:\")";
            // 
            // TwitchDisplayName
            // 
            this.TwitchDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TwitchDisplayName.Location = new System.Drawing.Point(239, 4);
            this.TwitchDisplayName.Name = "TwitchDisplayName";
            this.TwitchDisplayName.Size = new System.Drawing.Size(220, 22);
            this.TwitchDisplayName.TabIndex = 1;
            this.TwitchDisplayName.TextChanged += new System.EventHandler(this.TwitchDisplayName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Twitch Display Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Twitch Channel #";
            // 
            // TwitchChannel
            // 
            this.TwitchChannel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TwitchChannel.Location = new System.Drawing.Point(239, 34);
            this.TwitchChannel.Name = "TwitchChannel";
            this.TwitchChannel.Size = new System.Drawing.Size(220, 22);
            this.TwitchChannel.TabIndex = 3;
            this.TwitchChannel.TextChanged += new System.EventHandler(this.TwitchChannel_TextChanged);
            // 
            // TwitchOAuth
            // 
            this.TwitchOAuth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TwitchOAuth.Location = new System.Drawing.Point(239, 64);
            this.TwitchOAuth.Name = "TwitchOAuth";
            this.TwitchOAuth.Size = new System.Drawing.Size(220, 22);
            this.TwitchOAuth.TabIndex = 4;
            this.TwitchOAuth.TextChanged += new System.EventHandler(this.TwitchOAuth_TextChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ResetButton.Location = new System.Drawing.Point(239, 93);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(158, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset to defaults";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ConfigControl";
            this.Size = new System.Drawing.Size(661, 433);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TwitchDisplayName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TwitchChannel;
        private System.Windows.Forms.TextBox TwitchOAuth;
        private System.Windows.Forms.Button ResetButton;
    }
}
