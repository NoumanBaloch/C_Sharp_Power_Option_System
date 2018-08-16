using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Shutdown_System
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();
        public Form1()
        {
            InitializeComponent();
        }

        private void shutdown(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Shutdown", "/s /t 0");
        }

        private void restart(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Shutdown", "/r /t 0");
        }

        private void locks(object sender, EventArgs e)
        {
            LockWorkStation();
        }
    }
}
