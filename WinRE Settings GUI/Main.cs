using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        //Set dark mode title bar

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 35, new[] { 1 }, 4);
            DwmSetWindowAttribute(Handle, 38, new[] { 1 }, 4);
        }

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
        }
    }
}
