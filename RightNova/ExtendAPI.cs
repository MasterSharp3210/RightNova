using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RightNova
{
    public partial class ExtendAPI : Form
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

        public ExtendAPI()
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

        private void ExtendAPI_Load(object sender, EventArgs e)
        {

        }

        private void DecimalTrackbar_Scroll(object sender, EventArgs e)
        {
            double value = DecimalTrackbar.Value / 10.0;

            DecimalValue.Text = value.ToString("0.0");
        }

        private void HexadecimalTrackbar_Scroll(object sender, EventArgs e)
        {
            double value = HexadecimalTrackbar.Value / 10.0;

            HexadecimalValue.Text = value.ToString("0.0");
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
