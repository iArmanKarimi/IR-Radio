using System;

namespace IRRadioLib.Stations
{
	//[Obsolete]
	public class GeneralStations
	{
		public const string
			BAHAARAAN = "http://s0.cdn1.iranseda.ir:1935/liveedge/radio-monasebati/playlist.m3u8",
			AVA = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-avaa/playlist.m3u8",
			EGHTESAAD = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-eghtesad/playlist.m3u8",
			IRAN = "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-iran/playlist.m3u8",
			PAYAAM = "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-payam/playlist.m3u8",
			TARTIL = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-tartil/playlist.m3u8",
			TELAAVAT = "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-talavat/playlist.m3u8",
			JAVAAN = "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-javan/playlist.m3u8",
			SALAAMAT = "http://s0.cdn1.iranseda.ir:1935/liveedge/radio-salamat/playlist.m3u8",
			SABAA = "http://s0.cdn1.iranseda.ir:1935/liveedge/radio-saba/playlist.m3u8",
			FARHANG = "http://s0.cdn1.iranseda.ir:1935/liveedge/radio-farhang/playlist.m3u8",
			QURAAN = "http://s0.cdn1.iranseda.ir:1935/liveedge/radio-quran/playlist.m3u8",
			GOFTEGO = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-goftego/playlist.m3u8",
			MAAREF = "http://s0.cdn1.iranseda.ir:1935/liveedge/radio-maaref/playlist.m3u8",
			NAMAAYESH = "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-namayesh/playlist.m3u8",
			VARZESH = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-varzesh/playlist.m3u8",
			ARABI = "http://s0.cdn1.iranseda.ir:1935/liveedge/radio-arabic/playlist.m3u8",
			ENGLISH = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-english/playlist.m3u8",
			BOROON_MARZI = "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-boroon-studio110/playlist.m3u8",
			DARI = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-boroon-dari/playlist.m3u8",
			ZIAARAT = "http://s1.cdn1.iranseda.ir:1935/liveedge/radio-ziarat/playlist.m3u8"
		;
		public static string GetChannelUrl(Channels channel)
		{
			switch (channel)
			{
				case Channels.Baharan:
					return BAHAARAAN;
				case Channels.Ava:
					return AVA;
				case Channels.Eghtesaad:
					return EGHTESAAD;
				case Channels.Iran:
					return IRAN;
				case Channels.Payam:
					return PAYAAM;
				case Channels.Tartil:
					return TARTIL;
				case Channels.Telaavat:
					return TELAAVAT;
				case Channels.Javaan:
					return JAVAAN;
				case Channels.Salaamat:
					return SALAAMAT;
				case Channels.Sabaa:
					return SABAA;
				case Channels.Farhang:
					return FARHANG;
				case Channels.Quraan:
					return QURAAN;
				case Channels.Goftegoo:
					return GOFTEGO;
				case Channels.Maaref:
					return MAAREF;
				case Channels.Namayesh:
					return NAMAAYESH;
				case Channels.Varzesh:
					return VARZESH;
				case Channels.Arabic:
					return ARABI;
				case Channels.English:
					return ENGLISH;
				case Channels.BoroonMarzi:
					return BOROON_MARZI;
				case Channels.Dari:
					return DARI;
				case Channels.Ziaarat:
					return ZIAARAT;
				default:
					return string.Empty;
			}
		}
		public enum Channels
		{
			Baharan = 26,
			Ava = 21,
			Eghtesaad = 19,
			Iran = 11,
			Payam = 12,
			Tartil = 101,
			Telaavat = 28,
			Javaan = 13,
			Salaamat = 17,
			Sabaa = 23,
			Farhang = 16,
			Quraan = 15,
			Goftegoo = 29,
			Maaref = 14,
			Namayesh = 22,
			Varzesh = 18,
			Arabic = 202,
			English = 201,
			BoroonMarzi = 2001,
			Dari = 2002,
			Ziaarat = 203,
		}
	}
}