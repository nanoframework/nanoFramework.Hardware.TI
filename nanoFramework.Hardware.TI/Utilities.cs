//
// Copyright (c) 2020 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

using System.Runtime.CompilerServices;

namespace nanoFramework.Hardware.TI
{
    /// <summary>
    /// Utilities for managing and handling TI SimpleLink target devices.
    /// </summary>
    /// <remarks>
    /// This API is available only for TI targets.
    /// </remarks>
    public static class Utilities
    {
        private static byte[] _deviceIeeeAddress;

        /// <summary>
        /// Gets the IEEE Address.
        /// </summary>
        public static byte[] IeeeAddress()
        {
            if (_deviceIeeeAddress == null)
            {
                _deviceIeeeAddress = NativeGetIeeeAddress();
            }

            return _deviceIeeeAddress;
        }

        #region native methods calls

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern byte[] NativeGetIeeeAddress();

        #endregion
    }
}
