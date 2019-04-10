/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListAvailableFileSystemTypesResponse : AcsResponse
	{

		private string requestId;

		private List<ListAvailableFileSystemTypes_FileSystemTypes> fileSystemTypeList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<ListAvailableFileSystemTypes_FileSystemTypes> FileSystemTypeList
		{
			get
			{
				return fileSystemTypeList;
			}
			set	
			{
				fileSystemTypeList = value;
			}
		}

		public class ListAvailableFileSystemTypes_FileSystemTypes
		{

			private string fileSystemType;

			private bool? available;

			private string protocolType;

			private List<string> storageTypes;

			public string FileSystemType
			{
				get
				{
					return fileSystemType;
				}
				set	
				{
					fileSystemType = value;
				}
			}

			public bool? Available
			{
				get
				{
					return available;
				}
				set	
				{
					available = value;
				}
			}

			public string ProtocolType
			{
				get
				{
					return protocolType;
				}
				set	
				{
					protocolType = value;
				}
			}

			public List<string> StorageTypes
			{
				get
				{
					return storageTypes;
				}
				set	
				{
					storageTypes = value;
				}
			}
		}
	}
}
