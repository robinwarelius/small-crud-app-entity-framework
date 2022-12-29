namespace HiltonDeluxe.Views
{
    partial class ExistingBookingForm
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
            this.invoiceButton = new System.Windows.Forms.Button();
            this.invoiceLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.infoGrid = new System.Windows.Forms.DataGridView();
            this.BokningID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnkomstDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvreseDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BokningDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KundID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EfterNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RumNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateLabel = new System.Windows.Forms.Label();
            this.updateListButton = new System.Windows.Forms.Button();
            this.startText = new System.Windows.Forms.TextBox();
            this.endText = new System.Windows.Forms.TextBox();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.personLabel = new System.Windows.Forms.Label();
            this.personBox = new System.Windows.Forms.ComboBox();
            this.bedBox = new System.Windows.Forms.ComboBox();
            this.bedLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceButton
            // 
            this.invoiceButton.Location = new System.Drawing.Point(986, 585);
            this.invoiceButton.Name = "invoiceButton";
            this.invoiceButton.Size = new System.Drawing.Size(75, 23);
            this.invoiceButton.TabIndex = 0;
            this.invoiceButton.Text = "Faktura";
            this.invoiceButton.UseVisualStyleBackColor = true;
            this.invoiceButton.Click += new System.EventHandler(this.invoiceButton_Click);
            // 
            // invoiceLabel
            // 
            this.invoiceLabel.AutoSize = true;
            this.invoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceLabel.Location = new System.Drawing.Point(984, 555);
            this.invoiceLabel.Name = "invoiceLabel";
            this.invoiceLabel.Size = new System.Drawing.Size(100, 13);
            this.invoiceLabel.TabIndex = 1;
            this.invoiceLabel.Text = "Hantera fakturor";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(439, 300);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Ta bort";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.Location = new System.Drawing.Point(436, 262);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(112, 13);
            this.deleteLabel.TabIndex = 3;
            this.deleteLabel.Text = "Markulera bokning";
            // 
            // infoGrid
            // 
            this.infoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BokningID,
            this.AnkomstDatum,
            this.AvreseDatum,
            this.BokningDatum,
            this.KundID,
            this.ForNamn,
            this.EfterNamn,
            this.RumNamn});
            this.infoGrid.Location = new System.Drawing.Point(12, 12);
            this.infoGrid.MultiSelect = false;
            this.infoGrid.Name = "infoGrid";
            this.infoGrid.ReadOnly = true;
            this.infoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.infoGrid.Size = new System.Drawing.Size(1083, 224);
            this.infoGrid.TabIndex = 4;
            // 
            // BokningID
            // 
            this.BokningID.HeaderText = "Bokningsnummer";
            this.BokningID.Name = "BokningID";
            this.BokningID.ReadOnly = true;
            this.BokningID.Width = 130;
            // 
            // AnkomstDatum
            // 
            this.AnkomstDatum.HeaderText = "Ankomst";
            this.AnkomstDatum.Name = "AnkomstDatum";
            this.AnkomstDatum.ReadOnly = true;
            this.AnkomstDatum.Width = 130;
            // 
            // AvreseDatum
            // 
            this.AvreseDatum.HeaderText = "Avresa";
            this.AvreseDatum.Name = "AvreseDatum";
            this.AvreseDatum.ReadOnly = true;
            this.AvreseDatum.Width = 130;
            // 
            // BokningDatum
            // 
            this.BokningDatum.HeaderText = "Bokningsdatum";
            this.BokningDatum.Name = "BokningDatum";
            this.BokningDatum.ReadOnly = true;
            this.BokningDatum.Width = 130;
            // 
            // KundID
            // 
            this.KundID.HeaderText = "Kundnummer";
            this.KundID.Name = "KundID";
            this.KundID.ReadOnly = true;
            this.KundID.Width = 130;
            // 
            // ForNamn
            // 
            this.ForNamn.HeaderText = "Förnamn";
            this.ForNamn.Name = "ForNamn";
            this.ForNamn.ReadOnly = true;
            this.ForNamn.Width = 130;
            // 
            // EfterNamn
            // 
            this.EfterNamn.HeaderText = "Efternamn";
            this.EfterNamn.Name = "EfterNamn";
            this.EfterNamn.ReadOnly = true;
            this.EfterNamn.Width = 130;
            // 
            // RumNamn
            // 
            this.RumNamn.HeaderText = "Rum";
            this.RumNamn.Name = "RumNamn";
            this.RumNamn.ReadOnly = true;
            this.RumNamn.Width = 130;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(58, 585);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Uppdatera";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.Location = new System.Drawing.Point(12, 262);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(227, 13);
            this.updateLabel.TabIndex = 6;
            this.updateLabel.Text = "Uppdatera bokning - sök på lediga rum";
            // 
            // updateListButton
            // 
            this.updateListButton.Location = new System.Drawing.Point(987, 242);
            this.updateListButton.Name = "updateListButton";
            this.updateListButton.Size = new System.Drawing.Size(98, 23);
            this.updateListButton.TabIndex = 7;
            this.updateListButton.Text = "Uppdatera listan";
            this.updateListButton.UseVisualStyleBackColor = true;
            this.updateListButton.Click += new System.EventHandler(this.updateListButton_Click);
            // 
            // startText
            // 
            this.startText.Location = new System.Drawing.Point(24, 324);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(124, 20);
            this.startText.TabIndex = 8;
            // 
            // endText
            // 
            this.endText.Location = new System.Drawing.Point(24, 387);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(121, 20);
            this.endText.TabIndex = 9;
            // 
            // roomBox
            // 
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Location = new System.Drawing.Point(12, 547);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(121, 21);
            this.roomBox.TabIndex = 10;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(21, 300);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(98, 13);
            this.startLabel.TabIndex = 11;
            this.startLabel.Text = "Nytt ankomstdatum";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(21, 371);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(90, 13);
            this.endLabel.TabIndex = 12;
            this.endLabel.Text = "Nytt avresedatum";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(12, 517);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(44, 13);
            this.roomLabel.TabIndex = 13;
            this.roomLabel.Text = "Välj rum";
            // 
            // personLabel
            // 
            this.personLabel.AutoSize = true;
            this.personLabel.Location = new System.Drawing.Point(155, 300);
            this.personLabel.Name = "personLabel";
            this.personLabel.Size = new System.Drawing.Size(75, 13);
            this.personLabel.TabIndex = 14;
            this.personLabel.Text = "Antal personer";
            // 
            // personBox
            // 
            this.personBox.FormattingEnabled = true;
            this.personBox.Location = new System.Drawing.Point(154, 323);
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(121, 21);
            this.personBox.TabIndex = 15;
            // 
            // bedBox
            // 
            this.bedBox.FormattingEnabled = true;
            this.bedBox.Location = new System.Drawing.Point(154, 547);
            this.bedBox.Name = "bedBox";
            this.bedBox.Size = new System.Drawing.Size(121, 21);
            this.bedBox.TabIndex = 16;
            this.bedBox.Visible = false;
            // 
            // bedLabel
            // 
            this.bedLabel.AutoSize = true;
            this.bedLabel.Location = new System.Drawing.Point(155, 517);
            this.bedLabel.Name = "bedLabel";
            this.bedLabel.Size = new System.Drawing.Size(66, 13);
            this.bedLabel.TabIndex = 17;
            this.bedLabel.Text = "Extra sängar";
            this.bedLabel.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(154, 387);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 23);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Sök på lediga rum";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateLabel2
            // 
            this.updateLabel2.AutoSize = true;
            this.updateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel2.Location = new System.Drawing.Point(12, 489);
            this.updateLabel2.Name = "updateLabel2";
            this.updateLabel2.Size = new System.Drawing.Size(129, 13);
            this.updateLabel2.TabIndex = 19;
            this.updateLabel2.Text = "Uppdatera bokningen";
            // 
            // ExistingBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 655);
            this.Controls.Add(this.updateLabel2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.bedLabel);
            this.Controls.Add(this.bedBox);
            this.Controls.Add(this.personBox);
            this.Controls.Add(this.personLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.startText);
            this.Controls.Add(this.updateListButton);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.infoGrid);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.invoiceLabel);
            this.Controls.Add(this.invoiceButton);
            this.Name = "ExistingBookingForm";
            this.Text = "ExistingBookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.infoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button invoiceButton;
        private System.Windows.Forms.Label invoiceLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.DataGridView infoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BokningID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnkomstDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvreseDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BokningDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn KundID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EfterNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RumNamn;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Button updateListButton;
        private System.Windows.Forms.TextBox startText;
        private System.Windows.Forms.TextBox endText;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label personLabel;
        private System.Windows.Forms.ComboBox personBox;
        private System.Windows.Forms.ComboBox bedBox;
        private System.Windows.Forms.Label bedLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label updateLabel2;
    }
}