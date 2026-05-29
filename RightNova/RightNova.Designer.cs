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
            menuStrip = new MenuStrip();
            menuToolStripRightNova = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            rightNovaWebsiteToolStripMenuItem = new ToolStripMenuItem();
            rightNovaLegacyToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            informationsToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            copyToClipboardToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            winAPIToolStripMenuItem = new ToolStripMenuItem();
            extendToolStripMenuItem = new ToolStripMenuItem();
            otherToolStripMenuItem = new ToolStripMenuItem();
            openPromptToolStripMenuItem = new ToolStripMenuItem();
            openAdminCmdToolStripMenuItem = new ToolStripMenuItem();
            openPowerShellToolStripMenuItem = new ToolStripMenuItem();
            OSLabel = new Label();
            ComputerLabel = new Label();
            DomainLabel = new Label();
            LineLabel1 = new Label();
            CPULabel = new Label();
            CoreLabel = new Label();
            RAMLabel = new Label();
            DiskLabel = new Label();
            LineLabel2 = new Label();
            GPULabel = new Label();
            MotherboardLabel = new Label();
            BIOSLabel = new Label();
            LineLabel3 = new Label();
            HWIDLabel = new Label();
            useWin32APIToolStripMenuItem = new ToolStripMenuItem();
            useWindowsAssemblyToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripRightNova, informationsToolStripMenuItem, winAPIToolStripMenuItem, otherToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(582, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripRightNova
            // 
            menuToolStripRightNova.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, rightNovaWebsiteToolStripMenuItem, rightNovaLegacyToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripRightNova.Name = "menuToolStripRightNova";
            menuToolStripRightNova.Size = new Size(75, 20);
            menuToolStripRightNova.Text = "RightNova";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // rightNovaWebsiteToolStripMenuItem
            // 
            rightNovaWebsiteToolStripMenuItem.Name = "rightNovaWebsiteToolStripMenuItem";
            rightNovaWebsiteToolStripMenuItem.Size = new Size(180, 22);
            rightNovaWebsiteToolStripMenuItem.Text = "RightNova GitHub";
            rightNovaWebsiteToolStripMenuItem.Click += rightNovaWebsiteToolStripMenuItem_Click;
            // 
            // rightNovaLegacyToolStripMenuItem
            // 
            rightNovaLegacyToolStripMenuItem.Name = "rightNovaLegacyToolStripMenuItem";
            rightNovaLegacyToolStripMenuItem.Size = new Size(180, 22);
            rightNovaLegacyToolStripMenuItem.Text = "RightNova Legacy";
            rightNovaLegacyToolStripMenuItem.Click += rightNovaLegacyToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // informationsToolStripMenuItem
            // 
            informationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, copyToClipboardToolStripMenuItem, exportToolStripMenuItem });
            informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            informationsToolStripMenuItem.Size = new Size(87, 20);
            informationsToolStripMenuItem.Text = "Informations";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(180, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // copyToClipboardToolStripMenuItem
            // 
            copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            copyToClipboardToolStripMenuItem.Size = new Size(180, 22);
            copyToClipboardToolStripMenuItem.Text = "Copy To Clipboard";
            copyToClipboardToolStripMenuItem.Click += copyToClipboardToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // winAPIToolStripMenuItem
            // 
            winAPIToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { extendToolStripMenuItem, useWin32APIToolStripMenuItem, useWindowsAssemblyToolStripMenuItem });
            winAPIToolStripMenuItem.Name = "winAPIToolStripMenuItem";
            winAPIToolStripMenuItem.Size = new Size(58, 20);
            winAPIToolStripMenuItem.Text = "WinAPI";
            // 
            // extendToolStripMenuItem
            // 
            extendToolStripMenuItem.Name = "extendToolStripMenuItem";
            extendToolStripMenuItem.Size = new Size(199, 22);
            extendToolStripMenuItem.Text = "Extend WinAPI Bridge";
            extendToolStripMenuItem.Click += extendToolStripMenuItem_Click;
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openPromptToolStripMenuItem, openAdminCmdToolStripMenuItem, openPowerShellToolStripMenuItem });
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(49, 20);
            otherToolStripMenuItem.Text = "Other";
            // 
            // openPromptToolStripMenuItem
            // 
            openPromptToolStripMenuItem.Name = "openPromptToolStripMenuItem";
            openPromptToolStripMenuItem.Size = new Size(193, 22);
            openPromptToolStripMenuItem.Text = "Open Prompt";
            openPromptToolStripMenuItem.Click += openPromptToolStripMenuItem_Click;
            // 
            // openAdminCmdToolStripMenuItem
            // 
            openAdminCmdToolStripMenuItem.Name = "openAdminCmdToolStripMenuItem";
            openAdminCmdToolStripMenuItem.Size = new Size(193, 22);
            openAdminCmdToolStripMenuItem.Text = "Open Prompt (Admin)";
            openAdminCmdToolStripMenuItem.Click += openAdminCmdToolStripMenuItem_Click;
            // 
            // openPowerShellToolStripMenuItem
            // 
            openPowerShellToolStripMenuItem.Name = "openPowerShellToolStripMenuItem";
            openPowerShellToolStripMenuItem.Size = new Size(193, 22);
            openPowerShellToolStripMenuItem.Text = "Open PowerShell";
            openPowerShellToolStripMenuItem.Click += openPowerShellToolStripMenuItem_Click;
            // 
            // OSLabel
            // 
            OSLabel.AutoSize = true;
            OSLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OSLabel.Location = new Point(14, 28);
            OSLabel.Margin = new Padding(4, 0, 4, 0);
            OSLabel.Name = "OSLabel";
            OSLabel.Size = new Size(51, 16);
            OSLabel.TabIndex = 1;
            OSLabel.Text = "OS: OS";
            // 
            // ComputerLabel
            // 
            ComputerLabel.AutoSize = true;
            ComputerLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComputerLabel.Location = new Point(14, 46);
            ComputerLabel.Margin = new Padding(4, 0, 4, 0);
            ComputerLabel.Name = "ComputerLabel";
            ComputerLabel.Size = new Size(169, 16);
            ComputerLabel.TabIndex = 2;
            ComputerLabel.Text = "Computer Name: Computer";
            // 
            // DomainLabel
            // 
            DomainLabel.AutoSize = true;
            DomainLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DomainLabel.Location = new Point(14, 65);
            DomainLabel.Margin = new Padding(4, 0, 4, 0);
            DomainLabel.Name = "DomainLabel";
            DomainLabel.Size = new Size(107, 16);
            DomainLabel.TabIndex = 3;
            DomainLabel.Text = "Domain: Domain";
            // 
            // LineLabel1
            // 
            LineLabel1.AutoSize = true;
            LineLabel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LineLabel1.Location = new Point(14, 83);
            LineLabel1.Margin = new Padding(4, 0, 4, 0);
            LineLabel1.Name = "LineLabel1";
            LineLabel1.Size = new Size(475, 16);
            LineLabel1.TabIndex = 4;
            LineLabel1.Text = "---------------------------------------------------------------------------------------------------------------------\r\n";
            // 
            // CPULabel
            // 
            CPULabel.AutoSize = true;
            CPULabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPULabel.Location = new Point(14, 102);
            CPULabel.Margin = new Padding(4, 0, 4, 0);
            CPULabel.Name = "CPULabel";
            CPULabel.Size = new Size(142, 16);
            CPULabel.TabIndex = 5;
            CPULabel.Text = "Processor (CPU): CPU";
            // 
            // CoreLabel
            // 
            CoreLabel.AutoSize = true;
            CoreLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CoreLabel.Location = new Point(14, 120);
            CoreLabel.Margin = new Padding(4, 0, 4, 0);
            CoreLabel.Name = "CoreLabel";
            CoreLabel.Size = new Size(193, 16);
            CoreLabel.TabIndex = 6;
            CoreLabel.Text = "Core / Threads: Core / Threads";
            // 
            // RAMLabel
            // 
            RAMLabel.AutoSize = true;
            RAMLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RAMLabel.Location = new Point(14, 138);
            RAMLabel.Margin = new Padding(4, 0, 4, 0);
            RAMLabel.Name = "RAMLabel";
            RAMLabel.Size = new Size(126, 16);
            RAMLabel.TabIndex = 7;
            RAMLabel.Text = "Installed RAM: RAM";
            // 
            // DiskLabel
            // 
            DiskLabel.AutoSize = true;
            DiskLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiskLabel.Location = new Point(14, 157);
            DiskLabel.Margin = new Padding(4, 0, 4, 0);
            DiskLabel.Name = "DiskLabel";
            DiskLabel.Size = new Size(133, 16);
            DiskLabel.TabIndex = 8;
            DiskLabel.Text = "Disk Space (C:): Disk";
            // 
            // LineLabel2
            // 
            LineLabel2.AutoSize = true;
            LineLabel2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LineLabel2.Location = new Point(14, 175);
            LineLabel2.Margin = new Padding(4, 0, 4, 0);
            LineLabel2.Name = "LineLabel2";
            LineLabel2.Size = new Size(475, 16);
            LineLabel2.TabIndex = 9;
            LineLabel2.Text = "---------------------------------------------------------------------------------------------------------------------\r\n";
            // 
            // GPULabel
            // 
            GPULabel.AutoSize = true;
            GPULabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GPULabel.Location = new Point(14, 194);
            GPULabel.Margin = new Padding(4, 0, 4, 0);
            GPULabel.Name = "GPULabel";
            GPULabel.Size = new Size(168, 16);
            GPULabel.TabIndex = 11;
            GPULabel.Text = "Graphics Card (GPU): GPU";
            // 
            // MotherboardLabel
            // 
            MotherboardLabel.AutoSize = true;
            MotherboardLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MotherboardLabel.Location = new Point(14, 212);
            MotherboardLabel.Margin = new Padding(4, 0, 4, 0);
            MotherboardLabel.Name = "MotherboardLabel";
            MotherboardLabel.Size = new Size(167, 16);
            MotherboardLabel.TabIndex = 12;
            MotherboardLabel.Text = "Motherboard: Motherboard";
            // 
            // BIOSLabel
            // 
            BIOSLabel.AutoSize = true;
            BIOSLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BIOSLabel.Location = new Point(14, 231);
            BIOSLabel.Margin = new Padding(4, 0, 4, 0);
            BIOSLabel.Name = "BIOSLabel";
            BIOSLabel.Size = new Size(75, 16);
            BIOSLabel.TabIndex = 13;
            BIOSLabel.Text = "BIOS: BIOS";
            // 
            // LineLabel3
            // 
            LineLabel3.AutoSize = true;
            LineLabel3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LineLabel3.Location = new Point(14, 249);
            LineLabel3.Margin = new Padding(4, 0, 4, 0);
            LineLabel3.Name = "LineLabel3";
            LineLabel3.Size = new Size(475, 16);
            LineLabel3.TabIndex = 14;
            LineLabel3.Text = "---------------------------------------------------------------------------------------------------------------------\r\n";
            // 
            // HWIDLabel
            // 
            HWIDLabel.AutoSize = true;
            HWIDLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HWIDLabel.Location = new Point(14, 268);
            HWIDLabel.Margin = new Padding(4, 0, 4, 0);
            HWIDLabel.Name = "HWIDLabel";
            HWIDLabel.Size = new Size(85, 16);
            HWIDLabel.TabIndex = 15;
            HWIDLabel.Text = "HWID: HWID";
            // 
            // useWin32APIToolStripMenuItem
            // 
            useWin32APIToolStripMenuItem.Checked = true;
            useWin32APIToolStripMenuItem.CheckState = CheckState.Checked;
            useWin32APIToolStripMenuItem.Name = "useWin32APIToolStripMenuItem";
            useWin32APIToolStripMenuItem.Size = new Size(199, 22);
            useWin32APIToolStripMenuItem.Text = "Use Win32 API";
            useWin32APIToolStripMenuItem.Click += useWin32APIToolStripMenuItem_Click;
            // 
            // useWindowsAssemblyToolStripMenuItem
            // 
            useWindowsAssemblyToolStripMenuItem.Checked = true;
            useWindowsAssemblyToolStripMenuItem.CheckState = CheckState.Checked;
            useWindowsAssemblyToolStripMenuItem.Name = "useWindowsAssemblyToolStripMenuItem";
            useWindowsAssemblyToolStripMenuItem.Size = new Size(199, 22);
            useWindowsAssemblyToolStripMenuItem.Text = "Use Windows Assembly";
            // 
            // RightNova
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 290);
            Controls.Add(HWIDLabel);
            Controls.Add(LineLabel3);
            Controls.Add(BIOSLabel);
            Controls.Add(MotherboardLabel);
            Controls.Add(GPULabel);
            Controls.Add(LineLabel2);
            Controls.Add(DiskLabel);
            Controls.Add(RAMLabel);
            Controls.Add(CoreLabel);
            Controls.Add(CPULabel);
            Controls.Add(LineLabel1);
            Controls.Add(DomainLabel);
            Controls.Add(ComputerLabel);
            Controls.Add(OSLabel);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "RightNova";
            Text = "RightNova";
            Load += RightNova_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
        private ToolStripMenuItem winAPIToolStripMenuItem;
        private ToolStripMenuItem extendToolStripMenuItem;
        private ToolStripMenuItem useWin32APIToolStripMenuItem;
        private ToolStripMenuItem useWindowsAssemblyToolStripMenuItem;
    }
}

