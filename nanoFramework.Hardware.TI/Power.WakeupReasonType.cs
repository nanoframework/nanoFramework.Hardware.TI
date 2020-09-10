//
// Copyright (c) 2020 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.Hardware.TI
{
    public partial class Power
    {
        /// <summary>
        /// Wakeup reason enumeration.
        /// </summary>
        public enum WakeupReasonType
        {
            /// <summary>
            /// Undetermined wakeup reason.
            /// </summary>
            Undetermined = 0,

            /// <summary>
            /// Wakeup from shudown mode.
            /// </summary>
            FromShutdown,

            /// <summary>
            /// Wakeup from pin.
            /// </summary>
            FromPin
        }
    }
}
