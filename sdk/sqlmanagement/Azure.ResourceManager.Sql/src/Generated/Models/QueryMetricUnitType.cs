// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The unit of the metric. </summary>
    public readonly partial struct QueryMetricUnitType : IEquatable<QueryMetricUnitType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QueryMetricUnitType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryMetricUnitType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PercentageValue = "percentage";
        private const string KBValue = "KB";
        private const string MicrosecondsValue = "microseconds";
        private const string CountValue = "count";

        /// <summary> percentage. </summary>
        public static QueryMetricUnitType Percentage { get; } = new QueryMetricUnitType(PercentageValue);
        /// <summary> KB. </summary>
        public static QueryMetricUnitType KB { get; } = new QueryMetricUnitType(KBValue);
        /// <summary> microseconds. </summary>
        public static QueryMetricUnitType Microseconds { get; } = new QueryMetricUnitType(MicrosecondsValue);
        /// <summary> count. </summary>
        public static QueryMetricUnitType Count { get; } = new QueryMetricUnitType(CountValue);
        /// <summary> Determines if two <see cref="QueryMetricUnitType"/> values are the same. </summary>
        public static bool operator ==(QueryMetricUnitType left, QueryMetricUnitType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryMetricUnitType"/> values are not the same. </summary>
        public static bool operator !=(QueryMetricUnitType left, QueryMetricUnitType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueryMetricUnitType"/>. </summary>
        public static implicit operator QueryMetricUnitType(string value) => new QueryMetricUnitType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryMetricUnitType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryMetricUnitType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
