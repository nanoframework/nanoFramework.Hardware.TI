//
// Copyright (c) 2020 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Hardware.TI
{
    public partial class Power
    {
        /// <summary>
        /// Source of system reset.
        /// </summary>
        public enum ResetSource : byte
        {
            /// <summary>
            /// Power-on reset.
            /// </summary>
            PowerOn = 0,

            /// <summary>
            /// Reset pin.
            /// </summary>
            ResetPin,

            /// <summary>
            /// VDDS failure.
            /// </summary>
            VddsFailure,

            /// <summary>
            /// VDDR failure.
            /// </summary>
            VddrFailure,

            /// <summary>
            /// Clock loss detected.
            /// </summary>
            ClockLoss,

            /// <summary>
            /// Software initiated system reset.
            /// </summary>
            SoftwareReset,

            /// <summary>
            /// Warm reset.
            /// </summary>
            WarmReset,

            /// <summary>
            /// System wakeup from shutdown.
            /// </summary>
            WakeupFromShutdown,

            /// <summary>
            /// Detected noise on TCK pin.
            /// </summary>
            NoiseOnTck
        }
    }
}
