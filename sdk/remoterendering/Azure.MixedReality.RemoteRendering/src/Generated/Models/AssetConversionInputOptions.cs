// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> Conversion input settings describe the origin of conversion input. </summary>
    public partial class AssetConversionInputOptions
    {
        /// <summary> Initializes a new instance of <see cref="AssetConversionInputOptions"/>. </summary>
        /// <param name="storageContainerUri"> The URI of the Azure blob storage container containing the input model. </param>
        /// <param name="relativeInputAssetPath"> The relative path starting at blobPrefix (or at the container root if blobPrefix is not provided) to the input model. Must point to a file with a supported file format ending. See https://docs.microsoft.com/azure/remote-rendering/how-tos/conversion/model-conversion for details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageContainerUri"/> or <paramref name="relativeInputAssetPath"/> is null. </exception>
        public AssetConversionInputOptions(Uri storageContainerUri, string relativeInputAssetPath)
        {
            Argument.AssertNotNull(storageContainerUri, nameof(storageContainerUri));
            Argument.AssertNotNull(relativeInputAssetPath, nameof(relativeInputAssetPath));

            StorageContainerUri = storageContainerUri;
            RelativeInputAssetPath = relativeInputAssetPath;
        }

        /// <summary> Initializes a new instance of <see cref="AssetConversionInputOptions"/>. </summary>
        /// <param name="storageContainerUri"> The URI of the Azure blob storage container containing the input model. </param>
        /// <param name="storageContainerReadListSas"> An Azure blob storage container shared access signature giving read and list access to the storage container. Optional. If not provided, the Azure Remote Rendering account needs to be linked with the storage account containing the blob container. See https://docs.microsoft.com/azure/remote-rendering/how-tos/create-an-account#link-storage-accounts for details. For security purposes this field will never be filled out in responses bodies. </param>
        /// <param name="blobPrefix"> Only Blobs starting with this prefix will be downloaded to perform the conversion. Optional. If not provided, all Blobs from the container will be downloaded. </param>
        /// <param name="relativeInputAssetPath"> The relative path starting at blobPrefix (or at the container root if blobPrefix is not provided) to the input model. Must point to a file with a supported file format ending. See https://docs.microsoft.com/azure/remote-rendering/how-tos/conversion/model-conversion for details. </param>
        internal AssetConversionInputOptions(Uri storageContainerUri, string storageContainerReadListSas, string blobPrefix, string relativeInputAssetPath)
        {
            StorageContainerUri = storageContainerUri;
            StorageContainerReadListSas = storageContainerReadListSas;
            BlobPrefix = blobPrefix;
            RelativeInputAssetPath = relativeInputAssetPath;
        }
        /// <summary> An Azure blob storage container shared access signature giving read and list access to the storage container. Optional. If not provided, the Azure Remote Rendering account needs to be linked with the storage account containing the blob container. See https://docs.microsoft.com/azure/remote-rendering/how-tos/create-an-account#link-storage-accounts for details. For security purposes this field will never be filled out in responses bodies. </summary>
        public string StorageContainerReadListSas { get; set; }
        /// <summary> Only Blobs starting with this prefix will be downloaded to perform the conversion. Optional. If not provided, all Blobs from the container will be downloaded. </summary>
        public string BlobPrefix { get; set; }
    }
}
