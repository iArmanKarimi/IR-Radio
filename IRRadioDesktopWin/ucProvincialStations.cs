using IRRadioDesktopWin.Properties;
using IRRadioLib.Stations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IRRadioDesktopWin
{
	public partial class ucProvincialStations : UserControl
	{
		public string Url { get; set; }
		public Bitmap Brand { get; set; }
		public ProvincialStations.Channels Channel { get; set; }

		public event EventHandler<ucProvincialStations> AnyClick;

		public ucProvincialStations() => InitializeComponent();

		public void SetupAnyClick()
		{
			foreach (RadioButton btn in flowLayoutPanel.Controls)
				if (AnyClick?.GetInvocationList()?.Length > 0)
					foreach (EventHandler<ucProvincialStations> subs in AnyClick?.GetInvocationList())
						btn.Click += (_, e) => subs?.Invoke(subs, this);
		}

		#region Click Handlers
		private void radioBtnStationAabaadaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_abadan;
			Url = ProvincialStations.ABAADAAN;
			Channel = ProvincialStations.Channels.Abadan;
		}

		private void radioBtnStationAazarBaayjan_Sharghi_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_tabriz;
			Url = ProvincialStations.TABRIZ;
			Channel = ProvincialStations.Channels.Azarbaayjaan_Sharghi;
		}

		private void radioBtnStationAazarbaayjan_Gharbi_CheckedChanged(object sender, EventArgs e)
		{

			Brand = Resources.radio_azgharbi;
			Url = ProvincialStations.AZARBAAYJAAN_GHARBI;
			Channel = ProvincialStations.Channels.Azarbaayjaan_Gharbi;
		}

		private void radioBtnStationArdebil_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_ardebil;
			Url = ProvincialStations.ARDEBIL;
			Channel = ProvincialStations.Channels.Ardebil;
		}

		private void radioBtnStationEsfahaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_esfahan;
			Url = ProvincialStations.ESFAHAAN;
			Channel = ProvincialStations.Channels.Esfahaan;
		}

		private void radioBtnStationAlborz_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_alborz;
			Url = ProvincialStations.ALBORZ;
			Channel = ProvincialStations.Channels.Alborz;
		}

		private void radioBtnStationIlam_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_ilam;
			Url = ProvincialStations.ILAAM;
			Channel = ProvincialStations.Channels.Ilaam;
		}

		private void radioBtnStationBooshehr_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_booshehr;
			Url = ProvincialStations.BOOSHEHR;
			Channel = ProvincialStations.Channels.Booshehr;
		}

		private void radioBtnStationTehran_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_tehran;
			Url = ProvincialStations.TEHRAN;
			Channel = ProvincialStations.Channels.Tehran;
		}

		private void radioBtnStationChaahaarMahaal_va_Bakhtiari_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_charmahal;
			Url = ProvincialStations.CHAAHAARMAHAAL_VA_BAKHTIARI;
			Channel = ProvincialStations.Channels.Chahaarmahaal_va_Bakhtiari;
		}

		private void radioBtnStationKhoraasaan_Jonoobi_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_khorasanjonoobi;
			Url = ProvincialStations.KHORAASAAN_JONOOBI;
			Channel = ProvincialStations.Channels.Khorasan_Jonoobi;
		}

		private void radioBtnStationKhoraasaan_Razavi_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_khorasanrazavi;
			Url = ProvincialStations.KHORAASAAN_RAZAVI;
			Channel = ProvincialStations.Channels.Khorasan_Razavi;
		}

		private void radioBtnStationKhoraasaan_Shomaali_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_khorasanshomali;
			Url = ProvincialStations.KHORAASAAN_SHOMAALI;
			Channel = ProvincialStations.Channels.Khorasan_Shomali;
		}

		private void radioBtnStationKhalijeFars_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_khalij;
			Url = ProvincialStations.KHALIJE_FARS;
			Channel = ProvincialStations.Channels.KhalijeFars;
		}

		private void radioBtnStationKhoozestaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_khoozestan;
			Url = ProvincialStations.KHOOZESTAAN;
			Channel = ProvincialStations.Channels.Khoozestan;
		}

		private void radioBtnStationZanjaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_zanjan;
			Url = ProvincialStations.ZANJAAN;
			Channel = ProvincialStations.Channels.Zanjaan;
		}

		private void radioBtnStationSemnaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_semnan;
			Url = ProvincialStations.SEMNAAN;
			Channel = ProvincialStations.Channels.Semnaan;
		}

		private void radioBtnStationSistanBaloochestaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_zahedan;
			Url = ProvincialStations.ZAAHEDAAN;
			Channel = ProvincialStations.Channels.Zaahedaan;
		}

		private void radioBtnStationFars_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_fars;
			Url = ProvincialStations.FARS;
			Channel = ProvincialStations.Channels.Fars;
		}

		private void radioBtnStationQazvin_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_qazvin;
			Url = ProvincialStations.QAZVIN;
			Channel = ProvincialStations.Channels.Qazvin;
		}

		private void radioBtnStationQom_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_qom;
			Url = ProvincialStations.QOM;
			Channel = ProvincialStations.Channels.Qom;
		}

		private void radioBtnStationKordestaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_kordestan;
			Url = ProvincialStations.KORDESTAAN;
			Channel = ProvincialStations.Channels.Kordestaan;
		}

		private void radioBtnStationKermaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_kerman;
			Url = ProvincialStations.KERMAAN;
			Channel = ProvincialStations.Channels.Kerman;
		}

		private void radioBtnStationKermaanshaah_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_kermanshah;
			Url = ProvincialStations.KERMAANSHAAH;
			Channel = ProvincialStations.Channels.Kermanshah;
		}

		private void radioBtnStationKohkolooye_va_BooyerAhmad_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_yasuj;
			Url = ProvincialStations.KOHKOLOOYE_VA_BOOYERAHMAD;
			Channel = ProvincialStations.Channels.Kohkolooye_va_BooyerAhmad;
		}

		private void radioBtnStationKish_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_kish;
			Url = ProvincialStations.KISH;
			Channel = ProvincialStations.Channels.Kish;
		}

		private void radioBtnStationGolestaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_golestan;
			Url = ProvincialStations.GOLESTAAN;
			Channel = ProvincialStations.Channels.Golestaan;
		}

		private void radioBtnStationGilaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_gilan;
			Url = ProvincialStations.GILAAN;
			Channel = ProvincialStations.Channels.Gilaan;
		}

		private void radioBtnStationLorestaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_lorestan;
			Url = ProvincialStations.LORESTAAN;
			Channel = ProvincialStations.Channels.Lorestaan;
		}

		private void radioBtnStationMaazandaraan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_mazandaran;
			Url = ProvincialStations.MAAZANDARAAN;
			Channel = ProvincialStations.Channels.Maazandaraan;
		}

		private void radioBtnStationMarkazi_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_markazi;
			Url = ProvincialStations.MARKAZI;
			Channel = ProvincialStations.Channels.Markazi;
		}

		private void radioBtnStationMahaabaad_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_mahabad;
			Url = ProvincialStations.MAHAABAAD;
			Channel = ProvincialStations.Channels.MahAbad;
		}

		private void radioBtnStationHamedaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_hamedan;
			Url = ProvincialStations.HAMEDAAN;
			Channel = ProvincialStations.Channels.Hamedaan;
		}

		private void radioBtnStationYazd_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_yazd;
			Url = ProvincialStations.YAZD;
			Channel = ProvincialStations.Channels.Yazd;
		}
		#endregion
	}
}
