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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListNodesResponse : AcsResponse
	{

		private string requestId;

		private List<ListNodes_ResultItem> result;

		private ListNodes_Headers headers;

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

		public List<ListNodes_ResultItem> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public ListNodes_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListNodes_ResultItem
		{

			private string ecsInstanceId;

			private string ecsInstanceName;

			private string status;

			private string osType;

			private string cloudAssistantStatus;

			private string agentStatus;

			private List<ListNodes_TagsItem> tags;

			private List<ListNodes_IpAddressItem> ipAddress;

			public string EcsInstanceId
			{
				get
				{
					return ecsInstanceId;
				}
				set	
				{
					ecsInstanceId = value;
				}
			}

			public string EcsInstanceName
			{
				get
				{
					return ecsInstanceName;
				}
				set	
				{
					ecsInstanceName = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string OsType
			{
				get
				{
					return osType;
				}
				set	
				{
					osType = value;
				}
			}

			public string CloudAssistantStatus
			{
				get
				{
					return cloudAssistantStatus;
				}
				set	
				{
					cloudAssistantStatus = value;
				}
			}

			public string AgentStatus
			{
				get
				{
					return agentStatus;
				}
				set	
				{
					agentStatus = value;
				}
			}

			public List<ListNodes_TagsItem> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public List<ListNodes_IpAddressItem> IpAddress
			{
				get
				{
					return ipAddress;
				}
				set	
				{
					ipAddress = value;
				}
			}

			public class ListNodes_TagsItem
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}

			public class ListNodes_IpAddressItem
			{

				private string host;

				private string ipType;

				public string Host
				{
					get
					{
						return host;
					}
					set	
					{
						host = value;
					}
				}

				public string IpType
				{
					get
					{
						return ipType;
					}
					set	
					{
						ipType = value;
					}
				}
			}
		}

		public class ListNodes_Headers
		{

			private int? xTotalCount;

			public int? XTotalCount
			{
				get
				{
					return xTotalCount;
				}
				set	
				{
					xTotalCount = value;
				}
			}
		}
	}
}
