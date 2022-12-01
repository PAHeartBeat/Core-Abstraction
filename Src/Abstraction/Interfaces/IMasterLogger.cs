// --------------------------------------------------------------------------------------
// <copyright file="IMasterLogger.cs" company="iPAHeartBeat">
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
