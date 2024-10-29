// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class BestWorkerMode : IUtf8JsonSerializable, IJsonModel<BestWorkerMode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BestWorkerMode>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BestWorkerMode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BestWorkerMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BestWorkerMode)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ScoringRule))
            {
                writer.WritePropertyName("scoringRule"u8);
                writer.WriteObjectValue<RouterRule>(ScoringRule, options);
            }
            if (Optional.IsDefined(ScoringRuleOptions))
            {
                writer.WritePropertyName("scoringRuleOptions"u8);
                writer.WriteObjectValue<ScoringRuleOptions>(ScoringRuleOptions, options);
            }
        }

        BestWorkerMode IJsonModel<BestWorkerMode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BestWorkerMode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BestWorkerMode)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBestWorkerMode(document.RootElement, options);
        }

        internal static BestWorkerMode DeserializeBestWorkerMode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterRule scoringRule = default;
            ScoringRuleOptions scoringRuleOptions = default;
            int minConcurrentOffers = default;
            int maxConcurrentOffers = default;
            bool? bypassSelectors = default;
            DistributionModeKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scoringRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scoringRule = RouterRule.DeserializeRouterRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("scoringRuleOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scoringRuleOptions = JobRouter.ScoringRuleOptions.DeserializeScoringRuleOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("minConcurrentOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minConcurrentOffers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentOffers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bypassSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypassSelectors = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new DistributionModeKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BestWorkerMode(
                minConcurrentOffers,
                maxConcurrentOffers,
                bypassSelectors,
                kind,
                serializedAdditionalRawData,
                scoringRule,
                scoringRuleOptions);
        }

        BinaryData IPersistableModel<BestWorkerMode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BestWorkerMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BestWorkerMode)} does not support writing '{options.Format}' format.");
            }
        }

        BestWorkerMode IPersistableModel<BestWorkerMode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BestWorkerMode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBestWorkerMode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BestWorkerMode)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BestWorkerMode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new BestWorkerMode FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBestWorkerMode(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
