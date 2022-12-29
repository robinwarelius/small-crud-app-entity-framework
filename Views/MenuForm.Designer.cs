namespace HiltonDeluxe.Views
{
    partial class MenuForm
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
            this.customerButton = new System.Windows.Forms.Button();
            this.myBookingButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.myBookingLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.hiltonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(26, 108);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(91, 23);
            this.customerButton.TabIndex = 0;
            this.customerButton.Text = "Kunder";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // myBookingButton
            // 
            this.myBookingButton.Location = new System.Drawing.Point(26, 208);
            this.myBookingButton.Name = "myBookingButton";
            this.myBookingButton.Size = new System.Drawing.Size(92, 23);
            this.myBookingButton.TabIndex = 1;
            this.myBookingButton.Text = "Bokningar";
            this.myBookingButton.UseVisualStyleBackColor = true;
            this.myBookingButton.Click += new System.EventHandler(this.myBookingButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(26, 312);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(101, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Skapa";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(23, 81);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(95, 13);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Hantera kunder";
            // 
            // myBookingLabel
            // 
            this.myBookingLabel.AutoSize = true;
            this.myBookingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myBookingLabel.Location = new System.Drawing.Point(23, 176);
            this.myBookingLabel.Name = "myBookingLabel";
            this.myBookingLabel.Size = new System.Drawing.Size(168, 13);
            this.myBookingLabel.TabIndex = 4;
            this.myBookingLabel.Text = "Hantera befintliga bokningar";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(23, 279);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(103, 13);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Skapa bokningar";
            // 
            // hiltonLabel
            // 
            this.hiltonLabel.AutoSize = true;
            this.hiltonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiltonLabel.Location = new System.Drawing.Point(157, 9);
            this.hiltonLabel.Name = "hiltonLabel";
            this.hiltonLabel.Size = new System.Drawing.Size(176, 24);
            this.hiltonLabel.TabIndex = 7;
            this.hiltonLabel.Text = "HiltonDeluxe.com";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 406);
            this.Controls.Add(this.hiltonLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.myBookingLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.myBookingButton);
            this.Controls.Add(this.customerButton);
            this.Name = "MenuForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button myBookingButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label myBookingLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label hiltonLabel;
    }
}