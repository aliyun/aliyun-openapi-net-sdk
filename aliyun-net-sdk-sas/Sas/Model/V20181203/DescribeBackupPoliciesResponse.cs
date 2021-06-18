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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeBackupPoliciesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeBackupPolicies_BackupPolicy> policies;

		private DescribeBackupPolicies_PageInfo pageInfo;

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

		public List<DescribeBackupPolicies_BackupPolicy> Policies
		{
			get
			{
				return policies;
			}
			set	
			{
				policies = value;
			}
		}

		public DescribeBackupPolicies_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeBackupPolicies_BackupPolicy
		{

			private long? id;

			private string name;

			private string status;

			private string policy;

			private string policyVersion;

			private string policyRegionId;

			private string clientStatus;

			private int? clientErrorCount;

			private int? serviceErrorCount;

			private int? healthClientCount;

			private List<string> uuidList;

			private List<string> remarkedUuidList;

			private List<string> clientErrorUuidList;

			private List<string> serviceErrorUuidList;

			private List<string> healthClientUuidList;

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

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}

			public string PolicyVersion
			{
				get
				{
					return policyVersion;
				}
				set	
				{
					policyVersion = value;
				}
			}

			public string PolicyRegionId
			{
				get
				{
					return policyRegionId;
				}
				set	
				{
					policyRegionId = value;
				}
			}

			public string ClientStatus
			{
				get
				{
					return clientStatus;
				}
				set	
				{
					clientStatus = value;
				}
			}

			public int? ClientErrorCount
			{
				get
				{
					return clientErrorCount;
				}
				set	
				{
					clientErrorCount = value;
				}
			}

			public int? ServiceErrorCount
			{
				get
				{
					return serviceErrorCount;
				}
				set	
				{
					serviceErrorCount = value;
				}
			}

			public int? HealthClientCount
			{
				get
				{
					return healthClientCount;
				}
				set	
				{
					healthClientCount = value;
				}
			}

			public List<string> UuidList
			{
				get
				{
					return uuidList;
				}
				set	
				{
					uuidList = value;
				}
			}

			public List<string> RemarkedUuidList
			{
				get
				{
					return remarkedUuidList;
				}
				set	
				{
					remarkedUuidList = value;
				}
			}

			public List<string> ClientErrorUuidList
			{
				get
				{
					return clientErrorUuidList;
				}
				set	
				{
					clientErrorUuidList = value;
				}
			}

			public List<string> ServiceErrorUuidList
			{
				get
				{
					return serviceErrorUuidList;
				}
				set	
				{
					serviceErrorUuidList = value;
				}
			}

			public List<string> HealthClientUuidList
			{
				get
				{
					return healthClientUuidList;
				}
				set	
				{
					healthClientUuidList = value;
				}
			}
		}

		public class DescribeBackupPolicies_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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
		}
	}
}
