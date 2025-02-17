// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.KubernetesConfiguration.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.KubernetesConfiguration. </summary>
    public static partial class KubernetesConfigurationExtensions
    {
        private static MockableKubernetesConfigurationArmClient GetMockableKubernetesConfigurationArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableKubernetesConfigurationArmClient(client0));
        }

        private static MockableKubernetesConfigurationResourceGroupResource GetMockableKubernetesConfigurationResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableKubernetesConfigurationResourceGroupResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="KubernetesClusterExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KubernetesClusterExtensionResource.CreateResourceIdentifier" /> to create a <see cref="KubernetesClusterExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationArmClient.GetKubernetesClusterExtensionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="KubernetesClusterExtensionResource"/> object. </returns>
        public static KubernetesClusterExtensionResource GetKubernetesClusterExtensionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableKubernetesConfigurationArmClient(client).GetKubernetesClusterExtensionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KubernetesFluxConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KubernetesFluxConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="KubernetesFluxConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationArmClient.GetKubernetesFluxConfigurationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="KubernetesFluxConfigurationResource"/> object. </returns>
        public static KubernetesFluxConfigurationResource GetKubernetesFluxConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableKubernetesConfigurationArmClient(client).GetKubernetesFluxConfigurationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="KubernetesSourceControlConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KubernetesSourceControlConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="KubernetesSourceControlConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationArmClient.GetKubernetesSourceControlConfigurationResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="KubernetesSourceControlConfigurationResource"/> object. </returns>
        public static KubernetesSourceControlConfigurationResource GetKubernetesSourceControlConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableKubernetesConfigurationArmClient(client).GetKubernetesSourceControlConfigurationResource(id);
        }

        /// <summary>
        /// Gets a collection of KubernetesClusterExtensionResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationResourceGroupResource.GetKubernetesClusterExtensions(string,string,string)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of KubernetesClusterExtensionResources and their operations over a KubernetesClusterExtensionResource. </returns>
        public static KubernetesClusterExtensionCollection GetKubernetesClusterExtensions(this ResourceGroupResource resourceGroupResource, string clusterRp, string clusterResourceName, string clusterName)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableKubernetesConfigurationResourceGroupResource(resourceGroupResource).GetKubernetesClusterExtensions(clusterRp, clusterResourceName, clusterName);
        }

        /// <summary>
        /// Gets Kubernetes Cluster Extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationResourceGroupResource.GetKubernetesClusterExtensionAsync(string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="extensionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<KubernetesClusterExtensionResource>> GetKubernetesClusterExtensionAsync(this ResourceGroupResource resourceGroupResource, string clusterRp, string clusterResourceName, string clusterName, string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableKubernetesConfigurationResourceGroupResource(resourceGroupResource).GetKubernetesClusterExtensionAsync(clusterRp, clusterResourceName, clusterName, extensionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets Kubernetes Cluster Extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/extensions/{extensionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Extensions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesClusterExtensionResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationResourceGroupResource.GetKubernetesClusterExtension(string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <param name="extensionName"> Name of the Extension. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="extensionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="extensionName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<KubernetesClusterExtensionResource> GetKubernetesClusterExtension(this ResourceGroupResource resourceGroupResource, string clusterRp, string clusterResourceName, string clusterName, string extensionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableKubernetesConfigurationResourceGroupResource(resourceGroupResource).GetKubernetesClusterExtension(clusterRp, clusterResourceName, clusterName, extensionName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of KubernetesFluxConfigurationResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationResourceGroupResource.GetKubernetesFluxConfigurations(string,string,string)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of KubernetesFluxConfigurationResources and their operations over a KubernetesFluxConfigurationResource. </returns>
        public static KubernetesFluxConfigurationCollection GetKubernetesFluxConfigurations(this ResourceGroupResource resourceGroupResource, string clusterRp, string clusterResourceName, string clusterName)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableKubernetesConfigurationResourceGroupResource(resourceGroupResource).GetKubernetesFluxConfigurations(clusterRp, clusterResourceName, clusterName);
        }

        /// <summary>
        /// Gets details of the Flux Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesFluxConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationResourceGroupResource.GetKubernetesFluxConfigurationAsync(string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="fluxConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<KubernetesFluxConfigurationResource>> GetKubernetesFluxConfigurationAsync(this ResourceGroupResource resourceGroupResource, string clusterRp, string clusterResourceName, string clusterName, string fluxConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableKubernetesConfigurationResourceGroupResource(resourceGroupResource).GetKubernetesFluxConfigurationAsync(clusterRp, clusterResourceName, clusterName, fluxConfigurationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details of the Flux Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/fluxConfigurations/{fluxConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FluxConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesFluxConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationResourceGroupResource.GetKubernetesFluxConfiguration(string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <param name="fluxConfigurationName"> Name of the Flux Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="fluxConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="fluxConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<KubernetesFluxConfigurationResource> GetKubernetesFluxConfiguration(this ResourceGroupResource resourceGroupResource, string clusterRp, string clusterResourceName, string clusterName, string fluxConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableKubernetesConfigurationResourceGroupResource(resourceGroupResource).GetKubernetesFluxConfiguration(clusterRp, clusterResourceName, clusterName, fluxConfigurationName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of KubernetesSourceControlConfigurationResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationResourceGroupResource.GetKubernetesSourceControlConfigurations(string,string,string)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/> or <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of KubernetesSourceControlConfigurationResources and their operations over a KubernetesSourceControlConfigurationResource. </returns>
        public static KubernetesSourceControlConfigurationCollection GetKubernetesSourceControlConfigurations(this ResourceGroupResource resourceGroupResource, string clusterRp, string clusterResourceName, string clusterName)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableKubernetesConfigurationResourceGroupResource(resourceGroupResource).GetKubernetesSourceControlConfigurations(clusterRp, clusterResourceName, clusterName);
        }

        /// <summary>
        /// Gets details of the Source Control Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations/{sourceControlConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesSourceControlConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationResourceGroupResource.GetKubernetesSourceControlConfigurationAsync(string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <param name="sourceControlConfigurationName"> Name of the Source Control Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="sourceControlConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="sourceControlConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<KubernetesSourceControlConfigurationResource>> GetKubernetesSourceControlConfigurationAsync(this ResourceGroupResource resourceGroupResource, string clusterRp, string clusterResourceName, string clusterName, string sourceControlConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableKubernetesConfigurationResourceGroupResource(resourceGroupResource).GetKubernetesSourceControlConfigurationAsync(clusterRp, clusterResourceName, clusterName, sourceControlConfigurationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets details of the Source Control Configuration.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{clusterRp}/{clusterResourceName}/{clusterName}/providers/Microsoft.KubernetesConfiguration/sourceControlConfigurations/{sourceControlConfigurationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SourceControlConfigurations_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="KubernetesSourceControlConfigurationResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableKubernetesConfigurationResourceGroupResource.GetKubernetesSourceControlConfiguration(string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterRp"> The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService. </param>
        /// <param name="clusterResourceName"> The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters. </param>
        /// <param name="clusterName"> The name of the kubernetes cluster. </param>
        /// <param name="sourceControlConfigurationName"> Name of the Source Control Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="sourceControlConfigurationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterRp"/>, <paramref name="clusterResourceName"/>, <paramref name="clusterName"/> or <paramref name="sourceControlConfigurationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<KubernetesSourceControlConfigurationResource> GetKubernetesSourceControlConfiguration(this ResourceGroupResource resourceGroupResource, string clusterRp, string clusterResourceName, string clusterName, string sourceControlConfigurationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableKubernetesConfigurationResourceGroupResource(resourceGroupResource).GetKubernetesSourceControlConfiguration(clusterRp, clusterResourceName, clusterName, sourceControlConfigurationName, cancellationToken);
        }
    }
}
