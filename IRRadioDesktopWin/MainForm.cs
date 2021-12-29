using IRRadioDesktopWin.Properties;
using IRRadioLib;
using IRRadioLib.Stations;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRRadioDesktopWin
{
	public partial class MainForm : Form
	{
		private bool IsTurnedOn = false;
		private readonly IIRRadioPlayer radio = new IRRadioWinPlayer();
		public MainForm() => InitializeComponent();
		private void MainForm_Load(object sender, EventArgs e)
		{
			SetupRadio();
			SetupAnyRadioButtonOfTabPagesClick();
			SetupOneCheckedItemPerStationTabPageForRadioButtons();
			ucSoundControls.Init(in radio);
		}
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => radio.Dispose();
		private void SetupRadio()
		{
			radio.Connected += Radio_Connected;
			radio.Connecting += Radio_Connecting;
		}
		private void SetupAnyRadioButtonOfTabPagesClick()
		{
			ucNamaaStations.AnyClick += UcNamaaStations_AnyClick;
			//ucNamaaStations.AnyClick += UcStations_AnyClick;

			ucGeneralStations.AnyClick += UcGeneralStations_AnyClick;
			//ucGeneralStations.AnyClick += UcStations_AnyClick;

			ucProvincialStations.AnyClick += UcProvincialStations_AnyClick;
			//ucProvincialStations.AnyClick += UcStations_AnyClick;

			ucNamaaStations.SetupAnyClick();
			ucGeneralStations.SetupAnyClick();
			ucProvincialStations.SetupAnyClick();
		}
		private bool CurrentStationImageUrlHasChanged;
		private string CurrentStationImageUrl = string.Empty;
		private Bitmap CurrentStationImage;
		private async Task AnyClick(Bitmap brand, string url, string imgUrl)
		{
			await TurnOff();
			radio.StationURL = url;
			CurrentStationImageUrlHasChanged = imgUrl != CurrentStationImageUrl;
			CurrentStationImageUrl = imgUrl;
			pictureBoxPlayingStationBrand.Image = brand;
			await TurnOn();
		}
		private async void UcNamaaStations_AnyClick(object sender, ucNamaaStations e)
			=> await AnyClick(e.Brand, e.Url, e.Channel.ToUrl());
		private async void UcGeneralStations_AnyClick(object sender, ucGeneralStations e)
			=> await AnyClick(e.Brand, e.Url, e.Channel.ToUrl());
		private async void UcProvincialStations_AnyClick(object sender, ucProvincialStations e)
			=> await AnyClick(e.Brand, e.Url, e.Channel.ToUrl());

		private void SetupOneCheckedItemPerStationTabPageForRadioButtons()
		{
			void Setup(UserControl ucMain, UserControl uc1, UserControl uc2)
			{
				foreach (Control control in ucMain.Controls[0].Controls)
					control.Click += (_, __) =>
					{
						foreach (RadioButton btn in uc1.Controls[0].Controls)
							btn.Checked = false;
						foreach (RadioButton btn in uc2.Controls[0].Controls)
							btn.Checked = false;
					};
			}
			Setup(ucProvincialStations, ucGeneralStations, ucNamaaStations);
			Setup(ucGeneralStations, ucProvincialStations, ucNamaaStations);
			Setup(ucNamaaStations, ucGeneralStations, ucProvincialStations);
		}

		private void Radio_Connected(object sender, EventArgs e)
		{
			errorProvider.Clear();
			timerRadioReconnect.Stop();
			btnTurnOnOff.Image = Resources.icons8_shutdown_80px;
		}
		private void Radio_Connecting(object sender, EventArgs e)
		{
			if (!IsTurnedOn)
			{
				timerRadioReconnect.Stop();
				return;
			}
			if (timerRadioReconnect.Enabled) return;
			timerRadioReconnect.Start();
			btnTurnOnOff.Image = Resources.icons8_shutdown_warn_orange_80px;
		}

		private void TimerRadioReconnect_Tick(object sender, EventArgs e) => radio.TurnOn();

		#region Helper
		private async Task TurnOff()
		{
			radio.TurnOff();
			IsTurnedOn = false;
			timerRadioReconnect.Stop();
			btnTurnOnOff.Image = Resources.icons8_shutdown_gray_80px;
			pictureBoxPlayingStationBrand.Image = Resources.radio_FM_picture;
			await SetPlayingStationImage();
		}
		private async Task TurnOn()
		{
			errorProvider.Clear();
			if (!radio.IsOnline)
			{
				await TurnOff();
				IsTurnedOn = false;
				errorProvider.SetError(btnTurnOnOff, "به اینترنت متصل نیستید");
				return;
			}
			radio.TurnOn();
			IsTurnedOn = true;
			btnTurnOnOff.Image = Resources.icons8_shutdown_80px;
			await SetPlayingStationImage();
		}
		private async Task SetPlayingStationImage()
		{
			async Task DownloadFromUrl()
			{
				if (CurrentStationImageUrlHasChanged)
				{
					var img = await radio.GetPlayingStationImage(CurrentStationImageUrl);
					if (img != null)
					{
						CurrentStationImage = img;
						pictureBoxPlayingStation.Image = img;
					}
				}
				else // don't re-download the previous image //
					if (CurrentStationImage != null)
					pictureBoxPlayingStation.Image = CurrentStationImage;
			}

			if (IsTurnedOn)
			{
				await DownloadFromUrl();
				// Todo: set audio playing gif
			}
			else
			{
				pictureBoxPlayingStation.Image = Resources.TV_no_signal_color_bars;
			}
		}
		#endregion

		private async void btnTurnOnOff_Click(object sender, EventArgs e)
		{
			errorProvider.Clear();

			if (IsTurnedOn)
				await TurnOff();
			else
				await TurnOn();

			await SetPlayingStationImage();
		}

		private void btnAboutMe_Click(object sender, EventArgs e)
		{
			new AboutMe().ShowDialog();
		}
	}
}
