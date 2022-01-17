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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of VirtualMachineScaleSetVM and their operations over its parent. </summary>
    public partial class VirtualMachineScaleSetVMCollection : ArmCollection, IEnumerable<VirtualMachineScaleSetVM>, IAsyncEnumerable<VirtualMachineScaleSetVM>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualMachineScaleSetVMsRestOperations _virtualMachineScaleSetVMsRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVMCollection"/> class for mocking. </summary>
        protected VirtualMachineScaleSetVMCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVMCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualMachineScaleSetVMCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualMachineScaleSetVMsRestClient = new VirtualMachineScaleSetVMsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualMachineScaleSet.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualMachineScaleSet.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Updates a virtual machine of a VM scale set. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Update Virtual Machine Scale Sets VM operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualMachineScaleSetVMUpdateOperation CreateOrUpdate(bool waitForCompletion, string instanceId, VirtualMachineScaleSetVMData parameters, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVMsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, parameters, cancellationToken);
                var operation = new VirtualMachineScaleSetVMUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualMachineScaleSetVMsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, parameters).Request, response);
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

        /// <summary> Updates a virtual machine of a VM scale set. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Update Virtual Machine Scale Sets VM operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualMachineScaleSetVMUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string instanceId, VirtualMachineScaleSetVMData parameters, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVMsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualMachineScaleSetVMUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualMachineScaleSetVMsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, parameters).Request, response);
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

        /// <summary> Gets a virtual machine from a VM scale set. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the instance view of the virtual machine. &apos;UserData&apos; will retrieve the UserData of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVM> Get(string instanceId, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVMsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVM(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a virtual machine from a VM scale set. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the instance view of the virtual machine. &apos;UserData&apos; will retrieve the UserData of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSetVM>> GetAsync(string instanceId, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVMsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSetVM(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the instance view of the virtual machine. &apos;UserData&apos; will retrieve the UserData of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<VirtualMachineScaleSetVM> GetIfExists(string instanceId, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineScaleSetVMsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetVM>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVM(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the instance view of the virtual machine. &apos;UserData&apos; will retrieve the UserData of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineScaleSetVM>> GetIfExistsAsync(string instanceId, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineScaleSetVMsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineScaleSetVM>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineScaleSetVM(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the instance view of the virtual machine. &apos;UserData&apos; will retrieve the UserData of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response<bool> Exists(string instanceId, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(instanceId, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the instance view of the virtual machine. &apos;UserData&apos; will retrieve the UserData of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string instanceId, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(instanceId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of all virtual machines in a VM scale sets. </summary>
        /// <param name="filter"> The filter to apply to the operation. Allowed values are &apos;startswith(instanceView/statuses/code, &apos;PowerState&apos;) eq true&apos;, &apos;properties/latestModelApplied eq true&apos;, &apos;properties/latestModelApplied eq false&apos;. </param>
        /// <param name="select"> The list parameters. Allowed values are &apos;instanceView&apos;, &apos;instanceView/statuses&apos;. </param>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetVM" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSetVM> GetAll(string filter = null, string select = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSetVM> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetVMsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, select, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVM(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineScaleSetVM> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineScaleSetVMsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, select, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVM(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all virtual machines in a VM scale sets. </summary>
        /// <param name="filter"> The filter to apply to the operation. Allowed values are &apos;startswith(instanceView/statuses/code, &apos;PowerState&apos;) eq true&apos;, &apos;properties/latestModelApplied eq true&apos;, &apos;properties/latestModelApplied eq false&apos;. </param>
        /// <param name="select"> The list parameters. Allowed values are &apos;instanceView&apos;, &apos;instanceView/statuses&apos;. </param>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetVM" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSetVM> GetAllAsync(string filter = null, string select = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSetVM>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetVMsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, select, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVM(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineScaleSetVM>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineScaleSetVMsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, select, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVM(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VirtualMachineScaleSetVM> IEnumerable<VirtualMachineScaleSetVM>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineScaleSetVM> IAsyncEnumerable<VirtualMachineScaleSetVM>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualMachineScaleSetVM, VirtualMachineScaleSetVMData> Construct() { }
    }
}
