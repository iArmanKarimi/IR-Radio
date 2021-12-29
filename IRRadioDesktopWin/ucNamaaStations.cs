using IRRadioDesktopWin.Properties;
using IRRadioLib.Stations;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IRRadioDesktopWin
{
	public partial class ucNamaaStations : UserControl
	{
		public string Url { get; set; }
		public Bitmap Brand { get; set; }
		public NamaaStations.Channels Channel { get; set; }

		public event EventHandler<ucNamaaStations> AnyClick;

		public ucNamaaStations() => InitializeComponent();

		public void SetupAnyClick()
		{
			foreach (RadioButton btn in flowLayoutPanel.Controls)
				if (AnyClick?.GetInvocationList()?.Length > 0)
					foreach (EventHandler<ucNamaaStations> subs in AnyClick?.GetInvocationList())
						btn.Click += (_, e) => subs?.Invoke(subs, this);
		}

		#region Click Handlers
		private void radioBtnStationNamaaAvaa_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_avaa;
			Url = NamaaStations.AVAA;
		}

		private void radioBtnStationNamaaEghtesaad_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_eghtesad;
			Url = NamaaStations.EGHTESAAD;
		}

		private void radioBtnStationNamaaIran_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_iran;
			Url = NamaaStations.IRAN;
		}

		private void radioBtnStationNamaaPayaam_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_payam;
			Url = NamaaStations.PAYAAM;
		}

		private void radioBtnStationNamaaTelaavat_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_talavat;
			Url = NamaaStations.TALAAVAT;
		}

		private void radioBtnStationNamaaTehran_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_tehran;
			Url = NamaaStations.TEHRAN;
		}

		private void radioBtnStationNamaaJavaan_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_javan;
			Url = NamaaStations.JAVAAN;
		}

		private void radioBtnStationNamaaSalaamat_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_salamat;
			Url = NamaaStations.SALAAMAT;
		}

		private void radioBtnStationNamaaSabaa_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_saba;
			Url = NamaaStations.SABAA;
		}

		private void radioBtnStationNamaaFarhang_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_farhang;
			Url = NamaaStations.FARHANG;
		}

		private void radioBtnStationNamaaQuran_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_quran;
			Url = NamaaStations.QURAAN;
		}

		private void radioBtnStationNamaaGoftoGoo_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_goftego;
			Url = NamaaStations.GOFTEGO;
		}

		private void radioBtnStationNamaaMaaref_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_maaref;
			Url = NamaaStations.MAAREF;
		}

		private void radioBtnStationNamaaNamaayesh_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_namayesh;
			Url = NamaaStations.NAMAAYESH;
		}

		private void radioBtnStationNamaaVarzesh_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_varzesh;
			Url = NamaaStations.VARZESH;
		}

		private void radioBtnStationNamaaZiaarat_CheckedChanged(object sender, EventArgs e)
		{
			Brand = Resources.radio_ziarat;
			Url = NamaaStations.ZIAARAT;
		}
		#endregion
	}
}
