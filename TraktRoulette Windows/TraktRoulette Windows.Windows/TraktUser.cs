using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace TraktBrowser
{
	public class TraktUser
	{
		[JsonProperty("username")]
		public string Username
		{
			get;
			set;
		}
		[JsonProperty("about")]
		public string About
		{
			get;
			set;
		}
		[JsonProperty("full_name")]
		public string FullName
		{
			get;
			set;
		}
		[JsonProperty("gender")]
		public string Gender
		{
			get;
			set;
		}
		[JsonProperty("location")]
		public string Location
		{
			get;
			set;
		}
		[JsonProperty("protected")]
		public string Protected
		{
			get;
			set;
		}
		[JsonProperty("age")]
		public int Age
		{
			get;
			set;
		}
		[JsonProperty("joined")]
		public int Joined
		{
			get;
			set;
		}
		[JsonProperty("avatar")]
		public string Avatar
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
		[JsonProperty("vip")]
		public bool Vip
		{
			get;
			set;
		}
		[JsonProperty("stats")]
		public Stats Stats
		{
			get;
			set;
		}
		[JsonProperty("watching")]
		public List<Watching> Watching
		{
			get;
			set;
		}
		[JsonProperty("watched")]
		public List<Watched> Watched
		{
			get;
			set;
		}
	}
}
