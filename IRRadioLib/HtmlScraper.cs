using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace IRRadioLib
{
	public class HtmlScraper : IDisposable
	{
		private const string imageId = "picprog";
		private readonly HttpClient client = new HttpClient();
		private readonly HtmlDocument document = new HtmlDocument();

		private async Task<HttpContent> FetchAsync(string url)
		{
			try
			{
				var res = await client.GetAsync(url);
				if (res.IsSuccessStatusCode)
					return res.Content;
				else
					return null;
			}
			catch (Exception) { return null; }
		}
		//private async Task<HttpContent> FetchAsync(string url)
		//{
		//	if (url is null) return null;
		//	var res = await client.GetAsync(url);
		//	return res.IsSuccessStatusCode ? res.Content : null;
		//}
		private string ScrapeImageLink(string html)
		{
			if (string.IsNullOrEmpty(html)) return null;
			try
			{
				document.LoadHtml(html);
				HtmlNode imgElement = document.GetElementbyId(imageId);
				if (imgElement != null)
				{
					var link = imgElement.Attributes["src"];
					if (link != null)
						return link.Value;
				}
				return null;
			}
			catch (Exception) { return null; }
		}
		private async Task<Bitmap> ToBitmapAsync(HttpContent content)
			=> content is null ? null : (Bitmap)Image.FromStream(await content.ReadAsStreamAsync());
		private async Task<string> GetContentString(HttpContent content)
			=> content is null ? null : await content.ReadAsStringAsync();

		public async Task<Bitmap> GetCurrentlyPlayingImageAsync(string url) =>
			string.IsNullOrEmpty(url) ? null :
			await ToBitmapAsync(
				await FetchAsync(
					ScrapeImageLink(
						await GetContentString(
							await FetchAsync(
								url
							)
						)
					)
				)
			);

		public void Dispose() => client.Dispose();
	}
}
