using System.Collections.Generic;
using System.Linq;
using Meridium.ShareCountService.Contracts;
using Meridium.ShareCountService.Requests;
using Meridium.ShareCountService.ResponseTypes;

namespace Meridium.ShareCountService
{
    public class ShareCountService : IShareCountService
    {
        private List<string> _keys;
        public IEnumerable<string> Keys
        {
            get
            {
                if (_keys != null)
                {
                    return _keys;
                }

                _keys = new List<string>();
                return _keys;
            }
        }

        public ShareCountResponse GetShares(IEnumerable<string> keys)
        {
            var response = new ShareCountResponse();
            foreach (var key in keys.ToList())
            {
                response.Add(Fetch(key));                
            }

            return response;
        }

        public ShareCountResponse GetShares(string key)
        {
            return new ShareCountResponse(){
                Fetch(key)
            };
        }

        public ConcatResponse Fetch(string key)
        {
            var facebookRequest = new FacebookRequest(key);
            var twitterRequest = new TwitterRequest(key);

            facebookRequest.GetShares();
            twitterRequest.GetShares();

            var concatResponse = new ConcatResponse
            {
                Key = key,
                TotalCounts = 0
            };

            var responseCounts = new Dictionary<string, string>();

            if (facebookRequest.Response != null)
            {
                responseCounts.Add(facebookRequest.Response.Service.ToString().ToLower(), facebookRequest.Response.Count);
                concatResponse.TotalCounts += double.Parse(facebookRequest.Response.Count);
            }

            if (twitterRequest.Response != null)
            {
                responseCounts.Add(twitterRequest.Response.Service.ToString().ToLower(), twitterRequest.Response.Count);
                concatResponse.TotalCounts += double.Parse(twitterRequest.Response.Count);
            }

            concatResponse.Counts = responseCounts;
            return concatResponse;
        }

    }
}
