using System.Drawing;
using System.Threading.Tasks;

namespace IRRadioLib
{
	public interface IHtmlScraper
	{
		Task<Bitmap> GetPlayingStationImage(string url);
	}
}