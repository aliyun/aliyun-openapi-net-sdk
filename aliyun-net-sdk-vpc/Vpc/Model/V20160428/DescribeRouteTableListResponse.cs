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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeRouteTableListResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeRouteTableList_RouterTableListType> routerTableList;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
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

		public List<DescribeRouteTableList_RouterTableListType> RouterTableList
		{
			get
			{
				return routerTableList;
			}
			set	
			{
				routerTableList = value;
			}
		}

		public class DescribeRouteTableList_RouterTableListType
		{

			private string vpcId;

			private string routerType;

			private string routerId;

			private string routeTableId;

			private string routeTableName;

			private string routeTableType;

			private string description;

			private string resourceGroupId;

			private string creationTime;

			private string status;

			private long? ownerId;

			private List<DescribeRouteTableList_Tag> tags;

			private List<string> vSwitchIds;

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string RouterType
			{
				get
				{
					return routerType;
				}
				set	
				{
					routerType = value;
				}
			}

			public string RouterId
			{
				get
				{
					return routerId;
				}
				set	
				{
					routerId = value;
				}
			}

			public string RouteTableId
			{
				get
				{
					return routeTableId;
				}
				set	
				{
					routeTableId = value;
				}
			}

			public string RouteTableName
			{
				get
				{
					return routeTableName;
				}
				set	
				{
					routeTableName = value;
				}
			}

			public string RouteTableType
			{
				get
				{
					return routeTableType;
				}
				set	
				{
					routeTableType = value;
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

			public string ResourceGroupId
			{
				get
				{
					return resourceGroupId;
				}
				set	
				{
					resourceGroupId = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
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

			public long? OwnerId
			{
				get
				{
					return ownerId;
				}
				set	
				{
					ownerId = value;
				}
			}

			public List<DescribeRouteTableList_Tag> Tags
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

			public List<string> VSwitchIds
			{
				get
				{
					return vSwitchIds;
				}
				set	
				{
					vSwitchIds = value;
				}
			}

			public class DescribeRouteTableList_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
