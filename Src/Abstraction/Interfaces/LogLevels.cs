// --------------------------------------------------------------------------------
// <copyright file="LogLevels.cs" company="N/A">
// Copyright (c) N/A. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------

namespace iPAHeartBeat.Core.Abstraction;

/// <summary>
/// bitwise Enumeration for the different kind of the logs Levels.
/// </summary>
public enum LogLevels : uint {
	/// <summary>
	/// Common Log level for debug or information.
	/// </summary>
	Log = 1 << 0,

	/// <summary>
	/// Level for major thing which is not right but not break the Code or application.
	/// </summary>
	Warning = 1 << 1,

	/// <summary>
	/// The Major issue that can or did break the code or the application.
	/// </summary>
	Error = 1 << 2,

	/// <summary>
	/// The level of the issue which either handled or not but it needs to report.
	/// </summary>
	Exception = 1 << 3,
}
