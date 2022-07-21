using System.Text.Json;

namespace L2Task1.Utils
{ 
    public static class JsonUtil
    {
        public static T DeserializeData<T>(string jsonPath) 
        {
            string jsonFileName = Directory.GetCurrentDirectory() +jsonPath;
            string jsonString = File.ReadAllText(jsonFileName);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
        
    }
}

