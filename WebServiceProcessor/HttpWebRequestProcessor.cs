using Constants;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace WebServiceProcessor
{
    public class HttpWebRequestProcessor
    {
        /// <summary>
        /// Post 调用webservice
        /// </summary>
        /// <param name="url">服务器路径</param>
        /// <param name="methodName">要调用的方法名称</param>
        /// <param name="hashTable">参数和值放到Hashtable</param>
        /// <returns>返回xml</returns>
        public static string PostWebService(string url, string methodName, Hashtable hashTable)
        {
            HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(string.Concat(url, CN.SLANT, methodName));
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            var postString = HashTableToPostData(hashTable);
            byte[] data = Encoding.UTF8.GetBytes(postString);
            webRequest.ContentLength = data.Length;
            Stream writer = webRequest.GetRequestStream();
            writer.Write(data, 0, data.Length);
            writer.Close();
            try
            {
                var response = webRequest.GetResponse();
                var stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string returnedXml = reader.ReadToEnd();
                reader.Close();
                return returnedXml;
            }
            catch (InvalidOperationException invalidOperationExeption)
            {
                Trace.WriteLine(invalidOperationExeption.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// Get 调用webservice
        /// </summary>
        /// <param name="URL">服务器路径</param>
        /// <param name="MethodName">要调用的方法名称</param>
        /// <param name="Pars">参数和值放到Hashtable</param>
        /// <returns>返回xml</returns>
        public static string GetWebService(String URL, String MethodName, Hashtable Pars)
        {
            string requestUriString = string.Concat(URL, CN.SLANT, MethodName, CN.QUESTION_MARK, HashTableToPostData(Pars));
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(requestUriString);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            // 凭证
            request.Credentials = CredentialCache.DefaultCredentials;
            //超时时间
            request.Timeout = 10000;
            try
            {
                var response = request.GetResponse();
                var stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream, Encoding.UTF8);
                String retXml = sr.ReadToEnd();
                sr.Close();
                return retXml;
            }
            catch (InvalidOperationException invalidOperationException)
            {
                Trace.WriteLine(invalidOperationException.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// 拼接路径
        /// </summary>
        /// <param name="hashTable">存放方法参数和值的Hashtable</param>
        /// <returns>返回拼接后的字符串</returns>
        private static string HashTableToPostData(Hashtable hashTable)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var key in hashTable.Keys)
            {
                if (stringBuilder.Length > 0)
                {
                    stringBuilder.Append(CN.AND);
                }
                string concatedKeyValue = string.Concat(HttpUtility.UrlEncode(key as string), CN.EQUALS, HttpUtility.UrlEncode(hashTable[key].ToString()));
                stringBuilder.Append(concatedKeyValue);
            }
            return stringBuilder.ToString();
        }
    }
}