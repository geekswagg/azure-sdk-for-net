// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SensitivitySetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SensitivitySettingResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSensitivitySettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetSensitivitySetting method.
    /// </summary>
    public partial class SensitivitySettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SensitivitySettingResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier()
        {
            var resourceId = $"/providers/Microsoft.Security/sensitivitySettings/current";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sensitivitySettingClientDiagnostics;
        private readonly SecurityCenterRestOperations _sensitivitySettingRestClient;
        private readonly SensitivitySettingData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/sensitivitySettings";

        /// <summary> Initializes a new instance of the <see cref="SensitivitySettingResource"/> class for mocking. </summary>
        protected SensitivitySettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SensitivitySettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SensitivitySettingResource(ArmClient client, SensitivitySettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SensitivitySettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SensitivitySettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sensitivitySettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sensitivitySettingApiVersion);
            _sensitivitySettingRestClient = new SecurityCenterRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sensitivitySettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SensitivitySettingData Data
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

        /// <summary>
        /// Gets data sensitivity settings for sensitive data discovery
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Security/sensitivitySettings/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSensitivitySettings</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SensitivitySettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SensitivitySettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sensitivitySettingClientDiagnostics.CreateScope("SensitivitySettingResource.Get");
            scope.Start();
            try
            {
                var response = await _sensitivitySettingRestClient.GetSensitivitySettingsAsync(cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SensitivitySettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets data sensitivity settings for sensitive data discovery
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Security/sensitivitySettings/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSensitivitySettings</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SensitivitySettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SensitivitySettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sensitivitySettingClientDiagnostics.CreateScope("SensitivitySettingResource.Get");
            scope.Start();
            try
            {
                var response = _sensitivitySettingRestClient.GetSensitivitySettings(cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SensitivitySettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates data sensitivity settings for sensitive data discovery
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Security/sensitivitySettings/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateSensitivitySettings</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SensitivitySettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The data sensitivity settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<SensitivitySettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SensitivitySettingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sensitivitySettingClientDiagnostics.CreateScope("SensitivitySettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sensitivitySettingRestClient.UpdateSensitivitySettingsAsync(content, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SensitivitySettingResource>(Response.FromValue(new SensitivitySettingResource(Client, response), response.GetRawResponse()));
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
        /// Updates data sensitivity settings for sensitive data discovery
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Security/sensitivitySettings/current</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateSensitivitySettings</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-02-15-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SensitivitySettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> The data sensitivity settings to update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<SensitivitySettingResource> CreateOrUpdate(WaitUntil waitUntil, SensitivitySettingCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _sensitivitySettingClientDiagnostics.CreateScope("SensitivitySettingResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sensitivitySettingRestClient.UpdateSensitivitySettings(content, cancellationToken);
                var operation = new SecurityCenterArmOperation<SensitivitySettingResource>(Response.FromValue(new SensitivitySettingResource(Client, response), response.GetRawResponse()));
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
    }
}
