using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using TraktBrowser;

namespace TraktRoulette_Windows 
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, IWatchListView
    {
        private string JsonString { get; set; }
        private List<Movie> MovieList { get; set; }

        private const string GetWatchListAPiCall = "http://api.trakt.tv/user/watchlist/movies.json/7b8cbd557ce6af7c0987fafdf4582044/Amoenus";

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnGetJson_Click(object sender, RoutedEventArgs e)
        {
            if (MovieList == null)
            {
                MovieList = GetWatchList();
            }
            int randomIndex = GetRandomElementIndexFromList(MovieList);
            Movie movie = MovieList.ElementAt(randomIndex);

            PopulateMovieTitleString(movie.Title);
        }

        private static int GetRandomElementIndexFromList(List<Movie> watchList)
        {
            int listItemCount = watchList.Count;
            Random r = new Random();
            int randomIndex = r.Next(0, listItemCount);
            return randomIndex;
        }

        private List<Movie> GetWatchList()
        {
            JsonString = JsonGrabber.DownloadContent(GetWatchListAPiCall);
            List<Movie> watchList = JsonGrabber.DeserializeMovies(JsonString);
            return watchList;
        }

        public void PopulateMovieTitleString(string title)
        {
            MovieTitle_TextBlock.Text = title;
        }
    }
}
