using Newtonsoft.Json;
using System;
namespace TraktBrowser
{
	public class FanOrPosterImages
	{
		[JsonProperty("poster")]
		public string Poster
		{
			get;
			set;
		}
		[JsonProperty("fanart")]
		public string Fanart
		{
			get;
			set;
		}
	}
}
