using System;
using System.Drawing;
using System.Windows.Forms;
using Three_Layered_Website_Plus_Wizards.Properties;

namespace Three_Layered_Website_Plus_Wizards
{
    public partial class SetupWizardForm : Form
    {
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
            DialogResult = DialogResult.OK;
            this.Close();
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
            connectionStringForm.ShowDialog();
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
    }
}
