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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiGroupsResponse : AcsResponse
	{

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<ApiGroupAttribute> apiGroupAttributes;

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

		public List<ApiGroupAttribute> ApiGroupAttributes
		{
			get
			{
				return apiGroupAttributes;
			}
			set	
			{
				apiGroupAttributes = value;
			}
		}

		public class ApiGroupAttribute{

			private string groupId;

			private string groupName;

			private string subDomain;

			private string description;

			private string createdTime;

			private string modifiedTime;

			private string regionId;

			private int? trafficLimit;

			private BillingStatusEnum? billingStatus;

			private IllegalStatusEnum? illegalStatus;

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string GroupName
			{
				get
				{
					return groupName;
				}
				set	
				{
					groupName = value;
				}
			}

			public string SubDomain
			{
				get
				{
					return subDomain;
				}
				set	
				{
					subDomain = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
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

			public int? TrafficLimit
			{
				get
				{
					return trafficLimit;
				}
				set	
				{
					trafficLimit = value;
				}
			}

			public BillingStatusEnum? BillingStatus
			{
				get
				{
					return billingStatus;
				}
				set	
				{
					billingStatus = value;
				}
			}

			public IllegalStatusEnum? IllegalStatus
			{
				get
				{
					return illegalStatus;
				}
				set	
				{
					illegalStatus = value;
				}
			}

public enum BillingStatusEnum {

					NORMAL,
					LOCKED,
}

public enum IllegalStatusEnum {

					NORMAL,
					LOCKED,
}
		}
	}
}