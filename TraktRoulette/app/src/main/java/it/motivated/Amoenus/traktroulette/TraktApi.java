package it.motivated.Amoenus.traktroulette;

import android.os.AsyncTask;

import org.json.JSONObject;

import java.net.URL;

public class TraktApi extends AsyncTask<URL, Integer, Long> {
        protected String doInBackground(URL... urls) {
            loadJSON(url);
        }



        protected void onPostExecute(Long result) {
            showDialog("Downloaded " + result + " bytes");
        }

    public void loadJSON(URL url) {
        // Creating JSON Parser instance
        JSONParser jParser = new JSONParser();

        // getting JSON string from URL
        JSONObject json = jParser.getJSONFromUrl(url);

        return json;
    }
}
