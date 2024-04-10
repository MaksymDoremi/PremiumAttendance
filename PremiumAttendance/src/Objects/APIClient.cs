using System;
using System.Configuration;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PremiumAttendance.objects
{
    /// <summary>
    /// Module used for retrieving data from svatkyapi.cz
    /// </summary>
    public class APIClient
    {
        private HttpClient client;

        public APIClient()
        {
            this.client = new HttpClient();
        }

        /// <summary>
        /// <para>Asyns method that request svatkyapi.cz for current holiday</para>
        /// <para>Format according to <see cref="SvatkyAPIObject"/></para>
        /// </summary>
        /// <returns><see cref="SvatkyAPIObject"/></returns>
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
