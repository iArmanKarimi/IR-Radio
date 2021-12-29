using System;

namespace IRRadioDesktopWin
{
	public interface IAnyClick<UserControl> 
	{
		event EventHandler<UserControl> AnyClick;
		void SetupAnyClick();
	}
}
