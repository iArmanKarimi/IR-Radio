using System;
using System.Windows.Forms;

namespace IRRadioDesktopWin
{
	public partial class AboutMe : Form
	{
		public AboutMe()
		{
			InitializeComponent();
		}

		const string GITHUB_PROFILE_LINK = "https://github.com/iArmanKarimi";
		const string GITHUB_REPO_LINK = "https://github.com/iArmanKarimi/IRRadioWindows";

		private void buttonGithub_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(GITHUB_REPO_LINK);
		}

		private void labelProfileName_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(GITHUB_PROFILE_LINK);
		}

		private void AboutMe_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
