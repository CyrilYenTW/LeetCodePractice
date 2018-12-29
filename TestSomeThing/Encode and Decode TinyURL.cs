using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace TestSomeThing
{
    public class Encode_and_Decode_TinyURL
    {
        public Encode_and_Decode_TinyURL()
        {
            var url = "https://tw.yahoo.com";

            var result = encode(url);

            result = decode(result);
        }

        // Encodes a URL to a shortened URL
        public string encode(string longUrl)
        {
            var url = "https://tinyurl.com/create.php";
            var data = "url=" + longUrl;

            var returnString = PostUrl(url, data.ToCharArray());

            var keyString = "id=\"copyinfo\" data-clipboard-text=\"";

            var startIndex = returnString.IndexOf(keyString) + keyString.Length;
            var endIndex = returnString.IndexOf("\"", startIndex);
            var newUrl = returnString.Substring(startIndex, endIndex - startIndex);

            return newUrl;
        }

        // Decodes a shortened URL to its original URL.
        public string decode(string shortUrl)
        {
            var result = string.Empty;

            HttpWebRequest request = (HttpWebRequest)(WebRequest.Create(shortUrl));

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

            {

                string uriString = response.ResponseUri.AbsoluteUri;

                result = uriString;

            }

            return result;
        }

        public string PostUrl(string WebURL, char[] PostData = null)
        {
            var encoding = Encoding.UTF8;

            //Post資料到Web
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(WebURL);
            request.Method = PostData == null ? "GET" : "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            if (PostData != null)
            {
                //將要傳遞的資料PostData轉成Byte陣列並寫入request
                byte[] byWordWriteroPost = encoding.GetBytes(PostData);
                request.ContentLength = byWordWriteroPost.Length;
                Stream stream = request.GetRequestStream();
                stream.Write(byWordWriteroPost, 0, byWordWriteroPost.Length);
                stream.Close();
            }

            //取得網頁結果
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), encoding);
            string returnString = reader.ReadToEnd();
            response.Close();

            return returnString;
        }
    }
}
