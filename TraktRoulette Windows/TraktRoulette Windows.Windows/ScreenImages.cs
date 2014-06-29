using Newtonsoft.Json;
using System;
namespace TraktBrowser
{
	public class ScreenImages
	{
		[JsonProperty("screen")]
		public string Screen
		{
			get;
			set;
		}
	}
}
