// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of LongTermRetentionBackup and their operations over its parent. </summary>
    public partial class SubscriptionLongTermRetentionBackupCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly LongTermRetentionBackupsRestOperations _longTermRetentionBackupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionBackupCollection"/> class for mocking. </summary>
        protected SubscriptionLongTermRetentionBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of SubscriptionLongTermRetentionBackupCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubscriptionLongTermRetentionBackupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _longTermRetentionBackupsRestClient = new LongTermRetentionBackupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Subscription.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionBackups_Get
        /// <summary> Gets a long term retention backup. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="longTermRetentionServerName"/>, <paramref name="longTermRetentionDatabaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public virtual Response<SubscriptionLongTermRetentionBackup> Get(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (longTermRetentionServerName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionServerName));
            }
            if (longTermRetentionDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionDatabaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _longTermRetentionBackupsRestClient.Get(Id.SubscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionBackups_Get
        /// <summary> Gets a long term retention backup. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="longTermRetentionServerName"/>, <paramref name="longTermRetentionDatabaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<SubscriptionLongTermRetentionBackup>> GetAsync(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (longTermRetentionServerName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionServerName));
            }
            if (longTermRetentionDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionDatabaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _longTermRetentionBackupsRestClient.GetAsync(Id.SubscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubscriptionLongTermRetentionBackup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="longTermRetentionServerName"/>, <paramref name="longTermRetentionDatabaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public virtual Response<SubscriptionLongTermRetentionBackup> GetIfExists(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (longTermRetentionServerName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionServerName));
            }
            if (longTermRetentionDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionDatabaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _longTermRetentionBackupsRestClient.Get(Id.SubscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SubscriptionLongTermRetentionBackup>(null, response.GetRawResponse())
                    : Response.FromValue(new SubscriptionLongTermRetentionBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="longTermRetentionServerName"/>, <paramref name="longTermRetentionDatabaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<SubscriptionLongTermRetentionBackup>> GetIfExistsAsync(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (longTermRetentionServerName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionServerName));
            }
            if (longTermRetentionDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionDatabaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _longTermRetentionBackupsRestClient.GetAsync(Id.SubscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SubscriptionLongTermRetentionBackup>(null, response.GetRawResponse())
                    : Response.FromValue(new SubscriptionLongTermRetentionBackup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="longTermRetentionServerName"/>, <paramref name="longTermRetentionDatabaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (longTermRetentionServerName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionServerName));
            }
            if (longTermRetentionDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionDatabaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="longTermRetentionServerName"/>, <paramref name="longTermRetentionDatabaseName"/>, or <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, string backupName, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (longTermRetentionServerName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionServerName));
            }
            if (longTermRetentionDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionDatabaseName));
            }
            if (backupName == null)
            {
                throw new ArgumentNullException(nameof(backupName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(locationName, longTermRetentionServerName, longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionBackups_ListByDatabase
        /// <summary> Lists all long term retention backups for a database. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionLongTermRetentionBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionLongTermRetentionBackup> GetAll(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (longTermRetentionServerName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionServerName));
            }
            if (longTermRetentionDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionDatabaseName));
            }

            Page<SubscriptionLongTermRetentionBackup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionBackupsRestClient.ListByDatabase(Id.SubscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionLongTermRetentionBackup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _longTermRetentionBackupsRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionBackups_ListByDatabase
        /// <summary> Lists all long term retention backups for a database. </summary>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionLongTermRetentionBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionLongTermRetentionBackup> GetAllAsync(string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName, bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            if (locationName == null)
            {
                throw new ArgumentNullException(nameof(locationName));
            }
            if (longTermRetentionServerName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionServerName));
            }
            if (longTermRetentionDatabaseName == null)
            {
                throw new ArgumentNullException(nameof(longTermRetentionDatabaseName));
            }

            async Task<Page<SubscriptionLongTermRetentionBackup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionBackupsRestClient.ListByDatabaseAsync(Id.SubscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionLongTermRetentionBackup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _longTermRetentionBackupsRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, locationName, longTermRetentionServerName, longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionBackup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SubscriptionLongTermRetentionBackup" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubscriptionLongTermRetentionBackup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SubscriptionLongTermRetentionBackup" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubscriptionLongTermRetentionBackup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SubscriptionLongTermRetentionBackup, LongTermRetentionBackupData> Construct() { }
    }
}
