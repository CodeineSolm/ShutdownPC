using System;
using MetroFramework.Forms;
using System.Diagnostics;

namespace ShutdownPC
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            switch (ShutdownCombobox.SelectedIndex)
            {
                case 0:
                    Process.Start("cmd", "/c shutdown -s -t 60");
                    break;
                case 1:
                    Process.Start("cmd", "/c shutdown -s -t 1800");
                    break;
                case 2:
                    Process.Start("cmd", "/c shutdown -s -t 3600");
                    break;
                case 3:
                    Process.Start("cmd", "/c shutdown -s -t 7200");
                    break;
                case 4:
                    Process.Start("cmd", "/c shutdown -s -t 10800");
                    break;
                case 5:
                    Process.Start("cmd", "/c shutdown -s -t 14400");
                    break;
                case 6:
                    Process.Start("cmd", "/c shutdown -s -t 18000");
                    break;                
                case 7:
                    Process.Start("cmd", "/c shutdown -s -t 21600");
                    break;
                case 8:
                    Process.Start("cmd", "/c shutdown -s -t 25200");
                    break;
                case 9:
                    Process.Start("cmd", "/c shutdown -s -t 28800");
                    break;
                case 10:
                    Process.Start("cmd", "/c shutdown -s -t 32400");
                    break;
                case 11:
                    Process.Start("cmd", "/c shutdown -s -t 36000");
                    break;
            }
        }

        private void StopShutdownButton_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c shutdown -a");
        }       
    }
}
