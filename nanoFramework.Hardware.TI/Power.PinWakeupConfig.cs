//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Hardware.TI
{
    public partial class Power
    {
        /// <summary>
        /// Configuration for GPIO pin to wakeup device.
        /// </summary>
        public class PinWakeupConfig
        {
#pragma warning disable S4487 // these fields will be read in native code
            private readonly int _pin;

            private readonly PinWakeupEdge _wakeupConfig;

            private readonly PinPullUpDown _pinPullUpDown;
#pragma warning restore S4487 // Unread "private" fields should be removed

            /// <summary>
            /// Create a wakeup configuration for a GPIO pin.
            /// </summary>
            /// <param name="pin">GPIO pin number to configure for wakeup.</param>
            /// <param name="wakeupConfig">Wakeup configuration for the GPIO pin.</param>
            /// <param name="pinPullUpDown">Option for internal pull-up or pull-down resistor.</param>
            /// <remarks>
            /// To remove a wakeup configuration from a pin set the <paramref name="wakeupConfig"/> to <see cref="PinWakeupEdge.None"/>.
            /// </remarks>
            public PinWakeupConfig(int pin, PinWakeupEdge wakeupConfig, PinPullUpDown pinPullUpDown = PinPullUpDown.None)
            {
                _pin = pin;
                _wakeupConfig = wakeupConfig;
                _pinPullUpDown = pinPullUpDown;
            }
        }
    }
}
