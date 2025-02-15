using System.Drawing.Text;
using System.Reflection;
using System.Diagnostics;
using Microsoft.Win32;

namespace remuxx
{
    public partial class Menu : Form
    {
        private Label FFmpegStatusLabel;

        public Menu()
        {
            InitializeComponent();
            InitializeFFmpegStatusLabel();
            UpdateInstallLabel();
            CheckFFmpegInstallation();
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            string regPath = @"*\shell\remuxx";
            string[] formatList = new string[] { "mp3", "wav", "ogg", "m4a", "wma", "flac", "aac" };

            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(regPath))
            {
                if (key != null)
                {
                    key.SetValue("subcommands", "");

                    using (RegistryKey shellKey = key.CreateSubKey("shell"))
                    {
                        foreach (string format in formatList)
                        {
                            using (RegistryKey formatKey = shellKey.CreateSubKey(format))
                            {
                                formatKey.SetValue("MUIVerb", $"Convert to {format.ToUpper()}");

                                using (RegistryKey commandKey = formatKey.CreateSubKey("command"))
                                {
                                    commandKey.SetValue("", Environment.ProcessPath + $" {format} %1");
                                }
                            }
                        }
                    }
                }
            }
            UpdateInstallLabel();
        }

        private void UninstallButton_Click(object sender, EventArgs e)
        {
            string remuxx = @"*\shell";
            using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(remuxx, true))
            {
                key.DeleteSubKeyTree("remuxx");
            }
            UpdateInstallLabel();
        }

        private void UpdateInstallLabel()
        {
            try
            {
                string remuxx = @"*\shell\remuxx";
                using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(remuxx, true))
                {
                    if (key != null)
                    {
                        InstallLabel.Text = "Enabled! :3";
                        InstallButton.Enabled = false;
                        UninstallButton.Enabled = true;
                    }
                    else
                    {
                        InstallLabel.Text = "Disabled :<";
                        InstallButton.Enabled = true;
                        UninstallButton.Enabled = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("An error occurred: Please run as Administrator");
                Environment.Exit(0);
            }
        }

        private void GitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", "https://github.com/sillycatmoments");
        }

        private void InitializeFFmpegStatusLabel()
        {
            FFmpegStatusLabel = new Label
            {
                Text = "Checking for FFmpeg...",
                AutoSize = true,
                Location = new System.Drawing.Point(19, 105)
            };
            Controls.Add(FFmpegStatusLabel);
        }

        private void CheckFFmpegInstallation()
        {
            if (IsFFmpegInstalled())
            {
                FFmpegStatusLabel.Text = "FFmpeg found!";
            }
            else
            {
                FFmpegStatusLabel.Text = "FFmpeg not found!";
            }
        }

        private bool IsFFmpegInstalled()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = "-version",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    process.WaitForExit();
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    return output.Contains("ffmpeg version") || error.Contains("ffmpeg version");
                }
            }
            catch
            {
                return false;
            }
        }

        private void InstallLabel_Click(object sender, EventArgs e)
        {

        }
    }
}