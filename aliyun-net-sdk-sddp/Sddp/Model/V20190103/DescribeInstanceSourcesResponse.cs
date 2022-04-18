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
	public class DescribeInstanceSourcesResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeInstanceSources_InstanceSource> items;

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

		public List<DescribeInstanceSources_InstanceSource> Items
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

		public class DescribeInstanceSources_InstanceSource
		{

			private string lastModifyUserId;

			private int? passwordStatus;

			private string engineType;

			private string tenantName;

			private string instanceId;

			private string instanceDescription;

			private long? dataLimitId;

			private string regionId;

			private string dbName;

			private long? lastModifyTime;

			private string regionName;

			private bool? canModifyUserName;

			private int? logStoreDay;

			private long? gmtCreate;

			private int? autoScan;

			private long? productId;

			private long? instanceSize;

			private string userName;

			private int? auditStatus;

			private long? id;

			private string tenantId;

			private int? enable;

			private int? checkStatus;

			private int? datamaskStatus;

			private string errorMessage;

			private int? samplingSize;

			public string LastModifyUserId
			{
				get
				{
					return lastModifyUserId;
				}
				set	
				{
					lastModifyUserId = value;
				}
			}

			public int? PasswordStatus
			{
				get
				{
					return passwordStatus;
				}
				set	
				{
					passwordStatus = value;
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

			public long? DataLimitId
			{
				get
				{
					return dataLimitId;
				}
				set	
				{
					dataLimitId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string DbName
			{
				get
				{
					return dbName;
				}
				set	
				{
					dbName = value;
				}
			}

			public long? LastModifyTime
			{
				get
				{
					return lastModifyTime;
				}
				set	
				{
					lastModifyTime = value;
				}
			}

			public string RegionName
			{
				get
				{
					return regionName;
				}
				set	
				{
					regionName = value;
				}
			}

			public bool? CanModifyUserName
			{
				get
				{
					return canModifyUserName;
				}
				set	
				{
					canModifyUserName = value;
				}
			}

			public int? LogStoreDay
			{
				get
				{
					return logStoreDay;
				}
				set	
				{
					logStoreDay = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public int? AutoScan
			{
				get
				{
					return autoScan;
				}
				set	
				{
					autoScan = value;
				}
			}

			public long? ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
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

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
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

			public int? Enable
			{
				get
				{
					return enable;
				}
				set	
				{
					enable = value;
				}
			}

			public int? CheckStatus
			{
				get
				{
					return checkStatus;
				}
				set	
				{
					checkStatus = value;
				}
			}

			public int? DatamaskStatus
			{
				get
				{
					return datamaskStatus;
				}
				set	
				{
					datamaskStatus = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public int? SamplingSize
			{
				get
				{
					return samplingSize;
				}
				set	
				{
					samplingSize = value;
				}
			}
		}
	}
}
