namespace AITech.WebUI.Helpers
{
    public static class HttpClientInstance
    {
        private static readonly HttpClient _client = new()
        {
            BaseAddress = new Uri("https://localhost:7074/api/")
        };

        public static HttpClient Client => _client;
    }
}
