namespace _2_lw
{
    partial class RemoveAccountForm
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
            this.BankAccountNumber = new System.Windows.Forms.MaskedTextBox();
            this.RemoveAccountLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankAccountNumber
            // 
            this.BankAccountNumber.Culture = new System.Globalization.CultureInfo("ru-BY");
            this.BankAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankAccountNumber.Location = new System.Drawing.Point(12, 51);
            this.BankAccountNumber.Mask = "000-000-000";
            this.BankAccountNumber.Name = "BankAccountNumber";
            this.BankAccountNumber.Size = new System.Drawing.Size(271, 30);
            this.BankAccountNumber.TabIndex = 1;
            this.BankAccountNumber.ValidatingType = typeof(int);
            // 
            // RemoveAccountLabel
            // 
            this.RemoveAccountLabel.AutoSize = true;
            this.RemoveAccountLabel.Location = new System.Drawing.Point(12, 32);
            this.RemoveAccountLabel.Name = "RemoveAccountLabel";
            this.RemoveAccountLabel.Size = new System.Drawing.Size(202, 16);
            this.RemoveAccountLabel.TabIndex = 2;
            this.RemoveAccountLabel.Text = "Enter account number to remove:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(12, 89);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(271, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 124);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.RemoveAccountLabel);
            this.Controls.Add(this.BankAccountNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RemoveAccountForm";
            this.Text = "RemoveAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox BankAccountNumber;
        private System.Windows.Forms.Label RemoveAccountLabel;
        private System.Windows.Forms.Button RemoveButton;
    }
}