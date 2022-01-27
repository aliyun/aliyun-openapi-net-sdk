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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class ListRecentlyRecycledDirectoriesResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<ListRecentlyRecycledDirectories_Entry> entries;

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

		public List<ListRecentlyRecycledDirectories_Entry> Entries
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

		public class ListRecentlyRecycledDirectories_Entry
		{

			private string fileId;

			private string path;

			private string name;

			private string lastDeleteTime;

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

			public string Path
			{
				get
				{
					return path;
				}
				set	
				{
					path = value;
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

			public string LastDeleteTime
			{
				get
				{
					return lastDeleteTime;
				}
				set	
				{
					lastDeleteTime = value;
				}
			}
		}
	}
}
