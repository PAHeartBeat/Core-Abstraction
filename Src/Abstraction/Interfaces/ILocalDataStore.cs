// --------------------------------------------------------------------------------------
// <copyright file="ILocalDataStore.cs" company="iPAHeartBeat">
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
