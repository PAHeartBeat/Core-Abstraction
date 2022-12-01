// --------------------------------------------------------------------------------------
// <copyright file="ISignalManager.cs" company="iPAHeartBeat">
// Copyright (c) iPAHeartBeat. All rights reserved.
// </copyright>
// <contribution>
// Author:           Ankur Ranpariya {iPAHeartBeat}
// EMail:            ankur30884@gmail.com
// Copyright:        (c) 2017, by: Ranpariya Ankur {iPAHeartBeat}
// Social:           @iPAHeartBeat, www.ranpariyaankur.com
//
// Original Source:  http://wiki.unity3d.com/index.php/NotificationCenter
// Last Modified:    Ankur Ranpariya
//
// Contributed by:   .
// Curtsey By:       .
// </contribution>
// --------------------------------------------------------------------------------------

using System;

namespace iPAHeartBeat.Core.Abstraction;

/// <summary>
/// This interface will provide basic infrastructure to use different Signal System with different kind on internal system.
/// </summary>
public interface ISignalManager {
	/// <summary>
	/// Will Execute the Signal with delay. Delay will be managed by Threading and execution of actual signal will happens with separate thread. Which could cause issue in certain system which are not allowed other than main thread of the application.
	/// </summary>
	/// <typeparam name="T">Signal type.</typeparam>
	/// <param name="data">Data with as same signal type which need pass with module or system.</param>
	/// <param name="wait">wait time in seconds before it will executes.</param>
	void DelayedFire<T>(T data, float wait);

	/// <summary>
	/// Will Execute the Signal instant in same thread from where execution asked.
	/// </summary>
	/// <typeparam name="T">Signal type.</typeparam>
	/// <param name="data">Data with as same signal type which need pass with module or system.</param>
	void Fire<T>(T data);

	/// <summary>
	/// Will register/subscribe a method which has a parametr of same signal type as Listener of signal for the particular signal type. If the method is already subscribed for particular signal, it will not be re-added as duplicate listener to avoid multiple call of a single listener and ignored silently without any error.
	/// </summary>
	/// <typeparam name="T">Signal type.</typeparam>
	/// <param name="handler">Reference of the method or action which will be executed when Signal fired.</param>
	void SubscribeSignal<T>(Action<T> handler);

	/// <summary>
	/// Will unregister/unsubscribe  method which subscribed to listen signals to execute. If method is not subscribed for particular signal type it will be silently ignored without any error.
	/// </summary>
	/// <typeparam name="T">Signal type.</typeparam>
	/// <param name="handler">Reference of the method or action which will be executed when Signal fired.</param>
	void UnsubscribeSignal<T>(Action<T> handler);
}
