// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class PrivateEndpointConnectionRequestStatus
    {
        internal static PrivateEndpointConnectionRequestStatus DeserializePrivateEndpointConnectionRequestStatus(JsonElement element)
        {
            Optional<string> privateLinkServiceId = default;
            Optional<string> privateEndpointConnectionName = default;
            Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateLinkServiceId"))
                {
                    privateLinkServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateEndpointConnectionName"))
                {
                    privateEndpointConnectionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateEndpointConnectionRequestStatus(privateLinkServiceId.Value, privateEndpointConnectionName.Value, status.Value);
        }
    }
}
