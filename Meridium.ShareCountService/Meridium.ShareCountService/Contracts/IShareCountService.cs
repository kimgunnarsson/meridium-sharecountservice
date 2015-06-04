using System.Collections.Generic;

namespace Meridium.ShareCountService.Contracts
{
    public interface IShareCountService
    {
        ShareCountResponse GetShares(string key);
        ShareCountResponse GetShares(IEnumerable<string> keys);
    }
}
