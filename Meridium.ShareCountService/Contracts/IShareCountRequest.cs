using System;

namespace Meridium.ShareCountService.Contracts
{
    public interface IShareCountRequest
    {
        Uri ServiceUri { get; set; }
        IShareCountResponse Response { get; set; }
        string GetResponse();
        void GetShares();
        void AssertResponse(IShareCountResponse response);
    }
}
