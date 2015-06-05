using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Meridium.ShareCountService.Contracts;

namespace Meridium.ShareCountService.ResponseTypes
{
    [Serializable]
    [DataContract]
    public class ConcatResponse : IShareCountConcatResponse
    {
        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public IEnumerable<KeyValuePair<string, string>> Counts { get; set; }

        [DataMember]
        public double TotalCounts { get; set; }
    }
}
