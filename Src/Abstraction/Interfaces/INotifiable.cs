// --------------------------------------------------------------------------------------
// <copyright file="INotifiable.cs" company="iPAHeartBeat">
// Copyright (c) iPAHeartBeat. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------

/*
Author:				Ankur Ranpariya {iPAHeartBeat}
EMail:				ankur30884@gmail.com
Copyright:			(c) 2017, Ankur Ranpariya {iPAHeartBeat}
Social:				@iPAHeartBeat,
GitHubL				https://www.github.com/PAHeartBeat

Original Source:	N/A
Last Modified:		Ankur Ranpariya
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
