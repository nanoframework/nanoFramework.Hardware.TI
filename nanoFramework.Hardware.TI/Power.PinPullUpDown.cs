//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Hardware.TI
{
    public partial class Power
    {
        /// <summary>
        /// Configuration for GPIO pin internal pull-up or pull-down resitor.
        /// </summary>

        // these values match the corresponding definitions from TI SimpleLink SDK
        // PIN_NOPULL
        // PIN_PULLUP
        // PIN_PULLDOWN
        public enum PinPullUpDown : uint
        {
            /// <summary>
            /// No pull-up or pull-down resistor.
            /// </summary>
            None = 0x80000000,

            /// <summary>
            /// Enable internal pull-up resistor for GPIO pin.
            /// </summary>
            PullUp = 0x80002000,

            /// <summary>
            /// Enable internal pull-down resistor for GPIO pin.
            /// </summary>
            PullDown = 0x80004000
        }
    }
}
