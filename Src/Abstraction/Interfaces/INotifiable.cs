// --------------------------------------------------------------------------------
// <copyright file="INotifiable.cs" company="N/A">
// Copyright (c) N/A. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------

namespace iPAHeartBeat.Core.Abstraction;

/// <summary>
/// Sends the Simple event without any input or output.
/// </summary>
public delegate void SimpleEvent();

/// <summary>
/// The system fr the share count of changes and/or addition in particular feature to display Notification on UI.
/// </summary>
public interface INotifiable {
	/// <summary>
	/// Gets the count of changes and/or additions.
	/// </summary>
	uint NotificationCount { get; }

	/// <summary>
	/// The helper method to the subscribe or listen Notification Changes info.
	/// </summary>
	/// <param name="listener">The reference of the method which needs to be added as listener.</param>
	void SubscribeChanges(SimpleEvent listener);

	/// <summary>
	/// the helper method to the unsubscribe or cancel listen notification changes info.
	/// </summary>
	/// <param name="listener">The reference of the method which needs to be removed from listener.</param>
	void UnsubscribeChanges(SimpleEvent listener);

	/// <summary>
	/// The Open Helper method to Inform all listener about changes.
	/// </summary>
	void Notify();
}
