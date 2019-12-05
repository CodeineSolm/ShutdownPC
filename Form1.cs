using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (ShutdownCombobox.SelectedIndex == 0)
            {
                Process.Start("cmd", "/c shutdown -s -t 60");
            } else if (ShutdownCombobox.SelectedIndex == 1)
            {
                Process.Start("cmd", "/c shutdown -s -t 1800");
            } else if (ShutdownCombobox.SelectedIndex == 2)
            {
                Process.Start("cmd", "/c shutdown -s -t 3600");
            }
            else if (ShutdownCombobox.SelectedIndex == 3)
            {
                Process.Start("cmd", "/c shutdown -s -t 7200");
            }
            else if (ShutdownCombobox.SelectedIndex == 4)
            {
                Process.Start("cmd", "/c shutdown -s -t 10800");
            }
            else if (ShutdownCombobox.SelectedIndex == 5)
            {
                Process.Start("cmd", "/c shutdown -s -t 14400");
            }
            else if (ShutdownCombobox.SelectedIndex == 6)
            {
                Process.Start("cmd", "/c shutdown -s -t 18000");
            }
        }

        private void StopShutdownButton_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c shutdown -a");
        }     
    }
}
