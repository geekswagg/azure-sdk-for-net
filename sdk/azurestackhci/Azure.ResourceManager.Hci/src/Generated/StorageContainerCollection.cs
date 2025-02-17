// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing a collection of <see cref="StorageContainerResource"/> and their operations.
    /// Each <see cref="StorageContainerResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="StorageContainerCollection"/> instance call the GetStorageContainers method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class StorageContainerCollection : ArmCollection, IEnumerable<StorageContainerResource>, IAsyncEnumerable<StorageContainerResource>
    {
        private readonly ClientDiagnostics _storageContainerClientDiagnostics;
        private readonly StorageContainersRestOperations _storageContainerRestClient;

        /// <summary> Initializes a new instance of the <see cref="StorageContainerCollection"/> class for mocking. </summary>
        protected StorageContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StorageContainerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StorageContainerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _storageContainerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Hci", StorageContainerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StorageContainerResource.ResourceType, out string storageContainerApiVersion);
            _storageContainerRestClient = new StorageContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, storageContainerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// The operation to create or update a storage container. Please note some properties can be set only during storage container creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers/{storageContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageContainerName"> Name of the storage container. </param>
        /// <param name="data"> The <see cref="StorageContainerData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StorageContainerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string storageContainerName, StorageContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageContainerName, nameof(storageContainerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageContainerClientDiagnostics.CreateScope("StorageContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _storageContainerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HciArmOperation<StorageContainerResource>(new StorageContainerOperationSource(Client), _storageContainerClientDiagnostics, Pipeline, _storageContainerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The operation to create or update a storage container. Please note some properties can be set only during storage container creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers/{storageContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="storageContainerName"> Name of the storage container. </param>
        /// <param name="data"> The <see cref="StorageContainerData"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StorageContainerResource> CreateOrUpdate(WaitUntil waitUntil, string storageContainerName, StorageContainerData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageContainerName, nameof(storageContainerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _storageContainerClientDiagnostics.CreateScope("StorageContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _storageContainerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, data, cancellationToken);
                var operation = new HciArmOperation<StorageContainerResource>(new StorageContainerOperationSource(Client), _storageContainerClientDiagnostics, Pipeline, _storageContainerRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a storage container
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers/{storageContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageContainerName"> Name of the storage container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerName"/> is null. </exception>
        public virtual async Task<Response<StorageContainerResource>> GetAsync(string storageContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageContainerName, nameof(storageContainerName));

            using var scope = _storageContainerClientDiagnostics.CreateScope("StorageContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _storageContainerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a storage container
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers/{storageContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageContainerName"> Name of the storage container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerName"/> is null. </exception>
        public virtual Response<StorageContainerResource> Get(string storageContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageContainerName, nameof(storageContainerName));

            using var scope = _storageContainerClientDiagnostics.CreateScope("StorageContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _storageContainerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StorageContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the storage containers in the specified resource group. Use the nextLink property in the response to get the next page of storage containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StorageContainerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageContainerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageContainerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new StorageContainerResource(Client, StorageContainerData.DeserializeStorageContainerData(e)), _storageContainerClientDiagnostics, Pipeline, "StorageContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all of the storage containers in the specified resource group. Use the nextLink property in the response to get the next page of storage containers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageContainerResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StorageContainerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _storageContainerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _storageContainerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new StorageContainerResource(Client, StorageContainerData.DeserializeStorageContainerData(e)), _storageContainerClientDiagnostics, Pipeline, "StorageContainerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers/{storageContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageContainerName"> Name of the storage container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string storageContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageContainerName, nameof(storageContainerName));

            using var scope = _storageContainerClientDiagnostics.CreateScope("StorageContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _storageContainerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers/{storageContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageContainerName"> Name of the storage container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerName"/> is null. </exception>
        public virtual Response<bool> Exists(string storageContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageContainerName, nameof(storageContainerName));

            using var scope = _storageContainerClientDiagnostics.CreateScope("StorageContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = _storageContainerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers/{storageContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageContainerName"> Name of the storage container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerName"/> is null. </exception>
        public virtual async Task<NullableResponse<StorageContainerResource>> GetIfExistsAsync(string storageContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageContainerName, nameof(storageContainerName));

            using var scope = _storageContainerClientDiagnostics.CreateScope("StorageContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _storageContainerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<StorageContainerResource>(response.GetRawResponse());
                return Response.FromValue(new StorageContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureStackHCI/storageContainers/{storageContainerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageContainers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StorageContainerResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="storageContainerName"> Name of the storage container. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageContainerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerName"/> is null. </exception>
        public virtual NullableResponse<StorageContainerResource> GetIfExists(string storageContainerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storageContainerName, nameof(storageContainerName));

            using var scope = _storageContainerClientDiagnostics.CreateScope("StorageContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _storageContainerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, storageContainerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<StorageContainerResource>(response.GetRawResponse());
                return Response.FromValue(new StorageContainerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StorageContainerResource> IEnumerable<StorageContainerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StorageContainerResource> IAsyncEnumerable<StorageContainerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
