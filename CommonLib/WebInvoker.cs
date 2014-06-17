using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib
{
    public class WebInvoker
    {
        public delegate void OnComplete(object sender, InvokerEventArgs e);
        //public event InvokerEventArgs OnStoreComplete;
        public class InvokerEventArgs : EventArgs
        {
            public string Message;
            public bool ErrorState;
        }

        public void GenerateRequest(string postContentString)
        {
            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = postContentString;
                byte[] data = encoding.GetBytes(postData);

                WebRequest request = WebRequest.Create("http://localhost/webservice/sendChat.php");
                //WebRequest request = WebRequest.Create("http://www.negombotrips.com/tistus/testdata.php");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                WebResponse response = request.GetResponse();
                stream = response.GetResponseStream();

                StreamReader sr = new StreamReader(stream);
                string returnMessage = sr.ReadToEnd();

                InvokerEventArgs e = new InvokerEventArgs();
                e.ErrorState = false;
                e.Message = returnMessage;

                //OnStoreComplete +=

                sr.Close();
                stream.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GenerateRequestString(string postContentString)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = postContentString;
            byte[] data = encoding.GetBytes(postData);

            WebRequest request = WebRequest.Create("http://localhost/webservice/sendChat.php");
            //WebRequest request = WebRequest.Create("http://www.negombotrips.com/tistus/testdata.php");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();

            WebResponse response = request.GetResponse();
            stream = response.GetResponseStream();

            StreamReader sr = new StreamReader(stream);
            string returnMessage = sr.ReadToEnd();

            sr.Close();
            stream.Close();

            return returnMessage;
        }

        public string GetInfomation()
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            string postData = "";
            byte[] data = encoding.GetBytes(postData);

            WebRequest request = WebRequest.Create("http://localhost/webservice/getHistory.php");
            //WebRequest request = WebRequest.Create("http://www.negombotrips.com/tistus/testdata.php");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            Stream stream = request.GetRequestStream();
            stream.Write(data, 0, data.Length);
            stream.Close();

            WebResponse response = request.GetResponse();
            stream = response.GetResponseStream();

            StreamReader sr = new StreamReader(stream);
            string returnMessage = sr.ReadToEnd();

            sr.Close();
            stream.Close();

            return returnMessage;
        }
    }
}
