using L2Task1.TestSettings.Models;
using L2Task1.Utils;

namespace L2Task1.TestSettings
{
    public static class Provider
    {
        public static TestSetting InitializeTestData()
        {
            return JsonUtil.DeserializeData<TestSetting>(@"\TestSettings\TestSetting.json");
        }
     
    }
}
