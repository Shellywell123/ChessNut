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
            this.WhitePieceSelectionBox = new System.Windows.Forms.ComboBox();
            this.BlackPieceSelectionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Moves = new System.Windows.Forms.Label();
            this.CurrentPiece = new System.Windows.Forms.Label();
            this.AvailableMoves = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Takable = new System.Windows.Forms.Label();
            this.CheckStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.TakenBlack = new System.Windows.Forms.Label();
            this.TakenWhite = new System.Windows.Forms.Label();
            this.BoardLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // WhitePieceSelectionBox
            // 
            this.WhitePieceSelectionBox.FormattingEnabled = true;
            this.WhitePieceSelectionBox.Location = new System.Drawing.Point(468, 54);
            this.WhitePieceSelectionBox.Name = "WhitePieceSelectionBox";
            this.WhitePieceSelectionBox.Size = new System.Drawing.Size(151, 21);
            this.WhitePieceSelectionBox.TabIndex = 0;
            this.WhitePieceSelectionBox.Text = "Piece ...";
            this.WhitePieceSelectionBox.SelectedIndexChanged += new System.EventHandler(this.WhitePieceSelectionBox_SelectedIndexChanged);
            // 
            // BlackPieceSelectionBox
            // 
            this.BlackPieceSelectionBox.FormattingEnabled = true;
            this.BlackPieceSelectionBox.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Knight",
            "Rook",
            "Bishop"});
            this.BlackPieceSelectionBox.Location = new System.Drawing.Point(468, 102);
            this.BlackPieceSelectionBox.Name = "BlackPieceSelectionBox";
            this.BlackPieceSelectionBox.Size = new System.Drawing.Size(151, 21);
            this.BlackPieceSelectionBox.TabIndex = 5;
            this.BlackPieceSelectionBox.Text = "Piece ...";
            this.BlackPieceSelectionBox.SelectedIndexChanged += new System.EventHandler(this.BlackPieceSelectionBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "White Pieces";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(468, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Black Pieces";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Moves
            // 
            this.Moves.AutoSize = true;
            this.Moves.Location = new System.Drawing.Point(468, 324);
            this.Moves.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Moves.Name = "Moves";
            this.Moves.Size = new System.Drawing.Size(39, 13);
            this.Moves.TabIndex = 10;
            this.Moves.Text = "Moves";
            // 
            // CurrentPiece
            // 
            this.CurrentPiece.AutoSize = true;
            this.CurrentPiece.Location = new System.Drawing.Point(468, 303);
            this.CurrentPiece.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentPiece.Name = "CurrentPiece";
            this.CurrentPiece.Size = new System.Drawing.Size(71, 13);
            this.CurrentPiece.TabIndex = 12;
            this.CurrentPiece.Text = "Current Piece";
            this.CurrentPiece.Click += new System.EventHandler(this.CurrentPiece_Click);
            // 
            // AvailableMoves
            // 
            this.AvailableMoves.FormattingEnabled = true;
            this.AvailableMoves.Location = new System.Drawing.Point(468, 148);
            this.AvailableMoves.Margin = new System.Windows.Forms.Padding(2);
            this.AvailableMoves.Name = "AvailableMoves";
            this.AvailableMoves.Size = new System.Drawing.Size(151, 21);
            this.AvailableMoves.TabIndex = 13;
            this.AvailableMoves.Text = "Avaliable Moves ...";
            this.AvailableMoves.SelectedIndexChanged += new System.EventHandler(this.AvailableMoves_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Move";
            // 
            // Takable
            // 
            this.Takable.AutoSize = true;
            this.Takable.Location = new System.Drawing.Point(468, 347);
            this.Takable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Takable.Name = "Takable";
            this.Takable.Size = new System.Drawing.Size(35, 13);
            this.Takable.TabIndex = 16;
            this.Takable.Text = "label5";
            this.Takable.Click += new System.EventHandler(this.Takable_Click);
            // 
            // CheckStatus
            // 
            this.CheckStatus.AutoSize = true;
            this.CheckStatus.Location = new System.Drawing.Point(468, 368);
            this.CheckStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckStatus.Name = "CheckStatus";
            this.CheckStatus.Size = new System.Drawing.Size(35, 13);
            this.CheckStatus.TabIndex = 17;
            this.CheckStatus.Text = "label5";
            this.CheckStatus.Click += new System.EventHandler(this.CheckStatus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Info";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(468, 10);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(150, 21);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "Reset Pieces";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(468, 172);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(150, 21);
            this.MoveButton.TabIndex = 20;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // TakenBlack
            // 
            this.TakenBlack.AutoSize = true;
            this.TakenBlack.Location = new System.Drawing.Point(471, 397);
            this.TakenBlack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TakenBlack.Name = "TakenBlack";
            this.TakenBlack.Size = new System.Drawing.Size(101, 13);
            this.TakenBlack.TabIndex = 21;
            this.TakenBlack.Text = "back pieces taken :";
            // 
            // TakenWhite
            // 
            this.TakenWhite.AutoSize = true;
            this.TakenWhite.Location = new System.Drawing.Point(471, 422);
            this.TakenWhite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TakenWhite.Name = "TakenWhite";
            this.TakenWhite.Size = new System.Drawing.Size(102, 13);
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
            this.BoardLayoutPanel.Location = new System.Drawing.Point(50, 50);
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
            this.BoardLayoutPanel.Size = new System.Drawing.Size(400, 400);
            this.BoardLayoutPanel.TabIndex = 23;
            this.BoardLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardLayoutPanel_Paint);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 500);
            this.Controls.Add(this.TakenWhite);
            this.Controls.Add(this.TakenBlack);
            this.Controls.Add(this.MoveButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckStatus);
            this.Controls.Add(this.Takable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AvailableMoves);
            this.Controls.Add(this.CurrentPiece);
            this.Controls.Add(this.Moves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlackPieceSelectionBox);
            this.Controls.Add(this.WhitePieceSelectionBox);
            this.Controls.Add(this.BoardLayoutPanel);
            this.Name = "Table";
            this.Text = "ChessNut";
            this.Load += new System.EventHandler(this.Table_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox WhitePieceSelectionBox;
        private System.Windows.Forms.ComboBox BlackPieceSelectionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Moves;
        private System.Windows.Forms.Label CurrentPiece;
        private System.Windows.Forms.ComboBox AvailableMoves;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Takable;
        private System.Windows.Forms.Label CheckStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Label TakenBlack;
        private System.Windows.Forms.Label TakenWhite;
        private System.Windows.Forms.TableLayoutPanel BoardLayoutPanel;
    }
}

