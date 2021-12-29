using System;
namespace IRRadioLib
{
	public class IWMPStatus
	{
		public  WMPStatus Status { get; private set; }
		public  string StatusString { get; private set; }
		public IWMPStatus Init(string status)
		{
			this.StatusString = status;
			var lower = status.ToLower();
			if (string.IsNullOrEmpty(status)) Status = WMPStatus.Empty;
			else if (lower.Contains("buffering")) Status = WMPStatus.Buffering;
			else if (lower.Contains("Finished")) Status = WMPStatus.Finished;
			else if (lower.Contains("Connecting")) Status = WMPStatus.Connecting;
			else if (lower.StartsWith("Playing")) Status = WMPStatus.Playing;
			else Status = WMPStatus.Unkown;
			return this;
		}
		public enum WMPStatus
		{
			Empty,
			Unkown,
			Playing,
			Finished,
			Buffering,
			Connecting,
		}
	}
}
