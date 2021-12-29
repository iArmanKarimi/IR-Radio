using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IRRadioCoreWin
{
	class Program
	{
		static void Main(string[] args)
		{
			const string URL = "http://s3.cdn1.iranseda.ir:1935/liveedge/radio-tehran/playlist.m3u8";
			Console.WriteLine("Started...");
			var wmp = new WMPLib.WindowsMediaPlayer();
			void Play()
			{
				wmp.URL = URL;
				if (wmp.playState != WMPLib.WMPPlayState.wmppsPlaying)
					wmp.controls.play();
			}
			try
			{
				Play();
				ushort transitioningCount = 0;
				uint transitioningLoopCount = 0;
				wmp.PlayStateChange += e =>
				{
					var state = (WMPLib.WMPPlayState)e;
					Console.WriteLine("State: " + state);
					switch (state)
					{
						case WMPLib.WMPPlayState.wmppsUndefined:
							break;
						case WMPLib.WMPPlayState.wmppsStopped:
							break;
						case WMPLib.WMPPlayState.wmppsPaused:
							break;
						case WMPLib.WMPPlayState.wmppsScanForward:
							break;
						case WMPLib.WMPPlayState.wmppsScanReverse:
							break;
						case WMPLib.WMPPlayState.wmppsBuffering:
							break;
						case WMPLib.WMPPlayState.wmppsWaiting:
							break;
						case WMPLib.WMPPlayState.wmppsMediaEnded:
							break;
						case WMPLib.WMPPlayState.wmppsLast:
							break;
						case WMPLib.WMPPlayState.wmppsReconnecting:
							break;

						case WMPLib.WMPPlayState.wmppsPlaying:
							transitioningCount = 0;
							transitioningLoopCount = 0;
							break;
						case WMPLib.WMPPlayState.wmppsTransitioning:
							++transitioningCount;
							if (transitioningCount == 2) // if disconnected
							{
								Play();
								// Don't wait for the first ~5 times, after that set Sleeper
								transitioningCount = 0;
								transitioningLoopCount++;
								if (transitioningLoopCount > 5)
									Thread.Sleep(500); // decrease it for faster reconnection //
							}
							Console.WriteLine();
							break;
						case WMPLib.WMPPlayState.wmppsReady:
							Play();
							break;
						default:
							break;
					}
				};
				//wmp.MediaError += _ => Console.WriteLine("Cannot play media file.");
				Console.Read();

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				Console.ReadLine();
				return;
			}
		}
	}
}
