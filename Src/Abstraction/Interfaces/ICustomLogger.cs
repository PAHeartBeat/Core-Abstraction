// --------------------------------------------------------------------------------
// <copyright file="ICustomLogger.cs" company="N/A">
// Copyright (c) N/A. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------

using System;

namespace iPAHeartBeat.Core.Abstraction;

/// <summary>
/// Basic Logger Infra structure to create Different type of logger and use it with game system.
/// </summary>
public interface ICustomLogger : IDisposable {
	/// <summary>
	/// Gets or sets the Log level to records.
	/// </summary>
	LogLevels LogLevel { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether flag system to active or deactivate particular logging system.
	/// </summary>
	bool IsLoggingEnabled { get; set; }

	/// <summary>
	/// The Helper method to check Enum value is Bit-wise enum (Flagged Enum or not.)
	/// </summary>
	/// <param name="value">The Enum value need to check.</param>
	/// <param name="checkWith">The value which need to check in bitwise enum.</param>
	/// <returns>true if <paramref name="checkWith"/> is part of <paramref name="value"/> otherwise false.</returns>
	bool IsFlagEnumHasValue(LogLevels value, LogLevels checkWith);

	/// <summary>
	/// Log info in logger as Debug.
	/// </summary>
	/// <param name="feature">Name of the feature for which sending debug log are being added.</param>
	/// <param name="maskValue">the bit-wise masking value to filter debug log based on mask.</param>
	/// <param name="args">data to be logged in system.</param>
	/// <param name="context">Context or file which ais trying to add debug.</param>
	/// <returns>true if log are recorded by logger otherwise false.</returns>
	bool LogDebug(string feature, int maskValue, object args, object context = null);

	/// <summary>
	/// Log info in logger as Warning.
	/// </summary>
	/// <param name="feature">Name of the feature for which sending debug log are being added.</param>
	/// <param name="maskValue">the bit-wise masking value to filter debug log based on mask.</param>
	/// <param name="args">data to be logged in system.</param>
	/// <param name="context">Context or file which ais trying to add debug.</param>
	/// <returns>true if log are recorded by logger otherwise false.</returns>
	bool LogWarning(string feature, int maskValue, object args, object context = null);

	/// <summary>
	/// Log info in logger as Error.
	/// </summary>
	/// <param name="feature">Name of the feature for which sending debug log are being added.</param>
	/// <param name="maskValue">the bit-wise masking value to filter debug log based on mask.</param>
	/// <param name="args">data to be logged in system.</param>
	/// <param name="context">Context or file which ais trying to add debug.</param>
	/// <returns>true if log are recorded by logger otherwise false.</returns>
	bool LogError(string feature, int maskValue, object args, object context = null);

	/// <summary>
	/// Log Exception in logger system.
	/// </summary>
	/// <param name="feature">Name of the feature for which sending debug log are being added.</param>
	/// <param name="maskValue">the bit-wise masking value to filter debug log based on mask.</param>
	/// <param name="ex">data to be logged in system.</param>
	/// <param name="context">Context or file which ais trying to add debug.</param>
	/// <returns>true if log are recorded by logger otherwise false.</returns>
	bool LogException(string feature, int maskValue, Exception ex, object context = null);
}
