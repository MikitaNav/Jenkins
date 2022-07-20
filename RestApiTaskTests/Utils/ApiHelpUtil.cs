using System.Net;
using RestApiTaskTests.Models;
using RestSharp;

namespace RestApiTaskTests.Utils
{
    public static class ApiHelpUtil
    {
        private const string baseUrl = "https://jsonplaceholder.typicode.com";

        public static RestClient SetUrl(string resourceUrl)
        {
            var url = baseUrl + resourceUrl;
            return new RestClient(url);
        }
        public static async Task<RestResponse> GetAllPosts(RestClient client)
        {
            var request = new RestRequest();
            return await client.ExecuteAsync(request);
        }

        public static async Task<RestResponse> GetPostById(RestClient client, int id)
        {
            var request = new RestRequest($"/{id}");
            return await client.ExecuteAsync(request);
        }
        public static int GetStatus(Task<RestResponse> response)
        {
            HttpStatusCode statusCode = response.Result.StatusCode;
            int numericStatusCode = (int)statusCode;
            Console.WriteLine(numericStatusCode);
            return numericStatusCode;
        }

        public static Task<RestResponse> PostData(RestClient client)
        {
            var request = new RestRequest();
            var body = new PostsModel { body = "example_body", title = "AlexExample", UserId = 1};
            request.AddJsonBody(body);
            return client.PostAsync(request);

        }
    }
}
