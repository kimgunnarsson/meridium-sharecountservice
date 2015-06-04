using System;
using System.Net;
using Meridium.ShareCountService.Contracts;

namespace Meridium.ShareCountService.Requests
{
    public abstract class ShareCountRequest : IShareCountRequest
    {
        protected abstract string ServiceEndPoint { get; }
        public abstract IShareCountResponse Response { get; set; }

        public string Key { get; set; }
        public Uri ServiceUri { get; set; }

        private void ConcatUri()
        {
            ServiceUri = new Uri(ServiceEndPoint + Key);
        }

        public string GetResponse()
        {
            ConcatUri();

            using (var webClient = new WebClient())
            {
                return webClient.DownloadString(ServiceUri);
            }
        }

        public abstract void GetShares();
        public abstract void AssertResponse(IShareCountResponse response);
    }
}
