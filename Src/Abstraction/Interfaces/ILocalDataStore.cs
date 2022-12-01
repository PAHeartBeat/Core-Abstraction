// --------------------------------------------------------------------------------------
// <copyright file="ILocalDataStore.cs" company="iPAHeartBeat">
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

using System.Collections.Generic;

namespace iPAHeartBeat.Core.Abstraction;

/// <summary>
/// Will Provide  to use basic Structure to use different kind of data storage option like PlayerPref or File or any other.
/// </summary>
public interface ILocalDataStore {
	/// <summary>
	/// Gets or set the list of the key which needs to be sync with server.
	/// </summary>
	List<string> PendingKeys { get; }

	/// <summary>
	/// Will Clear all local data from local cache.
	/// </summary>
	void ClearLocalData();

	/// <summary>
	/// Will Help to read key from Local data cache with typed/manged data type.
	/// </summary>
	/// <typeparam name="T">Type of the data which could be return from Data store.</typeparam>
	/// <param name="key">Data key to read.</param>
	/// <param name="defaultValue">Default value for the key if data is not availble in data store.</param>
	/// <returns>the typed data from the key or default value if data is not exists for data key.</returns>
	T GetKey<T>(string key, T defaultValue);

	/// <summary>
	/// Will Try to Write Data for a key on local data storage. data will be written without any encryption.
	/// </summary>
	/// <param name="key">Data key to read.</param>
	/// <param name="value">Un-encrypted data which need to be write on local storage.</param>
	void SetKey(string key, object value);

	/// <summary>
	/// Will Try to Write Data for a key on local data storage. data will be written either with encryption or without it based on Should Encrypt parameter.
	/// </summary>
	/// <param name="key">Data key to read.</param>
	/// <param name="value">Un-encrypted data which need to be write on local storage.</param>
	/// <param name="shouldEncrypt">Flag about should data write on local store with encryption on not.</param>
	/// <param name="willAddInPendingList">Flag about should data marked to pending list to sync..</param>
	void SetKey(string key, object value, bool shouldEncrypt, bool willAddInPendingList);

	/// <summary>
	/// The Helper service to unmark the data keys for sync with server.
	/// </summary>
	/// <param name="key">The data key which needs to unmark.</param>
	void UnMarkKey(string key);

	/// <summary>
	/// The Helper service to removes multiple key for server sync list.
	/// </summary>
	/// <param name="keys">The collection of the keys which needs to be unmark.</param>
	void UnMarkKeys(List<string> keys);
}
