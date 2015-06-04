using Meridium.ShareCountService.Requests;
using Meridium.ShareCountService.ResponseTypes;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Meridium.ShareCountService.Tests
{
    [TestFixture]
    public class ResponseTests
    {
        [Test]
        public void should_map_facebook_response()
        {
            var response = "{\"id\": \"http://www.dn.se\",\"shares\": 15431}";
            var mappedResponse = JsonConvert.DeserializeObject<FacebookResponse>(response);
            Assert.IsNotNull(mappedResponse);
        }

        [Test]
        public void should_return_facebook_response_service()
        {
            var response = "{\"id\": \"http://www.dn.se\",\"shares\": 15431}";
            var mappedResponse = JsonConvert.DeserializeObject<FacebookResponse>(response);
            Assert.True(mappedResponse.Service == ResponseService.Facebook);
        }

        [Test]
        public void should_return_facebook_response_empty()
        {
            var req = new FacebookRequest("key");
            req.AssertResponse(null);
            Assert.True(req.Response.Count == "0");
        }

        [Test]
        public void should_return_facebook_response_count_zero_fallback()
        {
            var req = new FacebookRequest("key");
            req.AssertResponse(new FacebookResponse()
            {
                Key = "Key",
                Count = null
            });

            Assert.True(req.Response.Count == "0");
        }

        [Test]
        public void should_map_twitter_response()
        {
            var response = "{\"count\":2180,\"url\":\"http:\\/\\/www.dn.se\\/\"}";
            var mappedResponse = JsonConvert.DeserializeObject<TwitterResponse>(response);
            Assert.IsNotNull(mappedResponse);
        }

        [Test]
        public void should_return_twitter_response_service()
        {
            var response = "{\"count\":2180,\"url\":\"http:\\/\\/www.dn.se\\/\"}";
            var mappedResponse = JsonConvert.DeserializeObject<TwitterResponse>(response);
            Assert.True(mappedResponse.Service == ResponseService.Twitter);
        }

        [Test]
        public void should_return_twitter_response_empty()
        {
            var req = new TwitterRequest("key");
            req.AssertResponse(null);
            Assert.True(req.Response.Count == "0");
        }

        [Test]
        public void should_return_twitter_response_count_zero_fallback()
        {
            var req = new TwitterRequest("key");
            req.AssertResponse(new TwitterResponse()
            {
                Key ="Key",
                Count = null
            });

            Assert.True(req.Response.Count == "0");
        }

    }
}
