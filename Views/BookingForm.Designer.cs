namespace HiltonDeluxe.Views
{
    partial class BookingForm
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
            this.roomLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.amountBedLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startDateText = new System.Windows.Forms.TextBox();
            this.endDateText = new System.Windows.Forms.TextBox();
            this.roomGrid = new System.Windows.Forms.DataGridView();
            this.RumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RumTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RumNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoutPersonLabel = new System.Windows.Forms.Label();
            this.amountPersonBox = new System.Windows.Forms.ComboBox();
            this.amountBedBox = new System.Windows.Forms.ComboBox();
            this.bookButton = new System.Windows.Forms.Button();
            this.customerBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.Location = new System.Drawing.Point(25, 31);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(80, 15);
            this.roomLabel.TabIndex = 1;
            this.roomLabel.Text = "Lediga rum";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(665, 259);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(140, 13);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Ankomstdatum (yyyy-mm-dd)";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(665, 341);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(132, 13);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "Avresedatum (yyyy-mm-dd)";
            // 
            // amountBedLabel
            // 
            this.amountBedLabel.AutoSize = true;
            this.amountBedLabel.Location = new System.Drawing.Point(25, 549);
            this.amountBedLabel.Name = "amountBedLabel";
            this.amountBedLabel.Size = new System.Drawing.Size(66, 13);
            this.amountBedLabel.TabIndex = 5;
            this.amountBedLabel.Text = "Extra sängar";
            this.amountBedLabel.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(670, 485);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Se rum och priser";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kund";
            // 
            // startDateText
            // 
            this.startDateText.Location = new System.Drawing.Point(668, 294);
            this.startDateText.Name = "startDateText";
            this.startDateText.Size = new System.Drawing.Size(192, 20);
            this.startDateText.TabIndex = 10;
            // 
            // endDateText
            // 
            this.endDateText.Location = new System.Drawing.Point(668, 370);
            this.endDateText.Name = "endDateText";
            this.endDateText.Size = new System.Drawing.Size(192, 20);
            this.endDateText.TabIndex = 11;
            // 
            // roomGrid
            // 
            this.roomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RumID,
            this.RumTyp,
            this.RumNamn,
            this.Pris});
            this.roomGrid.Location = new System.Drawing.Point(28, 64);
            this.roomGrid.MultiSelect = false;
            this.roomGrid.Name = "roomGrid";
            this.roomGrid.ReadOnly = true;
            this.roomGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomGrid.Size = new System.Drawing.Size(594, 444);
            this.roomGrid.TabIndex = 15;
            this.roomGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomGrid_CellDoubleClick);
            // 
            // RumID
            // 
            this.RumID.HeaderText = "Rumsnummer";
            this.RumID.Name = "RumID";
            this.RumID.ReadOnly = true;
            // 
            // RumTyp
            // 
            this.RumTyp.HeaderText = "Rumstyp";
            this.RumTyp.MinimumWidth = 8;
            this.RumTyp.Name = "RumTyp";
            this.RumTyp.ReadOnly = true;
            this.RumTyp.Width = 150;
            // 
            // RumNamn
            // 
            this.RumNamn.HeaderText = "Rumsnamn";
            this.RumNamn.MinimumWidth = 8;
            this.RumNamn.Name = "RumNamn";
            this.RumNamn.ReadOnly = true;
            this.RumNamn.Width = 150;
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris (1 natt)";
            this.Pris.MinimumWidth = 8;
            this.Pris.Name = "Pris";
            this.Pris.ReadOnly = true;
            this.Pris.Width = 150;
            // 
            // amoutPersonLabel
            // 
            this.amoutPersonLabel.AutoSize = true;
            this.amoutPersonLabel.Location = new System.Drawing.Point(667, 413);
            this.amoutPersonLabel.Name = "amoutPersonLabel";
            this.amoutPersonLabel.Size = new System.Drawing.Size(75, 13);
            this.amoutPersonLabel.TabIndex = 16;
            this.amoutPersonLabel.Text = "Antal personer";
            this.amoutPersonLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // amountPersonBox
            // 
            this.amountPersonBox.FormattingEnabled = true;
            this.amountPersonBox.Location = new System.Drawing.Point(668, 439);
            this.amountPersonBox.Name = "amountPersonBox";
            this.amountPersonBox.Size = new System.Drawing.Size(121, 21);
            this.amountPersonBox.TabIndex = 17;
            // 
            // amountBedBox
            // 
            this.amountBedBox.FormattingEnabled = true;
            this.amountBedBox.Location = new System.Drawing.Point(100, 546);
            this.amountBedBox.Name = "amountBedBox";
            this.amountBedBox.Size = new System.Drawing.Size(125, 21);
            this.amountBedBox.TabIndex = 13;
            this.amountBedBox.Visible = false;
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(242, 579);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(75, 23);
            this.bookButton.TabIndex = 18;
            this.bookButton.Text = "Boka";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // customerBox
            // 
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(101, 580);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(121, 21);
            this.customerBox.TabIndex = 19;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 644);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.amountPersonBox);
            this.Controls.Add(this.amoutPersonLabel);
            this.Controls.Add(this.roomGrid);
            this.Controls.Add(this.amountBedBox);
            this.Controls.Add(this.endDateText);
            this.Controls.Add(this.startDateText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.amountBedLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.roomLabel);
            this.Name = "BookingForm";
            this.Text = "SearchRoomAndBook";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label amountBedLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startDateText;
        private System.Windows.Forms.TextBox endDateText;
        private System.Windows.Forms.DataGridView roomGrid;
        private System.Windows.Forms.Label amoutPersonLabel;
        private System.Windows.Forms.ComboBox amountPersonBox;
        private System.Windows.Forms.ComboBox amountBedBox;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn RumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RumTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn RumNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.ComboBox customerBox;
    }
}