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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeParentInstanceResponse : AcsResponse
	{

		private string requestId;

		private int? currentPage;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeParentInstance_Data> items;

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

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
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

		public List<DescribeParentInstance_Data> Items
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

		public class DescribeParentInstance_Data
		{

			private string instanceId;

			private string localName;

			private string engineType;

			private string parentId;

			private string dbNum;

			private string clusterStatus;

			private string tenantId;

			private string tenantName;

			private string instanceDescription;

			private string resourceType;

			private string unConnectDbCount;

			private string unSupportOneClickAuthReason;

			private string connectNode;

			private string supportConnectNodes;

			private int? authStatus;

			private long? instanceSize;

			private int? auditStatus;

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string LocalName
			{
				get
				{
					return localName;
				}
				set	
				{
					localName = value;
				}
			}

			public string EngineType
			{
				get
				{
					return engineType;
				}
				set	
				{
					engineType = value;
				}
			}

			public string ParentId
			{
				get
				{
					return parentId;
				}
				set	
				{
					parentId = value;
				}
			}

			public string DbNum
			{
				get
				{
					return dbNum;
				}
				set	
				{
					dbNum = value;
				}
			}

			public string ClusterStatus
			{
				get
				{
					return clusterStatus;
				}
				set	
				{
					clusterStatus = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string TenantName
			{
				get
				{
					return tenantName;
				}
				set	
				{
					tenantName = value;
				}
			}

			public string InstanceDescription
			{
				get
				{
					return instanceDescription;
				}
				set	
				{
					instanceDescription = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public string UnConnectDbCount
			{
				get
				{
					return unConnectDbCount;
				}
				set	
				{
					unConnectDbCount = value;
				}
			}

			public string UnSupportOneClickAuthReason
			{
				get
				{
					return unSupportOneClickAuthReason;
				}
				set	
				{
					unSupportOneClickAuthReason = value;
				}
			}

			public string ConnectNode
			{
				get
				{
					return connectNode;
				}
				set	
				{
					connectNode = value;
				}
			}

			public string SupportConnectNodes
			{
				get
				{
					return supportConnectNodes;
				}
				set	
				{
					supportConnectNodes = value;
				}
			}

			public int? AuthStatus
			{
				get
				{
					return authStatus;
				}
				set	
				{
					authStatus = value;
				}
			}

			public long? InstanceSize
			{
				get
				{
					return instanceSize;
				}
				set	
				{
					instanceSize = value;
				}
			}

			public int? AuditStatus
			{
				get
				{
					return auditStatus;
				}
				set	
				{
					auditStatus = value;
				}
			}
		}
	}
}
