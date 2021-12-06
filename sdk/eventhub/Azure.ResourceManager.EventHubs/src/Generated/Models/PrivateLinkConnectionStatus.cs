// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Status of the connection. </summary>
    public readonly partial struct PrivateLinkConnectionStatus : IEquatable<PrivateLinkConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrivateLinkConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateLinkConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static PrivateLinkConnectionStatus Pending { get; } = new PrivateLinkConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static PrivateLinkConnectionStatus Approved { get; } = new PrivateLinkConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static PrivateLinkConnectionStatus Rejected { get; } = new PrivateLinkConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static PrivateLinkConnectionStatus Disconnected { get; } = new PrivateLinkConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="PrivateLinkConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(PrivateLinkConnectionStatus left, PrivateLinkConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateLinkConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(PrivateLinkConnectionStatus left, PrivateLinkConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrivateLinkConnectionStatus"/>. </summary>
        public static implicit operator PrivateLinkConnectionStatus(string value) => new PrivateLinkConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateLinkConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateLinkConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
