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
            this.ColumnSelectionBox2 = new System.Windows.Forms.ComboBox();
            this.RowSelectionBox2 = new System.Windows.Forms.ComboBox();
            this.PieceSelectionBox2 = new System.Windows.Forms.ComboBox();
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
            this.PieceSelectionBox.Location = new System.Drawing.Point(624, 67);
            this.PieceSelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.PieceSelectionBox.Name = "PieceSelectionBox";
            this.PieceSelectionBox.Size = new System.Drawing.Size(160, 24);
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
            this.RowSelectionBox.Location = new System.Drawing.Point(624, 99);
            this.RowSelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.RowSelectionBox.Name = "RowSelectionBox";
            this.RowSelectionBox.Size = new System.Drawing.Size(160, 24);
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
            this.ColumnSelectionBox.Location = new System.Drawing.Point(624, 131);
            this.ColumnSelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.ColumnSelectionBox.Name = "ColumnSelectionBox";
            this.ColumnSelectionBox.Size = new System.Drawing.Size(160, 24);
            this.ColumnSelectionBox.TabIndex = 2;
            this.ColumnSelectionBox.Text = "Column ...";
            this.ColumnSelectionBox.SelectedIndexChanged += new System.EventHandler(this.ColumnSelectionBox_SelectedIndexChanged);
            // 
            // ColumnSelectionBox2
            // 
            this.ColumnSelectionBox2.FormattingEnabled = true;
            this.ColumnSelectionBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.ColumnSelectionBox2.Location = new System.Drawing.Point(624, 275);
            this.ColumnSelectionBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ColumnSelectionBox2.Name = "ColumnSelectionBox2";
            this.ColumnSelectionBox2.Size = new System.Drawing.Size(160, 24);
            this.ColumnSelectionBox2.TabIndex = 3;
            this.ColumnSelectionBox2.Text = "Column ...";
            this.ColumnSelectionBox2.SelectedIndexChanged += new System.EventHandler(this.ColumnSelectionBox_SelectedIndexChanged2);
            // 
            // RowSelectionBox2
            // 
            this.RowSelectionBox2.FormattingEnabled = true;
            this.RowSelectionBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.RowSelectionBox2.Location = new System.Drawing.Point(624, 243);
            this.RowSelectionBox2.Margin = new System.Windows.Forms.Padding(4);
            this.RowSelectionBox2.Name = "RowSelectionBox2";
            this.RowSelectionBox2.Size = new System.Drawing.Size(160, 24);
            this.RowSelectionBox2.TabIndex = 4;
            this.RowSelectionBox2.Text = "Row ...";
            this.RowSelectionBox2.SelectedIndexChanged += new System.EventHandler(this.RowSelectionBox_SelectedIndexChanged2);
            // 
            // PieceSelectionBox2
            // 
            this.PieceSelectionBox2.FormattingEnabled = true;
            this.PieceSelectionBox2.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Knight",
            "Rook",
            "Bishop"});
            this.PieceSelectionBox2.Location = new System.Drawing.Point(624, 211);
            this.PieceSelectionBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PieceSelectionBox2.Name = "PieceSelectionBox2";
            this.PieceSelectionBox2.Size = new System.Drawing.Size(160, 24);
            this.PieceSelectionBox2.TabIndex = 5;
            this.PieceSelectionBox2.Text = "Piece ...";
            this.PieceSelectionBox2.SelectedIndexChanged += new System.EventHandler(this.PieceSelectionBox_SelectedIndexChanged2);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 615);
            this.Controls.Add(this.ColumnSelectionBox2);
            this.Controls.Add(this.RowSelectionBox2);
            this.Controls.Add(this.PieceSelectionBox2);
            this.Controls.Add(this.ColumnSelectionBox);
            this.Controls.Add(this.RowSelectionBox);
            this.Controls.Add(this.PieceSelectionBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Table";
            this.Text = "ChessNut";
            this.Load += new System.EventHandler(this.Table_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Table_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PieceSelectionBox;
        private System.Windows.Forms.ComboBox RowSelectionBox;
        private System.Windows.Forms.ComboBox ColumnSelectionBox;

        private System.Windows.Forms.ComboBox ColumnSelectionBox2;
        private System.Windows.Forms.ComboBox RowSelectionBox2;
        private System.Windows.Forms.ComboBox PieceSelectionBox2;
    }
}

