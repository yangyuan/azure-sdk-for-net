// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> SSL certificate email. </summary>
    public partial class CertificateEmail : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of CertificateEmail. </summary>
        public CertificateEmail()
        {
        }

        /// <summary> Initializes a new instance of CertificateEmail. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="emailId"> Email id. </param>
        /// <param name="timeStamp"> Time stamp. </param>
        internal CertificateEmail(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string emailId, DateTimeOffset? timeStamp) : base(id, name, resourceType, systemData, kind)
        {
            EmailId = emailId;
            TimeStamp = timeStamp;
        }

        /// <summary> Email id. </summary>
        public string EmailId { get; set; }
        /// <summary> Time stamp. </summary>
        public DateTimeOffset? TimeStamp { get; set; }
    }
}
