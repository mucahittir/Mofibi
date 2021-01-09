using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TasarimWebSayfa.Models
{
    public class Requester
    {
        public HttpClient client;

        public Requester()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://bruhmomentissuchamomentthat.pagekite.me/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
            client.DefaultRequestHeaders.UserAgent.ParseAdd("bepsi");

            client.Timeout = TimeSpan.FromSeconds(3);

            //BUNA HİÇ GEREK YOK GALİBA EN SON ÇÖZÜM BUNU KULLAN HATA ALIRSAN
            //ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }

        public async Task<HttpResponseMessage> GETAsync(string url = "")
        {
            try
            {
                var response = await client.GetAsync(url);
                return response;
            }
            catch (Exception e)
            {
                //Logger.WriteColor1(e.Message);
                return null;
            }
        }


        public async Task<HttpResponseMessage> POSTAsync(string url = "", string postData = "")
        {
            Dictionary<string, string> dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(postData);
            var data = new FormUrlEncodedContent(dict);

            try
            {
                var response = await client.PostAsync(url, data);
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               // throw new Exception();
                return null;
            }

        }


        public HttpResponseMessage PUT(string url = "", string postData = "", bool IsQuery = false)
        {
            try
            {
                HttpContent data = _manageData(postData);
                var response = client.PutAsync(url, data);
                return response.Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        HttpContent _manageData(string postData)
        {
            if (!true)
            {
                return new StringContent(postData, Encoding.UTF8, "multipart/form-data");//"application/json"
            }
            else
            {
                Dictionary<string, string> dict =
         JsonConvert.DeserializeObject<Dictionary<string, string>>(postData);
                return new FormUrlEncodedContent(dict);

            }

        }

    }


}