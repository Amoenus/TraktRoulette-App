using Newtonsoft.Json;
using System;
namespace TraktBrowser
{
	public class Shows
	{
		[JsonProperty("library")]
		public int Library
		{
			get;
			set;
		}
		[JsonProperty("watched")]
		public int Watched
		{
			get;
			set;
		}
		[JsonProperty("collection")]
		public int Collection
		{
			get;
			set;
		}
		[JsonProperty("shouts")]
		public int Shouts
		{
			get;
			set;
		}
		[JsonProperty("loved")]
		public int Loved
		{
			get;
			set;
		}
		[JsonProperty("hated")]
		public int Hated
		{
			get;
			set;
		}
	}
}
