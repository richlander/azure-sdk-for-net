// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Batch.Service.Models
{
    /// <summary> Whether the Azure Batch service actively verifies that the Image is compatible with the associated Compute Node agent SKU. </summary>
    public enum VerificationType
    {
        /// <summary> The Image is guaranteed to be compatible with the associated Compute Node agent SKU and all Batch features have been confirmed to work as expected. </summary>
        Verified,
        /// <summary> The associated Compute Node agent SKU should have binary compatibility with the Image, but specific functionality has not been verified. </summary>
        Unverified
    }
}
