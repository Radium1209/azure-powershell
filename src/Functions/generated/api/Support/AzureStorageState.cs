// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    public partial struct AzureStorageState :
        System.IEquatable<AzureStorageState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState InvalidCredentials = @"InvalidCredentials";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState InvalidShare = @"InvalidShare";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState Ok = @"Ok";

        /// <summary>the value for an instance of the <see cref="AzureStorageState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AzureStorageState" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AzureStorageState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AzureStorageState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AzureStorageState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AzureStorageState(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AzureStorageState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AzureStorageState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AzureStorageState && Equals((AzureStorageState)obj);
        }

        /// <summary>Returns hashCode for enum AzureStorageState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AzureStorageState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AzureStorageState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AzureStorageState" />.</param>

        public static implicit operator AzureStorageState(string value)
        {
            return new AzureStorageState(value);
        }

        /// <summary>Implicit operator to convert AzureStorageState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AzureStorageState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AzureStorageState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AzureStorageState</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.AzureStorageState e2)
        {
            return e2.Equals(e1);
        }
    }
}