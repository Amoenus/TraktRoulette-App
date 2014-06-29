using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Newtonsoft.Json;
using TraktBrowser;

namespace TraktRoulette_Windows
{
    class JsonGrabber
    {
        public static string DownloadContent(string url)
        {
            string result;
            try
            {
               // SetCredentials();
                //using (var handler = new HttpClientHandler
                //{
                //    Proxy = Program.Proxy
                //})
                {
                    using (var client = new HttpClient())
                    {
                        result = GetJson(client, url);
                    }
                }
            }
            catch (AggregateException e)
            {
                result = BuildErrorMessage(e);
            }
            return result;
        }

        private static string GetJson(HttpClient client, string url)
        {
            return client.GetStringAsync(url).Result;
        }

        //public static Image GetImageStreamFromUrl(string url)
        //{
        //    Image result;
        //    //using (var handler = new HttpClientHandler
        //    //{
        //    //    Proxy = Program.Proxy
        //    //})
        //    {
        //        using (var client = new HttpClient())
        //        {
        //            HttpResponseMessage response = client.GetAsync(url).Result;
        //            response.EnsureSuccessStatusCode();
        //          //  result = Image.FromStream(response.Content.ReadAsStreamAsync().Result);
        //        }
        //    }
        //    return result;
        //}

        private static string BuildErrorMessage(AggregateException e)
        {
            string result = e.Message + Environment.NewLine;
            return e.InnerExceptions.Aggregate(result, AddInnerExceptionMessages);
        }

        private static string AddInnerExceptionMessages(string result, Exception innerException)
        {
            result = result + innerException.Message + Environment.NewLine;
            if (innerException.InnerException != null)
            {
                result = result + innerException.InnerException.Message + Environment.NewLine;
            }
            return result;
        }

        //private static void SetCredentials()
        //{
        //    Program.Proxy.Credentials = CredentialCache.DefaultCredentials;
        //}

        public static TraktUser DeserializeTraktUser(string json)
        {
            return JsonConvert.DeserializeObject<TraktUser>(json);
        }

        public static Watching DeserializeWatching(string json)
        {
            return JsonConvert.DeserializeObject<Watching>(json);
        }

        public static List<Movie> DeserializeMovies(string json)
        {
            return JsonConvert.DeserializeObject<List<Movie>>(json);
        }
    }
}
