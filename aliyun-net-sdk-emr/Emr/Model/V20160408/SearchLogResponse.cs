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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class SearchLogResponse : AcsResponse
	{

		private string requestId;

		private bool? completed;

		private List<SearchLog_SlsLogItem> slsLogItemList;

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

		public bool? Completed
		{
			get
			{
				return completed;
			}
			set	
			{
				completed = value;
			}
		}

		public List<SearchLog_SlsLogItem> SlsLogItemList
		{
			get
			{
				return slsLogItemList;
			}
			set	
			{
				slsLogItemList = value;
			}
		}

		public class SearchLog_SlsLogItem
		{

			private int? timestamp;

			private string sourceIp;

			private string hostName;

			private string path;

			private string content;

			private string packMeta;

			private string packId;

			public int? Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			public string SourceIp
			{
				get
				{
					return sourceIp;
				}
				set	
				{
					sourceIp = value;
				}
			}

			public string HostName
			{
				get
				{
					return hostName;
				}
				set	
				{
					hostName = value;
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

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public string PackMeta
			{
				get
				{
					return packMeta;
				}
				set	
				{
					packMeta = value;
				}
			}

			public string PackId
			{
				get
				{
					return packId;
				}
				set	
				{
					packId = value;
				}
			}
		}
	}
}
