using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
            check();
        }

        private void ebtn(Control btn)
        {
            btn.Enabled = true;
            btn.ForeColor = Color.White;
        }

        private void dbtn(Control btn)
        {
            btn.Enabled = false;
            btn.ForeColor = Color.Gray;
        }

        private void enable_Click(object sender, EventArgs e)
        {
            var p2 = new Process();
            p2.StartInfo.FileName = "reagentc";
            p2.StartInfo.Arguments = "/enable";
            p2.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p2.Start();
            p2.WaitForExit();
            deb.Text = "1";
            check();
        }

        private void disable_Click(object sender, EventArgs e)
        {
            var p2 = new Process();
            p2.StartInfo.FileName = "reagentc";
            p2.StartInfo.Arguments = "/disable";
            p2.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p2.Start();
            p2.WaitForExit();
            deb.Text = "0";
            check();
        }

        private void repair_Click(object sender, EventArgs e)
        {
            using(var web = new WebClient())
            {
                web.DownloadFile("https://dl.dropbox.com/s/lahofrvpejlclkx/Winre.wim", "C:\\Windows\\System32\\Recovery\\WinRE.wim");
            }

            var p = new Process();
            p.StartInfo.FileName = "reagentc";
            p.StartInfo.Arguments = "/setreimage /path C:\\Windows\\System32\\Recovery";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p.Start();
            p.WaitForExit();

            var p2 = new Process();
            p2.StartInfo.FileName = "reagentc";
            p2.StartInfo.Arguments = "/enable";
            p2.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p2.Start();
            p2.WaitForExit();
            deb.Text="0";

            check();
        }
        private void check()
        {
            var p = new Process();
            p.StartInfo.FileName = "reagentc";
            p.StartInfo.Arguments = "/info";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            p.WaitForExit();
            string out1 = p.StandardOutput.ReadToEnd();
            if (out1.Contains("Enable"))
            {
                dbtn(enable);
                dbtn(repair);
                ebtn(disable);
            }
            else
            {
                if (deb.Text == "1")
                {
                    dbtn(enable);
                    ebtn(repair);
                    dbtn(disable);
                }
                else
                {
                    ebtn(enable);
                    dbtn(repair);
                    dbtn(disable);
                }
            }
        }
    }
}
