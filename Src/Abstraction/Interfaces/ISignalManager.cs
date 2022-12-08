// --------------------------------------------------------------------------------------
// <copyright file="ISignalManager.cs" company="iPAHeartBeat">
// Copyright (c) iPAHeartBeat. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------

/*
Author:				Ankur Ranpariya {iPAHeartBeat}
EMail:				ankur30884@gmail.com
Copyright:			(c) 2017, Ankur Ranpariya {iPAHeartBeat}
Social:				@iPAHeartBeat,
GitHubL				https://www.github.com/PAHeartBeat

Original Source:	http://wiki.unity3d.com/index.php/NotificationCenter
Last Modified: 		Ankur Ranpariya
Contributed By:		N/A

All rights reserved.
Redistribution and use in source and binary forms, with or without modification, are permitted provided that the
following conditions are met:

* Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
* Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
* Neither the name of the [ORGANIZATION] nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.


The above copyright notice and this permission notice shall be included in all copies or substantial portions of the
Software.

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
rights to use, copy, modify, merge, publish, distribute, sub license, and/or sell copies of the Software, and to permit
persons to whom the Software is furnished to do so, subject to the following conditions:

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE
*/

//
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
