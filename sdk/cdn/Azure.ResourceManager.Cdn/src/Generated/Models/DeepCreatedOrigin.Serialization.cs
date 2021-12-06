// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeepCreatedOrigin : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(HttpPort))
            {
                if (HttpPort != null)
                {
                    writer.WritePropertyName("httpPort");
                    writer.WriteNumberValue(HttpPort.Value);
                }
                else
                {
                    writer.WriteNull("httpPort");
                }
            }
            if (Optional.IsDefined(HttpsPort))
            {
                if (HttpsPort != null)
                {
                    writer.WritePropertyName("httpsPort");
                    writer.WriteNumberValue(HttpsPort.Value);
                }
                else
                {
                    writer.WriteNull("httpsPort");
                }
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader");
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(Priority))
            {
                if (Priority != null)
                {
                    writer.WritePropertyName("priority");
                    writer.WriteNumberValue(Priority.Value);
                }
                else
                {
                    writer.WriteNull("priority");
                }
            }
            if (Optional.IsDefined(Weight))
            {
                if (Weight != null)
                {
                    writer.WritePropertyName("weight");
                    writer.WriteNumberValue(Weight.Value);
                }
                else
                {
                    writer.WriteNull("weight");
                }
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(PrivateLinkAlias))
            {
                writer.WritePropertyName("privateLinkAlias");
                writer.WriteStringValue(PrivateLinkAlias);
            }
            if (Optional.IsDefined(PrivateLinkResourceId))
            {
                writer.WritePropertyName("privateLinkResourceId");
                writer.WriteStringValue(PrivateLinkResourceId);
            }
            if (Optional.IsDefined(PrivateLinkLocation))
            {
                writer.WritePropertyName("privateLinkLocation");
                writer.WriteStringValue(PrivateLinkLocation);
            }
            if (Optional.IsDefined(PrivateLinkApprovalMessage))
            {
                writer.WritePropertyName("privateLinkApprovalMessage");
                writer.WriteStringValue(PrivateLinkApprovalMessage);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DeepCreatedOrigin DeserializeDeepCreatedOrigin(JsonElement element)
        {
            string name = default;
            Optional<string> hostName = default;
            Optional<int?> httpPort = default;
            Optional<int?> httpsPort = default;
            Optional<string> originHostHeader = default;
            Optional<int?> priority = default;
            Optional<int?> weight = default;
            Optional<bool> enabled = default;
            Optional<string> privateLinkAlias = default;
            Optional<string> privateLinkResourceId = default;
            Optional<string> privateLinkLocation = default;
            Optional<string> privateLinkApprovalMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("hostName"))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("httpPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                httpPort = null;
                                continue;
                            }
                            httpPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("httpsPort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                httpsPort = null;
                                continue;
                            }
                            httpsPort = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("priority"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                priority = null;
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("weight"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                weight = null;
                                continue;
                            }
                            weight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkAlias"))
                        {
                            privateLinkAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkResourceId"))
                        {
                            privateLinkResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkLocation"))
                        {
                            privateLinkLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkApprovalMessage"))
                        {
                            privateLinkApprovalMessage = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DeepCreatedOrigin(name, hostName.Value, Optional.ToNullable(httpPort), Optional.ToNullable(httpsPort), originHostHeader.Value, Optional.ToNullable(priority), Optional.ToNullable(weight), Optional.ToNullable(enabled), privateLinkAlias.Value, privateLinkResourceId.Value, privateLinkLocation.Value, privateLinkApprovalMessage.Value);
        }
    }
}
