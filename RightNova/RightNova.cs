using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging.Effects;
using System.Globalization;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RightNova
{
    public partial class RightNova : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool DestroyIcon(IntPtr hIcon);

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(
            string pszPath,
            uint dwFileAttributes,
            out SHFILEINFO psfi,
            uint cbFileInfo,
            uint uFlags);

        const uint SHGFI_ICON = 0x100;
        const uint SHGFI_LARGEICON = 0x0;
        const uint SHGFI_USEFILEATTRIBUTES = 0x10;

        public RightNova()
        {
            InitializeComponent();

            SHFILEINFO shinfo = new SHFILEINFO();

            SHGetFileInfo(
                ".exe",
                0,
                out shinfo,
                (uint)Marshal.SizeOf<SHFILEINFO>(),
                SHGFI_ICON | SHGFI_LARGEICON | SHGFI_USEFILEATTRIBUTES);

            if (shinfo.hIcon != IntPtr.Zero)
            {
                using (Icon tempIcon = Icon.FromHandle(shinfo.hIcon))
                {
                    Icon = (Icon)tempIcon.Clone();
                }

                DestroyIcon(shinfo.hIcon);
            }
        }

        private void RightNova_Load(object sender, EventArgs e)
        {
            OSLabel.Text = "Operating System: " + OSInfo();
            ComputerLabel.Text = "Computer Name: " + Environment.MachineName;
            DomainLabel.Text = "Domain Name: " + Environment.UserName;
            CPULabel.Text = "CPU: " + CPUInfo();
            CoreLabel.Text = "Cores and Threads: " + CoreThreadsInfo();
            RAMLabel.Text = "RAM: " + RAMInfo();
            DiskLabel.Text = DiskInfo();
            GPULabel.Text = "GPU: " + GPUInfo();
            MotherboardLabel.Text = "Motherboard: " + MotherboardInfo();
            BIOSLabel.Text = "BIOS: " + BIOSInfo();
            HWIDLabel.Text = "HWID: " + HWIDInfo();
        }

        static string OSInfo()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get())
                return obj["Caption"]?.ToString() ?? "Unknown OS";

            return "Unknown OS";
        }

        static string CPUInfo()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name FROM Win32_Processor").Get())
                return obj["Name"]?.ToString() ?? "Unknown CPU";

            return "Unknown CPU";
        }

        static string CoreThreadsInfo()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT NumberOfCores, NumberOfLogicalProcessors FROM Win32_Processor").Get())
                return "Cores: " + obj["NumberOfCores"] + " / Threads: " + obj["NumberOfLogicalProcessors"];

            return "Unknown";
        }

        static string RAMInfo()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem").Get())
            {
                ulong kb = Convert.ToUInt64(obj["TotalVisibleMemorySize"]);

                double gb = kb / (1024.0 * 1024.0);

                return gb.ToString("0.0") + " GB";
            }

            return "Unknown RAM";
        }

        static string FormatSize(long bytes)
        {
            double size = bytes;

            const double KB = 1024.0;
            const double MB = KB * 1024;
            const double GB = MB * 1024;
            const double TB = GB * 1024;

            if (size >= TB)
                return (size / TB).ToString("0.0") + " TB";

            if (size >= GB)
                return (size / GB).ToString("0.0") + " GB";

            if (size >= MB)
                return (size / MB).ToString("0.0") + " MB";

            if (size >= KB)
                return (size / KB).ToString("0.0") + " KB";

            return size + " B";
        }

        static string DiskInfo()
        {
            string info = "";

            DriveInfo drive = new("C");

            if (drive.IsReady)
            {
                long freeBytes = drive.TotalFreeSpace;
                long totalBytes = drive.TotalSize;

                string free = FormatSize(freeBytes);
                string total = FormatSize(totalBytes);

                info = "Disk Space (C:): " + free + " free of " + total;
            }

            return info;
        }

        static string GPUInfo()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Name FROM Win32_VideoController").Get())
                return obj["Name"]?.ToString() ?? "Unknown GPU";

            return "Unknown GPU";
        }

        static string MotherboardInfo()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT Product FROM Win32_BaseBoard").Get())
                return obj["Product"]?.ToString() ?? "Unknown Motherboard";

            return "Unknown Motherboard";
        }

        static string BIOSInfo()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT SMBIOSBIOSVersion FROM Win32_BIOS").Get())
                return obj["SMBIOSBIOSVersion"]?.ToString() ?? "Unknown BIOS";

            return "Unknown BIOS";
        }

        static string GetVolume()
        {
            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT VolumeSerialNumber FROM Win32_LogicalDisk WHERE DeviceID='C:'").Get())
                return obj["VolumeSerialNumber"]?.ToString() ?? "";

            return "";
        }

        static string ComputeSHA(string input)
        {
            using SHA256 sha = SHA256.Create();

            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new();

            foreach (byte b in data)
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        static string HWIDInfo()
        {
            string cpu = CPUInfo();
            string bios = BIOSInfo();
            string mb = MotherboardInfo();
            string vol = GetVolume();

            string raw = cpu + "|" + bios + "|" + mb + "|" + vol;

            return ComputeSHA(raw);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo LocalCulture = CultureInfo.CurrentCulture;

            string osLinguage = LocalCulture.TwoLetterISOLanguageName;

            if (osLinguage == "it")
            {
                MessageBox.Show("Copyright © 2026 MasterSharp Team LLC. Tutti i diritti riservati.\n\n" +
                "RightNova 1.5.0 by Itelcan3 (aka.MasterSharp3210)\n" +
                "https://twitter.com/MasterSharp3210\n" +
                "https://github.com/MasterSharp3210\n\n" +
                "RightNova è un programma che consente all'utente di lavorare con le WinAPI per ottenere riferimenti all'hardware e utilizzare tutte le risorse a disposizione di Windows...\n\n" +
                "WINAPI\n" +
                "Win32 API\n" +
                "Marshal (Windows Marshalling)\n" +
                "SHINFO\n" +
                "Kernel32\n" +
                "Shell32\n\n" +
                "https://github.com/MasterSharp3210/RightNova", "RightNova 1.5.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Copyright © 2026 MasterSharp Team LLC. All rights reserved.\n\n" +
                "RightNova 1.5.0 by Itelcan3 (aka.MasterSharp3210)\n" +
                "https://twitter.com/MasterSharp3210\n" +
                "https://github.com/MasterSharp3210\n\n" +
                "RightNova is a program that allows the user to work with the WinAPI to get references to the hardware and use all the resources available in Windows...\n\n" +
                "WINAPI\n" +
                "Win32 API\n" +
                "Marshal (Windows Marshalling)\n" +
                "SHINFO\n" +
                "Kernel32\n" +
                "Shell32\n\n" +
                "https://github.com/MasterSharp3210/RightNova", "RightNova 1.5.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rightNovaWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/MasterSharp3210/RightNova",
                UseShellExecute = true
            });
        }

        private void rightNovaLegacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RightNova Legacy is a version of RightNova written in C++. It is recommended to use this version if you are using an older operating system or if you have compatibility issues with the latest version.", "RightNova Legacy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OSLabel.Text = "Operating System: " + OSInfo();
            ComputerLabel.Text = "Computer Name: " + Environment.MachineName;
            DomainLabel.Text = "Domain Name: " + Environment.UserName;
            CPULabel.Text = "CPU: " + CPUInfo();
            CoreLabel.Text = "Cores and Threads: " + CoreThreadsInfo();
            RAMLabel.Text = "RAM: " + RAMInfo();
            DiskLabel.Text = DiskInfo();
            GPULabel.Text = "GPU: " + GPUInfo();
            MotherboardLabel.Text = "Motherboard: " + MotherboardInfo();
            BIOSLabel.Text = "BIOS: " + BIOSInfo();
            HWIDLabel.Text = "HWID: " + HWIDInfo();

            MessageBox.Show("System information refreshed!", "RightNova", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = OSLabel.Text + "\n" +
                          ComputerLabel.Text + "\n" +
                          DomainLabel.Text + "\n" +
                          LineLabel1.Text + "\n" +
                          CPULabel.Text + "\n" +
                          CoreLabel.Text + "\n" +
                          RAMLabel.Text + "\n" +
                          DiskLabel.Text + "\n" +
                          LineLabel2.Text + "\n" +
                          GPULabel.Text + "\n" +
                          MotherboardLabel.Text + "\n" +
                          BIOSLabel.Text + "\n" +
                          LineLabel3.Text + "\n" +
                          HWIDLabel.Text;

            Clipboard.SetText(text);

            MessageBox.Show("System information copied to clipboard!", "RightNova", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string allInfo =
                OSLabel.Text + "\r\n" +
                ComputerLabel.Text + "\r\n" +
                DomainLabel.Text + "\r\n" +
                LineLabel1.Text + "\r\n" +
                CPULabel.Text + "\r\n" +
                CoreLabel.Text + "\r\n" +
                RAMLabel.Text + "\r\n" +
                DiskLabel.Text + "\r\n" +
                LineLabel2.Text + "\r\n" +
                GPULabel.Text + "\r\n" +
                MotherboardLabel.Text + "\r\n" +
                BIOSLabel.Text + "\r\n" +
                LineLabel3.Text + "\r\n" +
                HWIDLabel.Text;

            SaveFileDialog sfd = new()
            {
                Filter = "Text File (*.txt)|*.txt",
                Title = "Save System Info",
                FileName = "sys_info.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, allInfo);
            }
        }

        private void extendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtendAPI extendapi = new ExtendAPI();
            extendapi.ShowDialog();
        }

        private void openPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                UseShellExecute = true
            });
        }

        private void openAdminCmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Verb = "runas",
                UseShellExecute = true
            });
        }

        private void openPowerShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "powershell.exe",
                UseShellExecute = true
            });
        }
    }
}
