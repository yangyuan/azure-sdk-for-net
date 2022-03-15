// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> ResourceNavigationLink resource. </summary>
    public partial class ResourceNavigationLink : SubResource
    {
        /// <summary> Initializes a new instance of ResourceNavigationLink. </summary>
        public ResourceNavigationLink()
        {
        }

        /// <summary> Initializes a new instance of ResourceNavigationLink. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="linkedResourceType"> Resource type of the linked resource. </param>
        /// <param name="link"> Link to the external resource. </param>
        /// <param name="provisioningState"> The provisioning state of the resource navigation link resource. </param>
        internal ResourceNavigationLink(string id, string name, string etag, string resourceType, string linkedResourceType, string link, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            ResourceType = resourceType;
            LinkedResourceType = linkedResourceType;
            Link = link;
            ProvisioningState = provisioningState;
        }

        /// <summary> Name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Resource type. </summary>
        public string ResourceType { get; }
        /// <summary> Resource type of the linked resource. </summary>
        public string LinkedResourceType { get; set; }
        /// <summary> Link to the external resource. </summary>
        public string Link { get; set; }
        /// <summary> The provisioning state of the resource navigation link resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
