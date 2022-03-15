// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class RelayServiceConnectionEntityData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(EntityName))
            {
                writer.WritePropertyName("entityName");
                writer.WriteStringValue(EntityName);
            }
            if (Optional.IsDefined(EntityConnectionString))
            {
                writer.WritePropertyName("entityConnectionString");
                writer.WriteStringValue(EntityConnectionString);
            }
            if (Optional.IsDefined(ResourceConnectionString))
            {
                writer.WritePropertyName("resourceConnectionString");
                writer.WriteStringValue(ResourceConnectionString);
            }
            if (Optional.IsDefined(Hostname))
            {
                writer.WritePropertyName("hostname");
                writer.WriteStringValue(Hostname);
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port");
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(BiztalkUri))
            {
                writer.WritePropertyName("biztalkUri");
                writer.WriteStringValue(BiztalkUri.AbsoluteUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RelayServiceConnectionEntityData DeserializeRelayServiceConnectionEntityData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> entityName = default;
            Optional<string> entityConnectionString = default;
            Optional<string> resourceConnectionString = default;
            Optional<string> hostname = default;
            Optional<int> port = default;
            Optional<Uri> biztalkUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("entityName"))
                        {
                            entityName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("entityConnectionString"))
                        {
                            entityConnectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceConnectionString"))
                        {
                            resourceConnectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostname"))
                        {
                            hostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("port"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            port = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("biztalkUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            biztalkUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RelayServiceConnectionEntityData(id, name, type, systemData, kind.Value, entityName.Value, entityConnectionString.Value, resourceConnectionString.Value, hostname.Value, Optional.ToNullable(port), biztalkUri.Value);
        }
    }
}
