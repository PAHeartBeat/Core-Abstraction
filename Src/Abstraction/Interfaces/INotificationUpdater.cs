// --------------------------------------------------------------------------------
// <copyright file="INotificationUpdater.cs" company="N/A">
// Copyright (c) N/A. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------

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
