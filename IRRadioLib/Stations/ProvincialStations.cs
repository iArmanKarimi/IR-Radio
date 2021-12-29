namespace IRRadioLib.Stations
{
	/// <summary>
	/// State/Province channels
	/// </summary>
	public class ProvincialStations
	{
		public const string
			ABAADAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-abadan/playlist.m3u8",
			TABRIZ = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-tabriz/playlist.m3u8", // AZARBAYJAAN_SHARGI
			AZARBAAYJAAN_GHARBI = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-azgharbi/playlist.m3u8",
			ARDEBIL = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-ardebil/playlist.m3u8",
			ESFAHAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-esfahan/playlist.m3u8",
			ALBORZ = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-alborz/playlist.m3u8",
			ILAAM = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-ilam/playlist.m3u8",
			BOOSHEHR = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-bushehr/playlist.m3u8",
			CHAAHAARMAHAAL_VA_BAKHTIARI = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-shahrekord/playlist.m3u8", // Shahre Kord
			KHORAASAAN_JONOOBI = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-khorasanjonoobi/playlist.m3u8",
			KHORAASAAN_RAZAVI = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-khorasanrazavi/playlist.m3u8",
			KHORAASAAN_SHOMAALI = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-khorsanshomali/playlist.m3u8",
			KHALIJE_FARS = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-bandarabas/playlist.m3u8",
			KHOOZESTAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-khoozestan/playlist.m3u8",
			ZANJAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-zanjan/playlist.m3u8",
			ZIARAAT = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-ziarat/playlist.m3u8",
			SEMNAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-semnan/playlist.m3u8",
			ZAAHEDAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-zahedan/playlist.m3u8", // Sistan Baloochestaan
			FARS = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-fars/playlist.m3u8",
			QAZVIN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-qazvin/playlist.m3u8",
			QOM = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-qom/playlist.m3u8",
			KORDESTAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-kordestan/playlist.m3u8",
			KERMAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-kerman/playlist.m3u8",
			KERMAANSHAAH = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-kermanshah/playlist.m3u8",
			KOHKOLOOYE_VA_BOOYERAHMAD = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-yasuj/playlist.m3u8", // Yaasooj
			KISH = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-kish/playlist.m3u8",
			GOLESTAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-gorgan/playlist.m3u8",
			GILAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-rasht/playlist.m3u8",
			LORESTAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-lorestan/playlist.m3u8",
			MAAZANDARAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-sari/playlist.m3u8",
			MARKAZI = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-markazi/playlist.m3u8", // ARAAK
			MAHAABAAD = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-mahabad/playlist.m3u8",
			HAMEDAAN = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-hamedan/playlist.m3u8",
			YAZD = "http://altcdn.iranseda.ir:1935/channel-live/smil:r-yazd/playlist.m3u8",
			TEHRAN = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-tehran/playlist.m3u8"
		;

		public static string GetChannelUrl(Channels channel)
		{
			switch (channel)
			{
				case Channels.Abadan:
					return ABAADAAN;
				case Channels.Azarbaayjaan_Sharghi:
					return TABRIZ;
				case Channels.Azarbaayjaan_Gharbi:
					return AZARBAAYJAAN_GHARBI;
				case Channels.Ardebil:
					return ARDEBIL;
				case Channels.Esfahaan:
					return ESFAHAAN;
				case Channels.Alborz:
					return ALBORZ;
				case Channels.Ilaam:
					return ILAAM;
				case Channels.Booshehr:
					return BOOSHEHR;
				case Channels.Chahaarmahaal_va_Bakhtiari:
					return CHAAHAARMAHAAL_VA_BAKHTIARI;
				case Channels.Khorasan_Jonoobi:
					return KHORAASAAN_JONOOBI;
				case Channels.Khorasan_Razavi:
					return KHORAASAAN_RAZAVI;
				case Channels.Khorasan_Shomali:
					return KHORAASAAN_SHOMAALI;
				case Channels.KhalijeFars:
					return KHALIJE_FARS;
				case Channels.Khoozestan:
					return KHOOZESTAAN;
				case Channels.Tehran:
					return TEHRAN;
				case Channels.Zanjaan:
					return ZANJAAN;
				case Channels.Ziaarat:
					return ZIARAAT;
				case Channels.Semnaan:
					return SEMNAAN;
				case Channels.Zaahedaan:
					return ZANJAAN;
				case Channels.Fars:
					return FARS;
				case Channels.Qazvin:
					return QAZVIN;
				case Channels.Qom:
					return QOM;
				case Channels.Kordestaan:
					return KORDESTAAN;
				case Channels.Kerman:
					return KERMAAN;
				case Channels.Kermanshah:
					return KERMAANSHAAH;
				case Channels.Kohkolooye_va_BooyerAhmad:
					return KOHKOLOOYE_VA_BOOYERAHMAD;
				case Channels.Kish:
					return KISH;
				case Channels.Golestaan:
					return GOLESTAAN;
				case Channels.Gilaan:
					return GILAAN;
				case Channels.Lorestaan:
					return LORESTAAN;
				case Channels.Maazandaraan:
					return MAAZANDARAAN;
				case Channels.Markazi:
					return MARKAZI;
				case Channels.MahAbad:
					return MAHAABAAD;
				case Channels.Hamedaan:
					return HAMEDAAN;
				case Channels.Yazd:
					return YAZD;
				default:
					return string.Empty;
			}
		}

		/// <summary>
		/// Channels related to states
		/// </summary>
		public enum Channels
		{
			Abadan = 527,
			Azarbaayjaan_Sharghi = 508,
			Azarbaayjaan_Gharbi = 509,
			Ardebil = 510,
			Esfahaan = 525,
			Alborz = 501,
			Ilaam = 512,
			Booshehr = 523,
			Chahaarmahaal_va_Bakhtiari = 506,
			Khorasan_Jonoobi = 529,
			Khorasan_Razavi = 528,
			Khorasan_Shomali = 530,
			KhalijeFars = 514,
			Khoozestan = 502,
			Tehran = 20,
			Zanjaan = 519,
			Ziaarat = 203,
			Semnaan = 520,
			Zaahedaan = 532,
			Fars = 524,
			Qazvin = 533,
			Qom = 516,
			Kordestaan = 503,
			Kerman = 513,
			Kermanshah = 511,
			Kohkolooye_va_BooyerAhmad = 522,
			Kish = 521,
			Golestaan = 507,
			Gilaan = 515,
			Lorestaan = 526,
			Maazandaraan = 505,
			Markazi = 517,
			MahAbad = 531,
			Hamedaan = 518,
			Yazd = 504,
		}
	}
}