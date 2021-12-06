// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class FirewallPolicyRuleCollectionGroupsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of FirewallPolicyRuleCollectionGroupsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public FirewallPolicyRuleCollectionGroupsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/firewallPolicies/", false);
            uri.AppendPath(firewallPolicyName, true);
            uri.AppendPath("/ruleCollectionGroups/", false);
            uri.AppendPath(ruleCollectionGroupName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, or <paramref name="ruleCollectionGroupName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleCollectionGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionGroupName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, or <paramref name="ruleCollectionGroupName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleCollectionGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionGroupName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/firewallPolicies/", false);
            uri.AppendPath(firewallPolicyName, true);
            uri.AppendPath("/ruleCollectionGroups/", false);
            uri.AppendPath(ruleCollectionGroupName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, or <paramref name="ruleCollectionGroupName"/> is null. </exception>
        public async Task<Response<FirewallPolicyRuleCollectionGroupData>> GetAsync(string subscriptionId, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleCollectionGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionGroupName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallPolicyRuleCollectionGroupData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FirewallPolicyRuleCollectionGroupData.DeserializeFirewallPolicyRuleCollectionGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FirewallPolicyRuleCollectionGroupData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, or <paramref name="ruleCollectionGroupName"/> is null. </exception>
        public Response<FirewallPolicyRuleCollectionGroupData> Get(string subscriptionId, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleCollectionGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionGroupName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallPolicyRuleCollectionGroupData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FirewallPolicyRuleCollectionGroupData.DeserializeFirewallPolicyRuleCollectionGroupData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FirewallPolicyRuleCollectionGroupData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroupData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/firewallPolicies/", false);
            uri.AppendPath(firewallPolicyName, true);
            uri.AppendPath("/ruleCollectionGroups/", false);
            uri.AppendPath(ruleCollectionGroupName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleCollectionGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, <paramref name="ruleCollectionGroupName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleCollectionGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleCollectionGroup operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="firewallPolicyName"/>, <paramref name="ruleCollectionGroupName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string firewallPolicyName, string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroupData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }
            if (ruleCollectionGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, firewallPolicyName, ruleCollectionGroupName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string firewallPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/firewallPolicies/", false);
            uri.AppendPath(firewallPolicyName, true);
            uri.AppendPath("/ruleCollectionGroups", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="firewallPolicyName"/> is null. </exception>
        public async Task<Response<FirewallPolicyRuleCollectionGroupListResult>> ListAsync(string subscriptionId, string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, firewallPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallPolicyRuleCollectionGroupListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FirewallPolicyRuleCollectionGroupListResult.DeserializeFirewallPolicyRuleCollectionGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="firewallPolicyName"/> is null. </exception>
        public Response<FirewallPolicyRuleCollectionGroupListResult> List(string subscriptionId, string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, firewallPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallPolicyRuleCollectionGroupListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FirewallPolicyRuleCollectionGroupListResult.DeserializeFirewallPolicyRuleCollectionGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string firewallPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="firewallPolicyName"/> is null. </exception>
        public async Task<Response<FirewallPolicyRuleCollectionGroupListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, firewallPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallPolicyRuleCollectionGroupListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FirewallPolicyRuleCollectionGroupListResult.DeserializeFirewallPolicyRuleCollectionGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="firewallPolicyName"> The name of the Firewall Policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="firewallPolicyName"/> is null. </exception>
        public Response<FirewallPolicyRuleCollectionGroupListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string firewallPolicyName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (firewallPolicyName == null)
            {
                throw new ArgumentNullException(nameof(firewallPolicyName));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, firewallPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FirewallPolicyRuleCollectionGroupListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FirewallPolicyRuleCollectionGroupListResult.DeserializeFirewallPolicyRuleCollectionGroupListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
