// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> For more information see [setting the AKS cluster auto-upgrade channel](https://docs.microsoft.com/azure/aks/upgrade-cluster#set-auto-upgrade-channel). </summary>
    public readonly partial struct UpgradeChannel : IEquatable<UpgradeChannel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UpgradeChannel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UpgradeChannel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RapidValue = "rapid";
        private const string StableValue = "stable";
        private const string PatchValue = "patch";
        private const string NodeImageValue = "node-image";
        private const string NoneValue = "none";

        /// <summary> Automatically upgrade the cluster to the latest supported patch release on the latest supported minor version. In cases where the cluster is at a version of Kubernetes that is at an N-2 minor version where N is the latest supported minor version, the cluster first upgrades to the latest supported patch version on N-1 minor version. For example, if a cluster is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, your cluster first is upgraded to 1.18.6, then is upgraded to 1.19.1. </summary>
        public static UpgradeChannel Rapid { get; } = new UpgradeChannel(RapidValue);
        /// <summary> Automatically upgrade the cluster to the latest supported patch release on minor version N-1, where N is the latest supported minor version. For example, if a cluster is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, your cluster is upgraded to 1.18.6. </summary>
        public static UpgradeChannel Stable { get; } = new UpgradeChannel(StableValue);
        /// <summary> Automatically upgrade the cluster to the latest supported patch version when it becomes available while keeping the minor version the same. For example, if a cluster is running version 1.17.7 and versions 1.17.9, 1.18.4, 1.18.6, and 1.19.1 are available, your cluster is upgraded to 1.17.9. </summary>
        public static UpgradeChannel Patch { get; } = new UpgradeChannel(PatchValue);
        /// <summary> Automatically upgrade the node image to the latest version available. Microsoft provides patches and new images for image nodes frequently (usually weekly), but your running nodes won&apos;t get the new images unless you do a node image upgrade. Turning on the node-image channel will automatically update your node images whenever a new version is available. </summary>
        public static UpgradeChannel NodeImage { get; } = new UpgradeChannel(NodeImageValue);
        /// <summary> Disables auto-upgrades and keeps the cluster at its current version of Kubernetes. </summary>
        public static UpgradeChannel None { get; } = new UpgradeChannel(NoneValue);
        /// <summary> Determines if two <see cref="UpgradeChannel"/> values are the same. </summary>
        public static bool operator ==(UpgradeChannel left, UpgradeChannel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UpgradeChannel"/> values are not the same. </summary>
        public static bool operator !=(UpgradeChannel left, UpgradeChannel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UpgradeChannel"/>. </summary>
        public static implicit operator UpgradeChannel(string value) => new UpgradeChannel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UpgradeChannel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UpgradeChannel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
