using RestApiTaskTests.Models;
using RestApiTaskTests.Utils;


namespace RestApiTaskTests.TestSetting
{
    public static class Provider
    {
        private const string pathTestSet = @"\TestSetting\TestSettings.json";
        private const string pathUser = @"\TestSetting\User5.json";
        public static TestSettings InitializeTestData()
        {
          return JsonUtil.DeserializeFromFile<TestSettings>(pathTestSet);
        }
        public static UsersModel InitializeUserData()
        {
            return JsonUtil.DeserializeFromFile<UsersModel>(pathUser);
        }
    }
}
