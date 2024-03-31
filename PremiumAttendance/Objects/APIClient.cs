using System;
using System.Configuration;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PremiumAttendance.Objects
{
    public class APIClient
    {
        private HttpClient client;
        public APIClient()
        {
            this.client = new HttpClient();
        }

        public async Task<SvatkyAPIObject> GetJsonResponse()
        {
            string path = ConfigurationManager.AppSettings["apiURL"];
            try
            {
                HttpResponseMessage response = await this.client.GetAsync(path);
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();

                SvatkyAPIObject svatek = JsonSerializer.Deserialize<SvatkyAPIObject>(jsonResponse);

                return svatek;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
