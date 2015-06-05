using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Meridium.ShareCountService.Contracts;

namespace Meridium.ShareCountService
{
    [DataContract]
    public class ShareCountResponse : IEnumerable<IShareCountConcatResponse>
    {
        internal readonly List<IShareCountConcatResponse> Values;

        public ShareCountResponse()
        {
            Values = new List<IShareCountConcatResponse>();
        }

        public IEnumerator<IShareCountConcatResponse> GetEnumerator()
        {
            return Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(IShareCountConcatResponse response)
        {
            Values.Add(response);
        }
    }
}
