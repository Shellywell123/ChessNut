namespace ChessNut
{
    partial class Promotion
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
            this.promotionPieceBox = new System.Windows.Forms.ComboBox();
            this.promotionPieceConfirm = new System.Windows.Forms.Button();
            this.promotionalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promotionPieceBox
            // 
            this.promotionPieceBox.FormattingEnabled = true;
            this.promotionPieceBox.Items.AddRange(new object[] {
            "Queen",
            "Knight",
            "Rook",
            "Bishop"});
            this.promotionPieceBox.Location = new System.Drawing.Point(28, 76);
            this.promotionPieceBox.Name = "promotionPieceBox";
            this.promotionPieceBox.Size = new System.Drawing.Size(186, 24);
            this.promotionPieceBox.TabIndex = 0;
            this.promotionPieceBox.SelectedIndexChanged += new System.EventHandler(this.promotionPieceBox_SelectedIndexChanged);
            // 
            // promotionPieceConfirm
            // 
            this.promotionPieceConfirm.Location = new System.Drawing.Point(84, 134);
            this.promotionPieceConfirm.Name = "promotionPieceConfirm";
            this.promotionPieceConfirm.Size = new System.Drawing.Size(75, 23);
            this.promotionPieceConfirm.TabIndex = 1;
            this.promotionPieceConfirm.Text = "confirm";
            this.promotionPieceConfirm.UseVisualStyleBackColor = true;
            this.promotionPieceConfirm.Click += new System.EventHandler(this.promotionPieceConfirm_Click);
            // 
            // promotionalLabel
            // 
            this.promotionalLabel.AutoSize = true;
            this.promotionalLabel.Location = new System.Drawing.Point(25, 24);
            this.promotionalLabel.Name = "promotionalLabel";
            this.promotionalLabel.Size = new System.Drawing.Size(189, 16);
            this.promotionalLabel.TabIndex = 2;
            this.promotionalLabel.Text = "Pawn promotion - select piece.";
            this.promotionalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Promotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 186);
            this.Controls.Add(this.promotionalLabel);
            this.Controls.Add(this.promotionPieceConfirm);
            this.Controls.Add(this.promotionPieceBox);
            this.Name = "Promotion";
            this.Text = "Promotion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox promotionPieceBox;
        private System.Windows.Forms.Button promotionPieceConfirm;
        private System.Windows.Forms.Label promotionalLabel;
    }
}