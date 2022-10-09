using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRE_Settings_GUI
{
    public partial class Main : Form
    {
        //Set dark mode title bar and bypass wow64

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 35, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 38, new[] { 1 }, 4);
            IntPtr wow64Value = IntPtr.Zero;
            Wow64DisableWow64FsRedirection(ref wow64Value);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Wow64RevertWow64FsRedirection(IntPtr ptr);

        public Main()
        {
            InitializeComponent();
        }

        private void enable_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("reagentc.exe", "/enable");
        }

        private void disable_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("reagentc.exe", "/disable");
        }

        private void repair_Click(object sender, EventArgs e)
        {
            using(var web = new WebClient())
            {
                web.DownloadFile("https://dl.dropbox.com/s/lahofrvpejlclkx/Winre.wim", "C:\\Windows\\System32\\Recovery\\WinRE.wim");
            }

            var p = new Process();
            p.StartInfo.FileName = "regentc";
            p.StartInfo.Arguments = "/setreimage /path C:\\Windows\\System32\\Recovery";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p.WaitForExit();

            System.Diagnostics.Process.Start("reagentc.exe", "/enable");
        }
    }
}
