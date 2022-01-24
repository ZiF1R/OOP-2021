namespace _1_lw
{
    partial class Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            this.SizeInputLabel = new System.Windows.Forms.Label();
            this.SizeInput = new System.Windows.Forms.NumericUpDown();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.AscendingSortButton = new System.Windows.Forms.Button();
            this.DescendingSortButton = new System.Windows.Forms.Button();
            this.FirstQuery = new System.Windows.Forms.Button();
            this.SecondQuery = new System.Windows.Forms.Button();
            this.ThirdQuery = new System.Windows.Forms.Button();
            this.FirstQueryLabel = new System.Windows.Forms.Label();
            this.SecondQueryLabel = new System.Windows.Forms.Label();
            this.ThirdQueryLabel = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SizeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // SizeInputLabel
            // 
            this.SizeInputLabel.AutoSize = true;
            this.SizeInputLabel.Location = new System.Drawing.Point(50, 27);
            this.SizeInputLabel.Name = "SizeInputLabel";
            this.SizeInputLabel.Size = new System.Drawing.Size(268, 16);
            this.SizeInputLabel.TabIndex = 1;
            this.SizeInputLabel.Text = "Please, enter size of collection (from 0 to 50):";
            this.SizeInputLabel.Click += new System.EventHandler(this.SizeInputLabel_Click);
            // 
            // SizeInput
            // 
            this.SizeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeInput.Location = new System.Drawing.Point(53, 46);
            this.SizeInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SizeInput.Name = "SizeInput";
            this.SizeInput.Size = new System.Drawing.Size(361, 38);
            this.SizeInput.TabIndex = 2;
            this.SizeInput.ThousandsSeparator = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GenerateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateButton.FlatAppearance.BorderSize = 0;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateButton.Location = new System.Drawing.Point(420, 46);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(172, 38);
            this.GenerateButton.TabIndex = 3;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            // 
            // AscendingSortButton
            // 
            this.AscendingSortButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AscendingSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AscendingSortButton.FlatAppearance.BorderSize = 0;
            this.AscendingSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AscendingSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AscendingSortButton.Location = new System.Drawing.Point(53, 103);
            this.AscendingSortButton.Name = "AscendingSortButton";
            this.AscendingSortButton.Size = new System.Drawing.Size(265, 48);
            this.AscendingSortButton.TabIndex = 4;
            this.AscendingSortButton.Text = "Ascending sort";
            this.AscendingSortButton.UseVisualStyleBackColor = false;
            // 
            // DescendingSortButton
            // 
            this.DescendingSortButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DescendingSortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DescendingSortButton.FlatAppearance.BorderSize = 0;
            this.DescendingSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescendingSortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescendingSortButton.Location = new System.Drawing.Point(324, 103);
            this.DescendingSortButton.Name = "DescendingSortButton";
            this.DescendingSortButton.Size = new System.Drawing.Size(268, 48);
            this.DescendingSortButton.TabIndex = 5;
            this.DescendingSortButton.Text = "Descending sort";
            this.DescendingSortButton.UseVisualStyleBackColor = false;
            // 
            // FirstQuery
            // 
            this.FirstQuery.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirstQuery.FlatAppearance.BorderSize = 0;
            this.FirstQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstQuery.Location = new System.Drawing.Point(53, 186);
            this.FirstQuery.Name = "FirstQuery";
            this.FirstQuery.Size = new System.Drawing.Size(172, 38);
            this.FirstQuery.TabIndex = 6;
            this.FirstQuery.Text = "Query 1";
            this.FirstQuery.UseVisualStyleBackColor = false;
            // 
            // SecondQuery
            // 
            this.SecondQuery.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SecondQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecondQuery.FlatAppearance.BorderSize = 0;
            this.SecondQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondQuery.Location = new System.Drawing.Point(236, 186);
            this.SecondQuery.Name = "SecondQuery";
            this.SecondQuery.Size = new System.Drawing.Size(172, 38);
            this.SecondQuery.TabIndex = 7;
            this.SecondQuery.Text = "Query 2";
            this.SecondQuery.UseVisualStyleBackColor = false;
            // 
            // ThirdQuery
            // 
            this.ThirdQuery.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ThirdQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThirdQuery.FlatAppearance.BorderSize = 0;
            this.ThirdQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThirdQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdQuery.Location = new System.Drawing.Point(420, 186);
            this.ThirdQuery.Name = "ThirdQuery";
            this.ThirdQuery.Size = new System.Drawing.Size(169, 38);
            this.ThirdQuery.TabIndex = 8;
            this.ThirdQuery.Text = "Query 3";
            this.ThirdQuery.UseVisualStyleBackColor = false;
            // 
            // FirstQueryLabel
            // 
            this.FirstQueryLabel.AutoSize = true;
            this.FirstQueryLabel.Location = new System.Drawing.Point(50, 167);
            this.FirstQueryLabel.Name = "FirstQueryLabel";
            this.FirstQueryLabel.Size = new System.Drawing.Size(131, 16);
            this.FirstQueryLabel.TabIndex = 9;
            this.FirstQueryLabel.Text = "Get minimal element:\r\n";
            // 
            // SecondQueryLabel
            // 
            this.SecondQueryLabel.AutoSize = true;
            this.SecondQueryLabel.Location = new System.Drawing.Point(233, 167);
            this.SecondQueryLabel.Name = "SecondQueryLabel";
            this.SecondQueryLabel.Size = new System.Drawing.Size(135, 16);
            this.SecondQueryLabel.TabIndex = 10;
            this.SecondQueryLabel.Text = "Get maximal element:\r\n";
            // 
            // ThirdQueryLabel
            // 
            this.ThirdQueryLabel.AutoSize = true;
            this.ThirdQueryLabel.Location = new System.Drawing.Point(417, 167);
            this.ThirdQueryLabel.Name = "ThirdQueryLabel";
            this.ThirdQueryLabel.Size = new System.Drawing.Size(156, 16);
            this.ThirdQueryLabel.TabIndex = 11;
            this.ThirdQueryLabel.Text = "Get elements from range:\r\n";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(53, 263);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(539, 288);
            this.Output.TabIndex = 12;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(50, 244);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(48, 16);
            this.OutputLabel.TabIndex = 13;
            this.OutputLabel.Text = "Output:";
            this.OutputLabel.Click += new System.EventHandler(this.OutputLabel_Click);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 590);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.ThirdQueryLabel);
            this.Controls.Add(this.SecondQueryLabel);
            this.Controls.Add(this.FirstQueryLabel);
            this.Controls.Add(this.ThirdQuery);
            this.Controls.Add(this.SecondQuery);
            this.Controls.Add(this.FirstQuery);
            this.Controls.Add(this.DescendingSortButton);
            this.Controls.Add(this.AscendingSortButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.SizeInput);
            this.Controls.Add(this.SizeInputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Generator";
            this.Text = "Generator";
            ((System.ComponentModel.ISupportInitialize)(this.SizeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SizeInputLabel;
        private System.Windows.Forms.NumericUpDown SizeInput;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button AscendingSortButton;
        private System.Windows.Forms.Button DescendingSortButton;
        private System.Windows.Forms.Button FirstQuery;
        private System.Windows.Forms.Button SecondQuery;
        private System.Windows.Forms.Button ThirdQuery;
        private System.Windows.Forms.Label FirstQueryLabel;
        private System.Windows.Forms.Label SecondQueryLabel;
        private System.Windows.Forms.Label ThirdQueryLabel;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label OutputLabel;
    }
}