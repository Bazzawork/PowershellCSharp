namespace TenableApi;

using RestSharp;
using TenableApi.Models;

public class GetAgentGroups
{
    public async Task<RestResponse> GetGroupsAsync()
    {
        // https://blog.atavisticsoftware.com/2014/02/using-restsharp-to-deserialize-json.html
        var options = new RestClientOptions("https://cloud.tenable.com/scanners/null/agent-groups");
        var client = new RestClient(options);
        var request = new RestRequest("");
        request.AddHeader("accept", "application/json");
        request.AddHeader();
        var response = await client.GetAsync(request);
        return response;
		// Console.WriteLine("{0}", response.Content);
    }
}
