using System;
using System.Threading.Tasks;
using WMPLib;

namespace IRRadioLib
{
	public class IRRadioWinPlayer : IIRRadioPlayer
	{
		private WindowsMediaPlayer wmp;
		private readonly IWMPStatus WMPStatus = new IWMPStatus();
		private readonly HtmlScraper htmlScraper = new HtmlScraper();
		public string StationURL { get; set; } = string.Empty;
		public int Volume { set => wmp.settings.volume = value; }
		public bool Mute { get => wmp.settings.mute; set => wmp.settings.mute = value; }
		public bool IsPlaying => wmp.playState == WMPPlayState.wmppsPlaying;

		/// <summary>
		/// Is network connection available
		/// </summary>
		public bool IsOnline => wmp.isOnline;
		public IWMPStatus Status => WMPStatus.Init(wmp.status);
		public IWMPNetwork Network => wmp.network;
		/// <summary></summary>
		/// <remarks>
		/// volume: MAX=100, MIN=0
		/// </remarks>
		public IWMPSettings Settings => wmp.settings;
		public WMPOpenState OpenState => wmp.openState;
		public WMPPlayState PlayState => wmp.playState;
		/// <summary>
		/// same as current track
		/// </summary>
		public IWMPMedia CurrentMedia => wmp.currentMedia;
		public IWMPMedia CurrentTrack => wmp.controls.currentItem;
		public IWMPPlaylist CurrentPlaylist => wmp.currentPlaylist;
		public IWMPMediaCollection MediaCollection => wmp.mediaCollection;
		public IWMPPlaylistCollection PlaylistCollection => wmp.playlistCollection;

		public event EventHandler StatusChange;
		public event OnPlayState PlayStateChange;
		public delegate void OnPlayState(WMPPlayState state);

		/// <summary>Occurs when playing</summary>
		public event EventHandler Playing;
		/// <summary>Occurs when player has started to play</summary>
		public event EventHandler Connected;
		/// <summary>Occurs when reconnection is required (retry state)</summary>
		public event EventHandler Connecting;

		public IRRadioWinPlayer()
		{
			wmp = new WindowsMediaPlayer();
			wmp.PlayStateChange += Wmp_PlayStateChange;
			wmp.PlayStateChange += e => PlayStateChange?.Invoke((WMPPlayState)e);
			wmp.StatusChange += () => StatusChange?.Invoke(this, EventArgs.Empty);
		}

		private uint transitioningCount = 0;
		private bool onReconnectionLoop = true;
		private void Wmp_PlayStateChange(int NewState)
		{
			switch ((WMPPlayState)NewState)
			{
				case WMPPlayState.wmppsUndefined:
					break;
				case WMPPlayState.wmppsStopped:
					break;
				case WMPPlayState.wmppsPaused:
					break;
				case WMPPlayState.wmppsScanForward:
					break;
				case WMPPlayState.wmppsScanReverse:
					break;
				case WMPPlayState.wmppsBuffering:
					break;
				case WMPPlayState.wmppsWaiting:
					break;
				case WMPPlayState.wmppsMediaEnded:
					break;
				case WMPPlayState.wmppsLast:
					break;
				case WMPPlayState.wmppsReconnecting:
					break;

				case WMPPlayState.wmppsReady:
					if (!wmp.status.ToLower().StartsWith("playing"))
						TurnOn();
					break;
				case WMPPlayState.wmppsPlaying:
					transitioningCount = 0;
					onReconnectionLoop = false;
					Playing?.Invoke(this, EventArgs.Empty);
					Connected?.Invoke(this, EventArgs.Empty);
					break;
				case WMPPlayState.wmppsTransitioning:
					Connecting?.Invoke(this, EventArgs.Empty);
					if (onReconnectionLoop) break;
					transitioningCount++;
					if (transitioningCount == 2) // if disconnected 
						onReconnectionLoop = true;
					break;
				default:
					break;
			}
		}

		public void TurnOn()
		{
			if (wmp.playState == WMPPlayState.wmppsPlaying)
				return;
			try
			{
				wmp.URL = StationURL;
				wmp.controls.play();
			}
			catch { }
		}
		public void TurnOff() => wmp.controls.stop();
		public void Previous() => wmp.controls.previous();
		public void Next() => wmp.controls.next();
		public async Task<System.Drawing.Bitmap> GetPlayingStationImage(string url)
			=> await htmlScraper.GetCurrentlyPlayingImageAsync(url);

		public void Dispose()
		{
			TurnOff();
			wmp.close();
		}

		public string CurrentPosition => wmp.controls.currentPositionString; // 00:03 elapsed time of CurrentTrack //
	}
}
