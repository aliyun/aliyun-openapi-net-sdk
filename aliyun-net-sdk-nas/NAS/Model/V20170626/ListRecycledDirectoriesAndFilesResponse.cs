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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class ListRecycledDirectoriesAndFilesResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<ListRecycledDirectoriesAndFiles_Entry> entries;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<ListRecycledDirectoriesAndFiles_Entry> Entries
		{
			get
			{
				return entries;
			}
			set	
			{
				entries = value;
			}
		}

		public class ListRecycledDirectoriesAndFiles_Entry
		{

			private string fileId;

			private string type;

			private string name;

			private string deleteTime;

			private string inode;

			private string aTime;

			private string mTime;

			private string cTime;

			private long? size;

			public string FileId
			{
				get
				{
					return fileId;
				}
				set	
				{
					fileId = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string DeleteTime
			{
				get
				{
					return deleteTime;
				}
				set	
				{
					deleteTime = value;
				}
			}

			public string Inode
			{
				get
				{
					return inode;
				}
				set	
				{
					inode = value;
				}
			}

			public string ATime
			{
				get
				{
					return aTime;
				}
				set	
				{
					aTime = value;
				}
			}

			public string MTime
			{
				get
				{
					return mTime;
				}
				set	
				{
					mTime = value;
				}
			}

			public string CTime
			{
				get
				{
					return cTime;
				}
				set	
				{
					cTime = value;
				}
			}

			public long? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}
		}
	}
}
