using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevOne.Security.Cryptography.BCrypt;
using Three_Layered_Website_Plus_Wizards.Properties;

namespace Three_Layered_Website_Plus_Wizards
{
    public partial class SetupWizardForm : Form
    {

        public Dictionary<string,string> SetupReplacements = new Dictionary<string, string>();

        public SetupWizardForm(string solutionName, string organizationName)
        {
            InitializeComponent();
            WebsiteTitleTextbox.Text = solutionName;
            CopyrightTextbox.Text = organizationName;
        }

        private void SetupWizardFormOkButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            FillReplacements();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FillReplacements()
        {
            SetupReplacements.Add("$WebTitle$",WebsiteTitleTextbox.Text);
            SetupReplacements.Add("$Copyright$",CopyrightTextbox.Text);
            SetupReplacements.Add("$HTTPS$",HTTPSCheckbox.Checked.ToString().ToLower());
            SetupReplacements.Add("$ConnectionString$",ConnectionStringTextbox.Text);
            SetupReplacements.Add("$AdminUsername$", AdminUserUsernameTextbox.Text.EscapeForSql());
            var adminPassword = BCryptHelper.HashPassword(AdminUserPasswordTextbox.Text, BCryptHelper.GenerateSalt(5));
            SetupReplacements.Add("$AdminPassword$", adminPassword.EscapeForSql());
            SetupReplacements.Add("$AdminQuestion$", AdminUserSecurityQuestionTextbox.Text.EscapeForSql());
            SetupReplacements.Add("$AdminAnswer$", AdminUserAnswerTextbox.Text.EscapeForSql());
            SetupReplacements.Add("$AdminEmail$", AdminUserEmailTextbox.Text.EscapeForSql());
            var roles = RolesListbox.Items.OfType<string>().ToArray();
            var rolesSql = new StringBuilder();
            foreach (var role in roles)
            {
                rolesSql.AppendFormat("IF(NOT EXISTS(SELECT [Id] FROM [Membership].[Role] WHERE [Name] = '{0}'))\n\t\tINSERT INTO[Membership].[Role]([Name],[SystemDefault]) VALUES('{0}', 1)\n\t",role.EscapeForSql());
            }
            SetupReplacements.Add("$WebsiteRoles$", rolesSql.ToString());
            var securityQuestions = SecurityQuestionListbox.Items.OfType<string>().ToArray();
            var securityQuestionsSql = new StringBuilder();
            foreach (var securityQuestion in securityQuestions)
            {
                securityQuestionsSql.AppendFormat("IF(NOT EXISTS (SELECT [Id] FROM [Membership].[SecurityQuestion] WHERE [Text] = '{0}' AND [SystemDefault] = 1))\n\t\tINSERT INTO[Membership].[SecurityQuestion]([Text],[SystemDefault]) VALUES('{0}', 1)\n\t", securityQuestion.EscapeForSql());
            }
            SetupReplacements.Add("$WebsiteSecurityQuestions$", securityQuestionsSql.ToString());
        }

        private bool ValidateInputs()
        {
            var isWebSiteSectionValid = ValidateWebsiteSection();
            var isDatabaseSectionValid = ValidateDatabaseSection();
            var isAdminUserSectionValid = ValidateAdminUserSection();
            return isWebSiteSectionValid && isDatabaseSectionValid && isAdminUserSectionValid;
        }

        private bool ValidateWebsiteSection()
        {
            if (HTTPSCheckbox.Checked) return true;
            return MessageBox.Show(
                       Resources.HTTPSUncheckedWarning,
                       Resources.HTTPSUncheckedWarningTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, false) == DialogResult.Yes;
        }

        private bool ValidateDatabaseSection()
        {
            MarkAsValid(ConnectionStringTextbox);
            var connectionStringValid = !string.IsNullOrEmpty(ConnectionStringTextbox.Text);
            if (!connectionStringValid) MarkAsInvalid(ConnectionStringTextbox);
            return connectionStringValid;
        }

        private bool ValidateAdminUserSection()
        {
            MarkAsValid(AdminUserUsernameTextbox);
            MarkAsValid(AdminUserEmailTextbox);
            var isUsernameValid = !string.IsNullOrEmpty(AdminUserUsernameTextbox.Text);
            var isEmailValid = !string.IsNullOrEmpty(AdminUserEmailTextbox.Text);
            if (!isUsernameValid) MarkAsInvalid(AdminUserUsernameTextbox);
            if (!isEmailValid) MarkAsInvalid(AdminUserEmailTextbox);
            return isUsernameValid && isEmailValid;
        }

        private void MarkAsInvalid(TextBox input)
        {
            input.BackColor = Color.Firebrick;
        }

        private void MarkAsValid(TextBox input)
        {
            input.BackColor = Color.FromName("Window");
        }

        private void ConnectionStringSetButton_Click(object sender, EventArgs e)
        {
            var connectionStringForm = new ConnectionStringSetupForm();
            var dialogResult = connectionStringForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ConnectionStringTextbox.Text = connectionStringForm.ConnectionString();
            }
        }

        private void RemoveRoleButton_Click(object sender, EventArgs e)
        {
            if (RolesListbox.SelectedIndices.Contains(0))
            {
                MessageBox.Show(Resources.AdminRemovalWaringText,Resources.AdminRemovalWaringTitle,MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly, false);
                return;
            }
            RolesListbox.Items.Remove(RolesListbox.SelectedItem);
        }

        private void RoleAddButton_Click(object sender, EventArgs e)
        {
            if (RolesListbox.Items.Contains(RoleNameTextbox.Text))
            {
                if (MessageBox.Show(Resources.DuplicateRoleWarningText, Resources.DuplicateRoleWarningTitle, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly,
                        false) == DialogResult.No) return;
            }
            RolesListbox.Items.Add(RoleNameTextbox.Text);
            RoleNameTextbox.Clear();
        }

        private void RemoveSecurityQuestionButton_Click(object sender, EventArgs e)
        {
            SecurityQuestionListbox.Items.Remove(SecurityQuestionListbox.SelectedItem);
        }

        private void AddSecurityQuestionButton_Click(object sender, EventArgs e)
        {
            SecurityQuestionListbox.Items.Add(SecurityQuestionTextTextbox.Text);
            SecurityQuestionTextTextbox.Clear();
        }

        private void AdminUserSection_TextChanged(object sender, EventArgs e)
        {
            ValidateAdminUserSection();
        }

        private void SetupWizardFormCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
