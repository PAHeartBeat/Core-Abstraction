// --------------------------------------------------------------------------------------
// <copyright file="IMasterLogger.cs" company="iPAHeartBeat">
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
/// Basic Logger Infra structure to create Different type of logger and use it with game system.
/// </summary>
public interface IMasterLogger : ICustomLogger {
	/// <summary>
	/// The Helper service to Register loggers to process logs.
	/// </summary>
	/// <param name="loggerId">The unique identifer of the logger implementation.</param>
	/// <param name="logger">The instance of the <see ref="ICustomLogger"/> Implementation.</param>
	void RegisterLogger(string loggerId, ICustomLogger logger);

	/// <summary>
	/// Will Remove the logger system from internal Logger collection for specified logger id..
	/// </summary>
	/// <param name="loggerId">The unique identifier for the logger implementation.</param>
	void RemoveLogger(string loggerId);

	/// <summary>
	/// Will return the reference of the logger implementation for specified logger id.
	/// </summary>
	/// <param name="loggerId">The unique identifier for the logger implementation.</param>
	/// <returns>The instance of logger system if exists otherwise null.</returns>
	ICustomLogger GetLogger(string loggerId);
}
