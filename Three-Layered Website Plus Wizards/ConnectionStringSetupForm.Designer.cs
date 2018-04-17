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
            this.ActionPanel.AutoScroll = true;
            this.ActionPanel.AutoSize = true;
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ActionPanel.Location = new System.Drawing.Point(0, 0);
            this.ActionPanel.MaximumSize = new System.Drawing.Size(0, 400);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(584, 0);
            this.ActionPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainPanel.Controls.Add(this.ConnectionString_Textbox);
            this.MainPanel.Controls.Add(this.OK_Button);
            this.MainPanel.Controls.Add(this.Cancel_Button);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 29);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(584, 21);
            this.MainPanel.TabIndex = 1;
            // 
            // ConnectionString_Textbox
            // 
            this.ConnectionString_Textbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConnectionString_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionString_Textbox.Location = new System.Drawing.Point(0, 0);
            this.ConnectionString_Textbox.Name = "ConnectionString_Textbox";
            this.ConnectionString_Textbox.ReadOnly = true;
            this.ConnectionString_Textbox.Size = new System.Drawing.Size(434, 20);
            this.ConnectionString_Textbox.TabIndex = 2;
            // 
            // OK_Button
            // 
            this.OK_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.OK_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.OK_Button.Location = new System.Drawing.Point(434, 0);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 21);
            this.OK_Button.TabIndex = 1;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel_Button.Location = new System.Drawing.Point(509, 0);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 21);
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ConnectionStringSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 50);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ActionPanel);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 39);
            this.Name = "ConnectionStringSetupForm";
            this.Text = "Form1";
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