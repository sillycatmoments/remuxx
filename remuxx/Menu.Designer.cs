namespace remuxx
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InstallButton = new Button();
            UninstallButton = new Button();
            InstallLabel = new Label();
            GitHubLink = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // InstallButton
            // 
            InstallButton.Location = new Point(19, 57);
            InstallButton.Name = "InstallButton";
            InstallButton.Size = new Size(75, 32);
            InstallButton.TabIndex = 0;
            InstallButton.Text = "Enable";
            InstallButton.UseVisualStyleBackColor = true;
            InstallButton.Click += InstallButton_Click;
            // 
            // UninstallButton
            // 
            UninstallButton.Location = new Point(95, 57);
            UninstallButton.Name = "UninstallButton";
            UninstallButton.Size = new Size(75, 32);
            UninstallButton.TabIndex = 0;
            UninstallButton.Text = "Disable";
            UninstallButton.UseVisualStyleBackColor = true;
            UninstallButton.Click += UninstallButton_Click;
            // 
            // InstallLabel
            // 
            InstallLabel.AutoSize = true;
            InstallLabel.Location = new Point(19, 92);
            InstallLabel.Name = "InstallLabel";
            InstallLabel.Size = new Size(91, 15);
            InstallLabel.TabIndex = 1;
            InstallLabel.Text = "crazy easter egg";
            InstallLabel.Click += InstallLabel_Click;
            // 
            // GitHubLink
            // 
            GitHubLink.AutoSize = true;
            GitHubLink.Location = new Point(15, 34);
            GitHubLink.Name = "GitHubLink";
            GitHubLink.Size = new Size(110, 15);
            GitHubLink.TabIndex = 2;
            GitHubLink.TabStop = true;
            GitHubLink.Text = "by sillycatmoments";
            GitHubLink.LinkClicked += GitHubLink_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 3;
            label1.Text = "remuxx";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 128);
            Controls.Add(label1);
            Controls.Add(GitHubLink);
            Controls.Add(InstallLabel);
            Controls.Add(UninstallButton);
            Controls.Add(InstallButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InstallButton;
        private Button UninstallButton;
        private Label InstallLabel;
        private LinkLabel GitHubLink;
        private Label label1;
    }
}
