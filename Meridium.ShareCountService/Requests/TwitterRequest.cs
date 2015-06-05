using System;
using Meridium.ShareCountService.Contracts;
using Meridium.ShareCountService.ResponseTypes;
using Newtonsoft.Json;

namespace Meridium.ShareCountService.Requests
{
    public class TwitterRequest : ShareCountRequest
    {
        protected override string ServiceEndPoint
        {
            get { return "http://urls.api.twitter.com/1/urls/count.json?url="; }
        }

        public override IShareCountResponse Response { get; set; }

        public override void GetShares()
        {
            var response = GetResponse();
            AssertResponse(JsonConvert.DeserializeObject<TwitterResponse>(response));
        }

        public override void AssertResponse(IShareCountResponse response)
        {
            if (response == null)
            {
                response = new TwitterResponse()
                {
                    Count = "0",
                    Key = Key
                };
            }

            if (string.IsNullOrEmpty(response.Count))
            {
                response.Count = "0";
            }

            Response = response;
        }

        public TwitterRequest(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(key);
            }

            Key = key;
        }

    }
}
