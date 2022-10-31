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
            this.Moves = new System.Windows.Forms.Label();
            this.CurrentPiece = new System.Windows.Forms.Label();
            this.Takable = new System.Windows.Forms.Label();
            this.CheckStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TakenBlack = new System.Windows.Forms.Label();
            this.TakenWhite = new System.Windows.Forms.Label();
            this.BoardLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentTurnBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Moves
            // 
            this.Moves.AutoSize = true;
            this.Moves.Location = new System.Drawing.Point(620, 289);
            this.Moves.Name = "Moves";
            this.Moves.Size = new System.Drawing.Size(48, 16);
            this.Moves.TabIndex = 10;
            this.Moves.Text = "Moves";
            // 
            // CurrentPiece
            // 
            this.CurrentPiece.AutoSize = true;
            this.CurrentPiece.Location = new System.Drawing.Point(620, 273);
            this.CurrentPiece.Name = "CurrentPiece";
            this.CurrentPiece.Size = new System.Drawing.Size(87, 16);
            this.CurrentPiece.TabIndex = 12;
            this.CurrentPiece.Text = "Current Piece";
            this.CurrentPiece.Click += new System.EventHandler(this.CurrentPiece_Click);
            // 
            // Takable
            // 
            this.Takable.AutoSize = true;
            this.Takable.Location = new System.Drawing.Point(620, 305);
            this.Takable.Name = "Takable";
            this.Takable.Size = new System.Drawing.Size(44, 16);
            this.Takable.TabIndex = 16;
            this.Takable.Text = "label5";
            this.Takable.Click += new System.EventHandler(this.Takable_Click);
            // 
            // CheckStatus
            // 
            this.CheckStatus.AutoSize = true;
            this.CheckStatus.Location = new System.Drawing.Point(620, 321);
            this.CheckStatus.Name = "CheckStatus";
            this.CheckStatus.Size = new System.Drawing.Size(44, 16);
            this.CheckStatus.TabIndex = 17;
            this.CheckStatus.Text = "label5";
            this.CheckStatus.Click += new System.EventHandler(this.CheckStatus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(620, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Info";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(623, 62);
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
            this.TakenBlack.Location = new System.Drawing.Point(620, 337);
            this.TakenBlack.Name = "TakenBlack";
            this.TakenBlack.Size = new System.Drawing.Size(123, 16);
            this.TakenBlack.TabIndex = 21;
            this.TakenBlack.Text = "back pieces taken :";
            // 
            // TakenWhite
            // 
            this.TakenWhite.AutoSize = true;
            this.TakenWhite.Location = new System.Drawing.Point(620, 353);
            this.TakenWhite.Name = "TakenWhite";
            this.TakenWhite.Size = new System.Drawing.Size(123, 16);
            this.TakenWhite.TabIndex = 22;
            this.TakenWhite.Text = "white pieces taken :";
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
            this.CurrentTurnBox.Location = new System.Drawing.Point(620, 257);
            this.CurrentTurnBox.Name = "CurrentTurnBox";
            this.CurrentTurnBox.Size = new System.Drawing.Size(79, 16);
            this.CurrentTurnBox.TabIndex = 24;
            this.CurrentTurnBox.Text = "Current Turn";
            this.CurrentTurnBox.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 615);
            this.Controls.Add(this.CurrentTurnBox);
            this.Controls.Add(this.TakenWhite);
            this.Controls.Add(this.TakenBlack);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckStatus);
            this.Controls.Add(this.Takable);
            this.Controls.Add(this.CurrentPiece);
            this.Controls.Add(this.Moves);
            this.Controls.Add(this.BoardLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Table";
            this.Text = "ChessNut";
            this.Load += new System.EventHandler(this.Table_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Moves;
        private System.Windows.Forms.Label CurrentPiece;
        private System.Windows.Forms.Label Takable;
        private System.Windows.Forms.Label CheckStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label TakenBlack;
        private System.Windows.Forms.Label TakenWhite;
        private System.Windows.Forms.TableLayoutPanel BoardLayoutPanel;
        private System.Windows.Forms.Label CurrentTurnBox;
    }
}

