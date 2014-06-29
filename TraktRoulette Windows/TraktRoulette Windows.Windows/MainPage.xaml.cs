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

        private const string GetWatchListAPiCall = "http://api.trakt.tv/user/watchlist/movies.json/7b8cbd557ce6af7c0987fafdf4582044/Amoenus";

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnGetJson_Click(object sender, RoutedEventArgs e)
        {

            JsonString = JsonGrabber.DownloadContent(GetWatchListAPiCall);
            List<Movie> watchList = JsonGrabber.DeserializeMovies(jsonString);
            int listItemCount = watchList.Count;
            Random r = new Random();
            int x = r.Next(0, listItemCount);
            PopulateJsonString(watchList.ElementAt(x).Title);
        }

        public void PopulateJsonString(string json)
        {
            JsonText.Text = json;
        }
    }
}
