﻿namespace _1_lw
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.ChangeSignButton = new System.Windows.Forms.Button();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.DivideButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SquareButton = new System.Windows.Forms.Button();
            this.CubeButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ThreeNumberButton = new System.Windows.Forms.Button();
            this.TwoNumberButton = new System.Windows.Forms.Button();
            this.OneNumberButton = new System.Windows.Forms.Button();
            this.ZeroNumberButton = new System.Windows.Forms.Button();
            this.FiveNumberButton = new System.Windows.Forms.Button();
            this.FourNumberButton = new System.Windows.Forms.Button();
            this.SixNumberButton = new System.Windows.Forms.Button();
            this.SevenNumberButton = new System.Windows.Forms.Button();
            this.EightNumberButton = new System.Windows.Forms.Button();
            this.NineNumberButton = new System.Windows.Forms.Button();
            this.SinButton = new System.Windows.Forms.Button();
            this.CosButton = new System.Windows.Forms.Button();
            this.TanButton = new System.Windows.Forms.Button();
            this.CtanButton = new System.Windows.Forms.Button();
            this.CubeRootButton = new System.Windows.Forms.Button();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Firebrick;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearButton.Location = new System.Drawing.Point(29, 124);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 59);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackspaceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackspaceButton.FlatAppearance.BorderSize = 0;
            this.BackspaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackspaceButton.Location = new System.Drawing.Point(110, 124);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(318, 59);
            this.BackspaceButton.TabIndex = 2;
            this.BackspaceButton.Text = "Backspace";
            this.BackspaceButton.UseVisualStyleBackColor = false;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // ChangeSignButton
            // 
            this.ChangeSignButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ChangeSignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeSignButton.FlatAppearance.BorderSize = 0;
            this.ChangeSignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSignButton.Location = new System.Drawing.Point(110, 449);
            this.ChangeSignButton.Name = "ChangeSignButton";
            this.ChangeSignButton.Size = new System.Drawing.Size(75, 59);
            this.ChangeSignButton.TabIndex = 3;
            this.ChangeSignButton.Text = "±";
            this.ChangeSignButton.UseVisualStyleBackColor = false;
            // 
            // OutputField
            // 
            this.OutputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputField.CausesValidation = false;
            this.OutputField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputField.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::_1_lw.Properties.Settings.Default, "Edit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OutputField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputField.Location = new System.Drawing.Point(29, 49);
            this.OutputField.Name = "OutputField";
            this.OutputField.ReadOnly = global::_1_lw.Properties.Settings.Default.Edit;
            this.OutputField.Size = new System.Drawing.Size(399, 41);
            this.OutputField.TabIndex = 0;
            this.OutputField.Text = "";
            this.OutputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DivideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivideButton.FlatAppearance.BorderSize = 0;
            this.DivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivideButton.Location = new System.Drawing.Point(353, 189);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 59);
            this.DivideButton.TabIndex = 4;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = false;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MultiplyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultiplyButton.FlatAppearance.BorderSize = 0;
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.Location = new System.Drawing.Point(353, 254);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(75, 59);
            this.MultiplyButton.TabIndex = 5;
            this.MultiplyButton.Text = "×";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            // 
            // SquareButton
            // 
            this.SquareButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SquareButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SquareButton.FlatAppearance.BorderSize = 0;
            this.SquareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareButton.Location = new System.Drawing.Point(191, 189);
            this.SquareButton.Name = "SquareButton";
            this.SquareButton.Size = new System.Drawing.Size(75, 59);
            this.SquareButton.TabIndex = 6;
            this.SquareButton.Text = "x²";
            this.SquareButton.UseVisualStyleBackColor = false;
            // 
            // CubeButton
            // 
            this.CubeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CubeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CubeButton.FlatAppearance.BorderSize = 0;
            this.CubeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CubeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CubeButton.Location = new System.Drawing.Point(272, 189);
            this.CubeButton.Name = "CubeButton";
            this.CubeButton.Size = new System.Drawing.Size(75, 59);
            this.CubeButton.TabIndex = 7;
            this.CubeButton.Text = "x³";
            this.CubeButton.UseVisualStyleBackColor = false;
            // 
            // SubtractButton
            // 
            this.SubtractButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SubtractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubtractButton.FlatAppearance.BorderSize = 0;
            this.SubtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubtractButton.Location = new System.Drawing.Point(353, 319);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(75, 59);
            this.SubtractButton.TabIndex = 8;
            this.SubtractButton.Text = "–";
            this.SubtractButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(353, 384);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 59);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.FlatAppearance.BorderSize = 0;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.Location = new System.Drawing.Point(353, 449);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 59);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "=";
            this.CalculateButton.UseVisualStyleBackColor = false;
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DotButton.FlatAppearance.BorderSize = 0;
            this.DotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DotButton.Location = new System.Drawing.Point(272, 449);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(75, 59);
            this.DotButton.TabIndex = 11;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            // 
            // ThreeNumberButton
            // 
            this.ThreeNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ThreeNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThreeNumberButton.FlatAppearance.BorderSize = 0;
            this.ThreeNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreeNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeNumberButton.Location = new System.Drawing.Point(272, 384);
            this.ThreeNumberButton.Name = "ThreeNumberButton";
            this.ThreeNumberButton.Size = new System.Drawing.Size(75, 59);
            this.ThreeNumberButton.TabIndex = 12;
            this.ThreeNumberButton.Text = "3";
            this.ThreeNumberButton.UseVisualStyleBackColor = false;
            this.ThreeNumberButton.Click += new System.EventHandler(this.ThreeNumberButton_Click);
            // 
            // TwoNumberButton
            // 
            this.TwoNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TwoNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwoNumberButton.FlatAppearance.BorderSize = 0;
            this.TwoNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoNumberButton.Location = new System.Drawing.Point(191, 384);
            this.TwoNumberButton.Name = "TwoNumberButton";
            this.TwoNumberButton.Size = new System.Drawing.Size(75, 59);
            this.TwoNumberButton.TabIndex = 13;
            this.TwoNumberButton.Text = "2";
            this.TwoNumberButton.UseVisualStyleBackColor = false;
            this.TwoNumberButton.Click += new System.EventHandler(this.TwoNumberButton_Click);
            // 
            // OneNumberButton
            // 
            this.OneNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OneNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OneNumberButton.FlatAppearance.BorderSize = 0;
            this.OneNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OneNumberButton.Location = new System.Drawing.Point(110, 384);
            this.OneNumberButton.Name = "OneNumberButton";
            this.OneNumberButton.Size = new System.Drawing.Size(75, 59);
            this.OneNumberButton.TabIndex = 14;
            this.OneNumberButton.Text = "1";
            this.OneNumberButton.UseVisualStyleBackColor = false;
            this.OneNumberButton.Click += new System.EventHandler(this.OneNumberButton_Click);
            // 
            // ZeroNumberButton
            // 
            this.ZeroNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ZeroNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZeroNumberButton.FlatAppearance.BorderSize = 0;
            this.ZeroNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZeroNumberButton.Location = new System.Drawing.Point(191, 449);
            this.ZeroNumberButton.Name = "ZeroNumberButton";
            this.ZeroNumberButton.Size = new System.Drawing.Size(75, 59);
            this.ZeroNumberButton.TabIndex = 15;
            this.ZeroNumberButton.Text = "0";
            this.ZeroNumberButton.UseVisualStyleBackColor = false;
            this.ZeroNumberButton.Click += new System.EventHandler(this.ZeroNumberButton_Click);
            // 
            // FiveNumberButton
            // 
            this.FiveNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FiveNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FiveNumberButton.FlatAppearance.BorderSize = 0;
            this.FiveNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiveNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiveNumberButton.Location = new System.Drawing.Point(191, 319);
            this.FiveNumberButton.Name = "FiveNumberButton";
            this.FiveNumberButton.Size = new System.Drawing.Size(75, 59);
            this.FiveNumberButton.TabIndex = 16;
            this.FiveNumberButton.Text = "5";
            this.FiveNumberButton.UseVisualStyleBackColor = false;
            this.FiveNumberButton.Click += new System.EventHandler(this.FiveNumberButton_Click);
            // 
            // FourNumberButton
            // 
            this.FourNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FourNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FourNumberButton.FlatAppearance.BorderSize = 0;
            this.FourNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourNumberButton.Location = new System.Drawing.Point(110, 319);
            this.FourNumberButton.Name = "FourNumberButton";
            this.FourNumberButton.Size = new System.Drawing.Size(75, 59);
            this.FourNumberButton.TabIndex = 17;
            this.FourNumberButton.Text = "4";
            this.FourNumberButton.UseVisualStyleBackColor = false;
            this.FourNumberButton.Click += new System.EventHandler(this.FourNumberButton_Click);
            // 
            // SixNumberButton
            // 
            this.SixNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SixNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SixNumberButton.FlatAppearance.BorderSize = 0;
            this.SixNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixNumberButton.Location = new System.Drawing.Point(272, 319);
            this.SixNumberButton.Name = "SixNumberButton";
            this.SixNumberButton.Size = new System.Drawing.Size(75, 59);
            this.SixNumberButton.TabIndex = 18;
            this.SixNumberButton.Text = "6";
            this.SixNumberButton.UseVisualStyleBackColor = false;
            this.SixNumberButton.Click += new System.EventHandler(this.SixNumberButton_Click);
            // 
            // SevenNumberButton
            // 
            this.SevenNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SevenNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SevenNumberButton.FlatAppearance.BorderSize = 0;
            this.SevenNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SevenNumberButton.Location = new System.Drawing.Point(110, 254);
            this.SevenNumberButton.Name = "SevenNumberButton";
            this.SevenNumberButton.Size = new System.Drawing.Size(75, 59);
            this.SevenNumberButton.TabIndex = 19;
            this.SevenNumberButton.Text = "7";
            this.SevenNumberButton.UseVisualStyleBackColor = false;
            this.SevenNumberButton.Click += new System.EventHandler(this.SevenNumberButton_Click);
            // 
            // EightNumberButton
            // 
            this.EightNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EightNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EightNumberButton.FlatAppearance.BorderSize = 0;
            this.EightNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EightNumberButton.Location = new System.Drawing.Point(191, 254);
            this.EightNumberButton.Name = "EightNumberButton";
            this.EightNumberButton.Size = new System.Drawing.Size(75, 59);
            this.EightNumberButton.TabIndex = 20;
            this.EightNumberButton.Text = "8";
            this.EightNumberButton.UseVisualStyleBackColor = false;
            this.EightNumberButton.Click += new System.EventHandler(this.EightNumberButton_Click);
            // 
            // NineNumberButton
            // 
            this.NineNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NineNumberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NineNumberButton.FlatAppearance.BorderSize = 0;
            this.NineNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NineNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NineNumberButton.Location = new System.Drawing.Point(272, 254);
            this.NineNumberButton.Name = "NineNumberButton";
            this.NineNumberButton.Size = new System.Drawing.Size(75, 59);
            this.NineNumberButton.TabIndex = 21;
            this.NineNumberButton.Text = "9";
            this.NineNumberButton.UseVisualStyleBackColor = false;
            this.NineNumberButton.Click += new System.EventHandler(this.NineNumberButton_Click);
            // 
            // SinButton
            // 
            this.SinButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SinButton.FlatAppearance.BorderSize = 0;
            this.SinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SinButton.Location = new System.Drawing.Point(110, 189);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(75, 59);
            this.SinButton.TabIndex = 22;
            this.SinButton.Text = "sin";
            this.SinButton.UseVisualStyleBackColor = false;
            // 
            // CosButton
            // 
            this.CosButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CosButton.FlatAppearance.BorderSize = 0;
            this.CosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CosButton.Location = new System.Drawing.Point(29, 189);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(75, 59);
            this.CosButton.TabIndex = 23;
            this.CosButton.Text = "cos";
            this.CosButton.UseVisualStyleBackColor = false;
            // 
            // TanButton
            // 
            this.TanButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TanButton.FlatAppearance.BorderSize = 0;
            this.TanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TanButton.Location = new System.Drawing.Point(29, 254);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(75, 59);
            this.TanButton.TabIndex = 24;
            this.TanButton.Text = "tan";
            this.TanButton.UseVisualStyleBackColor = false;
            // 
            // CtanButton
            // 
            this.CtanButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CtanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CtanButton.FlatAppearance.BorderSize = 0;
            this.CtanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CtanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CtanButton.Location = new System.Drawing.Point(29, 319);
            this.CtanButton.Name = "CtanButton";
            this.CtanButton.Size = new System.Drawing.Size(75, 59);
            this.CtanButton.TabIndex = 25;
            this.CtanButton.Text = "cot";
            this.CtanButton.UseVisualStyleBackColor = false;
            // 
            // CubeRootButton
            // 
            this.CubeRootButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CubeRootButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CubeRootButton.FlatAppearance.BorderSize = 0;
            this.CubeRootButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CubeRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CubeRootButton.Location = new System.Drawing.Point(29, 449);
            this.CubeRootButton.Name = "CubeRootButton";
            this.CubeRootButton.Size = new System.Drawing.Size(75, 59);
            this.CubeRootButton.TabIndex = 26;
            this.CubeRootButton.Text = "∛";
            this.CubeRootButton.UseVisualStyleBackColor = false;
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SquareRootButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SquareRootButton.FlatAppearance.BorderSize = 0;
            this.SquareRootButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SquareRootButton.Location = new System.Drawing.Point(29, 384);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(75, 59);
            this.SquareRootButton.TabIndex = 27;
            this.SquareRootButton.Text = "√";
            this.SquareRootButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 534);
            this.Controls.Add(this.SquareRootButton);
            this.Controls.Add(this.CubeRootButton);
            this.Controls.Add(this.CtanButton);
            this.Controls.Add(this.TanButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.SinButton);
            this.Controls.Add(this.NineNumberButton);
            this.Controls.Add(this.EightNumberButton);
            this.Controls.Add(this.SevenNumberButton);
            this.Controls.Add(this.SixNumberButton);
            this.Controls.Add(this.FourNumberButton);
            this.Controls.Add(this.FiveNumberButton);
            this.Controls.Add(this.ZeroNumberButton);
            this.Controls.Add(this.OneNumberButton);
            this.Controls.Add(this.TwoNumberButton);
            this.Controls.Add(this.ThreeNumberButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.CubeButton);
            this.Controls.Add(this.SquareButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.ChangeSignButton);
            this.Controls.Add(this.BackspaceButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OutputField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackspaceButton;
        private System.Windows.Forms.Button ChangeSignButton;
        private System.Windows.Forms.TextBox OutputField;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SquareButton;
        private System.Windows.Forms.Button CubeButton;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button ThreeNumberButton;
        private System.Windows.Forms.Button TwoNumberButton;
        private System.Windows.Forms.Button OneNumberButton;
        private System.Windows.Forms.Button ZeroNumberButton;
        private System.Windows.Forms.Button FiveNumberButton;
        private System.Windows.Forms.Button FourNumberButton;
        private System.Windows.Forms.Button SixNumberButton;
        private System.Windows.Forms.Button SevenNumberButton;
        private System.Windows.Forms.Button EightNumberButton;
        private System.Windows.Forms.Button NineNumberButton;
        private System.Windows.Forms.Button SinButton;
        private System.Windows.Forms.Button CosButton;
        private System.Windows.Forms.Button TanButton;
        private System.Windows.Forms.Button CtanButton;
        private System.Windows.Forms.Button CubeRootButton;
        private System.Windows.Forms.Button SquareRootButton;
    }
}

