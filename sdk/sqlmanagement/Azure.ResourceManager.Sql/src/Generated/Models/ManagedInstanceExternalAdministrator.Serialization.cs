// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceExternalAdministrator : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorType))
            {
                writer.WritePropertyName("administratorType");
                writer.WriteStringValue(AdministratorType.Value.ToString());
            }
            if (Optional.IsDefined(PrincipalType))
            {
                writer.WritePropertyName("principalType");
                writer.WriteStringValue(PrincipalType.Value.ToString());
            }
            if (Optional.IsDefined(Login))
            {
                writer.WritePropertyName("login");
                writer.WriteStringValue(Login);
            }
            if (Optional.IsDefined(Sid))
            {
                writer.WritePropertyName("sid");
                writer.WriteStringValue(Sid.Value);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(AzureADOnlyAuthentication))
            {
                writer.WritePropertyName("azureADOnlyAuthentication");
                writer.WriteBooleanValue(AzureADOnlyAuthentication.Value);
            }
            writer.WriteEndObject();
        }

        internal static ManagedInstanceExternalAdministrator DeserializeManagedInstanceExternalAdministrator(JsonElement element)
        {
            Optional<AdministratorType> administratorType = default;
            Optional<PrincipalType> principalType = default;
            Optional<string> login = default;
            Optional<Guid> sid = default;
            Optional<Guid> tenantId = default;
            Optional<bool> azureADOnlyAuthentication = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("administratorType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    administratorType = new AdministratorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("principalType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    principalType = new PrincipalType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("login"))
                {
                    login = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sid"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("azureADOnlyAuthentication"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureADOnlyAuthentication = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ManagedInstanceExternalAdministrator(Optional.ToNullable(administratorType), Optional.ToNullable(principalType), login.Value, Optional.ToNullable(sid), Optional.ToNullable(tenantId), Optional.ToNullable(azureADOnlyAuthentication));
        }
    }
}
