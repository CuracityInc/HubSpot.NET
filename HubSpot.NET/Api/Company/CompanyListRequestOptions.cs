﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api.Company
{
    /// <summary>
    /// Options used when searching for companies by domain.
    /// </summary>
    [DataContract]
    public class CompanySearchByDomain
    {
        [DataMember(Name = "limit")]
        public int Limit { get; set; } = 100;

        [DataMember(Name = "requestOptions")]
        public CompanySearchByDomainRequestOptions RequestOptions { get; set; } = new CompanySearchByDomainRequestOptions();

        [DataMember(Name = "offset")]
        public CompanySearchOffset Offset { get; set; } = new CompanySearchOffset();

        public string RouteBasePath => "/companies/v2";
        public bool IsNameValue => true;
        public void AcceptHubSpotDataEntity(ref object converted)
        {

        }
    }

    [DataContract]
    public class CompanySearchByDomainRequestOptions
    {
        [DataMember(Name = "properties")]
        public List<string> Properties { get; set; } = new List<string> { "domain", "name", "website" };
    }

    [DataContract]
    public class CompanySearchOffset
    {

        [DataMember(Name = "isPrimary")]
        public bool IsPrimary { get; set; } = true;

        [DataMember(Name = "companyId")]
        public long CompanyId { get; set; }
    }

}
