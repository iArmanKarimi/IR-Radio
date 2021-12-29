using System;
using System.Drawing;
using System.Threading.Tasks;

namespace IRRadioLib
{
	public interface IIRRadioPlayer : IDisposable, IHtmlScraper
	{
		int Volume { set; }
		bool Mute { get; set; }
		bool IsOnline { get; }
		bool IsPlaying { get; }
		string StationURL { get; set; }

		event EventHandler Playing;
		event EventHandler Connected;
		event EventHandler Connecting;

		void TurnOn();
		void TurnOff();
	}
}
