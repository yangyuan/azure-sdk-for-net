// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A Class representing a SqlContainer along with the instance operations that can be performed on it. </summary>
    public partial class SqlContainer : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlContainer"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string databaseName, string containerName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DocumentDB/databaseAccounts/{accountName}/sqlDatabases/{databaseName}/containers/{containerName}";
            return new ResourceIdentifier(resourceId);
        }
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SqlResourcesRestOperations _sqlResourcesRestClient;
        private readonly SqlContainerData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlContainer"/> class for mocking. </summary>
        protected SqlContainer()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlContainer"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlContainer(ArmResource options, SqlContainerData data) : base(options, data.Id)
        {
            HasData = true;
            _data = data;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _sqlResourcesRestClient = new SqlResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SqlContainer"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlContainer(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _sqlResourcesRestClient = new SqlResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SqlContainer"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlContainer(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _sqlResourcesRestClient = new SqlResourcesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/databaseAccounts/sqlDatabases/containers";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SqlContainerData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SqlContainer>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlContainer.Get");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the SQL container under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlContainer> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlContainer.Get");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlContainer.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlContainer.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an existing Azure Cosmos DB SQL container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SqlResourceDeleteSqlContainerOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlContainer.Delete");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.DeleteSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SqlResourceDeleteSqlContainerOperation(_clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateDeleteSqlContainerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes an existing Azure Cosmos DB SQL container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SqlResourceDeleteSqlContainerOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlContainer.Delete");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.DeleteSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SqlResourceDeleteSqlContainerOperation(_clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateDeleteSqlContainerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response);
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

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async virtual Task<Response<SqlContainer>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key), $"{nameof(key)} provided cannot be null or a whitespace.");
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainer.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _sqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SqlContainer(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public virtual Response<SqlContainer> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key), $"{nameof(key)} provided cannot be null or a whitespace.");
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainer.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue[key] = value;
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _sqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new SqlContainer(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async virtual Task<Response<SqlContainer>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags), $"{nameof(tags)} provided cannot be null.");
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainer.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _sqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SqlContainer(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public virtual Response<SqlContainer> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags), $"{nameof(tags)} provided cannot be null.");
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainer.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.ReplaceWith(tags);
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _sqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new SqlContainer(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async virtual Task<Response<SqlContainer>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key), $"{nameof(key)} provided cannot be null or a whitespace.");
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainer.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                await TagResource.CreateOrUpdateAsync(originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _sqlResourcesRestClient.GetSqlContainerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SqlContainer(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public virtual Response<SqlContainer> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentNullException(nameof(key), $"{nameof(key)} provided cannot be null or a whitespace.");
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainer.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.Properties.TagsValue.Remove(key);
                TagResource.CreateOrUpdate(originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _sqlResourcesRestClient.GetSqlContainer(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new SqlContainer(this, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves continuous backup information for a container resource. </summary>
        /// <param name="location"> The name of the continuous backup restore location. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public async virtual Task<SqlResourceRetrieveContinuousBackupInformationOperation> RetrieveContinuousBackupInformationAsync(bool waitForCompletion, ContinuousBackupRestoreLocation location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainer.RetrieveContinuousBackupInformation");
            scope.Start();
            try
            {
                var response = await _sqlResourcesRestClient.RetrieveContinuousBackupInformationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, location, cancellationToken).ConfigureAwait(false);
                var operation = new SqlResourceRetrieveContinuousBackupInformationOperation(_clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateRetrieveContinuousBackupInformationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, location).Request, response);
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

        /// <summary> Retrieves continuous backup information for a container resource. </summary>
        /// <param name="location"> The name of the continuous backup restore location. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public virtual SqlResourceRetrieveContinuousBackupInformationOperation RetrieveContinuousBackupInformation(bool waitForCompletion, ContinuousBackupRestoreLocation location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlContainer.RetrieveContinuousBackupInformation");
            scope.Start();
            try
            {
                var response = _sqlResourcesRestClient.RetrieveContinuousBackupInformation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, location, cancellationToken);
                var operation = new SqlResourceRetrieveContinuousBackupInformationOperation(_clientDiagnostics, Pipeline, _sqlResourcesRestClient.CreateRetrieveContinuousBackupInformationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, location).Request, response);
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

        #region DatabaseAccountSqlDatabaseContainerThroughputSetting

        /// <summary> Gets an object representing a DatabaseAccountSqlDatabaseContainerThroughputSetting along with the instance operations that can be performed on it in the SqlContainer. </summary>
        /// <returns> Returns a <see cref="DatabaseAccountSqlDatabaseContainerThroughputSetting" /> object. </returns>
        public virtual DatabaseAccountSqlDatabaseContainerThroughputSetting GetDatabaseAccountSqlDatabaseContainerThroughputSetting()
        {
            return new DatabaseAccountSqlDatabaseContainerThroughputSetting(this, new ResourceIdentifier(Id.ToString() + "/throughputSettings/default"));
        }
        #endregion

        #region SqlStoredProcedure

        /// <summary> Gets a collection of SqlStoredProcedures in the SqlContainer. </summary>
        /// <returns> An object representing collection of SqlStoredProcedures and their operations over a SqlContainer. </returns>
        public virtual SqlStoredProcedureCollection GetSqlStoredProcedures()
        {
            return new SqlStoredProcedureCollection(this);
        }
        #endregion

        #region SqlUserDefinedFunction

        /// <summary> Gets a collection of SqlUserDefinedFunctions in the SqlContainer. </summary>
        /// <returns> An object representing collection of SqlUserDefinedFunctions and their operations over a SqlContainer. </returns>
        public virtual SqlUserDefinedFunctionCollection GetSqlUserDefinedFunctions()
        {
            return new SqlUserDefinedFunctionCollection(this);
        }
        #endregion

        #region SqlTrigger

        /// <summary> Gets a collection of SqlTriggers in the SqlContainer. </summary>
        /// <returns> An object representing collection of SqlTriggers and their operations over a SqlContainer. </returns>
        public virtual SqlTriggerCollection GetSqlTriggers()
        {
            return new SqlTriggerCollection(this);
        }
        #endregion
    }
}
