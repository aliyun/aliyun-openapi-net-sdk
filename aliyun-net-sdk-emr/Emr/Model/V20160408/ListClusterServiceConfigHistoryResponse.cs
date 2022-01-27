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
	public class ListClusterServiceConfigHistoryResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListClusterServiceConfigHistory_ConfigHistory> configHistoryList;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<ListClusterServiceConfigHistory_ConfigHistory> ConfigHistoryList
		{
			get
			{
				return configHistoryList;
			}
			set	
			{
				configHistoryList = value;
			}
		}

		public class ListClusterServiceConfigHistory_ConfigHistory
		{

			private string serviceName;

			private string configVersion;

			private string configFileName;

			private string configItemName;

			private string newValue;

			private string oldValue;

			private bool? applied;

			private long? createTime;

			private string author;

			private string comment;

			private string hostGroupId;

			private string hostGroupName;

			private string hostInstanceId;

			private string hostName;

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string ConfigVersion
			{
				get
				{
					return configVersion;
				}
				set	
				{
					configVersion = value;
				}
			}

			public string ConfigFileName
			{
				get
				{
					return configFileName;
				}
				set	
				{
					configFileName = value;
				}
			}

			public string ConfigItemName
			{
				get
				{
					return configItemName;
				}
				set	
				{
					configItemName = value;
				}
			}

			public string NewValue
			{
				get
				{
					return newValue;
				}
				set	
				{
					newValue = value;
				}
			}

			public string OldValue
			{
				get
				{
					return oldValue;
				}
				set	
				{
					oldValue = value;
				}
			}

			public bool? Applied
			{
				get
				{
					return applied;
				}
				set	
				{
					applied = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string Author
			{
				get
				{
					return author;
				}
				set	
				{
					author = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string HostGroupId
			{
				get
				{
					return hostGroupId;
				}
				set	
				{
					hostGroupId = value;
				}
			}

			public string HostGroupName
			{
				get
				{
					return hostGroupName;
				}
				set	
				{
					hostGroupName = value;
				}
			}

			public string HostInstanceId
			{
				get
				{
					return hostInstanceId;
				}
				set	
				{
					hostInstanceId = value;
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
		}
	}
}
