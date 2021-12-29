namespace IRRadioLib.Stations
{
	public static class Extensions
	{
		public static string ToUrl(this GeneralStations.Channels channel)
		{
			var ch = (int)channel;
			var url = "http://player.iranseda.ir/live-player/?VALID=TRUE&CH=" + ch + "&t=b&auto=true&SAVE=TRUE";
			return url;
		}
		public static string ToUrl(this NamaaStations.Channels channel)
		{
			var ch = (int)channel;
			return "http://player.iranseda.ir/live-player/?VALID=TRUE&CH=" + ch + "&t=b&auto=true&SAVE=TRUE";
		}
		public static string ToUrl(this ProvincialStations.Channels channel)
		{
			var ch = (int)channel;
			return "http://player.iranseda.ir/live-player/?VALID=TRUE&CH=" + ch + "&t=b&auto=true&SAVE=TRUE";
		}
	}
}
