using System;
using System.Drawing;

namespace IRRadioDesktopWin
{
	public interface IStationsUserControl<Channels, UserControl> where Channels : Enum
	{
		string Url { get; set; }
		Bitmap Brand { get; set; }
		Channels Channel { get; set; }
	}
}