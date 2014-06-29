using Newtonsoft.Json;
using System;
namespace TraktBrowser
{
	public class Watching
	{
		[JsonProperty("hated")]
		public string Type
		{
			get;
			set;
		}
		[JsonProperty("action")]
		public string Action
		{
			get;
			set;
		}
		[JsonProperty("show")]
		public Show Show
		{
			get;
			set;
		}
		[JsonProperty("episode")]
		public Episode Episode
		{
			get;
			set;
		}
	}
}
