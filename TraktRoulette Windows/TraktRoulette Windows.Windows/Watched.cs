using Newtonsoft.Json;
using System;
namespace TraktBrowser
{
	public class Watched
	{
		[JsonProperty("type")]
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
		[JsonProperty("watched")]
		public int WatchedDate
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
		[JsonProperty("movie")]
		public Movie Movie
		{
			get;
			set;
		}
	}
}
