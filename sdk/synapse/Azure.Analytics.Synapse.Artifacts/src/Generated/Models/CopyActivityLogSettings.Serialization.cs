// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(CopyActivityLogSettingsConverter))]
    public partial class CopyActivityLogSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LogLevel))
            {
                writer.WritePropertyName("logLevel");
                writer.WriteObjectValue(LogLevel);
            }
            if (Optional.IsDefined(EnableReliableLogging))
            {
                writer.WritePropertyName("enableReliableLogging");
                writer.WriteObjectValue(EnableReliableLogging);
            }
            writer.WriteEndObject();
        }

        internal static CopyActivityLogSettings DeserializeCopyActivityLogSettings(JsonElement element)
        {
            Optional<object> logLevel = default;
            Optional<object> enableReliableLogging = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logLevel = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("enableReliableLogging"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableReliableLogging = property.Value.GetObject();
                    continue;
                }
            }
            return new CopyActivityLogSettings(logLevel.Value, enableReliableLogging.Value);
        }

        internal partial class CopyActivityLogSettingsConverter : JsonConverter<CopyActivityLogSettings>
        {
            public override void Write(Utf8JsonWriter writer, CopyActivityLogSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CopyActivityLogSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCopyActivityLogSettings(document.RootElement);
            }
        }
    }
}
