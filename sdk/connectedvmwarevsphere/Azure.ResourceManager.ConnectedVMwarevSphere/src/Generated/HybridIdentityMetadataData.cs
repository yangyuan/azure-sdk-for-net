// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing the HybridIdentityMetadata data model. </summary>
    public partial class HybridIdentityMetadataData : ResourceData
    {
        /// <summary> Initializes a new instance of HybridIdentityMetadataData. </summary>
        public HybridIdentityMetadataData()
        {
        }

        /// <summary> Initializes a new instance of HybridIdentityMetadataData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vmId"> Gets or sets the Vm Id. </param>
        /// <param name="publicKey"> Gets or sets the Public Key. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        internal HybridIdentityMetadataData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string vmId, string publicKey, SystemAssignedServiceIdentity identity, string provisioningState) : base(id, name, resourceType, systemData)
        {
            VmId = vmId;
            PublicKey = publicKey;
            Identity = identity;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets or sets the Vm Id. </summary>
        public string VmId { get; set; }
        /// <summary> Gets or sets the Public Key. </summary>
        public string PublicKey { get; set; }
        /// <summary> The identity of the resource. </summary>
        public SystemAssignedServiceIdentity Identity { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
