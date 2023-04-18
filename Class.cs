using System.Net;
using System.Text;

namespace api_auth1
{
    public class Class
    {
        JsonContent content = JsonContent.Create;
        public static String Post(string url, string content)
        {
            
            HttpWebRequest request = (HttpWebRequest)WeakReference.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            byte[] contentBytes = Encoding.UTF8.GetBytes(content);
            request.ContentLength = contentBytes.Length;
            using (Stream s = request.GetRequestStream())
            {
                s.Write(contentBytes, 0, contentBytes.Length);
            }
            string result = "";
            WebResponse response = request.GetResponse();
            using (StreamReader sr = new(response.GetResponseStream(), Encoding.UTF8))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }

    }

}
