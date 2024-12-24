using MongoDB.Entities;
using SearchService.Models;

namespace SearchService.Services
{
    public class AuctionSvcHttpClient
    {
        public HttpClient _httpClient;
        public IConfiguration _config;
        public AuctionSvcHttpClient(HttpClient httpClient, IConfiguration config)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<List<Item>> GetItemsForSearchDb()
        {
            var lastUpdated = await DB.Find<Item, string>()
                    .Sort(x => x.Descending(a => a.UpdatedAt))
                    .Project(x => x.UpdatedAt.ToString())
                    .ExecuteFirstAsync();

            Console.WriteLine("Last updated: " + lastUpdated);

            if (string.IsNullOrEmpty(lastUpdated))
            {
                lastUpdated = string.Empty;
            }
            return await _httpClient.GetFromJsonAsync<List<Item>>(_config["AuctionServiceUrl"] 
                    + "/api/auctions?date=" + lastUpdated);
        }
    }
}