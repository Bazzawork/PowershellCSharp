using RestSharp;


using TenableApi.Models;

namespace TenableApi.Models
{
    public class Groups
    {
        public List<Group> GroupsList { get; set; } = new List<Group>();
        public int Total { get; set; }
        public int Offset { get; set; }
        public int Count { get; set; }

        public static async Task<Groups> GetGroupsAsync(string apiKey, string apiSecret)
        {
            var options = new RestClientOptions("https://cloud.tenable.com/scanners/null/agent-groups")
            {
                ThrowOnAnyError = true,
                Timeout = 3000
            };
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("X-ApiKeys", $"accessKey={apiKey}; secretKey={apiSecret}");
            var response = await client.GetAsync<Groups>(request);
            return response;
        }
    }
}   