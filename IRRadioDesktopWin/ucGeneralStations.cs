using IRRadioDesktopWin.Properties;
using IRRadioLib.Stations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IRRadioDesktopWin
{
	public partial class ucGeneralStations : UserControl, IAnyClick<ucGeneralStations>
	{
		public string Url { get; set; }
		public Bitmap Brand { get; set; }
		public GeneralStations.Channels Channel { get; set; }

		public event EventHandler<ucGeneralStations> AnyClick;

		public ucGeneralStations() => InitializeComponent();

		public void SetupAnyClick()
		{
			foreach (RadioButton btn in flowLayoutPanel.Controls)
				if (AnyClick?.GetInvocationList()?.Length > 0)
					foreach (EventHandler<ucGeneralStations> subs in AnyClick?.GetInvocationList())
						btn.Click += (_, e) => subs?.Invoke(subs, this);
		}

		#region Click Handlers
		private void radioBtnStationAvaa_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_avaa;
			Url = GeneralStations.AVA;
			Channel = GeneralStations.Channels.Ava;
		}

		private void radioBtnStationEghtesaad_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_eghtesad;
			Url = GeneralStations.EGHTESAAD;
			Channel = GeneralStations.Channels.Eghtesaad;
		}

		private void radioBtnStationEnglish_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_english;
			Url = GeneralStations.ENGLISH;
			Channel = GeneralStations.Channels.English;
		}

		private void radioBtnStationIran_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_iran;
			Url = GeneralStations.IRAN;
			Channel = GeneralStations.Channels.Iran;
		}

		private void radioBtnStationBoroonMarzi_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_boroon_studio110;
			Url = GeneralStations.BOROON_MARZI;
			Channel = GeneralStations.Channels.BoroonMarzi;
		}

		private void radioBtnStationBahaaraan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_monasebati;
			Url = GeneralStations.BAHAARAAN;
			Channel = GeneralStations.Channels.Baharan;
		}

		private void radioBtnStationPayaam_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_payam;
			Url = GeneralStations.PAYAAM;
			Channel = GeneralStations.Channels.Payam;
		}

		private void radioBtnStationTertil_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_tartil;
			Url = GeneralStations.TARTIL;
			Channel = GeneralStations.Channels.Tartil;
		}

		private void radioBtnStationTelaavat_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_talavat;
			Url = GeneralStations.TELAAVAT;
			Channel = GeneralStations.Channels.Telaavat;
		}

		private void radioBtnStationJavaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_javan;
			Url = GeneralStations.JAVAAN;
			Channel = GeneralStations.Channels.Javaan;
		}

		private void radioBtnStationDari_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_boroon_dari;
			Url = GeneralStations.DARI;
			Channel = GeneralStations.Channels.Dari;
		}

		private void radioBtnStationZiaarat_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_ziarat;
			Url = GeneralStations.ZIAARAT;
			Channel = GeneralStations.Channels.Ziaarat;
		}

		private void radioBtnStationSalaamat_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_salamat;
			Url = GeneralStations.SALAAMAT;
			Channel = GeneralStations.Channels.Salaamat;
		}

		private void radioBtnStationSabaa_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_saba;
			Url = GeneralStations.SABAA;
			Channel = GeneralStations.Channels.Sabaa;
		}

		private void radioBtnStationArabi_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_arabic;
			Url = GeneralStations.ARABI;
			Channel = GeneralStations.Channels.Arabic;
		}

		private void radioBtnStationFarhang_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_farhang;
			Url = GeneralStations.FARHANG;
			Channel = GeneralStations.Channels.Farhang;
		}

		private void radioBtnStationQuran_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_quran;
			Url = GeneralStations.QURAAN;
			Channel = GeneralStations.Channels.Quraan;
		}

		private void radioBtnStationGoftVaGoo_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_goftego;
			Url = GeneralStations.GOFTEGO;
			Channel = GeneralStations.Channels.Goftegoo;
		}

		private void radioBtnStationMaaref_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_maaref;
			Url = GeneralStations.MAAREF;
			Channel = GeneralStations.Channels.Maaref;
		}

		private void radioBtnStationNamaayesh_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_namayesh;
			Url = GeneralStations.NAMAAYESH;
			Channel = GeneralStations.Channels.Namayesh;
		}

		private void radioBtnStationVarzesh_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_varzesh;
			Url = GeneralStations.VARZESH;
			Channel = GeneralStations.Channels.Varzesh;
		}
		#endregion
	}
}
