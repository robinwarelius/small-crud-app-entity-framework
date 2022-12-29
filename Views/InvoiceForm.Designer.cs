namespace HiltonDeluxe.Views
{
    partial class InvoiceForm
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
            this.invoiceGrid = new System.Windows.Forms.DataGridView();
            this.FakturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Belopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hanterad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BokningsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BokningsDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.invoiceLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateLabel2 = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.payLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceGrid
            // 
            this.invoiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FakturaID,
            this.Belopp,
            this.Hanterad,
            this.BokningsID,
            this.BokningsDatum});
            this.invoiceGrid.Location = new System.Drawing.Point(24, 12);
            this.invoiceGrid.MultiSelect = false;
            this.invoiceGrid.Name = "invoiceGrid";
            this.invoiceGrid.ReadOnly = true;
            this.invoiceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceGrid.Size = new System.Drawing.Size(644, 382);
            this.invoiceGrid.TabIndex = 0;
            // 
            // FakturaID
            // 
            this.FakturaID.HeaderText = "FakturaNummer";
            this.FakturaID.Name = "FakturaID";
            this.FakturaID.ReadOnly = true;
            this.FakturaID.Width = 120;
            // 
            // Belopp
            // 
            this.Belopp.HeaderText = "Belopp";
            this.Belopp.Name = "Belopp";
            this.Belopp.ReadOnly = true;
            this.Belopp.Width = 120;
            // 
            // Hanterad
            // 
            this.Hanterad.HeaderText = "Hanterad";
            this.Hanterad.Name = "Hanterad";
            this.Hanterad.ReadOnly = true;
            this.Hanterad.Width = 120;
            // 
            // BokningsID
            // 
            this.BokningsID.HeaderText = "Bokningsnummer";
            this.BokningsID.Name = "BokningsID";
            this.BokningsID.ReadOnly = true;
            this.BokningsID.Width = 120;
            // 
            // BokningsDatum
            // 
            this.BokningsDatum.HeaderText = "Bokningsdatum";
            this.BokningsDatum.Name = "BokningsDatum";
            this.BokningsDatum.ReadOnly = true;
            this.BokningsDatum.Width = 120;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(710, 371);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Ta bort";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // invoiceLabel
            // 
            this.invoiceLabel.AutoSize = true;
            this.invoiceLabel.Location = new System.Drawing.Point(707, 344);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Size = new System.Drawing.Size(280, 13);
            this.invoiceLabel.TabIndex = 2;
            this.invoiceLabel.Text = "Markulera alla bokningar med obetalda fakturor (10 dagar)";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(24, 401);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Uppdatera";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(842, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(76, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Dagensdatum:";
            // 
            // dateLabel2
            // 
            this.dateLabel2.AutoSize = true;
            this.dateLabel2.Location = new System.Drawing.Point(933, 12);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(35, 13);
            this.dateLabel2.TabIndex = 5;
            this.dateLabel2.Text = "label1";
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(710, 280);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(75, 23);
            this.payButton.TabIndex = 6;
            this.payButton.Text = "Lägg till";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Location = new System.Drawing.Point(707, 252);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(89, 13);
            this.payLabel.TabIndex = 7;
            this.payLabel.Text = "Lägg till betalning";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.dateLabel2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.invoiceLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.invoiceGrid);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.invoiceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoiceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn FakturaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Belopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hanterad;
        private System.Windows.Forms.DataGridViewTextBoxColumn BokningsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BokningsDatum;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label invoiceLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateLabel2;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label payLabel;
    }
}