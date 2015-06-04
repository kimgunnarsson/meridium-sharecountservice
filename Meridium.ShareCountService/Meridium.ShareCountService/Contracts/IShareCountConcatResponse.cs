using System.Collections.Generic;

namespace Meridium.ShareCountService.Contracts
{
    public interface IShareCountConcatResponse
    {
        string Key { get; set; }
        IEnumerable<KeyValuePair<string, string>> Counts { get; set; }
        double TotalCounts { get; set; }
    }
}
