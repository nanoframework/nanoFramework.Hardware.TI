//
// Copyright (c) 2020 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Hardware.TI
{
    public partial class Power
    {
        /// <summary>
        /// Configuration for GPIO pin wakeup sensivity.
        /// </summary>

        // these values match the corresponding definitions from TI SimpleLink SDK
        // PINCC26XX_NO_WAKEUP
        // PINCC26XX_WAKEUP_POSEDGE
        // PINCC26XX_WAKEUP_NEGEDGE
        public enum PinWakeupEdge
        {
            /// <summary>
            /// No wakeup.
            /// </summary>
            None = 0,

            /// <summary>
            /// Wakeup from shutdown on positive edge.
            /// </summary>
            PositiveEdge = 0x18000000,

            /// <summary>
            /// Wakeup from shutdown on negative edge.
            /// </summary>
            NegativeEdge = 0x10000000
        }
    }
}
