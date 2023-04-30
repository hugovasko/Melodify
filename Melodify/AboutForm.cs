using System.Diagnostics;
using System.Windows.Forms;

namespace Melodify
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void LinkLabelAppCreatorName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/hugovasko") { UseShellExecute = true });
        }
    }
}
