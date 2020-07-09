﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using HubSpot.NET.Core.Interfaces;

namespace HubSpot.NET.Api.Company.Dto
{
    public class CompanySearchHubSpotModel<T> : IHubSpotModel where T : CompanyHubSpotModel, new()
    {

        [DataMember(Name = "total")]
        public long Total { get; set; }

        [DataMember(Name = "paging")]
        public PagingModel Paging { get; set; }

        /// <summary>
        /// Gets or sets the <typeparamref name="T"/>.
        /// </summary>
        /// <value>
        /// The <typeparamref name="T"/>.
        /// </value>
        [DataMember(Name = "results")]
        public IList<T> Results { get; set; } = new List<T>();

        public string RouteBasePath => "/crm/v3/objects/companies";

        public bool IsNameValue => false;

        public virtual void ToHubSpotDataEntity(ref dynamic converted)
        {
        }

        public virtual void FromHubSpotDataEntity(dynamic hubspotData)
        {
        }
    }

    [DataContract]
    public class PagingModel
    {
        [DataMember(Name = "next")]
        public NextModel Next { get; set; }
    }

    [DataContract]
    public class NextModel
    {
        [DataMember(Name = "after")]
        public string After { get; set; }
    }
}
