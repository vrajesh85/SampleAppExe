using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SamplExeApp
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            byte[] exeBytes = Properties.Resources.VSCodeSetup_x64_1_40_0;
            string exeToRun = Path.Combine(Path.GetTempPath(), "VSCodeSetup_x64_1_40_0.exe");

            using (FileStream exeFile = new FileStream(exeToRun, FileMode.Open))
                exeFile.Write(exeBytes, 0, exeBytes.Length);

            string parameter = textBox1.Text;

            Process.Start(exeToRun,parameter);

        }
    }
}
