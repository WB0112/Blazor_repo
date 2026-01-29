using Azure;
using Azure.Search.Documents;
using Azure.Search.Documents.Models;
namespace BlazorAzureOpenAI.Services
{


    public class SearchService
    {
        private readonly SearchClient _searchClient;

        public SearchService(IConfiguration config)
        {
            _searchClient = new SearchClient(
                new Uri(config["AzureSearch:Endpoint"]),
                config["AzureSearch:IndexName"],
                new AzureKeyCredential(config["AzureSearch:ApiKey"])
            );
        }

        public async Task<string> SearchAsync(float[] vector)
        {
            var options = new SearchOptions
            {
                Size = 5,
                VectorSearch = new()
                {
                    Queries =
                {
                    new VectorizedQuery(vector)
                    {
                        KNearestNeighborsCount = 5,
                        Fields = { "contentVector" }
                    }
                }
                }
            };

            var response = await _searchClient.SearchAsync<SearchDocument>("*", options);

            return string.Join("\n",
                response.Value.GetResults().Select(r => r.Document["content"]));
        }
    }
}
