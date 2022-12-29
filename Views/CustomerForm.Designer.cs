namespace HiltonDeluxe.Views
{
    partial class CustomerForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.updateListButton = new System.Windows.Forms.Button();
            this.customerGrid = new System.Windows.Forms.DataGridView();
            this.KundID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EfterNamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountLabel2 = new System.Windows.Forms.Label();
            this.showAmountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(618, 483);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Lägg till";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(699, 483);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Ta bort";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(537, 483);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Uppdatera";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(537, 264);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(237, 20);
            this.firstNameText.TabIndex = 5;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(537, 349);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(237, 20);
            this.lastNameText.TabIndex = 6;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(537, 431);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(237, 20);
            this.emailText.TabIndex = 7;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(534, 239);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(48, 13);
            this.firstnameLabel.TabIndex = 8;
            this.firstnameLabel.Text = "Förnamn";
            this.firstnameLabel.Click += new System.EventHandler(this.firstnameLabel_Click);
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(534, 322);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(55, 13);
            this.lastnameLabel.TabIndex = 9;
            this.lastnameLabel.Text = "Efternamn";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(534, 404);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(23, 29);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(53, 15);
            this.customerLabel.TabIndex = 12;
            this.customerLabel.Text = "Kunder";
            // 
            // updateListButton
            // 
            this.updateListButton.Location = new System.Drawing.Point(26, 518);
            this.updateListButton.Name = "updateListButton";
            this.updateListButton.Size = new System.Drawing.Size(117, 23);
            this.updateListButton.TabIndex = 13;
            this.updateListButton.Text = "Uppdatera kundlista";
            this.updateListButton.UseVisualStyleBackColor = true;
            this.updateListButton.Click += new System.EventHandler(this.updateListButton_Click);
            // 
            // customerGrid
            // 
            this.customerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KundID,
            this.ForNamn,
            this.EfterNamn,
            this.Email});
            this.customerGrid.Location = new System.Drawing.Point(12, 59);
            this.customerGrid.MultiSelect = false;
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.Size = new System.Drawing.Size(444, 447);
            this.customerGrid.TabIndex = 14;
            this.customerGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGrid_CellContentClick);
            this.customerGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGrid_CellContentClick);
            this.customerGrid.SelectionChanged += new System.EventHandler(this.customerGrid_SelectedIndexChanged);
            // 
            // KundID
            // 
            this.KundID.HeaderText = "KundID";
            this.KundID.MinimumWidth = 6;
            this.KundID.Name = "KundID";
            this.KundID.ReadOnly = true;
            // 
            // ForNamn
            // 
            this.ForNamn.HeaderText = "Förnamn";
            this.ForNamn.MinimumWidth = 8;
            this.ForNamn.Name = "ForNamn";
            this.ForNamn.ReadOnly = true;
            // 
            // EfterNamn
            // 
            this.EfterNamn.HeaderText = "Efternamn";
            this.EfterNamn.MinimumWidth = 8;
            this.EfterNamn.Name = "EfterNamn";
            this.EfterNamn.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(534, 155);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(124, 13);
            this.amountLabel.TabIndex = 15;
            this.amountLabel.Text = "Antal aktuella bokningar:";
            // 
            // amountLabel2
            // 
            this.amountLabel2.AutoSize = true;
            this.amountLabel2.Location = new System.Drawing.Point(664, 155);
            this.amountLabel2.Name = "amountLabel2";
            this.amountLabel2.Size = new System.Drawing.Size(0, 13);
            this.amountLabel2.TabIndex = 16;
            // 
            // showAmountButton
            // 
            this.showAmountButton.Location = new System.Drawing.Point(537, 180);
            this.showAmountButton.Name = "showAmountButton";
            this.showAmountButton.Size = new System.Drawing.Size(75, 23);
            this.showAmountButton.TabIndex = 17;
            this.showAmountButton.Text = "Visa";
            this.showAmountButton.UseVisualStyleBackColor = true;
            this.showAmountButton.Click += new System.EventHandler(this.showAmountButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 581);
            this.Controls.Add(this.showAmountButton);
            this.Controls.Add(this.amountLabel2);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.customerGrid);
            this.Controls.Add(this.updateListButton);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Button updateListButton;
        private System.Windows.Forms.DataGridView customerGrid;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label amountLabel2;
        private System.Windows.Forms.Button showAmountButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn KundID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EfterNamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}