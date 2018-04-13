namespace Three_Layered_Website_Plus_Wizards
{
    partial class SetupWizardForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupWizardForm));
            this.WebsiteTitleLabel = new System.Windows.Forms.Label();
            this.WebsiteTitleTextbox = new System.Windows.Forms.TextBox();
            this.CopyrightLabel = new System.Windows.Forms.Label();
            this.CopyrightTextbox = new System.Windows.Forms.TextBox();
            this.HTTPSCheckbox = new System.Windows.Forms.CheckBox();
            this.WebsiteSetupLabel = new System.Windows.Forms.Label();
            this.DatabaseSetupLabel = new System.Windows.Forms.Label();
            this.ConnectionStringTextbox = new System.Windows.Forms.TextBox();
            this.ConnectionStringLabel = new System.Windows.Forms.Label();
            this.ConnectionStringSetButton = new System.Windows.Forms.Button();
            this.WebsiteSecurityLabel = new System.Windows.Forms.Label();
            this.AdminUserLabel = new System.Windows.Forms.Label();
            this.AdminUserUsernameTextbox = new System.Windows.Forms.TextBox();
            this.AdminUserUsernameLabel = new System.Windows.Forms.Label();
            this.AdminUserPasswordTextbox = new System.Windows.Forms.TextBox();
            this.AdminUserPasswordLabel = new System.Windows.Forms.Label();
            this.AdminUserSecurityQuestionTextbox = new System.Windows.Forms.TextBox();
            this.AdminUserSecuirtyQuestionsLabel = new System.Windows.Forms.Label();
            this.AdminUserAnswerTextbox = new System.Windows.Forms.TextBox();
            this.AdminUserSecurityAnswerLabel = new System.Windows.Forms.Label();
            this.AdminUserEmailTextbox = new System.Windows.Forms.TextBox();
            this.AdminUserEmailLabel = new System.Windows.Forms.Label();
            this.RolesLabel = new System.Windows.Forms.Label();
            this.RolesListbox = new System.Windows.Forms.ListBox();
            this.RoleAddButton = new System.Windows.Forms.Button();
            this.RemoveRoleButton = new System.Windows.Forms.Button();
            this.RoleNameTextbox = new System.Windows.Forms.TextBox();
            this.SecurityQuestionTextTextbox = new System.Windows.Forms.TextBox();
            this.RemoveSecurityQuestionButton = new System.Windows.Forms.Button();
            this.AddSecurityQuestionButton = new System.Windows.Forms.Button();
            this.SecurityQuestionListbox = new System.Windows.Forms.ListBox();
            this.SecurityQuestionsLabel = new System.Windows.Forms.Label();
            this.SetupWizardFormCancelButton = new System.Windows.Forms.Button();
            this.SetupWizardFormOkButton = new System.Windows.Forms.Button();
            this.SetupWizardControlsPanel = new System.Windows.Forms.Panel();
            this.WebsiteTitleTextboxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WebsiteCopyrightTextboxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HTTPSCheckboxTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.AdminUserTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SetupWizardControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebsiteTitleLabel
            // 
            this.WebsiteTitleLabel.AutoSize = true;
            this.WebsiteTitleLabel.Location = new System.Drawing.Point(31, 22);
            this.WebsiteTitleLabel.Name = "WebsiteTitleLabel";
            this.WebsiteTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.WebsiteTitleLabel.TabIndex = 0;
            this.WebsiteTitleLabel.Text = "Title";
            // 
            // WebsiteTitleTextbox
            // 
            this.WebsiteTitleTextbox.AcceptsReturn = true;
            this.WebsiteTitleTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebsiteTitleTextbox.Location = new System.Drawing.Point(34, 38);
            this.WebsiteTitleTextbox.Name = "WebsiteTitleTextbox";
            this.WebsiteTitleTextbox.Size = new System.Drawing.Size(238, 20);
            this.WebsiteTitleTextbox.TabIndex = 1;
            this.WebsiteTitleTextboxToolTip.SetToolTip(this.WebsiteTitleTextbox, resources.GetString("WebsiteTitleTextbox.ToolTip"));
            // 
            // CopyrightLabel
            // 
            this.CopyrightLabel.AutoSize = true;
            this.CopyrightLabel.Location = new System.Drawing.Point(31, 61);
            this.CopyrightLabel.Name = "CopyrightLabel";
            this.CopyrightLabel.Size = new System.Drawing.Size(51, 13);
            this.CopyrightLabel.TabIndex = 2;
            this.CopyrightLabel.Text = "Copyright";
            // 
            // CopyrightTextbox
            // 
            this.CopyrightTextbox.AcceptsReturn = true;
            this.CopyrightTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyrightTextbox.Location = new System.Drawing.Point(34, 77);
            this.CopyrightTextbox.Name = "CopyrightTextbox";
            this.CopyrightTextbox.Size = new System.Drawing.Size(238, 20);
            this.CopyrightTextbox.TabIndex = 3;
            this.WebsiteCopyrightTextboxToolTip.SetToolTip(this.CopyrightTextbox, "The text put in here will show at the bottom of the website in the footer.\r\nThis " +
        "can be empty but this will lead to \"© [This current year] - \" been put in the fo" +
        "oter.");
            // 
            // HTTPSCheckbox
            // 
            this.HTTPSCheckbox.AutoSize = true;
            this.HTTPSCheckbox.Checked = true;
            this.HTTPSCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HTTPSCheckbox.Location = new System.Drawing.Point(34, 103);
            this.HTTPSCheckbox.Name = "HTTPSCheckbox";
            this.HTTPSCheckbox.Size = new System.Drawing.Size(120, 17);
            this.HTTPSCheckbox.TabIndex = 4;
            this.HTTPSCheckbox.Text = "HTTPS everywhere";
            this.HTTPSCheckboxTooltip.SetToolTip(this.HTTPSCheckbox, resources.GetString("HTTPSCheckbox.ToolTip"));
            this.HTTPSCheckbox.UseVisualStyleBackColor = true;
            // 
            // WebsiteSetupLabel
            // 
            this.WebsiteSetupLabel.AutoSize = true;
            this.WebsiteSetupLabel.Location = new System.Drawing.Point(12, 9);
            this.WebsiteSetupLabel.Name = "WebsiteSetupLabel";
            this.WebsiteSetupLabel.Size = new System.Drawing.Size(46, 13);
            this.WebsiteSetupLabel.TabIndex = 5;
            this.WebsiteSetupLabel.Text = "Website";
            // 
            // DatabaseSetupLabel
            // 
            this.DatabaseSetupLabel.AutoSize = true;
            this.DatabaseSetupLabel.Location = new System.Drawing.Point(12, 123);
            this.DatabaseSetupLabel.Name = "DatabaseSetupLabel";
            this.DatabaseSetupLabel.Size = new System.Drawing.Size(53, 13);
            this.DatabaseSetupLabel.TabIndex = 6;
            this.DatabaseSetupLabel.Text = "Database";
            // 
            // ConnectionStringTextbox
            // 
            this.ConnectionStringTextbox.AcceptsReturn = true;
            this.ConnectionStringTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionStringTextbox.Enabled = false;
            this.ConnectionStringTextbox.Location = new System.Drawing.Point(34, 152);
            this.ConnectionStringTextbox.Name = "ConnectionStringTextbox";
            this.ConnectionStringTextbox.ReadOnly = true;
            this.ConnectionStringTextbox.Size = new System.Drawing.Size(168, 20);
            this.ConnectionStringTextbox.TabIndex = 8;
            // 
            // ConnectionStringLabel
            // 
            this.ConnectionStringLabel.AutoSize = true;
            this.ConnectionStringLabel.Location = new System.Drawing.Point(31, 136);
            this.ConnectionStringLabel.Name = "ConnectionStringLabel";
            this.ConnectionStringLabel.Size = new System.Drawing.Size(89, 13);
            this.ConnectionStringLabel.TabIndex = 7;
            this.ConnectionStringLabel.Text = "Connection string";
            // 
            // ConnectionStringSetButton
            // 
            this.ConnectionStringSetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionStringSetButton.Location = new System.Drawing.Point(208, 152);
            this.ConnectionStringSetButton.Name = "ConnectionStringSetButton";
            this.ConnectionStringSetButton.Size = new System.Drawing.Size(64, 20);
            this.ConnectionStringSetButton.TabIndex = 9;
            this.ConnectionStringSetButton.Text = "Set";
            this.ConnectionStringSetButton.UseVisualStyleBackColor = true;
            this.ConnectionStringSetButton.Click += new System.EventHandler(this.ConnectionStringSetButton_Click);
            // 
            // WebsiteSecurityLabel
            // 
            this.WebsiteSecurityLabel.AutoSize = true;
            this.WebsiteSecurityLabel.Location = new System.Drawing.Point(12, 175);
            this.WebsiteSecurityLabel.Name = "WebsiteSecurityLabel";
            this.WebsiteSecurityLabel.Size = new System.Drawing.Size(85, 13);
            this.WebsiteSecurityLabel.TabIndex = 10;
            this.WebsiteSecurityLabel.Text = "Website security";
            // 
            // AdminUserLabel
            // 
            this.AdminUserLabel.AutoSize = true;
            this.AdminUserLabel.Location = new System.Drawing.Point(31, 188);
            this.AdminUserLabel.Name = "AdminUserLabel";
            this.AdminUserLabel.Size = new System.Drawing.Size(59, 13);
            this.AdminUserLabel.TabIndex = 11;
            this.AdminUserLabel.Text = "Admin user";
            // 
            // AdminUserUsernameTextbox
            // 
            this.AdminUserUsernameTextbox.AcceptsReturn = true;
            this.AdminUserUsernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminUserUsernameTextbox.Location = new System.Drawing.Point(49, 217);
            this.AdminUserUsernameTextbox.Name = "AdminUserUsernameTextbox";
            this.AdminUserUsernameTextbox.Size = new System.Drawing.Size(223, 20);
            this.AdminUserUsernameTextbox.TabIndex = 13;
            this.AdminUserTooltip.SetToolTip(this.AdminUserUsernameTextbox, resources.GetString("AdminUserUsernameTextbox.ToolTip"));
            this.AdminUserUsernameTextbox.TextChanged += new System.EventHandler(this.AdminUserSection_TextChanged);
            // 
            // AdminUserUsernameLabel
            // 
            this.AdminUserUsernameLabel.AutoSize = true;
            this.AdminUserUsernameLabel.Location = new System.Drawing.Point(46, 201);
            this.AdminUserUsernameLabel.Name = "AdminUserUsernameLabel";
            this.AdminUserUsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.AdminUserUsernameLabel.TabIndex = 12;
            this.AdminUserUsernameLabel.Text = "Username";
            // 
            // AdminUserPasswordTextbox
            // 
            this.AdminUserPasswordTextbox.AcceptsReturn = true;
            this.AdminUserPasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminUserPasswordTextbox.Location = new System.Drawing.Point(49, 256);
            this.AdminUserPasswordTextbox.Name = "AdminUserPasswordTextbox";
            this.AdminUserPasswordTextbox.PasswordChar = '*';
            this.AdminUserPasswordTextbox.Size = new System.Drawing.Size(223, 20);
            this.AdminUserPasswordTextbox.TabIndex = 15;
            this.AdminUserTooltip.SetToolTip(this.AdminUserPasswordTextbox, resources.GetString("AdminUserPasswordTextbox.ToolTip"));
            // 
            // AdminUserPasswordLabel
            // 
            this.AdminUserPasswordLabel.AutoSize = true;
            this.AdminUserPasswordLabel.Location = new System.Drawing.Point(46, 240);
            this.AdminUserPasswordLabel.Name = "AdminUserPasswordLabel";
            this.AdminUserPasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.AdminUserPasswordLabel.TabIndex = 14;
            this.AdminUserPasswordLabel.Text = "Password";
            // 
            // AdminUserSecurityQuestionTextbox
            // 
            this.AdminUserSecurityQuestionTextbox.AcceptsReturn = true;
            this.AdminUserSecurityQuestionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminUserSecurityQuestionTextbox.Location = new System.Drawing.Point(49, 295);
            this.AdminUserSecurityQuestionTextbox.Name = "AdminUserSecurityQuestionTextbox";
            this.AdminUserSecurityQuestionTextbox.Size = new System.Drawing.Size(223, 20);
            this.AdminUserSecurityQuestionTextbox.TabIndex = 17;
            this.AdminUserTooltip.SetToolTip(this.AdminUserSecurityQuestionTextbox, "The security question that the admin user will answer to reset there password for" +
        " the website.");
            // 
            // AdminUserSecuirtyQuestionsLabel
            // 
            this.AdminUserSecuirtyQuestionsLabel.AutoSize = true;
            this.AdminUserSecuirtyQuestionsLabel.Location = new System.Drawing.Point(46, 279);
            this.AdminUserSecuirtyQuestionsLabel.Name = "AdminUserSecuirtyQuestionsLabel";
            this.AdminUserSecuirtyQuestionsLabel.Size = new System.Drawing.Size(88, 13);
            this.AdminUserSecuirtyQuestionsLabel.TabIndex = 16;
            this.AdminUserSecuirtyQuestionsLabel.Text = "Security question";
            // 
            // AdminUserAnswerTextbox
            // 
            this.AdminUserAnswerTextbox.AcceptsReturn = true;
            this.AdminUserAnswerTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminUserAnswerTextbox.Location = new System.Drawing.Point(49, 334);
            this.AdminUserAnswerTextbox.Name = "AdminUserAnswerTextbox";
            this.AdminUserAnswerTextbox.Size = new System.Drawing.Size(223, 20);
            this.AdminUserAnswerTextbox.TabIndex = 19;
            this.AdminUserTooltip.SetToolTip(this.AdminUserAnswerTextbox, "The answer to the security question that the admin user will answer to reset ther" +
        "e password for the website.");
            // 
            // AdminUserSecurityAnswerLabel
            // 
            this.AdminUserSecurityAnswerLabel.AutoSize = true;
            this.AdminUserSecurityAnswerLabel.Location = new System.Drawing.Point(46, 318);
            this.AdminUserSecurityAnswerLabel.Name = "AdminUserSecurityAnswerLabel";
            this.AdminUserSecurityAnswerLabel.Size = new System.Drawing.Size(82, 13);
            this.AdminUserSecurityAnswerLabel.TabIndex = 18;
            this.AdminUserSecurityAnswerLabel.Text = "Security answer";
            // 
            // AdminUserEmailTextbox
            // 
            this.AdminUserEmailTextbox.AcceptsReturn = true;
            this.AdminUserEmailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminUserEmailTextbox.Location = new System.Drawing.Point(49, 373);
            this.AdminUserEmailTextbox.Name = "AdminUserEmailTextbox";
            this.AdminUserEmailTextbox.Size = new System.Drawing.Size(223, 20);
            this.AdminUserEmailTextbox.TabIndex = 21;
            this.AdminUserTooltip.SetToolTip(this.AdminUserEmailTextbox, "The email for the admin user that a password reset will be sent to by the website" +
        ".");
            this.AdminUserEmailTextbox.TextChanged += new System.EventHandler(this.AdminUserSection_TextChanged);
            // 
            // AdminUserEmailLabel
            // 
            this.AdminUserEmailLabel.AutoSize = true;
            this.AdminUserEmailLabel.Location = new System.Drawing.Point(46, 357);
            this.AdminUserEmailLabel.Name = "AdminUserEmailLabel";
            this.AdminUserEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.AdminUserEmailLabel.TabIndex = 20;
            this.AdminUserEmailLabel.Text = "Email";
            // 
            // RolesLabel
            // 
            this.RolesLabel.AutoSize = true;
            this.RolesLabel.Location = new System.Drawing.Point(31, 396);
            this.RolesLabel.Name = "RolesLabel";
            this.RolesLabel.Size = new System.Drawing.Size(34, 13);
            this.RolesLabel.TabIndex = 22;
            this.RolesLabel.Text = "Roles";
            // 
            // RolesListbox
            // 
            this.RolesListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RolesListbox.FormattingEnabled = true;
            this.RolesListbox.Items.AddRange(new object[] {
            "Administrator",
            "Default"});
            this.RolesListbox.Location = new System.Drawing.Point(49, 412);
            this.RolesListbox.Name = "RolesListbox";
            this.RolesListbox.Size = new System.Drawing.Size(223, 69);
            this.RolesListbox.TabIndex = 23;
            // 
            // RoleAddButton
            // 
            this.RoleAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleAddButton.Location = new System.Drawing.Point(167, 487);
            this.RoleAddButton.Name = "RoleAddButton";
            this.RoleAddButton.Size = new System.Drawing.Size(35, 23);
            this.RoleAddButton.TabIndex = 24;
            this.RoleAddButton.Text = "Add";
            this.RoleAddButton.UseVisualStyleBackColor = true;
            this.RoleAddButton.Click += new System.EventHandler(this.RoleAddButton_Click);
            // 
            // RemoveRoleButton
            // 
            this.RemoveRoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveRoleButton.Location = new System.Drawing.Point(208, 487);
            this.RemoveRoleButton.Name = "RemoveRoleButton";
            this.RemoveRoleButton.Size = new System.Drawing.Size(64, 23);
            this.RemoveRoleButton.TabIndex = 25;
            this.RemoveRoleButton.Text = "Remove";
            this.RemoveRoleButton.UseVisualStyleBackColor = true;
            this.RemoveRoleButton.Click += new System.EventHandler(this.RemoveRoleButton_Click);
            // 
            // RoleNameTextbox
            // 
            this.RoleNameTextbox.AcceptsReturn = true;
            this.RoleNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleNameTextbox.Location = new System.Drawing.Point(49, 489);
            this.RoleNameTextbox.Name = "RoleNameTextbox";
            this.RoleNameTextbox.Size = new System.Drawing.Size(112, 20);
            this.RoleNameTextbox.TabIndex = 26;
            // 
            // SecurityQuestionTextTextbox
            // 
            this.SecurityQuestionTextTextbox.AcceptsReturn = true;
            this.SecurityQuestionTextTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityQuestionTextTextbox.Location = new System.Drawing.Point(49, 605);
            this.SecurityQuestionTextTextbox.Name = "SecurityQuestionTextTextbox";
            this.SecurityQuestionTextTextbox.Size = new System.Drawing.Size(112, 20);
            this.SecurityQuestionTextTextbox.TabIndex = 31;
            // 
            // RemoveSecurityQuestionButton
            // 
            this.RemoveSecurityQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveSecurityQuestionButton.Location = new System.Drawing.Point(208, 603);
            this.RemoveSecurityQuestionButton.Name = "RemoveSecurityQuestionButton";
            this.RemoveSecurityQuestionButton.Size = new System.Drawing.Size(64, 23);
            this.RemoveSecurityQuestionButton.TabIndex = 30;
            this.RemoveSecurityQuestionButton.Text = "Remove";
            this.RemoveSecurityQuestionButton.UseVisualStyleBackColor = true;
            this.RemoveSecurityQuestionButton.Click += new System.EventHandler(this.RemoveSecurityQuestionButton_Click);
            // 
            // AddSecurityQuestionButton
            // 
            this.AddSecurityQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSecurityQuestionButton.Location = new System.Drawing.Point(167, 603);
            this.AddSecurityQuestionButton.Name = "AddSecurityQuestionButton";
            this.AddSecurityQuestionButton.Size = new System.Drawing.Size(35, 23);
            this.AddSecurityQuestionButton.TabIndex = 29;
            this.AddSecurityQuestionButton.Text = "Add";
            this.AddSecurityQuestionButton.UseVisualStyleBackColor = true;
            this.AddSecurityQuestionButton.Click += new System.EventHandler(this.AddSecurityQuestionButton_Click);
            // 
            // SecurityQuestionListbox
            // 
            this.SecurityQuestionListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityQuestionListbox.FormattingEnabled = true;
            this.SecurityQuestionListbox.Items.AddRange(new object[] {
            "What is the first and last name of your first boyfriend or girlfriend?",
            "Which phone number do you remember most from your childhood?",
            "What was your favorite place to visit as a child?",
            "Who is your favorite actor, musician, or artist?",
            "What is the name of your favorite pet?",
            "In what city were you born?",
            "What high school did you attend?",
            "What is your mother\'s maiden name?",
            "What street did you grow up on?",
            "What was the make of your first car?",
            "When is your anniversary?",
            "What is your favorite color?",
            "What is your father\'s middle name?",
            "What is the name of your first grade teacher?",
            "What was your high school mascot?",
            "Which is your favorite web browser?"});
            this.SecurityQuestionListbox.Location = new System.Drawing.Point(49, 528);
            this.SecurityQuestionListbox.Name = "SecurityQuestionListbox";
            this.SecurityQuestionListbox.Size = new System.Drawing.Size(223, 69);
            this.SecurityQuestionListbox.TabIndex = 28;
            // 
            // SecurityQuestionsLabel
            // 
            this.SecurityQuestionsLabel.AutoSize = true;
            this.SecurityQuestionsLabel.Location = new System.Drawing.Point(31, 512);
            this.SecurityQuestionsLabel.Name = "SecurityQuestionsLabel";
            this.SecurityQuestionsLabel.Size = new System.Drawing.Size(93, 13);
            this.SecurityQuestionsLabel.TabIndex = 27;
            this.SecurityQuestionsLabel.Text = "Security questions";
            // 
            // SetupWizardFormCancelButton
            // 
            this.SetupWizardFormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SetupWizardFormCancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SetupWizardFormCancelButton.Location = new System.Drawing.Point(218, 0);
            this.SetupWizardFormCancelButton.Name = "SetupWizardFormCancelButton";
            this.SetupWizardFormCancelButton.Size = new System.Drawing.Size(64, 25);
            this.SetupWizardFormCancelButton.TabIndex = 32;
            this.SetupWizardFormCancelButton.Text = "Cancel";
            this.SetupWizardFormCancelButton.UseVisualStyleBackColor = true;
            // 
            // SetupWizardFormOkButton
            // 
            this.SetupWizardFormOkButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SetupWizardFormOkButton.Location = new System.Drawing.Point(154, 0);
            this.SetupWizardFormOkButton.Name = "SetupWizardFormOkButton";
            this.SetupWizardFormOkButton.Size = new System.Drawing.Size(64, 25);
            this.SetupWizardFormOkButton.TabIndex = 33;
            this.SetupWizardFormOkButton.Text = "OK";
            this.SetupWizardFormOkButton.UseVisualStyleBackColor = true;
            this.SetupWizardFormOkButton.Click += new System.EventHandler(this.SetupWizardFormOkButton_Click);
            // 
            // SetupWizardControlsPanel
            // 
            this.SetupWizardControlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetupWizardControlsPanel.Controls.Add(this.SetupWizardFormOkButton);
            this.SetupWizardControlsPanel.Controls.Add(this.SetupWizardFormCancelButton);
            this.SetupWizardControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SetupWizardControlsPanel.Location = new System.Drawing.Point(0, 633);
            this.SetupWizardControlsPanel.Name = "SetupWizardControlsPanel";
            this.SetupWizardControlsPanel.Size = new System.Drawing.Size(284, 27);
            this.SetupWizardControlsPanel.TabIndex = 34;
            // 
            // WebsiteTitleTextboxToolTip
            // 
            this.WebsiteTitleTextboxToolTip.IsBalloon = true;
            this.WebsiteTitleTextboxToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.WebsiteTitleTextboxToolTip.ToolTipTitle = "Website title";
            // 
            // WebsiteCopyrightTextboxToolTip
            // 
            this.WebsiteCopyrightTextboxToolTip.IsBalloon = true;
            this.WebsiteCopyrightTextboxToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.WebsiteCopyrightTextboxToolTip.ToolTipTitle = "Copyright text";
            // 
            // HTTPSCheckboxTooltip
            // 
            this.HTTPSCheckboxTooltip.IsBalloon = true;
            this.HTTPSCheckboxTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HTTPSCheckboxTooltip.ToolTipTitle = "HTTPS";
            // 
            // AdminUserTooltip
            // 
            this.AdminUserTooltip.IsBalloon = true;
            this.AdminUserTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AdminUserTooltip.ToolTipTitle = "Admin user details";
            // 
            // SetupWizardForm
            // 
            this.AcceptButton = this.SetupWizardFormOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SetupWizardFormCancelButton;
            this.ClientSize = new System.Drawing.Size(284, 660);
            this.ControlBox = false;
            this.Controls.Add(this.SetupWizardControlsPanel);
            this.Controls.Add(this.SecurityQuestionTextTextbox);
            this.Controls.Add(this.RemoveSecurityQuestionButton);
            this.Controls.Add(this.AddSecurityQuestionButton);
            this.Controls.Add(this.SecurityQuestionListbox);
            this.Controls.Add(this.SecurityQuestionsLabel);
            this.Controls.Add(this.RoleNameTextbox);
            this.Controls.Add(this.RemoveRoleButton);
            this.Controls.Add(this.RoleAddButton);
            this.Controls.Add(this.RolesListbox);
            this.Controls.Add(this.RolesLabel);
            this.Controls.Add(this.AdminUserEmailTextbox);
            this.Controls.Add(this.AdminUserEmailLabel);
            this.Controls.Add(this.AdminUserAnswerTextbox);
            this.Controls.Add(this.AdminUserSecurityAnswerLabel);
            this.Controls.Add(this.AdminUserSecurityQuestionTextbox);
            this.Controls.Add(this.AdminUserSecuirtyQuestionsLabel);
            this.Controls.Add(this.AdminUserPasswordTextbox);
            this.Controls.Add(this.AdminUserPasswordLabel);
            this.Controls.Add(this.AdminUserUsernameTextbox);
            this.Controls.Add(this.AdminUserUsernameLabel);
            this.Controls.Add(this.AdminUserLabel);
            this.Controls.Add(this.WebsiteSecurityLabel);
            this.Controls.Add(this.ConnectionStringSetButton);
            this.Controls.Add(this.ConnectionStringTextbox);
            this.Controls.Add(this.ConnectionStringLabel);
            this.Controls.Add(this.DatabaseSetupLabel);
            this.Controls.Add(this.WebsiteSetupLabel);
            this.Controls.Add(this.HTTPSCheckbox);
            this.Controls.Add(this.CopyrightTextbox);
            this.Controls.Add(this.CopyrightLabel);
            this.Controls.Add(this.WebsiteTitleTextbox);
            this.Controls.Add(this.WebsiteTitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupWizardForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setup";
            this.TopMost = true;
            this.SetupWizardControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WebsiteTitleLabel;
        private System.Windows.Forms.TextBox WebsiteTitleTextbox;
        private System.Windows.Forms.Label CopyrightLabel;
        private System.Windows.Forms.TextBox CopyrightTextbox;
        private System.Windows.Forms.CheckBox HTTPSCheckbox;
        private System.Windows.Forms.Label WebsiteSetupLabel;
        private System.Windows.Forms.Label DatabaseSetupLabel;
        private System.Windows.Forms.TextBox ConnectionStringTextbox;
        private System.Windows.Forms.Label ConnectionStringLabel;
        private System.Windows.Forms.Button ConnectionStringSetButton;
        private System.Windows.Forms.Label WebsiteSecurityLabel;
        private System.Windows.Forms.Label AdminUserLabel;
        private System.Windows.Forms.TextBox AdminUserUsernameTextbox;
        private System.Windows.Forms.Label AdminUserUsernameLabel;
        private System.Windows.Forms.TextBox AdminUserPasswordTextbox;
        private System.Windows.Forms.Label AdminUserPasswordLabel;
        private System.Windows.Forms.TextBox AdminUserSecurityQuestionTextbox;
        private System.Windows.Forms.Label AdminUserSecuirtyQuestionsLabel;
        private System.Windows.Forms.TextBox AdminUserAnswerTextbox;
        private System.Windows.Forms.Label AdminUserSecurityAnswerLabel;
        private System.Windows.Forms.TextBox AdminUserEmailTextbox;
        private System.Windows.Forms.Label AdminUserEmailLabel;
        private System.Windows.Forms.Label RolesLabel;
        private System.Windows.Forms.ListBox RolesListbox;
        private System.Windows.Forms.Button RoleAddButton;
        private System.Windows.Forms.Button RemoveRoleButton;
        private System.Windows.Forms.TextBox RoleNameTextbox;
        private System.Windows.Forms.TextBox SecurityQuestionTextTextbox;
        private System.Windows.Forms.Button RemoveSecurityQuestionButton;
        private System.Windows.Forms.Button AddSecurityQuestionButton;
        private System.Windows.Forms.ListBox SecurityQuestionListbox;
        private System.Windows.Forms.Label SecurityQuestionsLabel;
        private System.Windows.Forms.Button SetupWizardFormCancelButton;
        private System.Windows.Forms.Button SetupWizardFormOkButton;
        private System.Windows.Forms.Panel SetupWizardControlsPanel;
        private System.Windows.Forms.ToolTip WebsiteTitleTextboxToolTip;
        private System.Windows.Forms.ToolTip WebsiteCopyrightTextboxToolTip;
        private System.Windows.Forms.ToolTip HTTPSCheckboxTooltip;
        private System.Windows.Forms.ToolTip AdminUserTooltip;
    }
}