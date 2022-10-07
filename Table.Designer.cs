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
            this.PieceSelectionBox = new System.Windows.Forms.ComboBox();
            this.RowSelectionBox = new System.Windows.Forms.ComboBox();
            this.ColumnSelectionBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PieceSelectionBox
            // 
            this.PieceSelectionBox.FormattingEnabled = true;
            this.PieceSelectionBox.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Knight",
            "Rook",
            "Bishop"});
            this.PieceSelectionBox.Location = new System.Drawing.Point(602, 329);
            this.PieceSelectionBox.Name = "PieceSelectionBox";
            this.PieceSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.PieceSelectionBox.TabIndex = 0;
            this.PieceSelectionBox.Text = "Piece ...";
            this.PieceSelectionBox.SelectedIndexChanged += new System.EventHandler(this.PieceSelectionBox_SelectedIndexChanged);
            // 
            // RowSelectionBox
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
            this.RowSelectionBox.Location = new System.Drawing.Point(602, 372);
            this.RowSelectionBox.Name = "RowSelectionBox";
            this.RowSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.RowSelectionBox.TabIndex = 1;
            this.RowSelectionBox.Text = "Row ...";
            this.RowSelectionBox.SelectedIndexChanged += new System.EventHandler(this.RowSelectionBox_SelectedIndexChanged);
            // 
            // ColumnSelectionBox
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
            this.ColumnSelectionBox.Location = new System.Drawing.Point(602, 417);
            this.ColumnSelectionBox.Name = "ColumnSelectionBox";
            this.ColumnSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.ColumnSelectionBox.TabIndex = 2;
            this.ColumnSelectionBox.Text = "Column ...";
            this.ColumnSelectionBox.SelectedIndexChanged += new System.EventHandler(this.ColumnSelectionBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(149, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColumnSelectionBox);
            this.Controls.Add(this.RowSelectionBox);
            this.Controls.Add(this.PieceSelectionBox);
            this.Name = "Table";
            this.Text = "ChessNut";
            this.Load += new System.EventHandler(this.Table_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Load);
            this.ResumeLayout(false);
            //
            // Board
            //
            this.ChessBoard = new Board(8);
            int border_size = 50;
            int square_size = 50;


        }

        #endregion

        private System.Windows.Forms.ComboBox PieceSelectionBox;
        private System.Windows.Forms.ComboBox RowSelectionBox;
        private System.Windows.Forms.ComboBox ColumnSelectionBox;
        private System.Windows.Forms.Panel panel1;
        private Board ChessBoard;
    }
}

