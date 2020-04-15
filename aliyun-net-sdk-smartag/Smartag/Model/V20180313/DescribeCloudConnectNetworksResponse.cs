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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeCloudConnectNetworksResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeCloudConnectNetworks_CloudConnectNetwork> cloudConnectNetworks;

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

		public List<DescribeCloudConnectNetworks_CloudConnectNetwork> CloudConnectNetworks
		{
			get
			{
				return cloudConnectNetworks;
			}
			set	
			{
				cloudConnectNetworks = value;
			}
		}

		public class DescribeCloudConnectNetworks_CloudConnectNetwork
		{

			private string ccnId;

			private string name;

			private string associatedCloudBoxCount;

			private string availableCloudBoxCount;

			private string associatedCenId;

			private string associatedCenOwnerId;

			private string description;

			private long? createTime;

			private bool? isDefault;

			private string cidrBlock;

			private string snatCidrBlock;

			private string interworkingStatus;

			private List<DescribeCloudConnectNetworks_Tag> tags;

			public string CcnId
			{
				get
				{
					return ccnId;
				}
				set	
				{
					ccnId = value;
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

			public string AssociatedCloudBoxCount
			{
				get
				{
					return associatedCloudBoxCount;
				}
				set	
				{
					associatedCloudBoxCount = value;
				}
			}

			public string AvailableCloudBoxCount
			{
				get
				{
					return availableCloudBoxCount;
				}
				set	
				{
					availableCloudBoxCount = value;
				}
			}

			public string AssociatedCenId
			{
				get
				{
					return associatedCenId;
				}
				set	
				{
					associatedCenId = value;
				}
			}

			public string AssociatedCenOwnerId
			{
				get
				{
					return associatedCenOwnerId;
				}
				set	
				{
					associatedCenOwnerId = value;
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

			public bool? IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
				}
			}

			public string CidrBlock
			{
				get
				{
					return cidrBlock;
				}
				set	
				{
					cidrBlock = value;
				}
			}

			public string SnatCidrBlock
			{
				get
				{
					return snatCidrBlock;
				}
				set	
				{
					snatCidrBlock = value;
				}
			}

			public string InterworkingStatus
			{
				get
				{
					return interworkingStatus;
				}
				set	
				{
					interworkingStatus = value;
				}
			}

			public List<DescribeCloudConnectNetworks_Tag> Tags
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

			public class DescribeCloudConnectNetworks_Tag
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
