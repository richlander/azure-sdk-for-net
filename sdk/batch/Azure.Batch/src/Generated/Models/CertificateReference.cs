// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Batch.Service.Models
{
    /// <summary> A reference to a Certificate to be installed on Compute Nodes in a Pool. </summary>
    public partial class CertificateReference
    {
        /// <summary> Initializes a new instance of CertificateReference. </summary>
        /// <param name="thumbprint"> The thumbprint of the Certificate. </param>
        /// <param name="thumbprintAlgorithm"> The algorithm with which the thumbprint is associated. This must be sha1. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="thumbprint"/> or <paramref name="thumbprintAlgorithm"/> is null. </exception>
        public CertificateReference(string thumbprint, string thumbprintAlgorithm)
        {
            if (thumbprint == null)
            {
                throw new ArgumentNullException(nameof(thumbprint));
            }
            if (thumbprintAlgorithm == null)
            {
                throw new ArgumentNullException(nameof(thumbprintAlgorithm));
            }

            Thumbprint = thumbprint;
            ThumbprintAlgorithm = thumbprintAlgorithm;
            Visibility = new ChangeTrackingList<CertificateVisibility>();
        }

        /// <summary> Initializes a new instance of CertificateReference. </summary>
        /// <param name="thumbprint"> The thumbprint of the Certificate. </param>
        /// <param name="thumbprintAlgorithm"> The algorithm with which the thumbprint is associated. This must be sha1. </param>
        /// <param name="storeLocation"> The default value is currentuser. This property is applicable only for Pools configured with Windows Compute Nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows Image reference). For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location. For Certificates with visibility of &apos;remoteUser&apos;, a &apos;certs&apos; directory is created in the user&apos;s home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory. </param>
        /// <param name="storeName"> This property is applicable only for Pools configured with Windows Compute Nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows Image reference). Common store names include: My, Root, CA, Trust, Disallowed, TrustedPeople, TrustedPublisher, AuthRoot, AddressBook, but any custom store name can also be used. The default value is My. </param>
        /// <param name="visibility"> You can specify more than one visibility in this collection. The default is all Accounts. </param>
        internal CertificateReference(string thumbprint, string thumbprintAlgorithm, CertificateStoreLocation? storeLocation, string storeName, IList<CertificateVisibility> visibility)
        {
            Thumbprint = thumbprint;
            ThumbprintAlgorithm = thumbprintAlgorithm;
            StoreLocation = storeLocation;
            StoreName = storeName;
            Visibility = visibility;
        }

        /// <summary> The thumbprint of the Certificate. </summary>
        public string Thumbprint { get; set; }
        /// <summary> The algorithm with which the thumbprint is associated. This must be sha1. </summary>
        public string ThumbprintAlgorithm { get; set; }
        /// <summary> The default value is currentuser. This property is applicable only for Pools configured with Windows Compute Nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows Image reference). For Linux Compute Nodes, the Certificates are stored in a directory inside the Task working directory and an environment variable AZ_BATCH_CERTIFICATES_DIR is supplied to the Task to query for this location. For Certificates with visibility of &apos;remoteUser&apos;, a &apos;certs&apos; directory is created in the user&apos;s home directory (e.g., /home/{user-name}/certs) and Certificates are placed in that directory. </summary>
        public CertificateStoreLocation? StoreLocation { get; set; }
        /// <summary> This property is applicable only for Pools configured with Windows Compute Nodes (that is, created with cloudServiceConfiguration, or with virtualMachineConfiguration using a Windows Image reference). Common store names include: My, Root, CA, Trust, Disallowed, TrustedPeople, TrustedPublisher, AuthRoot, AddressBook, but any custom store name can also be used. The default value is My. </summary>
        public string StoreName { get; set; }
        /// <summary> You can specify more than one visibility in this collection. The default is all Accounts. </summary>
        public IList<CertificateVisibility> Visibility { get; }
    }
}
