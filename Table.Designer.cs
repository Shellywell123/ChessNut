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
            this.RowSelectionBox = new System.Windows.Forms.ComboBox();
            this.ColumnSelectionBox = new System.Windows.Forms.ComboBox();
            this.BlackPieceSelectionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Moves = new System.Windows.Forms.Label();
            this.CurrentPiece = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WhitePieceSelectionBox
            // 
            this.WhitePieceSelectionBox.FormattingEnabled = true;
            this.WhitePieceSelectionBox.Location = new System.Drawing.Point(624, 67);
            this.WhitePieceSelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.WhitePieceSelectionBox.Name = "WhitePieceSelectionBox";
            this.WhitePieceSelectionBox.Size = new System.Drawing.Size(160, 24);
            this.WhitePieceSelectionBox.TabIndex = 0;
            this.WhitePieceSelectionBox.Text = "Piece ...";
            this.WhitePieceSelectionBox.SelectedIndexChanged += new System.EventHandler(this.WhitePieceSelectionBox_SelectedIndexChanged);
            // 
            // WhiteRowSelectionBox
            // 
            this.RowSelectionBox.FormattingEnabled = true;
            this.RowSelectionBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.RowSelectionBox.Location = new System.Drawing.Point(624, 177);
            this.RowSelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.RowSelectionBox.Name = "RowSelectionBox";
            this.RowSelectionBox.Size = new System.Drawing.Size(160, 24);
            this.RowSelectionBox.TabIndex = 1;
            this.RowSelectionBox.Text = "Row ...";
            this.RowSelectionBox.SelectedIndexChanged += new System.EventHandler(this.RowSelectionBox_SelectedIndexChanged);
            // 
            // WhiteColumnSelectionBox
            // 
            this.ColumnSelectionBox.FormattingEnabled = true;
            this.ColumnSelectionBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.ColumnSelectionBox.Location = new System.Drawing.Point(624, 209);
            this.ColumnSelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.ColumnSelectionBox.Name = "ColumnSelectionBox";
            this.ColumnSelectionBox.Size = new System.Drawing.Size(160, 24);
            this.ColumnSelectionBox.TabIndex = 2;
            this.ColumnSelectionBox.Text = "Column ...";
            this.ColumnSelectionBox.SelectedIndexChanged += new System.EventHandler(this.ColumnSelectionBox_SelectedIndexChanged);
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
            this.BlackPieceSelectionBox.Location = new System.Drawing.Point(624, 125);
            this.BlackPieceSelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.BlackPieceSelectionBox.Name = "BlackPieceSelectionBox";
            this.BlackPieceSelectionBox.Size = new System.Drawing.Size(160, 24);
            this.BlackPieceSelectionBox.TabIndex = 5;
            this.BlackPieceSelectionBox.Text = "Piece ...";
            this.BlackPieceSelectionBox.SelectedIndexChanged += new System.EventHandler(this.BlackPieceSelectionBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(624, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "White";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Black";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Moves
            // 
            this.Moves.AutoSize = true;
            this.Moves.Location = new System.Drawing.Point(624, 399);
            this.Moves.Name = "Moves";
            this.Moves.Size = new System.Drawing.Size(60, 20);
            this.Moves.TabIndex = 10;
            this.Moves.Text = "Moves";
            // 
            // CurrentPiece
            // 
            this.CurrentPiece.AutoSize = true;
            this.CurrentPiece.Location = new System.Drawing.Point(624, 373);
            this.CurrentPiece.Name = "CurrentPiece";
            this.CurrentPiece.Size = new System.Drawing.Size(109, 20);
            this.CurrentPiece.TabIndex = 12;
            this.CurrentPiece.Text = "Current Piece";
            this.CurrentPiece.Click += new System.EventHandler(this.CurrentPiece_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 615);
            this.Controls.Add(this.CurrentPiece);
            this.Controls.Add(this.Moves);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlackPieceSelectionBox);
            this.Controls.Add(this.ColumnSelectionBox);
            this.Controls.Add(this.RowSelectionBox);
            this.Controls.Add(this.WhitePieceSelectionBox);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox RowSelectionBox;
        private System.Windows.Forms.ComboBox ColumnSelectionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Moves;
        private System.Windows.Forms.Label CurrentPiece;
    }
}

