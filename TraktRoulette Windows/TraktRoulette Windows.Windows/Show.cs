using Newtonsoft.Json;
using System.Collections.Generic;

namespace TraktBrowser
{
	public class Show
	{
		[JsonProperty("title")]
		public string Title
		{
			get;
			set;
		}
		[JsonProperty("year")]
		public int Year
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
		[JsonProperty("imdb_id")]
		public string ImdbId
		{
			get;
			set;
		}
		[JsonProperty("tvdb_id")]
		public string TvdbId
		{
			get;
			set;
		}
		[JsonProperty("tvrage_id")]
		public string TvRageId
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
		[JsonProperty("country")]
		public string Country
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
		[JsonProperty("runtime")]
		public int Runtime
		{
			get;
			set;
		}
		[JsonProperty("network")]
		public string Network
		{
			get;
			set;
		}
		[JsonProperty("air_day")]
		public string AirDay
		{
			get;
			set;
		}
		[JsonProperty("air_time")]
		public string AirTime
		{
			get;
			set;
		}
		[JsonProperty("certification")]
		public string Certification
		{
			get;
			set;
		}
		[JsonProperty("images")]
		public Images Images
		{
			get;
			set;
		}
		[JsonProperty("genres")]
		public List<string> Genres
		{
			get;
			set;
		}
	}
}
