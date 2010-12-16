using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace Milkshake.Integration.Google.Translate
{
    ///
    /// An API Client for the Google AJAX Translate API.
    ///
    public class TranslateApi
    {
        ///
        /// The JavaScript serializer
        ///
        private JavaScriptSerializer _Serializer = new JavaScriptSerializer();

        ///
        /// Translates the text.
        ///
        public string TranslateText(string inputText, string sourceLanguage, string destinationLanguage, string apiKey)
        {
            string requestUrl = string.Format("http://ajax.googleapis.com/ajax/services/language/translate?v=1.0&q={0}&langpair={1}|{2}&key={3}",
                HttpUtility.UrlEncode(inputText), sourceLanguage.ToLowerInvariant(), destinationLanguage.ToLowerInvariant(), apiKey);

            string responseJson = String.Empty;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(requestUrl);
            
            using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
            {
                using (StreamReader sr = new StreamReader(res.GetResponseStream()))
                {
                    responseJson = sr.ReadToEnd();
                }
            }

            GoogleAjaxResponse translation = this._Serializer.Deserialize<GoogleAjaxResponse>(responseJson);

            if (translation != null && translation.ResponseData != null && translation.ResponseData.ResponseStatus == HttpStatusCode.OK)
            {
                return translation.ResponseData.TranslatedText;
            }
            else
            {
                return String.Empty;
            }
        }
    }
}