namespace DictionaryLetterCounter
{
    public class HtmlHttp
    {
        private readonly HttpClient _httpClient;

        public HtmlHttp(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient)); 
        }

        public async Task<string> GetHtmlAsStringAsync(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var htmlContent = await response.Content.ReadAsStringAsync();

                return htmlContent;
            }
            catch (HttpRequestException e)
            {
                throw new Exception($"Error while fetching URL {url}: {e.Message}", e);
            }
            catch (TaskCanceledException e)
            {
                throw new Exception($"Request timeout for URL {url}: {e.Message}", e);
            }
            catch (Exception e)
            {
                throw new Exception($"An unexpected error occurred: {e.Message}", e);
            }
        }
    }
}
