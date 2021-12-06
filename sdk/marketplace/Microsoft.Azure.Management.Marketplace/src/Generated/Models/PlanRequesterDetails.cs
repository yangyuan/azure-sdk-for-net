// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Marketplace.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Plan with requesters details
    /// </summary>
    public partial class PlanRequesterDetails
    {
        /// <summary>
        /// Initializes a new instance of the PlanRequesterDetails class.
        /// </summary>
        public PlanRequesterDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PlanRequesterDetails class.
        /// </summary>
        /// <param name="planId">Gets the plan id</param>
        /// <param name="planDisplayName">Gets the plan display name</param>
        /// <param name="requesters">Gets requesters details list</param>
        public PlanRequesterDetails(string planId = default(string), string planDisplayName = default(string), IList<UserRequestDetails> requesters = default(IList<UserRequestDetails>))
        {
            PlanId = planId;
            PlanDisplayName = planDisplayName;
            Requesters = requesters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the plan id
        /// </summary>
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; private set; }

        /// <summary>
        /// Gets the plan display name
        /// </summary>
        [JsonProperty(PropertyName = "planDisplayName")]
        public string PlanDisplayName { get; private set; }

        /// <summary>
        /// Gets requesters details list
        /// </summary>
        [JsonProperty(PropertyName = "requesters")]
        public IList<UserRequestDetails> Requesters { get; private set; }

    }
}
