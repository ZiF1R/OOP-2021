namespace _2_lw
{
    partial class Bank
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank));
            this.BankAccountNumber = new System.Windows.Forms.MaskedTextBox();
            this.BankAccountNumberLabel = new System.Windows.Forms.Label();
            this.DepositTypeList = new System.Windows.Forms.ComboBox();
            this.DepositTypeListLabel = new System.Windows.Forms.Label();
            this.AccountBalance = new System.Windows.Forms.NumericUpDown();
            this.AccountBalanceLabel = new System.Windows.Forms.Label();
            this.AccountOpeningDate = new System.Windows.Forms.DateTimePicker();
            this.AccountOpeningDateLabel = new System.Windows.Forms.Label();
            this.OwnerInfoGroup = new System.Windows.Forms.GroupBox();
            this.PassportDataGroup = new System.Windows.Forms.GroupBox();
            this.ExpiresDate1 = new System.Windows.Forms.DateTimePicker();
            this.ExpiresDateLabel = new System.Windows.Forms.Label();
            this.PassportInputLabel = new System.Windows.Forms.Label();
            this.PassportInput = new System.Windows.Forms.TextBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.PatronimicInputLabel = new System.Windows.Forms.Label();
            this.PatronimicInput = new System.Windows.Forms.TextBox();
            this.SurnameInputLabel = new System.Windows.Forms.Label();
            this.SurnameInput = new System.Windows.Forms.TextBox();
            this.NameInputLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.SMSNotificationsCheckbox = new System.Windows.Forms.CheckBox();
            this.InternetBanking = new System.Windows.Forms.CheckBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.MenuToolbar = new System.Windows.Forms.MenuStrip();
            this.MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchByButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchAccountNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchFullName = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchDepositType = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortDepositType = new System.Windows.Forms.ToolStripMenuItem();
            this.SortOpeningDate = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.depositTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openingDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.CurrentAccountsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.LastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AccountBalance)).BeginInit();
            this.OwnerInfoGroup.SuspendLayout();
            this.PassportDataGroup.SuspendLayout();
            this.MenuToolbar.SuspendLayout();
            this.StatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BankAccountNumber
            // 
            this.BankAccountNumber.Culture = new System.Globalization.CultureInfo("ru-BY");
            this.BankAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankAccountNumber.Location = new System.Drawing.Point(37, 53);
            this.BankAccountNumber.Mask = "000-000-000";
            this.BankAccountNumber.Name = "BankAccountNumber";
            this.BankAccountNumber.Size = new System.Drawing.Size(271, 30);
            this.BankAccountNumber.TabIndex = 0;
            this.BankAccountNumber.ValidatingType = typeof(int);
            this.BankAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.BankAccountNumber_Validating);
            // 
            // BankAccountNumberLabel
            // 
            this.BankAccountNumberLabel.AutoSize = true;
            this.BankAccountNumberLabel.Location = new System.Drawing.Point(34, 34);
            this.BankAccountNumberLabel.Name = "BankAccountNumberLabel";
            this.BankAccountNumberLabel.Size = new System.Drawing.Size(201, 16);
            this.BankAccountNumberLabel.TabIndex = 1;
            this.BankAccountNumberLabel.Text = "Enter your bank account number:\r\n";
            // 
            // DepositTypeList
            // 
            this.DepositTypeList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.DepositTypeList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DepositTypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepositTypeList.FormattingEnabled = true;
            this.DepositTypeList.Items.AddRange(new object[] {
            "Накопительный",
            "Расчетный",
            "Сберегательный",
            "Срочный"});
            this.DepositTypeList.Location = new System.Drawing.Point(37, 113);
            this.DepositTypeList.Name = "DepositTypeList";
            this.DepositTypeList.Size = new System.Drawing.Size(271, 30);
            this.DepositTypeList.TabIndex = 1;
            this.DepositTypeList.Validating += new System.ComponentModel.CancelEventHandler(this.DepositTypeList_Validating);
            // 
            // DepositTypeListLabel
            // 
            this.DepositTypeListLabel.AutoSize = true;
            this.DepositTypeListLabel.Location = new System.Drawing.Point(34, 94);
            this.DepositTypeListLabel.Name = "DepositTypeListLabel";
            this.DepositTypeListLabel.Size = new System.Drawing.Size(134, 16);
            this.DepositTypeListLabel.TabIndex = 3;
            this.DepositTypeListLabel.Text = "Choose deposit type:";
            // 
            // AccountBalance
            // 
            this.AccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountBalance.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AccountBalance.Location = new System.Drawing.Point(37, 233);
            this.AccountBalance.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.AccountBalance.Name = "AccountBalance";
            this.AccountBalance.Size = new System.Drawing.Size(271, 30);
            this.AccountBalance.TabIndex = 3;
            this.AccountBalance.ThousandsSeparator = true;
            // 
            // AccountBalanceLabel
            // 
            this.AccountBalanceLabel.AutoSize = true;
            this.AccountBalanceLabel.Location = new System.Drawing.Point(34, 214);
            this.AccountBalanceLabel.Name = "AccountBalanceLabel";
            this.AccountBalanceLabel.Size = new System.Drawing.Size(184, 16);
            this.AccountBalanceLabel.TabIndex = 5;
            this.AccountBalanceLabel.Text = "Enter your balance (in dolors):";
            // 
            // AccountOpeningDate
            // 
            this.AccountOpeningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountOpeningDate.Location = new System.Drawing.Point(37, 173);
            this.AccountOpeningDate.MaxDate = new System.DateTime(2022, 2, 27, 0, 0, 0, 0);
            this.AccountOpeningDate.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.AccountOpeningDate.Name = "AccountOpeningDate";
            this.AccountOpeningDate.Size = new System.Drawing.Size(271, 30);
            this.AccountOpeningDate.TabIndex = 2;
            this.AccountOpeningDate.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // AccountOpeningDateLabel
            // 
            this.AccountOpeningDateLabel.AutoSize = true;
            this.AccountOpeningDateLabel.Location = new System.Drawing.Point(34, 154);
            this.AccountOpeningDateLabel.Name = "AccountOpeningDateLabel";
            this.AccountOpeningDateLabel.Size = new System.Drawing.Size(155, 16);
            this.AccountOpeningDateLabel.TabIndex = 7;
            this.AccountOpeningDateLabel.Text = "Date of account opening:\r\n";
            // 
            // OwnerInfoGroup
            // 
            this.OwnerInfoGroup.Controls.Add(this.PassportDataGroup);
            this.OwnerInfoGroup.Controls.Add(this.BirthDateLabel);
            this.OwnerInfoGroup.Controls.Add(this.BirthDate);
            this.OwnerInfoGroup.Controls.Add(this.PatronimicInputLabel);
            this.OwnerInfoGroup.Controls.Add(this.PatronimicInput);
            this.OwnerInfoGroup.Controls.Add(this.SurnameInputLabel);
            this.OwnerInfoGroup.Controls.Add(this.SurnameInput);
            this.OwnerInfoGroup.Controls.Add(this.NameInputLabel);
            this.OwnerInfoGroup.Controls.Add(this.NameInput);
            this.OwnerInfoGroup.Location = new System.Drawing.Point(334, 34);
            this.OwnerInfoGroup.Name = "OwnerInfoGroup";
            this.OwnerInfoGroup.Padding = new System.Windows.Forms.Padding(10);
            this.OwnerInfoGroup.Size = new System.Drawing.Size(600, 296);
            this.OwnerInfoGroup.TabIndex = 4;
            this.OwnerInfoGroup.TabStop = false;
            this.OwnerInfoGroup.Text = "Owner info";
            // 
            // PassportDataGroup
            // 
            this.PassportDataGroup.Controls.Add(this.ExpiresDate1);
            this.PassportDataGroup.Controls.Add(this.ExpiresDateLabel);
            this.PassportDataGroup.Controls.Add(this.PassportInputLabel);
            this.PassportDataGroup.Controls.Add(this.PassportInput);
            this.PassportDataGroup.Location = new System.Drawing.Point(288, 25);
            this.PassportDataGroup.Name = "PassportDataGroup";
            this.PassportDataGroup.Padding = new System.Windows.Forms.Padding(10);
            this.PassportDataGroup.Size = new System.Drawing.Size(288, 166);
            this.PassportDataGroup.TabIndex = 8;
            this.PassportDataGroup.TabStop = false;
            this.PassportDataGroup.Text = "Passport data";
            // 
            // ExpiresDate1
            // 
            this.ExpiresDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpiresDate1.Location = new System.Drawing.Point(16, 119);
            this.ExpiresDate1.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.ExpiresDate1.MinDate = new System.DateTime(2022, 2, 27, 0, 0, 0, 0);
            this.ExpiresDate1.Name = "ExpiresDate1";
            this.ExpiresDate1.Size = new System.Drawing.Size(250, 30);
            this.ExpiresDate1.TabIndex = 13;
            this.ExpiresDate1.Value = new System.DateTime(2022, 2, 27, 0, 0, 0, 0);
            // 
            // ExpiresDateLabel
            // 
            this.ExpiresDateLabel.AutoSize = true;
            this.ExpiresDateLabel.Location = new System.Drawing.Point(13, 89);
            this.ExpiresDateLabel.Name = "ExpiresDateLabel";
            this.ExpiresDateLabel.Size = new System.Drawing.Size(55, 16);
            this.ExpiresDateLabel.TabIndex = 10;
            this.ExpiresDateLabel.Text = "Expires:";
            // 
            // PassportInputLabel
            // 
            this.PassportInputLabel.AutoSize = true;
            this.PassportInputLabel.Location = new System.Drawing.Point(13, 25);
            this.PassportInputLabel.Name = "PassportInputLabel";
            this.PassportInputLabel.Size = new System.Drawing.Size(203, 16);
            this.PassportInputLabel.TabIndex = 10;
            this.PassportInputLabel.Text = "Passport number (14 characters):";
            // 
            // PassportInput
            // 
            this.PassportInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportInput.Location = new System.Drawing.Point(16, 44);
            this.PassportInput.MaxLength = 14;
            this.PassportInput.Name = "PassportInput";
            this.PassportInput.Size = new System.Drawing.Size(253, 28);
            this.PassportInput.TabIndex = 8;
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(16, 204);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(66, 16);
            this.BirthDateLabel.TabIndex = 10;
            this.BirthDateLabel.Text = "Birth date:";
            // 
            // BirthDate
            // 
            this.BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDate.Location = new System.Drawing.Point(19, 223);
            this.BirthDate.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.BirthDate.MinDate = new System.DateTime(1951, 1, 1, 0, 0, 0, 0);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(250, 30);
            this.BirthDate.TabIndex = 7;
            this.BirthDate.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // PatronimicInputLabel
            // 
            this.PatronimicInputLabel.AutoSize = true;
            this.PatronimicInputLabel.Location = new System.Drawing.Point(13, 144);
            this.PatronimicInputLabel.Name = "PatronimicInputLabel";
            this.PatronimicInputLabel.Size = new System.Drawing.Size(70, 16);
            this.PatronimicInputLabel.TabIndex = 12;
            this.PatronimicInputLabel.Text = "Patronimic";
            // 
            // PatronimicInput
            // 
            this.PatronimicInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronimicInput.Location = new System.Drawing.Point(16, 163);
            this.PatronimicInput.Name = "PatronimicInput";
            this.PatronimicInput.Size = new System.Drawing.Size(253, 28);
            this.PatronimicInput.TabIndex = 6;
            // 
            // SurnameInputLabel
            // 
            this.SurnameInputLabel.AutoSize = true;
            this.SurnameInputLabel.Location = new System.Drawing.Point(13, 25);
            this.SurnameInputLabel.Name = "SurnameInputLabel";
            this.SurnameInputLabel.Size = new System.Drawing.Size(61, 16);
            this.SurnameInputLabel.TabIndex = 10;
            this.SurnameInputLabel.Text = "Surname";
            // 
            // SurnameInput
            // 
            this.SurnameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameInput.Location = new System.Drawing.Point(16, 44);
            this.SurnameInput.Name = "SurnameInput";
            this.SurnameInput.Size = new System.Drawing.Size(253, 28);
            this.SurnameInput.TabIndex = 4;
            // 
            // NameInputLabel
            // 
            this.NameInputLabel.AutoSize = true;
            this.NameInputLabel.Location = new System.Drawing.Point(13, 83);
            this.NameInputLabel.Name = "NameInputLabel";
            this.NameInputLabel.Size = new System.Drawing.Size(44, 16);
            this.NameInputLabel.TabIndex = 9;
            this.NameInputLabel.Text = "Name";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameInput.Location = new System.Drawing.Point(16, 102);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(253, 28);
            this.NameInput.TabIndex = 5;
            // 
            // SMSNotificationsCheckbox
            // 
            this.SMSNotificationsCheckbox.AutoSize = true;
            this.SMSNotificationsCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SMSNotificationsCheckbox.Location = new System.Drawing.Point(37, 280);
            this.SMSNotificationsCheckbox.Name = "SMSNotificationsCheckbox";
            this.SMSNotificationsCheckbox.Size = new System.Drawing.Size(146, 22);
            this.SMSNotificationsCheckbox.TabIndex = 10;
            this.SMSNotificationsCheckbox.Text = "SMS notifications";
            this.SMSNotificationsCheckbox.UseVisualStyleBackColor = true;
            // 
            // InternetBanking
            // 
            this.InternetBanking.AutoSize = true;
            this.InternetBanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InternetBanking.Location = new System.Drawing.Point(37, 308);
            this.InternetBanking.Name = "InternetBanking";
            this.InternetBanking.Size = new System.Drawing.Size(133, 22);
            this.InternetBanking.TabIndex = 11;
            this.InternetBanking.Text = "Internet banking";
            this.InternetBanking.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddButton.CausesValidation = false;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(37, 358);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(271, 60);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SerializeButton
            // 
            this.SerializeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SerializeButton.FlatAppearance.BorderSize = 0;
            this.SerializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerializeButton.Location = new System.Drawing.Point(37, 454);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(271, 37);
            this.SerializeButton.TabIndex = 13;
            this.SerializeButton.Text = "Save to JSON-file";
            this.SerializeButton.UseVisualStyleBackColor = false;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeserializeButton.FlatAppearance.BorderSize = 0;
            this.DeserializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeserializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeserializeButton.Location = new System.Drawing.Point(37, 497);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(271, 37);
            this.DeserializeButton.TabIndex = 14;
            this.DeserializeButton.Text = "Read from JSON-file";
            this.DeserializeButton.UseVisualStyleBackColor = false;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(334, 358);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Output.Size = new System.Drawing.Size(600, 176);
            this.Output.TabIndex = 15;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(334, 337);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(48, 16);
            this.OutputLabel.TabIndex = 16;
            this.OutputLabel.Text = "Output:";
            // 
            // MenuToolbar
            // 
            this.MenuToolbar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButton,
            this.sortByToolStripMenuItem,
            this.sortByToolStripMenuItem1,
            this.clearToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.MenuToolbar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuToolbar.Location = new System.Drawing.Point(0, 0);
            this.MenuToolbar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuToolbar.Name = "MenuToolbar";
            this.MenuToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuToolbar.ShowItemToolTips = true;
            this.MenuToolbar.Size = new System.Drawing.Size(965, 30);
            this.MenuToolbar.TabIndex = 17;
            this.MenuToolbar.Text = "MenuToolbar";
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchByButton,
            this.SortByButton,
            this.SaveMenuButton,
            this.AboutProgram});
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.ShortcutKeyDisplayString = "";
            this.MenuButton.Size = new System.Drawing.Size(60, 26);
            this.MenuButton.Text = "Menu";
            // 
            // SearchByButton
            // 
            this.SearchByButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchAccountNumber,
            this.SearchFullName,
            this.SearchBalance,
            this.SearchDepositType});
            this.SearchByButton.Name = "SearchByButton";
            this.SearchByButton.Size = new System.Drawing.Size(252, 26);
            this.SearchByButton.Text = "Search by";
            // 
            // SearchAccountNumber
            // 
            this.SearchAccountNumber.Name = "SearchAccountNumber";
            this.SearchAccountNumber.Size = new System.Drawing.Size(201, 26);
            this.SearchAccountNumber.Text = "Account number";
            this.SearchAccountNumber.Click += new System.EventHandler(this.SearchAccountNumber_Click);
            // 
            // SearchFullName
            // 
            this.SearchFullName.Name = "SearchFullName";
            this.SearchFullName.Size = new System.Drawing.Size(201, 26);
            this.SearchFullName.Text = "Full name";
            this.SearchFullName.Click += new System.EventHandler(this.SearchFullName_Click);
            // 
            // SearchBalance
            // 
            this.SearchBalance.Name = "SearchBalance";
            this.SearchBalance.Size = new System.Drawing.Size(201, 26);
            this.SearchBalance.Text = "Balance";
            this.SearchBalance.Click += new System.EventHandler(this.SearchBalance_Click);
            // 
            // SearchDepositType
            // 
            this.SearchDepositType.Name = "SearchDepositType";
            this.SearchDepositType.Size = new System.Drawing.Size(201, 26);
            this.SearchDepositType.Text = "Deposit type";
            this.SearchDepositType.Click += new System.EventHandler(this.SearchDepositType_Click);
            // 
            // SortByButton
            // 
            this.SortByButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortDepositType,
            this.SortOpeningDate});
            this.SortByButton.Name = "SortByButton";
            this.SortByButton.Size = new System.Drawing.Size(252, 26);
            this.SortByButton.Text = "Sort by";
            // 
            // SortDepositType
            // 
            this.SortDepositType.Name = "SortDepositType";
            this.SortDepositType.Size = new System.Drawing.Size(183, 26);
            this.SortDepositType.Text = "Deposit type";
            this.SortDepositType.Click += new System.EventHandler(this.SortDepositType_Click);
            // 
            // SortOpeningDate
            // 
            this.SortOpeningDate.Name = "SortOpeningDate";
            this.SortOpeningDate.Size = new System.Drawing.Size(183, 26);
            this.SortOpeningDate.Text = "Opening date";
            this.SortOpeningDate.Click += new System.EventHandler(this.SortOpeningDate_Click);
            // 
            // SaveMenuButton
            // 
            this.SaveMenuButton.Name = "SaveMenuButton";
            this.SaveMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SaveMenuButton.Size = new System.Drawing.Size(252, 26);
            this.SaveMenuButton.Text = "Save";
            this.SaveMenuButton.Click += new System.EventHandler(this.SaveMenuButton_Click);
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.AboutProgram.Size = new System.Drawing.Size(252, 26);
            this.AboutProgram.Text = "About program";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountNumberToolStripMenuItem,
            this.fullNameToolStripMenuItem,
            this.balanceToolStripMenuItem,
            this.depositTypeToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.sortByToolStripMenuItem.Text = "Search by";
            // 
            // accountNumberToolStripMenuItem
            // 
            this.accountNumberToolStripMenuItem.Name = "accountNumberToolStripMenuItem";
            this.accountNumberToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.accountNumberToolStripMenuItem.Text = "Account number";
            this.accountNumberToolStripMenuItem.Click += new System.EventHandler(this.SearchAccountNumber_Click);
            // 
            // fullNameToolStripMenuItem
            // 
            this.fullNameToolStripMenuItem.Name = "fullNameToolStripMenuItem";
            this.fullNameToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.fullNameToolStripMenuItem.Text = "Full name";
            this.fullNameToolStripMenuItem.Click += new System.EventHandler(this.SearchFullName_Click);
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.balanceToolStripMenuItem.Text = "Balance";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.SearchBalance_Click);
            // 
            // depositTypeToolStripMenuItem
            // 
            this.depositTypeToolStripMenuItem.Name = "depositTypeToolStripMenuItem";
            this.depositTypeToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.depositTypeToolStripMenuItem.Text = "Deposit type";
            this.depositTypeToolStripMenuItem.Click += new System.EventHandler(this.SearchDepositType_Click);
            // 
            // sortByToolStripMenuItem1
            // 
            this.sortByToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositTypeToolStripMenuItem1,
            this.openingDateToolStripMenuItem});
            this.sortByToolStripMenuItem1.Name = "sortByToolStripMenuItem1";
            this.sortByToolStripMenuItem1.Size = new System.Drawing.Size(70, 26);
            this.sortByToolStripMenuItem1.Text = "Sort by";
            // 
            // depositTypeToolStripMenuItem1
            // 
            this.depositTypeToolStripMenuItem1.Name = "depositTypeToolStripMenuItem1";
            this.depositTypeToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.depositTypeToolStripMenuItem1.Text = "Deposit type";
            this.depositTypeToolStripMenuItem1.Click += new System.EventHandler(this.SortDepositType_Click);
            // 
            // openingDateToolStripMenuItem
            // 
            this.openingDateToolStripMenuItem.Name = "openingDateToolStripMenuItem";
            this.openingDateToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.openingDateToolStripMenuItem.Text = "Opening date";
            this.openingDateToolStripMenuItem.Click += new System.EventHandler(this.SortOpeningDate_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearAccounts);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveAccount);
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentAccountsCount,
            this.LastAction,
            this.CurrentTime});
            this.StatusBar.Location = new System.Drawing.Point(0, 576);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(965, 26);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 18;
            this.StatusBar.Text = "StatusBar";
            // 
            // CurrentAccountsCount
            // 
            this.CurrentAccountsCount.Name = "CurrentAccountsCount";
            this.CurrentAccountsCount.Size = new System.Drawing.Size(84, 20);
            this.CurrentAccountsCount.Text = "Accounts: 0";
            // 
            // LastAction
            // 
            this.LastAction.Name = "LastAction";
            this.LastAction.Size = new System.Drawing.Size(83, 20);
            this.LastAction.Text = "Last action:";
            // 
            // CurrentTime
            // 
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(94, 20);
            this.CurrentTime.Text = "Current time:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 602);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.DeserializeButton);
            this.Controls.Add(this.SerializeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InternetBanking);
            this.Controls.Add(this.SMSNotificationsCheckbox);
            this.Controls.Add(this.OwnerInfoGroup);
            this.Controls.Add(this.AccountOpeningDateLabel);
            this.Controls.Add(this.AccountOpeningDate);
            this.Controls.Add(this.AccountBalanceLabel);
            this.Controls.Add(this.AccountBalance);
            this.Controls.Add(this.DepositTypeListLabel);
            this.Controls.Add(this.DepositTypeList);
            this.Controls.Add(this.BankAccountNumberLabel);
            this.Controls.Add(this.BankAccountNumber);
            this.Controls.Add(this.MenuToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuToolbar;
            this.Name = "Bank";
            this.Text = "Bank";
            ((System.ComponentModel.ISupportInitialize)(this.AccountBalance)).EndInit();
            this.OwnerInfoGroup.ResumeLayout(false);
            this.OwnerInfoGroup.PerformLayout();
            this.PassportDataGroup.ResumeLayout(false);
            this.PassportDataGroup.PerformLayout();
            this.MenuToolbar.ResumeLayout(false);
            this.MenuToolbar.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox BankAccountNumber;
        private System.Windows.Forms.Label BankAccountNumberLabel;
        private System.Windows.Forms.ComboBox DepositTypeList;
        private System.Windows.Forms.Label DepositTypeListLabel;
        private System.Windows.Forms.NumericUpDown AccountBalance;
        private System.Windows.Forms.Label AccountBalanceLabel;
        private System.Windows.Forms.DateTimePicker AccountOpeningDate;
        private System.Windows.Forms.Label AccountOpeningDateLabel;
        private System.Windows.Forms.GroupBox OwnerInfoGroup;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameInputLabel;
        private System.Windows.Forms.Label SurnameInputLabel;
        private System.Windows.Forms.TextBox SurnameInput;
        private System.Windows.Forms.Label PatronimicInputLabel;
        private System.Windows.Forms.TextBox PatronimicInput;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.CheckBox SMSNotificationsCheckbox;
        private System.Windows.Forms.CheckBox InternetBanking;
        private System.Windows.Forms.GroupBox PassportDataGroup;
        private System.Windows.Forms.Label ExpiresDateLabel;
        private System.Windows.Forms.Label PassportInputLabel;
        private System.Windows.Forms.TextBox PassportInput;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.MenuStrip MenuToolbar;
        private System.Windows.Forms.ToolStripMenuItem MenuButton;
        private System.Windows.Forms.ToolStripMenuItem SearchByButton;
        private System.Windows.Forms.ToolStripMenuItem SortByButton;
        private System.Windows.Forms.ToolStripMenuItem SortDepositType;
        private System.Windows.Forms.ToolStripMenuItem SortOpeningDate;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuButton;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.ToolStripMenuItem SearchAccountNumber;
        private System.Windows.Forms.ToolStripMenuItem SearchFullName;
        private System.Windows.Forms.ToolStripMenuItem SearchBalance;
        private System.Windows.Forms.ToolStripMenuItem SearchDepositType;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel CurrentAccountsCount;
        private System.Windows.Forms.ToolStripStatusLabel LastAction;
        private System.Windows.Forms.ToolStripStatusLabel CurrentTime;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem depositTypeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openingDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker ExpiresDate1;
    }
}

