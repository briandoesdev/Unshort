using System.Net.Http.Headers;

namespace Unshort {
    public class Program {
        private static HttpClient? client;

        static void Main(string[] args) {
            InitiateHttpClient();
            foreach (var item in args)
            {
                string url = item;
                if (!url.StartsWith(value: "http")) {
                    url = $"https://{item}";
                }
                ConvertToLongUrl(shortUrl: url);
            }
        }

        private static void InitiateHttpClient()
        {
            HttpClientHandler clientHandler = new HttpClientHandler() {
                AllowAutoRedirect = false
            };

            client = new HttpClient(handler: clientHandler) {
                Timeout = TimeSpan.FromSeconds(5)
            };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(item: new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add(name: "User-Agent", value: "nurl");
        }

        private static void ConvertToLongUrl(string shortUrl) {
            try {
                var resp = client!.GetAsync(requestUri: shortUrl).ConfigureAwait(false).GetAwaiter().GetResult();
                IEnumerable<string>? locationHeader;
                if (resp.Headers.TryGetValues(name: "Location", values: out locationHeader)) {
                    Console.WriteLine(value: locationHeader.First());
                } else {
                    Console.WriteLine(value: shortUrl);
                }
            }
            catch (TaskCanceledException) {
                if (shortUrl.StartsWith("https")) {
                    string httpShortUrl = shortUrl.Remove(4, 1);
                    ConvertToLongUrl(httpShortUrl);
                }
                else {
                    Console.WriteLine(value: $"Exception: Request timeout for {shortUrl}");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(value: $"Unexpected exception: {ex.Message}");
            }
        }
    }
}
