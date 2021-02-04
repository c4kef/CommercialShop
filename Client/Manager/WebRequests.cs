using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;

namespace Client.Manager
{
    class WebRequests
    {
        private List<object> tmpBufferValue;
        private List<string> tmpBufferName;
        private Uri target;

        public WebRequests(string address)
        {
            tmpBufferValue = new List<object>();
            tmpBufferName = new List<string>();
            target = new Uri(address);
        }

        public void Add(string Name, object Value, bool encrypt = false)
        {
            tmpBufferName.Add(Name);
            tmpBufferValue.Add((encrypt) ? Security.Encrypt(Value.ToString()) : Value);
        }

        public void Clear()
        {
            tmpBufferName.Clear();
            tmpBufferValue.Clear();
        }

        public string Send(bool decryptRequest = false)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(target);
            request.Method = "POST";
            string s = "";
            for (int i = 0; i < tmpBufferName.Count; i++)
            {
                object[] textArray1 = new object[] { s, tmpBufferName[i], "=", tmpBufferValue[i], "&" };
                s = string.Concat(textArray1);
            }
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = (long)bytes.Length;
            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(bytes, 0, bytes.Length);
            }
            WebResponse response = request.GetResponse();
            string str2 = "";
            using (Stream stream2 = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream2))
                {
                    str2 = reader.ReadToEnd();
                }
            }
            response.Close();
            return (decryptRequest) ? Security.Decrypt(str2) : str2;
        }
    }
}
