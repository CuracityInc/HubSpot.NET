﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using HubSpot.NET.Core.Interfaces;

namespace HubSpot.NET.Api.EmailSubscriptions.Dto
{
    public class SubscriptionStatusHubSpotModel : IHubSpotModel
    {
        [DataMember(Name = "subscribed")]
        public bool Subscribed { get; set; }

        [DataMember(Name = "markedAsSpam")]
        public bool MarkedAsSpam { get; set; }

        [DataMember(Name = "bounced")]
        public bool Bounced { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "subscriptionStatuses")]
        public List<SubscriptionStatusDetailHubSpotModel> SubscriptionStatuses { get; set; }

        [IgnoreDataMember]
        public bool IsNameValue { get; }

        public void ToHubSpotDataEntity(ref dynamic dataEntity)
        {
        }

        public void FromHubSpotDataEntity(dynamic hubspotData)
        {
        }

        [IgnoreDataMember]
        public string RouteBasePath => "/email/public/v1";
    }
}