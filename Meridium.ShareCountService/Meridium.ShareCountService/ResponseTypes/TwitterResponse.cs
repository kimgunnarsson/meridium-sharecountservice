using System.Runtime.Serialization;
using Meridium.ShareCountService.Contracts;

namespace Meridium.ShareCountService.ResponseTypes
{
    [DataContract]
    public class TwitterResponse : IShareCountResponse
    {
        [DataMember(Name = "Count")]
        public string Count { get; set; }

        [DataMember(Name = "Url")]
        public string Key { get; set;}

        [DataMember]
        public ResponseService Service
        {
            get
            {
                return ResponseService.Twitter;
            }
        }
    }
}
