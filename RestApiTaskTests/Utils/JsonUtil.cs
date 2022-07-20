using Newtonsoft.Json;
using RestSharp;

namespace RestApiTaskTests.Utils
{
   public static class JsonUtil
    {
        public static T DeserializePosts<T>(Task<RestResponse> response)
        {
            string jsonString = response.Result.Content.ToString();
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
        public static List<T> DeserializeToList<T>(Task<RestResponse> response)
        {
            string jsonString = response.Result.Content.ToString();
            return JsonConvert.DeserializeObject<List<T>>(jsonString);
        }

        public static void JsonWriter(Task<RestResponse> response, string fileName)
        {
            string jsonString = response.Result.Content.ToString();
            File.WriteAllText(fileName, jsonString);
        }
        public static T DeserializeFromFile<T>(string jsonPath)
        {
            string jsonFileName = Directory.GetCurrentDirectory() + jsonPath;
            string jsonString = File.ReadAllText(jsonFileName);
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}
