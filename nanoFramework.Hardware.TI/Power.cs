//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Runtime.CompilerServices;

namespace nanoFramework.Hardware.TI
{
    /// <summary>
    /// Provides methods to control power mode of the target CPU.
    /// </summary>
    /// <remarks>
    /// This API is available only for TI targets.
    /// </remarks>
    public static partial class Power
    {
        /// <summary>
        /// Sets the target device to enter TI "shutdown" mode.
        /// </summary>
        /// <remarks>
        /// If no wakeup sources configured then it will be a indefinite sleep.
        /// This call never returns.
        /// After the device enters shutdown a wakeup source will wake the device and the execution will start as if it was a reset.
        /// Keep in mind that the execution WILL NOT continue after the call to this method.
        /// </remarks>
        public static void EnterShutdownMode()
        {
            NativeEnterShutdownMode();

            // force an infinite sleep to allow execution engine to exit this thread and pick the reboot flags set on the call above
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }

        /// <summary>
        /// Sets the target device to enter TI "standby" mode.
        /// </summary>
        /// <param name="duration">Duration of the standby mode.</param>
        /// <remarks>
        /// After the device enters standby it will wake-up after the set period of time .
        /// Keep in mind that the execution WILL NOT continue after the call to this method.
        /// </remarks>
        public static void EnterStandbyMode(TimeSpan duration)
        {
            NativeEnterStandbyMode(duration);

            // force an infinite sleep to allow execution engine to exit this thread and pick the reboot flags set on the call above
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }

        /// <summary>
        /// Setup wakeup configuration from GPIO pins.
        /// </summary>
        /// <param name="pinWakeupConfig">Array of <see cref="PinWakeupConfig"/> with the configuration for the GPIO pins.</param>
        /// <remarks>
        /// This method is used to setup the wakeup configuration from GPIO pins.
        /// If there is a need to make further changes to the configuration just call this method again with the new configuration.
        /// There is no storage for the configuration nor any method to query the existing configuration, if any.
        /// If a GPIO pin has been setup with a wakeup configuration and that needs to be removed, it should be added to the new configuration
        /// array with <see cref="PinWakeupEdge.None"/>.
        /// </remarks>
        [MethodImpl(MethodImplOptions.InternalCall)]
#pragma warning disable S4200 // OK to call native method directly
        public static extern void ConfigureWakeupFromGpioPin(PinWakeupConfig[] pinWakeupConfig);
#pragma warning restore S4200 // Native methods should be wrapped

        #region native methods calls

        /// <summary>
        /// Gets the reset source.
        /// </summary>
        public static extern ResetSource SourceOfReset
        {
            [MethodImpl(MethodImplOptions.InternalCall)]
            get;
        }

        ///// <summary>
        ///// Disables the specified <paramref name="pin"/> as wake-up source.
        ///// </summary>
        ///// <remarks>
        ///// The wake-up pin availability is target dependent. Check the target device data-sheet for details.
        ///// If the specified pin is not available an <see cref="ArgumentException"/> is  thrown.
        ///// </remarks>
        //[MethodImpl(MethodImplOptions.InternalCall)]
        //public static extern void DisableWakeupPin(WakeupPin pin = WakeupPin.Pin1);

        ///// <summary>
        ///// Enables the specified <paramref name="pin"/> as wake-up source.
        ///// </summary>
        ///// <remarks>
        ///// The wake-up pin availability is target dependent. Check the target device data-sheet for details.
        ///// If the specified pin is not available an <see cref="ArgumentException"/> is  thrown.
        ///// </remarks>
        //[MethodImpl(MethodImplOptions.InternalCall)]
        //public static extern void EnableWakeupPin(WakeupPin pin = WakeupPin.Pin1);

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern void NativeEnterShutdownMode();

        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern void NativeEnterStandbyMode(TimeSpan duration);

        #endregion

    }
}
