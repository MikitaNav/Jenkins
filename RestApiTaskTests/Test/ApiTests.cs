using NUnit.Framework;
using RestApiTaskTests.Models;
using RestApiTaskTests.Utils;
using RestApiTaskTests.TestSetting;

namespace RestApiTaskTests.Test
{
    public class Tests 
    {
        [Test]
        public void ApiTests()
        {
            var postsUrl = ApiHelpUtil.SetUrl(Provider.InitializeTestData().postUrl);
            var responseCase1 = ApiHelpUtil.GetAllPosts(postsUrl);
            Assert.AreEqual(Provider.InitializeTestData().statusCode200, ApiHelpUtil.GetStatus(responseCase1), "Status in case 1 is different");
            var responseCase2 = ApiHelpUtil.GetPostById(postsUrl, Provider.InitializeTestData().post99Id);
            Assert.AreEqual(Provider.InitializeTestData().statusCode200, ApiHelpUtil.GetStatus(responseCase2), "Status in case2 is different");
            Assert.AreEqual(Provider.InitializeTestData().post99Id, JsonUtil.DeserializePosts<PostsModel>(responseCase2).id, "Id in case2 is different");
            Assert.IsNotEmpty(JsonUtil.DeserializePosts<PostsModel>(responseCase2).body, "Body in case2 is empty");
            var responseCase3 = ApiHelpUtil.GetPostById(postsUrl, Provider.InitializeTestData().post150Id);
            Assert.AreEqual(Provider.InitializeTestData().statusCode404, ApiHelpUtil.GetStatus(responseCase3), "Status in case 3 is different");
            Assert.IsNull(JsonUtil.DeserializePosts<PostsModel>(responseCase3).body,"Body in case 3 isn't null");
            var responseCase4 = ApiHelpUtil.PostData(postsUrl);
            Assert.AreEqual(Provider.InitializeTestData().statusCode201, ApiHelpUtil.GetStatus(responseCase4), "Status in case 4 isn't posted");
            Assert.AreEqual(Provider.InitializeTestData().post101Id, JsonUtil.DeserializePosts<PostsModel>(responseCase4).id, "Id in case 4 is different");
            var usersUrl = ApiHelpUtil.SetUrl("/users");
            var responseCase5 = ApiHelpUtil.GetAllPosts(usersUrl);
            Assert.AreEqual(Provider.InitializeTestData().statusCode200, ApiHelpUtil.GetStatus(responseCase5), "Status in case 5 is different");
            var actListUsersCase5 = JsonUtil.DeserializeToList<UsersModel>(responseCase5);
            var expListUserCase5 = Provider.InitializeUserData();
            Assert.AreEqual(expListUserCase5.id, actListUsersCase5[Provider.InitializeTestData().actualUser5Id].id,"Person in case5 is different");
            var responseCase6 = ApiHelpUtil.GetPostById(usersUrl, Provider.InitializeTestData().user5Id);
            var actListUserCase6 = JsonUtil.DeserializePosts<UsersModel>(responseCase6);
            Assert.AreEqual(Provider.InitializeTestData().statusCode200, ApiHelpUtil.GetStatus(responseCase6), "Status in case6 is different");
            Assert.AreEqual(expListUserCase5.id, actListUserCase6.id, "Person in case6 is different");
        }
    }
}