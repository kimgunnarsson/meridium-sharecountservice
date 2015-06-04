using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Meridium.ShareCountService.Tests
{
    [TestFixture]
    public class ShareCountRequestTest
    {
        [Test]
        public void should_return_sharecount()
        {
            var service = new ShareCountService();
            var shareCount = service.GetShares("http://www.dn.se");
            Assert.IsNotNull(shareCount);
        }

        [Test]
        public void should_return_multiple_shares()
        {
            var service = new ShareCountService();
            var keys = new List<string> { "http://www.meridium.se", "http://www.cnn.com" };
            var response = service.GetShares(keys);
            var shareCount = response.ToList();
            Assert.True(shareCount.Count == 2);
        }

        [Test]
        public void shoud_return_sharecountresponse()
        {
            var service = new ShareCountService();
            var response = service.GetShares("http://www.dn.se");
            Assert.IsInstanceOf<ShareCountResponse>(response);
        }

    }
}
