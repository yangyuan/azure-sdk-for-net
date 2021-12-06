// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The response of the List Namespace operation. </summary>
    internal partial class EventHubNamespaceListResult
    {
        /// <summary> Initializes a new instance of EventHubNamespaceListResult. </summary>
        internal EventHubNamespaceListResult()
        {
            Value = new ChangeTrackingList<EventHubNamespaceData>();
        }

        /// <summary> Initializes a new instance of EventHubNamespaceListResult. </summary>
        /// <param name="value"> Result of the List Namespace operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of namespaces. </param>
        internal EventHubNamespaceListResult(IReadOnlyList<EventHubNamespaceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the List Namespace operation. </summary>
        public IReadOnlyList<EventHubNamespaceData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of namespaces. </summary>
        public string NextLink { get; }
    }
}
