using System.Runtime.Serialization;
using Meridium.ShareCountService.Contracts;

namespace Meridium.ShareCountService.ResponseTypes
{
    [DataContract]
    public class FacebookResponse : IShareCountResponse
    {
        [DataMember(Name = "Shares")]
        public string Count { get; set; }

        [DataMember(Name = "Id")]
        public string Key { get; set;}

        public ResponseService Service
        {
            get
            {
                return  ResponseService.Facebook;
            }
        }
    }
}
