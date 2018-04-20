using System.Net.Http;
using System.Threading.Tasks;

namespace HGame.Helpers
{
    public class HttpHelper
    {
        public static async Task<string> GetContentAsync(string url)
        {
            HttpClient client = new HttpClient();
            var getContent = await client.GetAsync(url).ConfigureAwait(false);
            var content = getContent.Content;
            var data = await content.ReadAsStringAsync().ConfigureAwait(false);
            client.Dispose();
            getContent.Dispose();
            content.Dispose();
            return data;
        }

        public static HttpClient Client = new HttpClient();
    }
}
