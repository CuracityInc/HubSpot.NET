using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api
{
    public class BatchAssociationLabelsInputList
    {
        [DataMember(Name = "types")]
        public List<AssociationLabelTypes> Types { get; set; }

        [DataMember(Name = "from")]
        public AssociationObjectId From { get; set; }

        [DataMember(Name = "to")]
        public AssociationObjectId To { get; set; }
    }
}
