using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace TraktBrowser
{
	public class Movie
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
		[JsonProperty("released")]
		public int Released
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
		[JsonProperty("trailer")]
		public string Trailer
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
		[JsonProperty("tagline")]
		public string Tagline
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
		[JsonProperty("certification")]
		public string Certification
		{
			get;
			set;
		}
		[JsonProperty("imdb_id")]
		public string ImdbID
		{
			get;
			set;
		}
		[JsonProperty("tmdb_id")]
		public string TmdbID
		{
			get;
			set;
		}
		[JsonProperty("images")]
		public FanOrPosterImages Images
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
