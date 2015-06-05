using System;
using Meridium.ShareCountService.Requests;
using NUnit.Framework;

namespace Meridium.ShareCountService.Tests
{
    [TestFixture]
    public class RequestTests
    {
        [Test]
        public void facebook_should_throw_argument_null_exception_by_empty_string()
        {
            Assert.Throws<ArgumentNullException>(() => new FacebookRequest(string.Empty));
        }

        [Test]
        public void facebook_should_throw_argument_null_exception_by_null_value()
        {
            Assert.Throws<ArgumentNullException>(() => new FacebookRequest(null));
        }

        [Test]
        public void twitter_should_throw_argument_null_exception_by_empty_string()
        {
            Assert.Throws<ArgumentNullException>(() => new TwitterRequest(string.Empty));
        }

        [Test]
        public void twitter_should_throw_argument_null_exception_by_null_value()
        {
            Assert.Throws<ArgumentNullException>(() => new TwitterRequest(null));
        }
    }
}
