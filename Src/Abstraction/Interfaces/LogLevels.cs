// --------------------------------------------------------------------------------------
// <copyright file="LogLevels.cs" company="iPAHeartBeat">
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
