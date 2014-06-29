using Newtonsoft.Json;
using System;
namespace TraktBrowser
{
	public class Episode
	{
		[JsonProperty("season")]
		public int Season
		{
			get;
			set;
		}
		[JsonProperty("number")]
		public int Number
		{
			get;
			set;
		}
		[JsonProperty("title")]
		public string Title
		{
			get;
			set;
		}
		[JsonProperty("overview")]
		public string Overview
		{
			get;
			set;
		}
		[JsonProperty("first_aired")]
		public int FirstAired
		{
			get;
			set;
		}
		[JsonProperty("url")]
		public string Url
		{
			get;
			set;
		}
		[JsonProperty("images")]
		public ScreenImages Images
		{
			get;
			set;
		}
	}
}
