using System.Runtime.Serialization;

namespace HubSpot.NET.Api
{
    public class AssociationLabelTypes
    {
        [DataMember(Name = "associationCategory")]
        public AssociationCategoryTypes AssociationCategory { get; set; }

        [DataMember(Name = "associationTypeId")]
        public int AssociationTypeId { get; set; }
    }

    public enum AssociationCategoryTypes { USER_DEFINED, HUBSPOT_DEFINED }
}
