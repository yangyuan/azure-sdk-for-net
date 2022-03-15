// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> The descendant. </summary>
    public partial class DescendantInfo : ResourceData
    {
        /// <summary> Initializes a new instance of DescendantInfo. </summary>
        internal DescendantInfo()
        {
        }

        /// <summary> Initializes a new instance of DescendantInfo. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> The friendly name of the management group. </param>
        /// <param name="parent"> The ID of the parent management group. </param>
        internal DescendantInfo(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string displayName, DescendantParentGroupInfo parent) : base(id, name, resourceType, systemData)
        {
            DisplayName = displayName;
            Parent = parent;
        }

        /// <summary> The friendly name of the management group. </summary>
        public string DisplayName { get; }
        /// <summary> The ID of the parent management group. </summary>
        internal DescendantParentGroupInfo Parent { get; }
        /// <summary> The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </summary>
        public string ParentId
        {
            get => Parent.Id;
        }
    }
}
