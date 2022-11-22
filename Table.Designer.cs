namespace ChessNut
{
    partial class Table
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WhiteCheckStatus = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TakenBlack = new System.Windows.Forms.Label();
            this.TakenWhite = new System.Windows.Forms.Label();
            this.BoardLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentTurnBox = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.BlackCheckStatus = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // WhiteCheckStatus
            // 
            this.WhiteCheckStatus.AutoSize = true;
            this.WhiteCheckStatus.Location = new System.Drawing.Point(620, 538);
            this.WhiteCheckStatus.Name = "WhiteCheckStatus";
            this.WhiteCheckStatus.Size = new System.Drawing.Size(122, 16);
            this.WhiteCheckStatus.TabIndex = 17;
            this.WhiteCheckStatus.Text = "White Check Status";
            this.WhiteCheckStatus.Click += new System.EventHandler(this.CheckStatus_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(623, 11);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(200, 26);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "Reset Pieces";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // TakenBlack
            // 
            this.TakenBlack.AutoSize = true;
            this.TakenBlack.Location = new System.Drawing.Point(620, 522);
            this.TakenBlack.Name = "TakenBlack";
            this.TakenBlack.Size = new System.Drawing.Size(128, 16);
            this.TakenBlack.TabIndex = 21;
            this.TakenBlack.Text = "Black Pieces Taken";
            // 
            // TakenWhite
            // 
            this.TakenWhite.AutoSize = true;
            this.TakenWhite.Location = new System.Drawing.Point(620, 62);
            this.TakenWhite.Name = "TakenWhite";
            this.TakenWhite.Size = new System.Drawing.Size(128, 16);
            this.TakenWhite.TabIndex = 22;
            this.TakenWhite.Text = "White Pieces Taken";
            // 
            // BoardLayoutPanel
            // 
            this.BoardLayoutPanel.ColumnCount = 8;
            this.BoardLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.Location = new System.Drawing.Point(67, 62);
            this.BoardLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BoardLayoutPanel.Name = "BoardLayoutPanel";
            this.BoardLayoutPanel.RowCount = 8;
            this.BoardLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.BoardLayoutPanel.Size = new System.Drawing.Size(533, 492);
            this.BoardLayoutPanel.TabIndex = 23;
            this.BoardLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardLayoutPanel_Paint);
            // 
            // CurrentTurnBox
            // 
            this.CurrentTurnBox.AutoSize = true;
            this.CurrentTurnBox.Location = new System.Drawing.Point(620, 290);
            this.CurrentTurnBox.Name = "CurrentTurnBox";
            this.CurrentTurnBox.Size = new System.Drawing.Size(79, 16);
            this.CurrentTurnBox.TabIndex = 24;
            this.CurrentTurnBox.Text = "Current Turn";
            this.CurrentTurnBox.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(620, 306);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(75, 16);
            this.Score.TabIndex = 25;
            this.Score.Text = "Score W-B ";
            this.Score.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // BlackCheckStatus
            // 
            this.BlackCheckStatus.AutoSize = true;
            this.BlackCheckStatus.Location = new System.Drawing.Point(620, 78);
            this.BlackCheckStatus.Name = "BlackCheckStatus";
            this.BlackCheckStatus.Size = new System.Drawing.Size(122, 16);
            this.BlackCheckStatus.TabIndex = 26;
            this.BlackCheckStatus.Text = "Black Check Status";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 613);
            this.Controls.Add(this.BlackCheckStatus);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.CurrentTurnBox);
            this.Controls.Add(this.TakenWhite);
            this.Controls.Add(this.TakenBlack);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.WhiteCheckStatus);
            this.Controls.Add(this.BoardLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Table";
            this.Text = "ChessNut";
            this.Load += new System.EventHandler(this.Table_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WhiteCheckStatus;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label TakenBlack;
        private System.Windows.Forms.Label TakenWhite;
        private System.Windows.Forms.TableLayoutPanel BoardLayoutPanel;
        private System.Windows.Forms.Label CurrentTurnBox;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label BlackCheckStatus;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

