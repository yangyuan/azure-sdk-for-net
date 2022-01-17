// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of PublicIPAddress and their operations over its parent. </summary>
    public partial class PublicIPAddressCollection : ArmCollection, IEnumerable<PublicIPAddress>, IAsyncEnumerable<PublicIPAddress>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PublicIPAddressesRestOperations _publicIPAddressesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PublicIPAddressCollection"/> class for mocking. </summary>
        protected PublicIPAddressCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PublicIPAddressCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PublicIPAddressCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _publicIPAddressesRestClient = new PublicIPAddressesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates a static or dynamic public IP address. </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP address operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PublicIPAddressCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string publicIpAddressName, PublicIPAddressData parameters, CancellationToken cancellationToken = default)
        {
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _publicIPAddressesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, parameters, cancellationToken);
                var operation = new PublicIPAddressCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _publicIPAddressesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a static or dynamic public IP address. </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP address operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PublicIPAddressCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string publicIpAddressName, PublicIPAddressData parameters, CancellationToken cancellationToken = default)
        {
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _publicIPAddressesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PublicIPAddressCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _publicIPAddressesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified public IP address in a specified resource group. </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public virtual Response<PublicIPAddress> Get(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.Get");
            scope.Start();
            try
            {
                var response = _publicIPAddressesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublicIPAddress(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified public IP address in a specified resource group. </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public async virtual Task<Response<PublicIPAddress>> GetAsync(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.Get");
            scope.Start();
            try
            {
                var response = await _publicIPAddressesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PublicIPAddress(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public virtual Response<PublicIPAddress> GetIfExists(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _publicIPAddressesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<PublicIPAddress>(null, response.GetRawResponse());
                return Response.FromValue(new PublicIPAddress(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public async virtual Task<Response<PublicIPAddress>> GetIfExistsAsync(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _publicIPAddressesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publicIpAddressName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<PublicIPAddress>(null, response.GetRawResponse());
                return Response.FromValue(new PublicIPAddress(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public virtual Response<bool> Exists(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(publicIpAddressName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIpAddressName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(publicIpAddressName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all public IP addresses in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublicIPAddress" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublicIPAddress> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PublicIPAddress> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _publicIPAddressesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPAddress(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PublicIPAddress> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _publicIPAddressesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPAddress(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all public IP addresses in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublicIPAddress" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublicIPAddress> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PublicIPAddress>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _publicIPAddressesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPAddress(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PublicIPAddress>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _publicIPAddressesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PublicIPAddress(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PublicIPAddress" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PublicIPAddress.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PublicIPAddress" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PublicIPAddress.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PublicIPAddress> IEnumerable<PublicIPAddress>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PublicIPAddress> IAsyncEnumerable<PublicIPAddress>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, PublicIPAddress, PublicIPAddressData> Construct() { }
    }
}
