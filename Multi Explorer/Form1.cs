using Microsoft.WindowsAPICodePack.Controls;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            explorerBrowser1.NavigationOptions.PaneVisibility.Commands = PaneVisibilityState.Hide;
            explorerBrowser2.NavigationOptions.PaneVisibility.Commands = PaneVisibilityState.Hide;
            explorerBrowser3.NavigationOptions.PaneVisibility.Commands = PaneVisibilityState.Hide;
            explorerBrowser4.NavigationOptions.PaneVisibility.Commands = PaneVisibilityState.Hide;

            explorerBrowser1.Navigate((ShellObject)KnownFolders.Documents);
            explorerBrowser2.Navigate((ShellObject)KnownFolders.Documents);
            explorerBrowser3.Navigate((ShellObject)KnownFolders.Documents);
            explorerBrowser4.Navigate((ShellObject)KnownFolders.Documents);
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;
            panel1.Visible = false;
        }

        private void splitContainer1_DoubleClick(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
            panel1.Visible = true;
        }

        private void splitContainer2_DoubleClick(object sender, EventArgs e)
        {
            splitContainer2.SplitterDistance = (splitContainer2.Width - 4) / 2;
        }

        private void splitContainer3_DoubleClick(object sender, EventArgs e)
        {
            splitContainer3.SplitterDistance = (splitContainer3.Width - 4) / 2;
        }
    }
}
