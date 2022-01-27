namespace _2_lw.SearchForm
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchInputLabel = new System.Windows.Forms.Label();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchInputLabel
            // 
            this.SearchInputLabel.AutoSize = true;
            this.SearchInputLabel.Location = new System.Drawing.Point(55, 47);
            this.SearchInputLabel.Name = "SearchInputLabel";
            this.SearchInputLabel.Size = new System.Drawing.Size(44, 16);
            this.SearchInputLabel.TabIndex = 0;
            this.SearchInputLabel.Text = "label1";
            // 
            // SearchInput
            // 
            this.SearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchInput.Location = new System.Drawing.Point(58, 66);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(288, 30);
            this.SearchInput.TabIndex = 1;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(58, 123);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(288, 280);
            this.Output.TabIndex = 2;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(55, 104);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(48, 16);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output:";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.SearchInputLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchInputLabel;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label OutputLabel;
    }
}