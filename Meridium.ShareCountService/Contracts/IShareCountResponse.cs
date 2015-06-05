using Meridium.ShareCountService.ResponseTypes;

namespace Meridium.ShareCountService.Contracts
{
    public interface IShareCountResponse
    {
        string Key { get; set; }
        string Count { get; set; }
        ResponseService Service { get; }
    }
}
