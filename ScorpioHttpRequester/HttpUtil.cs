using System;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;
namespace Commons.Util
{
    /// <summary> Http请求回调 </summary>
    public delegate void HttpProcessListener(HttpProcessResult result, object args);
    /// <summary> Http请求返回结果 </summary>
    public class HttpProcessResult
    {
        /// <summary> 是否成功 </summary>
        public bool succeed = false;
        /// <summary> 返回的CODE </summary>
        public HttpStatusCode statusCode = (HttpStatusCode)(-1);
        /// <summary> 错误信息 </summary>
        public String errorMessage = "";
        /// <summary> 输出流 </summary>
        public Stream stream = null;
    }
    /// <summary> Http工具类 </summary>
    public static class HttpUtil
    {
        private static readonly Encoding Encode = Encoding.UTF8;
        const int READ_LENGTH = 2048;
        /// <summary> Http请求超时时间 </summary>
        private static int TIME_OUT_LENGTH = 30000;
        /// <summary> 设置Http请求超时时间 </summary>
        public static void setTimeOutLength(int length)
        {
            TIME_OUT_LENGTH = length;
        }
        /// <summary> 获得Http请求超时时间 </summary>
        public static int getTimeOutLength()
        {
            return TIME_OUT_LENGTH;
        }
        /// <summary> 网络字符转码 </summary>
        //public static String urlencode(String data)
        //{
        //    try {
        //        return UriTranscoder.URLEncode(data, Encode);
        //    } catch (Exception e) {
        //        Logger.error("urlencode is error data : {0}  {1}", data, e.ToString());
        //    }
        //    return "";
        //}
        ///// <summary> 网络字符解码 </summary>
        //public static String urldecode(String data)
        //{
        //    try {
        //        return UriTranscoder.URLDecode(data, Encode);
        //    } catch (Exception e) {
        //        Logger.error("urldecode is error data : {0}  {1}", data, e.ToString());
        //    }
        //    return "";
        //}
        /// <summary> http返回结果转成字符串 </summary>
        public static String toString(HttpProcessResult result)
        {
            if (result == null)
                return "";
            return toString(result.stream);
        }
        /// <summary> 字节流转成字符串 </summary>
        public static String toString(Stream stream)
        {
            try {
                if (stream == null)
                    return "";
                byte[] bytes = toByteArray(stream);
                return Encode.GetString(bytes);
            } catch (System.Exception e) {
            }
            return "";
        }
        /// <summary> http返回结果转成byte[] </summary>
        public static byte[] toByteArray(HttpProcessResult result)
        {
            if (result == null)
                return null;
            return toByteArray(result.stream);
        }
        /// <summary> 字节流转成byte[] </summary>
        public static byte[] toByteArray(Stream stream)
        {
            try {
                if (stream == null)
                    return null;
                MemoryStream result = new MemoryStream();
                int length = 0;
                byte[] bytes = new byte[READ_LENGTH];
                while ((length = stream.Read(bytes, 0, READ_LENGTH)) > 0)
                {
                    result.Write(bytes, 0, length);
                }
                return result.ToArray();
            } catch (System.Exception e) {
            }
            return null;
        }
        /// <summary> 发送http get请求 </summary>
        public static HttpProcessResult httpGet(String uri)
        {
            HttpProcessResult result = new HttpProcessResult();
            try {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                request.Timeout = TIME_OUT_LENGTH;                    //设定超时时间10秒
                HttpWebResponse response = null;
                try {
                    response = (HttpWebResponse)request.GetResponse(); ;
                } catch (WebException e) {
                    response = (HttpWebResponse)e.Response;
                }
                result.statusCode = response.StatusCode;
                if (result.statusCode < HttpStatusCode.OK || result.statusCode >= HttpStatusCode.Ambiguous)
                    throw new Exception(string.Format("StatusCode error : {0}({1})", result.statusCode, (int)result.statusCode));
                result.succeed = true;
                result.stream = response.GetResponseStream();
                return result;
            } catch (Exception e) {
                result.errorMessage = string.Format("httpGet is error  uri : {0}   {1}", uri, e.ToString());
            }
            return result;
        }
        /// <summary> 发送http post请求 </summary>
        public static HttpProcessResult httpPost(String uri, String body)
        {
            HttpProcessResult result = new HttpProcessResult();
            try {
                return httpPost(uri, Encode.GetBytes(body));
            } catch (System.Exception e) {
                result.errorMessage = string.Format("httpPost is error  uri : {0}   {1}", uri, e.ToString());
            }
            return result;
        }
        /// <summary> 发送http post请求 </summary>
        public static HttpProcessResult httpPost(String uri, byte[] body)
        {
            HttpProcessResult result = new HttpProcessResult();
            try {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                request.Timeout = TIME_OUT_LENGTH;          //设定超时时间30秒
                request.Method = "POST";                    //POST类型
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = body.Length;        //发送数据长度
                Stream stream = request.GetRequestStream(); //获得操作流
                stream.Write(body, 0, body.Length);
                stream.Close();
                HttpWebResponse response = null;
                try {
                    response = (HttpWebResponse)request.GetResponse();
                } catch (WebException e) {
                    response = (HttpWebResponse)e.Response;
                }
                result.statusCode = response.StatusCode;
                if (result.statusCode < HttpStatusCode.OK || result.statusCode >= HttpStatusCode.Ambiguous)
                    throw new Exception(string.Format("StatusCode error : {0}({1})",result.statusCode,(int)result.statusCode));
                result.succeed = true;
                result.stream = response.GetResponseStream();
                return result;
            } catch (Exception e) {
                result.errorMessage = string.Format("httpPost is error  uri : {0}   {1}", uri, e.ToString());
            }
            return result;
        }
        /// <summary> 异步发送http get请求 </summary>
        public static void httpGetSync(String uri, HttpProcessListener listener)
        {
            httpGetSync(uri, listener, null);
        }
        /// <summary> 异步发送http get请求 </summary>
        public static void httpGetSync(String uri,HttpProcessListener listener, object args)
	    {
            Thread thread = new Thread(new ParameterizedThreadStart(httpGetThread));
            thread.Start(new object[] { uri, listener, args });
	    }
        private static void httpGetThread(object arg)
        {
            object[] args = (object[])arg;
            HttpProcessListener listener = (HttpProcessListener)args[1];
            HttpProcessResult result = httpGet((String)args[0]);
            if (listener != null) listener(result, args[2]);
        }
        /// <summary> 异步发送http post请求 </summary>
        public static void httpPostSync(String uri, String body, HttpProcessListener listener)
        {
            httpPostSync(uri, body, listener, null);
        }
        /// <summary> 异步发送http post请求 </summary>
        public static void httpPostSync(String uri,String body,HttpProcessListener listener,object args)
        {
            httpPostSync(uri, Encode.GetBytes(body), listener, args);
        }
        /// <summary> 异步发送http post请求 </summary>
        public static void httpPostSync(String uri, byte[] body, HttpProcessListener listener)
        {
            httpPostSync(uri, body, listener, null);
        }
        /// <summary> 异步发送http post请求 </summary>
        public static void httpPostSync(String uri, byte[] body, HttpProcessListener listener, object args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(httpPostThread));
            thread.Start(new object[] { uri, body, listener, args });
        }
        private static void httpPostThread(object arg)
        {
            object[] args = (object[])arg;
            HttpProcessListener listener = (HttpProcessListener)args[2];
            HttpProcessResult result = httpPost((String)args[0],(byte[])args[1]);
            if (listener != null) listener(result, args[3]);
        }
    }
}
