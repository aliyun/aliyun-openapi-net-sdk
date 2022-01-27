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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeClusterMemberInfoResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeClusterMemberInfo_Children> clusterChildren;

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

		public List<DescribeClusterMemberInfo_Children> ClusterChildren
		{
			get
			{
				return clusterChildren;
			}
			set	
			{
				clusterChildren = value;
			}
		}

		public class DescribeClusterMemberInfo_Children
		{

			private long? id;

			private string name;

			private string bizType;

			private int? replicaSize;

			private int? modifier;

			private string serviceVersion;

			private int? diskSizeMB;

			private string nickname;

			private string primaryInsName;

			private string classCode;

			private int? creator;

			private string resourceGroupName;

			private string health;

			private int? binlogRetentionDays;

			private string userId;

			private string lockReason;

			private string service;

			private long? capacity;

			private long? bandWidth;

			private long? connections;

			private long? currentBandWidth;

			private List<DescribeClusterMemberInfo_Item> items;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public int? ReplicaSize
			{
				get
				{
					return replicaSize;
				}
				set	
				{
					replicaSize = value;
				}
			}

			public int? Modifier
			{
				get
				{
					return modifier;
				}
				set	
				{
					modifier = value;
				}
			}

			public string ServiceVersion
			{
				get
				{
					return serviceVersion;
				}
				set	
				{
					serviceVersion = value;
				}
			}

			public int? DiskSizeMB
			{
				get
				{
					return diskSizeMB;
				}
				set	
				{
					diskSizeMB = value;
				}
			}

			public string Nickname
			{
				get
				{
					return nickname;
				}
				set	
				{
					nickname = value;
				}
			}

			public string PrimaryInsName
			{
				get
				{
					return primaryInsName;
				}
				set	
				{
					primaryInsName = value;
				}
			}

			public string ClassCode
			{
				get
				{
					return classCode;
				}
				set	
				{
					classCode = value;
				}
			}

			public int? Creator
			{
				get
				{
					return creator;
				}
				set	
				{
					creator = value;
				}
			}

			public string ResourceGroupName
			{
				get
				{
					return resourceGroupName;
				}
				set	
				{
					resourceGroupName = value;
				}
			}

			public string Health
			{
				get
				{
					return health;
				}
				set	
				{
					health = value;
				}
			}

			public int? BinlogRetentionDays
			{
				get
				{
					return binlogRetentionDays;
				}
				set	
				{
					binlogRetentionDays = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string LockReason
			{
				get
				{
					return lockReason;
				}
				set	
				{
					lockReason = value;
				}
			}

			public string Service
			{
				get
				{
					return service;
				}
				set	
				{
					service = value;
				}
			}

			public long? Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public long? BandWidth
			{
				get
				{
					return bandWidth;
				}
				set	
				{
					bandWidth = value;
				}
			}

			public long? Connections
			{
				get
				{
					return connections;
				}
				set	
				{
					connections = value;
				}
			}

			public long? CurrentBandWidth
			{
				get
				{
					return currentBandWidth;
				}
				set	
				{
					currentBandWidth = value;
				}
			}

			public List<DescribeClusterMemberInfo_Item> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class DescribeClusterMemberInfo_Item
			{

				private int? id;

				private string hostName;

				private string role;

				private string status;

				private string zoneId;

				private string ip;

				private List<string> ports;

				public int? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
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

				public string Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
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

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
					}
				}

				public string Ip
				{
					get
					{
						return ip;
					}
					set	
					{
						ip = value;
					}
				}

				public List<string> Ports
				{
					get
					{
						return ports;
					}
					set	
					{
						ports = value;
					}
				}
			}
		}
	}
}
