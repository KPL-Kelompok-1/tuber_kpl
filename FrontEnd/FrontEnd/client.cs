using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd
{
    internal class client<T>
    {
        public client()
        {
        }

        public List<T> Get(string url)
        {
            var client = new HttpClient();
            var response = client.GetAsync(url).Result;
   /*         Console.WriteLine(response);*/
            try
            {
                var content = response.Content.ReadAsStringAsync().Result;
              
                List<T> forums = JsonConvert.DeserializeObject<List<T>>(content);
                if ((int)response.StatusCode == 405) {
                    throw new Exception(response.ReasonPhrase);
                    return null;
                }
                else
                if (forums == null)
                {
                    throw new Exception("No data found");
                    return null;
                }
                return forums;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
         
        }

        public string Post(string url, T obj)
        {
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(url, data).Result;
            Console.WriteLine(response);
            string content = response.Content.ReadAsStringAsync().Result;
            return content;
        }

        public string Put(string url, T obj)
        {
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PutAsync(url, data).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            return content;
        }

        public string Delete(string url)
        {
            var client = new HttpClient();
            var response = client.DeleteAsync(url).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            return content;
        }
    }
}
