using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Hotel.Modelo
{
    public class Conexion<T>
    {

        private readonly string _UrlBase = "http://localhost:5029/api/";

        public async Task<ResponseDTO<List<T>>> Get(string url) {

            try {

                // Create an HttpClient object
                HttpClient client = new HttpClient();

                // Create a GET request
                HttpResponseMessage response = await client.GetAsync(_UrlBase + url);

                // Get the response body
                string body = await response.Content.ReadAsStringAsync();

                // Parse the response body as JSON
                var products = JsonConvert.DeserializeObject<ResponseDTO<List<T>>>(body)!;

                return products;
            }
            catch (Exception) 
            { 
                throw; 
            }     
        }

        public async Task<ResponseDTO<T>> Post(string url , object post)
        {
            try {
                HttpClient client = new HttpClient();

                string jsonPost = JsonConvert.SerializeObject(post);
                var httpContent = new StringContent(jsonPost, Encoding.UTF8, "application/json");

                // Create a POST request
                HttpResponseMessage response = await client.PostAsync(_UrlBase + url, httpContent);

                string body = await response.Content.ReadAsStringAsync();

                // Parse the response body as JSON
                var products = JsonConvert.DeserializeObject<ResponseDTO<T>>(body)!;

                // Close the client
                client.Dispose();

                return products;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ResponseDTO<bool>> Update(string url, object post)
        {
            try
            {
                HttpClient client = new HttpClient();

                string jsonPost = JsonConvert.SerializeObject(post);
                var httpContent = new StringContent(jsonPost, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(_UrlBase + url, httpContent);

                string body = await response.Content.ReadAsStringAsync();

                var products = JsonConvert.DeserializeObject<ResponseDTO<bool>>(body)!;

                client.Dispose();

                return products;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ResponseDTO<bool>> Delete(string url)
        {
            try
            {
                HttpClient client = new HttpClient();

                // Create a POST request
                HttpResponseMessage response = await client.DeleteAsync(_UrlBase + url);

                string body = await response.Content.ReadAsStringAsync();

                // Parse the response body as JSON
                var products = JsonConvert.DeserializeObject<ResponseDTO<bool>>(body)!;

                // Close the client
                client.Dispose();

                return products;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
