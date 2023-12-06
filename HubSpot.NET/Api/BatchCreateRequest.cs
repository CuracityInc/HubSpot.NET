using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api
{
    [DataContract]
    public class BatchCreateRequest<T>
    {
        [DataMember(Name = "inputs")]
        public List<T> Inputs { get; set; }
    }
}
