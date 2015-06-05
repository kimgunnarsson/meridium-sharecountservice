using System;
using System.Net;
using Meridium.ShareCountService.Contracts;
using Meridium.ShareCountService.ResponseTypes;
using Newtonsoft.Json;

namespace Meridium.ShareCountService.Requests
{
    public class FacebookRequest : ShareCountRequest
    {
        protected override string ServiceEndPoint
        {
            get { return "http://graph.facebook.com/";  }
        }

        public override IShareCountResponse Response { get; set; }

        public override void GetShares()
        {
            try
            {
                var response = GetResponse();
                AssertResponse(JsonConvert.DeserializeObject<FacebookResponse>(response));
            }
            catch (WebException webException)
            {
                AssertResponse(null);
            }
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

        public FacebookRequest(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException(key);
            }

            Key = key;
        }

    }
}
