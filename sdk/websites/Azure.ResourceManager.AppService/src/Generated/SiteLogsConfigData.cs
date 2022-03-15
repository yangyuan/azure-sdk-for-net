// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SiteLogsConfig data model. </summary>
    public partial class SiteLogsConfigData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SiteLogsConfigData. </summary>
        public SiteLogsConfigData()
        {
        }

        /// <summary> Initializes a new instance of SiteLogsConfigData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="applicationLogs"> Application logs configuration. </param>
        /// <param name="httpLogs"> HTTP logs configuration. </param>
        /// <param name="failedRequestsTracing"> Failed requests tracing configuration. </param>
        /// <param name="detailedErrorMessages"> Detailed error messages configuration. </param>
        internal SiteLogsConfigData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, ApplicationLogsConfig applicationLogs, HttpLogsConfig httpLogs, EnabledConfig failedRequestsTracing, EnabledConfig detailedErrorMessages) : base(id, name, resourceType, systemData, kind)
        {
            ApplicationLogs = applicationLogs;
            HttpLogs = httpLogs;
            FailedRequestsTracing = failedRequestsTracing;
            DetailedErrorMessages = detailedErrorMessages;
        }

        /// <summary> Application logs configuration. </summary>
        public ApplicationLogsConfig ApplicationLogs { get; set; }
        /// <summary> HTTP logs configuration. </summary>
        public HttpLogsConfig HttpLogs { get; set; }
        /// <summary> Failed requests tracing configuration. </summary>
        internal EnabledConfig FailedRequestsTracing { get; set; }
        /// <summary> True if configuration is enabled, false if it is disabled and null if configuration is not set. </summary>
        public bool? FailedRequestsTracingEnabled
        {
            get => FailedRequestsTracing is null ? default : FailedRequestsTracing.Enabled;
            set
            {
                if (FailedRequestsTracing is null)
                    FailedRequestsTracing = new EnabledConfig();
                FailedRequestsTracing.Enabled = value;
            }
        }

        /// <summary> Detailed error messages configuration. </summary>
        internal EnabledConfig DetailedErrorMessages { get; set; }
        /// <summary> True if configuration is enabled, false if it is disabled and null if configuration is not set. </summary>
        public bool? DetailedErrorMessagesEnabled
        {
            get => DetailedErrorMessages is null ? default : DetailedErrorMessages.Enabled;
            set
            {
                if (DetailedErrorMessages is null)
                    DetailedErrorMessages = new EnabledConfig();
                DetailedErrorMessages.Enabled = value;
            }
        }
    }
}
