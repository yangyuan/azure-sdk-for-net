// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.Storage
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region StorageAccount
        /// <summary> Gets an object representing a StorageAccount along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageAccount" /> object. </returns>
        public static StorageAccount GetStorageAccount(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new StorageAccount(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region DeletedAccount
        /// <summary> Gets an object representing a DeletedAccount along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeletedAccount" /> object. </returns>
        public static DeletedAccount GetDeletedAccount(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new DeletedAccount(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ManagementPolicy
        /// <summary> Gets an object representing a ManagementPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementPolicy" /> object. </returns>
        public static ManagementPolicy GetManagementPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ManagementPolicy(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region BlobInventoryPolicy
        /// <summary> Gets an object representing a BlobInventoryPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobInventoryPolicy" /> object. </returns>
        public static BlobInventoryPolicy GetBlobInventoryPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new BlobInventoryPolicy(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ObjectReplicationPolicy
        /// <summary> Gets an object representing a ObjectReplicationPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ObjectReplicationPolicy" /> object. </returns>
        public static ObjectReplicationPolicy GetObjectReplicationPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ObjectReplicationPolicy(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region EncryptionScope
        /// <summary> Gets an object representing a EncryptionScope along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="EncryptionScope" /> object. </returns>
        public static EncryptionScope GetEncryptionScope(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new EncryptionScope(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region BlobService
        /// <summary> Gets an object representing a BlobService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobService" /> object. </returns>
        public static BlobService GetBlobService(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new BlobService(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region BlobContainer
        /// <summary> Gets an object representing a BlobContainer along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlobContainer" /> object. </returns>
        public static BlobContainer GetBlobContainer(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new BlobContainer(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ImmutabilityPolicy
        /// <summary> Gets an object representing a ImmutabilityPolicy along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImmutabilityPolicy" /> object. </returns>
        public static ImmutabilityPolicy GetImmutabilityPolicy(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ImmutabilityPolicy(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region FileService
        /// <summary> Gets an object representing a FileService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileService" /> object. </returns>
        public static FileService GetFileService(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new FileService(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region FileShare
        /// <summary> Gets an object representing a FileShare along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FileShare" /> object. </returns>
        public static FileShare GetFileShare(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new FileShare(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region QueueService
        /// <summary> Gets an object representing a QueueService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QueueService" /> object. </returns>
        public static QueueService GetQueueService(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new QueueService(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region StorageQueue
        /// <summary> Gets an object representing a StorageQueue along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageQueue" /> object. </returns>
        public static StorageQueue GetStorageQueue(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new StorageQueue(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region TableService
        /// <summary> Gets an object representing a TableService along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TableService" /> object. </returns>
        public static TableService GetTableService(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new TableService(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Table
        /// <summary> Gets an object representing a Table along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Table" /> object. </returns>
        public static Table GetTable(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Table(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
