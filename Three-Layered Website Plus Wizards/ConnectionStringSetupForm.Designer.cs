namespace Three_Layered_Website_Plus_Wizards
{
    partial class ConnectionStringSetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionStringSetupForm));
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ConnectionString_Textbox = new System.Windows.Forms.TextBox();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionPanel
            // 
            resources.ApplyResources(this.ActionPanel, "ActionPanel");
            this.ActionPanel.Name = "ActionPanel";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainPanel.Controls.Add(this.ConnectionString_Textbox);
            this.MainPanel.Controls.Add(this.OK_Button);
            this.MainPanel.Controls.Add(this.Cancel_Button);
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            // 
            // ConnectionString_Textbox
            // 
            this.ConnectionString_Textbox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.ConnectionString_Textbox, "ConnectionString_Textbox");
            this.ConnectionString_Textbox.Name = "ConnectionString_Textbox";
            this.ConnectionString_Textbox.ReadOnly = true;
            // 
            // OK_Button
            // 
            this.OK_Button.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.OK_Button, "OK_Button");
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            resources.ApplyResources(this.Cancel_Button, "Cancel_Button");
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ConnectionStringSetupForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ActionPanel);
            this.Name = "ConnectionStringSetupForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.TextBox ConnectionString_Textbox;
    }
}