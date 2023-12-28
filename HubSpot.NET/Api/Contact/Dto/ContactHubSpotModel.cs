﻿using System;
using System.Runtime.Serialization;
using HubSpot.NET.Core.Interfaces;

namespace HubSpot.NET.Api.Contact.Dto
{
    /// <summary>
    /// Models a Contact entity within HubSpot. Default properties are included here
    /// with the intention that you'd extend this class with properties specific to 
    /// your HubSpot account.
    /// </summary>
    [DataContract]
    public class ContactHubSpotModel : IHubSpotModel
    {
        /// <summary>
        /// Contacts unique ID in HubSpot
        /// </summary>
        [DataMember(Name = "vid")]
        [IgnoreDataMember]
        public long? VId { get; set; }
        [DataMember(Name = "hs_object_id")]
        [IgnoreDataMember]
        public long? HSObjectId { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "firstname")]
        public string FirstName { get; set; }
        [DataMember(Name = "lastname")]
        public string LastName { get; set; }
        [DataMember(Name = "website")]
        public string Website { get; set; }
        [DataMember(Name = "company")]
        public string Company { get; set; }
        [DataMember(Name = "phone")]
        public string Phone { get; set; }
        [DataMember(Name = "address")]
        public string Address { get; set; }
        [DataMember(Name = "city")]
        public string City { get; set; }
        [DataMember(Name = "state")]
        public string State { get; set; }
        [DataMember(Name = "zip")]
        public string ZipCode { get; set; }

        [DataMember(Name="associatedcompanyid")]
        public long? AssociatedCompanyId { get; set; }

        [DataMember(Name="hubspot_owner_id")]
        public long? OwnerId { get; set; }

        [DataMember(Name = "createdAt")]
        [IgnoreDataMember]
        public DateTime? CreatedAt { get; set; }

        [DataMember(Name = "updatedAt")]
        [IgnoreDataMember]
        public DateTime? UpdatedAt { get; set; }

        [IgnoreDataMember]
        public ContactHubSpotAssociations Associations { get; set; }

        public string RouteBasePath => "/contacts/v1";
        public bool IsNameValue => false;
        public virtual void ToHubSpotDataEntity(ref dynamic converted)
        {

        }

        public virtual void FromHubSpotDataEntity(dynamic hubspotData)
        {
            
        }

        /// <summary>
        /// Set the Id based on whether or not the hs_object_id or vid are present
        /// </summary>
        [DataMember(Name = "id")]
        public long? Id
        {
            get
            {
                if (HSObjectId.HasValue)
                {
                    return HSObjectId;
                }
                else if (VId.HasValue)
                {
                    return VId;
                }
                else
                {
                    return null;
                }
            }
            set { }
        }
    }
}
