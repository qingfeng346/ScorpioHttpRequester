using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace ScorpioHttpRequester {
    public partial class Form1 : Form {
        private static readonly Encoding Encode = Encoding.UTF8;
        private delegate void Action();
        private List<string> m_Urls = new List<string>();
        private List<string> m_ContentBaseTypes = new List<string>() {
            "text/plain",
            "text/html",
            "application/json",
            "application/xml",
            "application/rdf+xml",
            "application/x-www-form-urlencoded",
        };
        private List<string> m_ContentTypes = new List<string>();
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            tabControl1.TabPages[0].Text = "Content";
            if (File.Exists("./urls")) {
                m_Urls.AddRange(Encode.GetString(File.ReadAllBytes("./urls")).Split('\n'));
            }
            foreach (var url in m_Urls) { urlText.Items.Add(url); }
            if (urlText.Items.Count > 0) urlText.Text = (string)urlText.Items[0];
            if (File.Exists("./contenttypes")) {
                m_ContentTypes.AddRange(Encode.GetString(File.ReadAllBytes("./contenttypes")).Split('\n'));
            } else {
                m_ContentTypes.AddRange(m_ContentBaseTypes);
            }
            if (File.Exists("./content")) {
                contentText.Text = Encode.GetString(File.ReadAllBytes("./content"));
            }
            foreach (var contenttype in m_ContentTypes) { contentTypeText.Items.Add(contenttype); }
            if (contentTypeText.Items.Count > 0) contentTypeText.Text = (string)contentTypeText.Items[0];
        }
        private void Save() {
            string url = urlText.Text;
            m_Urls.Remove(url);
            m_Urls.Insert(0, url);
            File.WriteAllBytes("./urls", Encode.GetBytes(string.Join("\n", m_Urls.ToArray())));
            string contentType = contentTypeText.Text;
            if (!contentTypeText.Items.Contains(contentType)) { contentTypeText.Items.Insert(0, contentType); }
            m_ContentTypes.Remove(contentType);
            m_ContentTypes.Insert(0, contentType);
            File.WriteAllBytes("./contenttypes", Encode.GetBytes(string.Join("\n", m_ContentTypes.ToArray())));
            if (!string.IsNullOrEmpty(contentText.Text))
                File.WriteAllBytes("./content", Encode.GetBytes(contentText.Text));
        }
        private void Exec(Action action) {
            Invoke(action);
        }
        private string toString(Stream stream) {
            if (stream == null) return "";
            return Encode.GetString(toByteArray(stream));
        }
        /// <summary> 字节流转成byte[] </summary>
        private byte[] toByteArray(Stream stream) {
            if (stream == null) return null;
            MemoryStream result = new MemoryStream();
            int length = 0;
            byte[] bytes = new byte[8192];
            while ((length = stream.Read(bytes, 0, 8192)) > 0) {
                result.Write(bytes, 0, length);
            }
            return result.ToArray();
        }
        private void SetData(HttpWebResponse response) {
            statusLabel.Text = "Status : " + response.ProtocolVersion.ToString() + " " + (int)response.StatusCode + " " + response.StatusDescription;
            if (response.StatusCode >= HttpStatusCode.OK && response.StatusCode < HttpStatusCode.Ambiguous) {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("State :");
                builder.AppendLine("        Method : " + response.Method);
                builder.AppendLine("        Url : " + response.ResponseUri.ToString());
                builder.AppendLine("        CharacterSet : " + response.CharacterSet);
                builder.AppendLine("        ContentEncoding : " + response.ContentEncoding);
                builder.AppendLine("Headers :");
                var heads = response.Headers.AllKeys;
                foreach (var head in heads) {
                    builder.AppendLine("        " + head + " : " + response.Headers.Get(head));
                }
                statusText.Text = builder.ToString();
                resultText.Text = toString(response.GetResponseStream());
            } else {
                resultText.Text = "";
            }
        }
        private void buttonGet_Click(object sender, EventArgs e) {
            string url = urlText.Text;
            if (string.IsNullOrEmpty(url)) {
                MessageBox.Show("请输入url");
                return;
            }
            Save();
            Thread thread = new Thread(() => {
                try {
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.Timeout = 30000;                    //设定超时时间30秒
                    HttpWebResponse response = null;
                    try {
                        response = (HttpWebResponse)request.GetResponse(); ;
                    } catch (WebException ex) {
                        response = (HttpWebResponse)ex.Response;
                    }
                    Exec(() => { SetData(response); });
                    response.Close();
                } catch (Exception ex) { 
                    Exec(() => { resultText.Text = "请求出错 : " + ex.ToString(); });
                }
            });
            thread.Start();
        }
        private void buttonPost_Click(object sender, EventArgs e) {
            string url = urlText.Text;
            if (string.IsNullOrEmpty(url)) {
                MessageBox.Show("请输入url");
                return;
            }
            string content = contentText.Text; 
            string contentType = contentTypeText.Text;
            Save();
            Thread thread = new Thread(() => {
                try {
                    byte[] body = Encode.GetBytes(content);
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                    request.Timeout = 3000;                     //设定超时时间30秒
                    request.Method = "POST";                    //POST类型
                    request.ContentType = contentType;          //ContentType
                    request.ContentLength = body.Length;        //发送数据长度
                    Stream stream = request.GetRequestStream(); //获得操作流
                    stream.Write(body, 0, body.Length);
                    stream.Close();
                    HttpWebResponse response = null;
                    try {
                        response = (HttpWebResponse)request.GetResponse();
                    } catch (WebException ex) {
                        response = (HttpWebResponse)ex.Response;
                    }
                    Exec(() => { SetData(response); });
                    response.Close();
                } catch (Exception ex) {
                    Exec(() => { resultText.Text = "请求出错 : " + ex.ToString(); });
                }
            });
            thread.Start();
        }

        private void buttonUrlEncode_Click(object sender, EventArgs e) {
            string text = resultText.Text;
            if (string.IsNullOrEmpty(text)) { return; }
            resultText.Text = Commons.Util.UriTranscoder.URLEncode(text, Encoding.UTF8);
        }

        private void buttonUrlDecode_Click(object sender, EventArgs e) {
            string text = resultText.Text;
            if (string.IsNullOrEmpty(text)) { return; }
            resultText.Text = Commons.Util.UriTranscoder.URLDecode(text, Encoding.UTF8);
        }
    }
}
