using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;


namespace oh22is.DTS.Task.ZIP
{
    public partial class frmZipUI : Form
    {
        TaskHost _taskHost;
        Connections _connections;

        public frmZipUI(TaskHost taskHost, Connections connections)
        {
            InitializeComponent();
            _taskHost = taskHost;
            _connections = connections;
        }

        private void frmZipUI_Load(object sender, EventArgs e)
        {
            cbAction.SelectedItem = _taskHost.Properties["Action"].GetValue(_taskHost) == null ? "ZIP" : _taskHost.Properties["Action"].GetValue(_taskHost).ToString(); 
            cbFileFolder.SelectedItem = _taskHost.Properties["FileFolder"].GetValue(_taskHost) == null ? "FILE" : _taskHost.Properties["FileFolder"].GetValue(_taskHost).ToString();
            txtInput.Text = _taskHost.Properties["Input"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Input"].GetValue(_taskHost).ToString();
            txtOutput.Text = _taskHost.Properties["Output"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Output"].GetValue(_taskHost).ToString();
            nudZipLevel.Value = _taskHost.Properties["ZipLevel"].GetValue(_taskHost) == null ? 0 : Convert.ToDecimal(_taskHost.Properties["ZipLevel"].GetValue(_taskHost));
            txtPassword.Text = _taskHost.Properties["Password"].GetValue(_taskHost) == null ? "" : _taskHost.Properties["Password"].GetValue(_taskHost).ToString();
            cbAESKeySize.SelectedItem = _taskHost.Properties["AesKeySize"].GetValue(_taskHost) == null ? 0 : Convert.ToDecimal(_taskHost.Properties["AesKeySize"].GetValue(_taskHost));
            cbZip64.Checked = _taskHost.Properties["Zip64"].GetValue(_taskHost) == null ? true : Convert.ToBoolean(_taskHost.Properties["Zip64"].GetValue(_taskHost));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _taskHost.Properties["Action"].SetValue(_taskHost, cbAction.SelectedItem.ToString());
            _taskHost.Properties["FileFolder"].SetValue(_taskHost, cbFileFolder.SelectedItem.ToString());
            _taskHost.Properties["Input"].SetValue(_taskHost, txtInput.Text);
            _taskHost.Properties["Output"].SetValue(_taskHost, txtOutput.Text);
            _taskHost.Properties["ZipLevel"].SetValue(_taskHost, nudZipLevel.Value);
            _taskHost.Properties["Password"].SetValue(_taskHost, txtPassword.Text);
            _taskHost.Properties["AesKeySize"].SetValue(_taskHost, cbAESKeySize.SelectedItem.ToString());
            _taskHost.Properties["Zip64"].SetValue(_taskHost, cbZip64.Checked);
            DialogResult = DialogResult.OK;
        }

        private void llblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TEitelberg");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.oh22.is");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.solisyon.de");
        }

        private void cbFileFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFileFolder.SelectedText != null)
            {
                txtInput.Enabled = true;
                txtOutput.Enabled = true;
                btnInput.Enabled = true;
                btnOutput.Enabled = true;
            }
            else
            {
                txtInput.Enabled = false;
                txtOutput.Enabled = false;
                btnInput.Enabled = false;
                btnOutput.Enabled = false;
            }

            if (cbFileFolder.SelectedItem.ToString() == "FOLDER")
            {
                cbAction.SelectedItem = "ZIP";
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (cbFileFolder.SelectedItem.ToString() == "FILE" && cbAction.SelectedItem.ToString() == "ZIP")
            {
                if(fileInput.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = fileInput.FileName;
                }
            }
            else if (cbFileFolder.SelectedItem.ToString() == "FOLDER" && cbAction.SelectedItem.ToString() == "ZIP")
            {
                if (folderInput.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = folderInput.SelectedPath;
                }
            }
            else if (cbFileFolder.SelectedItem.ToString() == "FILE" && cbAction.SelectedItem.ToString() == "UNZIP")
            {
                if (fileInput.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = fileInput.FileName;
                }
            }
            else if (cbFileFolder.SelectedItem.ToString() == "FOLDER" && cbAction.SelectedItem.ToString() == "UNZIP")
            {
                MessageBox.Show("Folders cannot be unziped.");
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (cbFileFolder.SelectedItem.ToString() == "FILE" && cbAction.SelectedItem.ToString() == "ZIP")
            {
                if (fileOutput.ShowDialog() == DialogResult.OK)
                {
                    txtOutput.Text = fileOutput.FileName;
                }
            }
            else if (cbFileFolder.SelectedItem.ToString() == "FOLDER" && cbAction.SelectedItem.ToString() == "ZIP")
            {
                if (fileOutput.ShowDialog() == DialogResult.OK)
                {
                    txtOutput.Text = fileOutput.FileName;
                }
            }
            else if (cbFileFolder.SelectedItem.ToString() == "FILE" && cbAction.SelectedItem.ToString() == "UNZIP")
            {
                if (folderOutput.ShowDialog() == DialogResult.OK)
                {
                    txtOutput.Text = folderOutput.SelectedPath;
                }
            }
            else if (cbFileFolder.SelectedItem.ToString() == "FOLDER" && cbAction.SelectedItem.ToString() == "UNZIP")
            {
                MessageBox.Show("Folders cannot be unziped.");
            }
        }

        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAction.SelectedItem.ToString() == "UNZIP")
            {
                cbFileFolder.SelectedItem = "FILE";
            }

            cbAESKeySize.Enabled = !(cbAction.SelectedItem.ToString() == "UNZIP");
            nudZipLevel.Enabled = !(cbAction.SelectedItem.ToString() == "UNZIP");
            txtPassword.Enabled = !(cbAction.SelectedItem.ToString() == "UNZIP");
            cbZip64.Enabled = !(cbAction.SelectedItem.ToString() == "UNZIP");

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            cbAESKeySize.Enabled = !String.IsNullOrEmpty(txtPassword.Text);
        }
    }
}
