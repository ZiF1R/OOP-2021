namespace _2_lw.SortForm
{
    partial class SortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortForm));
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.SortInput = new System.Windows.Forms.TextBox();
            this.SortInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(57, 104);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(48, 16);
            this.OutputLabel.TabIndex = 7;
            this.OutputLabel.Text = "Output:";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(60, 123);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(288, 280);
            this.Output.TabIndex = 6;
            // 
            // SortInput
            // 
            this.SortInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortInput.Location = new System.Drawing.Point(60, 66);
            this.SortInput.Name = "SortInput";
            this.SortInput.Size = new System.Drawing.Size(288, 30);
            this.SortInput.TabIndex = 5;
            // 
            // SortInputLabel
            // 
            this.SortInputLabel.AutoSize = true;
            this.SortInputLabel.Location = new System.Drawing.Point(57, 47);
            this.SortInputLabel.Name = "SortInputLabel";
            this.SortInputLabel.Size = new System.Drawing.Size(44, 16);
            this.SortInputLabel.TabIndex = 4;
            this.SortInputLabel.Text = "label1";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.SortInput);
            this.Controls.Add(this.SortInputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortForm";
            this.Text = "SortForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox SortInput;
        private System.Windows.Forms.Label SortInputLabel;
    }
}