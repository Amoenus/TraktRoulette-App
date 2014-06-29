using Newtonsoft.Json;
using System;
namespace TraktBrowser
{
	public class Stats
	{
		[JsonProperty("friends")]
		public int Friends
		{
			get;
			set;
		}
		[JsonProperty("shows")]
		public Shows Shows
		{
			get;
			set;
		}
		[JsonProperty("episodes")]
		public Episodes Episodes
		{
			get;
			set;
		}
		[JsonProperty("movies")]
		public Movies Movies
		{
			get;
			set;
		}
	}
}
