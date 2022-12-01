// --------------------------------------------------------------------------------------
// <copyright file="INotificationUpdater.cs" company="iPAHeartBeat">
// Copyright (c) iPAHeartBeat. All rights reserved.
// </copyright>
// <contribution>
// Author:           Ankur Ranpariya {iPAHeartBeat}
// EMail:            ankur30884@gmail.com
// Copyright:        (c) 2021, by: Ranpariya Ankur {iPAHeartBeat}
// Social:           @iPAHeartBeat, www.ranpariyaankur.com
//
// Original Source:  .
// Last Modified:    Ankur Ranpariya
//
// Contributed by:   .
// Curtsey By:       .
// </contribution>
// --------------------------------------------------------------------------------------

namespace iPAHeartBeat.Core.Abstraction;

/// <summary>
/// The System which can not just have notification option but with this it's have open system to change or reset the count of changes and/or addition.
/// </summary>
public interface INotificationUpdater : INotifiable {
	/// <summary>
	/// This will reset count to zero for changes and/or addition.
	/// </summary>
	void Reset();

	/// <summary>
	/// This will reduce the count of changes and/or addition.
	/// </summary>
	/// <param name="change">The count needs to reduce from current count.</param>
	void Reduce(uint change);
}
