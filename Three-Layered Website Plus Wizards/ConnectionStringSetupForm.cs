using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Three_Layered_Website_Plus_Wizards.Properties;

namespace Three_Layered_Website_Plus_Wizards
{
    public partial class ConnectionStringSetupForm : Form
    {
        private readonly SqlConnectionStringBuilder _connectionString = new SqlConnectionStringBuilder();

        public ConnectionStringSetupForm()
        {
            InitializeComponent();
            var connectionString = new SqlConnectionStringBuilder();
            var index = connectionString.Keys.Count;
            var mainPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 300,
                MaximumSize = new Size(600, 300),
                AutoScroll = true
            };
            Controls.Add(mainPanel);
            foreach (var connectionStringKey in connectionString.Keys.OfType<string>().OrderByDescending(x => x))
            {
                var safeConnectionStringKey = connectionStringKey.Replace(" ", "");
                var enabler = new CheckBox
                {
                    Name = safeConnectionStringKey,
                    Dock = DockStyle.Top,
                    Text = safeConnectionStringKey,
                    Padding = new Padding(0),
                    TabIndex = index
                };

                Control input = null;

                var inputType = connectionString[connectionStringKey].GetType();
                if (inputType == typeof(string) && connectionStringKey != "Network Library")
                {
                    input = new TextBox
                    {
                        Name = safeConnectionStringKey,
                        Dock = DockStyle.Top,
                        TabIndex = index,
                        Enabled = false,
                        Visible = false,
                        Text = connectionString[connectionStringKey].ToString()
                    };
                    input.TextChanged += (sender, args) => { InputChange(input, enabler, connectionStringKey); };
                }
                else if (inputType == typeof(bool))
                {
                    input = new CheckBox
                    {
                        Name = safeConnectionStringKey,
                        Dock = DockStyle.Top,
                        Text = Resources.ConnectionStringSetupForm_Checkbox_Toggle,
                        TabIndex = index,
                        Enabled = false,
                        Visible = false,
                        Padding = new Padding(20, 0, 0, 0)
                    };
                    ((CheckBox)input).CheckedChanged += (sender, args) =>
                    {
                        InputChange(input, enabler, connectionStringKey);
                    };
                }
                else if (inputType == typeof(int))
                {
                    input = new NumericUpDown
                    {
                        Name = safeConnectionStringKey,
                        Dock = DockStyle.Top,
                        TabIndex = index,
                        Enabled = false,
                        Visible = false,
                        Padding = new Padding(20, 0, 0, 0),
                        Maximum = int.MaxValue,
                        Minimum = 0,
                        Value = (int)connectionString[connectionStringKey]
                    };
                    input.TextChanged += (sender, args) => { InputChange(input, enabler, connectionStringKey); };
                }
                else if (inputType.IsEnum)
                {
                    input = new ComboBox
                    {
                        Name = safeConnectionStringKey,
                        Dock = DockStyle.Top,
                        TabIndex = index,
                        Enabled = false,
                        Visible = false,
                        DropDownStyle = ComboBoxStyle.DropDownList
                    };
                    ((ComboBox)input).Items.AddRange(inputType.GetEnumNames());
                    ((ComboBox)input).SelectedIndex = 0;
                    ((ComboBox)input).SelectedIndexChanged += (sender, args) =>
                    {
                        InputChange(input, enabler, connectionStringKey);
                    };
                }
                else if (connectionStringKey == "Network Library")
                {
                    input = new ComboBox
                    {
                        Name = safeConnectionStringKey,
                        Dock = DockStyle.Top,
                        TabIndex = index,
                        Enabled = false,
                        Visible = false,
                        DropDownStyle = ComboBoxStyle.DropDownList
                    };
                    ((ComboBox)input).Items.Add("dbnmpntw");
                    ((ComboBox)input).Items.Add("dbmsrpcn");
                    ((ComboBox)input).Items.Add("dbmsadsn");
                    ((ComboBox)input).Items.Add("dbmsgnet");
                    ((ComboBox)input).Items.Add("dbmslpcn");
                    ((ComboBox)input).Items.Add("dbmsspxn");
                    ((ComboBox)input).Items.Add("dbmssocn");
                    ((ComboBox)input).SelectedIndex = 0;
                    ((ComboBox)input).SelectedIndexChanged += (sender, args) =>
                    {
                        InputChange(input, enabler, connectionStringKey);
                    };
                }

                enabler.CheckedChanged += (sender, args) => { InputChange(input, enabler, connectionStringKey); };
                mainPanel.Controls.Add(input);
                mainPanel.Controls.Add(enabler);
                index--;
            }
        }

        private void InputChange(Control input, CheckBox enabler, string connectionStringKey)
        {
            input.Enabled = enabler.Checked;
            input.Visible = enabler.Checked;
            if (input.GetType() == typeof(TextBox))
                _connectionString[connectionStringKey] = enabler.Checked ? input.Text : null;

            if (input.GetType() == typeof(CheckBox))
            {
                var checkBoxInput = (CheckBox)input;
                if (!enabler.Checked)
                    _connectionString[connectionStringKey] = null;
                else
                    _connectionString[connectionStringKey] = checkBoxInput?.Checked;
            }

            if (input.GetType() == typeof(ComboBox))
                if (connectionStringKey == "Authentication")
                    if (!enabler.Checked)
                    {
                        _connectionString[connectionStringKey] = null;
                    }
                    else
                    {
                        var canParse =
                            Enum.TryParse(((ComboBox)input).Items[((ComboBox)input).SelectedIndex].ToString(),
                                out SqlAuthenticationMethod output);
                        if (!canParse) _connectionString[connectionStringKey] = null;

                        _connectionString[connectionStringKey] = output;
                    }
                else
                    _connectionString[connectionStringKey] = enabler.Checked
                        ? ((ComboBox)input).Items[((ComboBox)input).SelectedIndex].ToString()
                        : null;

            if (input.GetType() == typeof(NumericUpDown))
                try
                {
                    _connectionString[connectionStringKey] =
                        enabler.Checked ? ((NumericUpDown)input).Value.ToString(CultureInfo.CurrentCulture) : null;
                }
                catch (Exception)
                {
                    _connectionString[connectionStringKey] = null;
                }

            ConnectionString_Textbox.Text = _connectionString.ToString();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (!TestConnection()) return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string ConnectionString()
        {
            return _connectionString.ToString();
        }

        private bool TestConnection()
        {
            var testResult = false;
            var initialCatalog = _connectionString.InitialCatalog;
            try
            {
                _connectionString.InitialCatalog = string.Empty;
                var connectionTask = Task.Run(() => OpenCloseConnection());
                connectionTask.Wait(500);
                if (connectionTask.Status == TaskStatus.Faulted)
                {
                    if (connectionTask.Exception != null)
                    {
                        throw connectionTask.Exception;
                    }
                    else
                    {
                        throw new InvalidOperationException("The task to test the connection failed but no exception was thrown");
                    }
                }
                _connectionString.InitialCatalog = initialCatalog;
                MessageBox.Show(Resources.ConnectionStringSetupForm_TestConnection_Successful,
                    Resources.ConnectionStringSetupForm_TestConnection_Successful_Title, MessageBoxButtons.OK,
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly,
                    false);
                testResult = true;
            }
            catch (InvalidOperationException exception)
            {
                MessageBox.Show(
                    exception.HResult + Resources.ExceptionCodeMessageSeperator + exception.Message +
                    Resources.ConnectionStringSetupForm_TestConnection_InvalidOperationException,
                    Resources.ConnectionStringSetupForm_TestConnection_InvalidOperationException_Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly, false);
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.HResult + Resources.ExceptionCodeMessageSeperator + exception.Message,
                    Resources.ConnectionStringSetupForm_ConnectionIssues, MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, Resources.ConnectionStringSetupForm_UnexpectedException, MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
            finally
            {
                _connectionString.InitialCatalog = initialCatalog;
            }
            return testResult;
        }

        private void OpenCloseConnection()
        {
            SqlConnection testConnection = new SqlConnection(_connectionString.ConnectionString);
            testConnection.Open();
            testConnection.Close();
            testConnection.Dispose();
        }
    }
}
