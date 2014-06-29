using Newtonsoft.Json;
using System;
namespace TraktBrowser
{
	public class Episodes
	{
		[JsonProperty("watched")]
		public int Watched
		{
			get;
			set;
		}
		[JsonProperty("watched_unique")]
		public int WatchedUnique
		{
			get;
			set;
		}
		[JsonProperty("watched_trakt")]
		public int WatchedTrakt
		{
			get;
			set;
		}
		[JsonProperty("watched_trakt_unique")]
		public int WatchedTraktUnique
		{
			get;
			set;
		}
		[JsonProperty("watched_elsewhere")]
		public int WatchedElsewhere
		{
			get;
			set;
		}
		[JsonProperty("scrobbles")]
		public int Scrobbles
		{
			get;
			set;
		}
		[JsonProperty("scrobbles_unique")]
		public int ScrobblesUnique
		{
			get;
			set;
		}
		[JsonProperty("checkins")]
		public int Checkins
		{
			get;
			set;
		}
		[JsonProperty("checkins_unique")]
		public int CheckinsUnique
		{
			get;
			set;
		}
		[JsonProperty("seen")]
		public int Seen
		{
			get;
			set;
		}
		[JsonProperty("unwatched")]
		public int Unwatched
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
