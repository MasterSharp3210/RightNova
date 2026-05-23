namespace RightNova
{
    partial class RightNova
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripRightNova = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightNovaWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightNovaLegacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAdminCmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPowerShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ComputerLabel = new System.Windows.Forms.Label();
            this.DomainLabel = new System.Windows.Forms.Label();
            this.LineLabel1 = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.CoreLabel = new System.Windows.Forms.Label();
            this.RAMLabel = new System.Windows.Forms.Label();
            this.DiskLabel = new System.Windows.Forms.Label();
            this.LineLabel2 = new System.Windows.Forms.Label();
            this.GPULabel = new System.Windows.Forms.Label();
            this.MotherboardLabel = new System.Windows.Forms.Label();
            this.BIOSLabel = new System.Windows.Forms.Label();
            this.LineLabel3 = new System.Windows.Forms.Label();
            this.HWIDLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripRightNova,
            this.informationsToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(499, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripRightNova
            // 
            this.menuToolStripRightNova.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.rightNovaWebsiteToolStripMenuItem,
            this.rightNovaLegacyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripRightNova.Name = "menuToolStripRightNova";
            this.menuToolStripRightNova.Size = new System.Drawing.Size(75, 20);
            this.menuToolStripRightNova.Text = "RightNova";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rightNovaWebsiteToolStripMenuItem
            // 
            this.rightNovaWebsiteToolStripMenuItem.Name = "rightNovaWebsiteToolStripMenuItem";
            this.rightNovaWebsiteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rightNovaWebsiteToolStripMenuItem.Text = "RightNova GitHub";
            this.rightNovaWebsiteToolStripMenuItem.Click += new System.EventHandler(this.rightNovaWebsiteToolStripMenuItem_Click);
            // 
            // rightNovaLegacyToolStripMenuItem
            // 
            this.rightNovaLegacyToolStripMenuItem.Name = "rightNovaLegacyToolStripMenuItem";
            this.rightNovaLegacyToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.rightNovaLegacyToolStripMenuItem.Text = "RightNova Legacy";
            this.rightNovaLegacyToolStripMenuItem.Click += new System.EventHandler(this.rightNovaLegacyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.informationsToolStripMenuItem.Text = "Informations";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPromptToolStripMenuItem,
            this.openAdminCmdToolStripMenuItem,
            this.openPowerShellToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // openPromptToolStripMenuItem
            // 
            this.openPromptToolStripMenuItem.Name = "openPromptToolStripMenuItem";
            this.openPromptToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openPromptToolStripMenuItem.Text = "Open Prompt";
            this.openPromptToolStripMenuItem.Click += new System.EventHandler(this.openPromptToolStripMenuItem_Click);
            // 
            // openAdminCmdToolStripMenuItem
            // 
            this.openAdminCmdToolStripMenuItem.Name = "openAdminCmdToolStripMenuItem";
            this.openAdminCmdToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openAdminCmdToolStripMenuItem.Text = "Open Prompt (Admin)";
            this.openAdminCmdToolStripMenuItem.Click += new System.EventHandler(this.openAdminCmdToolStripMenuItem_Click);
            // 
            // openPowerShellToolStripMenuItem
            // 
            this.openPowerShellToolStripMenuItem.Name = "openPowerShellToolStripMenuItem";
            this.openPowerShellToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openPowerShellToolStripMenuItem.Text = "Open PowerShell";
            this.openPowerShellToolStripMenuItem.Click += new System.EventHandler(this.openPowerShellToolStripMenuItem_Click);
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(12, 24);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(51, 16);
            this.OSLabel.TabIndex = 1;
            this.OSLabel.Text = "OS: OS";
            // 
            // ComputerLabel
            // 
            this.ComputerLabel.AutoSize = true;
            this.ComputerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerLabel.Location = new System.Drawing.Point(12, 40);
            this.ComputerLabel.Name = "ComputerLabel";
            this.ComputerLabel.Size = new System.Drawing.Size(169, 16);
            this.ComputerLabel.TabIndex = 2;
            this.ComputerLabel.Text = "Computer Name: Computer";
            // 
            // DomainLabel
            // 
            this.DomainLabel.AutoSize = true;
            this.DomainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainLabel.Location = new System.Drawing.Point(12, 56);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.Size = new System.Drawing.Size(107, 16);
            this.DomainLabel.TabIndex = 3;
            this.DomainLabel.Text = "Domain: Domain";
            // 
            // LineLabel1
            // 
            this.LineLabel1.AutoSize = true;
            this.LineLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineLabel1.Location = new System.Drawing.Point(12, 72);
            this.LineLabel1.Name = "LineLabel1";
            this.LineLabel1.Size = new System.Drawing.Size(475, 16);
            this.LineLabel1.TabIndex = 4;
            this.LineLabel1.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------\r\n";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPULabel.Location = new System.Drawing.Point(12, 88);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(142, 16);
            this.CPULabel.TabIndex = 5;
            this.CPULabel.Text = "Processor (CPU): CPU";
            // 
            // CoreLabel
            // 
            this.CoreLabel.AutoSize = true;
            this.CoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreLabel.Location = new System.Drawing.Point(12, 104);
            this.CoreLabel.Name = "CoreLabel";
            this.CoreLabel.Size = new System.Drawing.Size(193, 16);
            this.CoreLabel.TabIndex = 6;
            this.CoreLabel.Text = "Core / Threads: Core / Threads";
            // 
            // RAMLabel
            // 
            this.RAMLabel.AutoSize = true;
            this.RAMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMLabel.Location = new System.Drawing.Point(12, 120);
            this.RAMLabel.Name = "RAMLabel";
            this.RAMLabel.Size = new System.Drawing.Size(126, 16);
            this.RAMLabel.TabIndex = 7;
            this.RAMLabel.Text = "Installed RAM: RAM";
            // 
            // DiskLabel
            // 
            this.DiskLabel.AutoSize = true;
            this.DiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiskLabel.Location = new System.Drawing.Point(12, 136);
            this.DiskLabel.Name = "DiskLabel";
            this.DiskLabel.Size = new System.Drawing.Size(133, 16);
            this.DiskLabel.TabIndex = 8;
            this.DiskLabel.Text = "Disk Space (C:): Disk";
            // 
            // LineLabel2
            // 
            this.LineLabel2.AutoSize = true;
            this.LineLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineLabel2.Location = new System.Drawing.Point(12, 152);
            this.LineLabel2.Name = "LineLabel2";
            this.LineLabel2.Size = new System.Drawing.Size(475, 16);
            this.LineLabel2.TabIndex = 9;
            this.LineLabel2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------\r\n";
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPULabel.Location = new System.Drawing.Point(12, 168);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(168, 16);
            this.GPULabel.TabIndex = 11;
            this.GPULabel.Text = "Graphics Card (GPU): GPU";
            // 
            // MotherboardLabel
            // 
            this.MotherboardLabel.AutoSize = true;
            this.MotherboardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherboardLabel.Location = new System.Drawing.Point(12, 184);
            this.MotherboardLabel.Name = "MotherboardLabel";
            this.MotherboardLabel.Size = new System.Drawing.Size(167, 16);
            this.MotherboardLabel.TabIndex = 12;
            this.MotherboardLabel.Text = "Motherboard: Motherboard";
            // 
            // BIOSLabel
            // 
            this.BIOSLabel.AutoSize = true;
            this.BIOSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIOSLabel.Location = new System.Drawing.Point(12, 200);
            this.BIOSLabel.Name = "BIOSLabel";
            this.BIOSLabel.Size = new System.Drawing.Size(75, 16);
            this.BIOSLabel.TabIndex = 13;
            this.BIOSLabel.Text = "BIOS: BIOS";
            // 
            // LineLabel3
            // 
            this.LineLabel3.AutoSize = true;
            this.LineLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineLabel3.Location = new System.Drawing.Point(12, 216);
            this.LineLabel3.Name = "LineLabel3";
            this.LineLabel3.Size = new System.Drawing.Size(475, 16);
            this.LineLabel3.TabIndex = 14;
            this.LineLabel3.Text = "---------------------------------------------------------------------------------" +
    "------------------------------------\r\n";
            // 
            // HWIDLabel
            // 
            this.HWIDLabel.AutoSize = true;
            this.HWIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HWIDLabel.Location = new System.Drawing.Point(12, 232);
            this.HWIDLabel.Name = "HWIDLabel";
            this.HWIDLabel.Size = new System.Drawing.Size(85, 16);
            this.HWIDLabel.TabIndex = 15;
            this.HWIDLabel.Text = "HWID: HWID";
            // 
            // RightNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 251);
            this.Controls.Add(this.HWIDLabel);
            this.Controls.Add(this.LineLabel3);
            this.Controls.Add(this.BIOSLabel);
            this.Controls.Add(this.MotherboardLabel);
            this.Controls.Add(this.GPULabel);
            this.Controls.Add(this.LineLabel2);
            this.Controls.Add(this.DiskLabel);
            this.Controls.Add(this.RAMLabel);
            this.Controls.Add(this.CoreLabel);
            this.Controls.Add(this.CPULabel);
            this.Controls.Add(this.LineLabel1);
            this.Controls.Add(this.DomainLabel);
            this.Controls.Add(this.ComputerLabel);
            this.Controls.Add(this.OSLabel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "RightNova";
            this.Text = "RightNova";
            this.Load += new System.EventHandler(this.RightNova_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripRightNova;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightNovaWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightNovaLegacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPromptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAdminCmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPowerShellToolStripMenuItem;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ComputerLabel;
        private System.Windows.Forms.Label DomainLabel;
        private System.Windows.Forms.Label LineLabel1;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label CoreLabel;
        private System.Windows.Forms.Label RAMLabel;
        private System.Windows.Forms.Label DiskLabel;
        private System.Windows.Forms.Label LineLabel2;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.Label MotherboardLabel;
        private System.Windows.Forms.Label BIOSLabel;
        private System.Windows.Forms.Label LineLabel3;
        private System.Windows.Forms.Label HWIDLabel;
    }
}

