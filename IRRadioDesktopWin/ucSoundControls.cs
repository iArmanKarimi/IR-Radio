using IRRadioDesktopWin.Properties;
using IRRadioLib;
using System;
using System.Windows.Forms;

namespace IRRadioDesktopWin
{
	public partial class ucSoundControls : UserControl
	{
		private IIRRadioPlayer radio;
		public ucSoundControls()
		{
			InitializeComponent();
		}
		public void Init(in IIRRadioPlayer player) => radio = player;
		private void btnMute_Click(object sender, EventArgs e)
		{
			if (radio == null) return;
			btnMute.Image = radio.Mute
				? Resources.icons8_audio_24px
				: Resources.icons8_no_audio_24px;
			radio.Mute = !radio.Mute;
		}
		private void trackBarVolume_ValueChanged(object sender, EventArgs e)
		{
			if (radio == null) return;
			var value = (sender as TrackBar).Value;
			radio.Volume = value;
			if (value > 0) radio.Mute = false;
			btnMute.Image = value == 0
				? Resources.icons8_no_audio_24px
				: Resources.icons8_audio_24px;
		}
	}
}
