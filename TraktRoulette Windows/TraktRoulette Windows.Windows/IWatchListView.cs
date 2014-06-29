using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraktRoulette_Windows
{
    interface IWatchListView
    {
        void PopulateJsonString(string json);
    }
}
