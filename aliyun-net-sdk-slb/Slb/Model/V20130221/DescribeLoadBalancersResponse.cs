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

namespace Aliyun.Acs.Slb.Model.V20130221
{
	public class DescribeLoadBalancersResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeLoadBalancers_LoadBalancer> loadBalancers;

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

		public List<DescribeLoadBalancers_LoadBalancer> LoadBalancers
		{
			get
			{
				return loadBalancers;
			}
			set	
			{
				loadBalancers = value;
			}
		}

		public class DescribeLoadBalancers_LoadBalancer
		{

			private string vpcId;

			private long? createTimeStamp;

			private string createTime;

			private string loadBalancerId;

			private string payType;

			private string addressType;

			private string networkType;

			private string regionId;

			private string vSwitchId;

			private string loadBalancerStatus;

			private string loadBalancerName;

			private string resourceGroupId;

			private string internetChargeType;

			private string address;

			private string slaveZoneId;

			private string regionIdAlias;

			private string masterZoneId;

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

			public long? CreateTimeStamp
			{
				get
				{
					return createTimeStamp;
				}
				set	
				{
					createTimeStamp = value;
				}
			}

			public string CreateTime
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

			public string LoadBalancerId
			{
				get
				{
					return loadBalancerId;
				}
				set	
				{
					loadBalancerId = value;
				}
			}

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string AddressType
			{
				get
				{
					return addressType;
				}
				set	
				{
					addressType = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
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

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string LoadBalancerStatus
			{
				get
				{
					return loadBalancerStatus;
				}
				set	
				{
					loadBalancerStatus = value;
				}
			}

			public string LoadBalancerName
			{
				get
				{
					return loadBalancerName;
				}
				set	
				{
					loadBalancerName = value;
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

			public string InternetChargeType
			{
				get
				{
					return internetChargeType;
				}
				set	
				{
					internetChargeType = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string SlaveZoneId
			{
				get
				{
					return slaveZoneId;
				}
				set	
				{
					slaveZoneId = value;
				}
			}

			public string RegionIdAlias
			{
				get
				{
					return regionIdAlias;
				}
				set	
				{
					regionIdAlias = value;
				}
			}

			public string MasterZoneId
			{
				get
				{
					return masterZoneId;
				}
				set	
				{
					masterZoneId = value;
				}
			}
		}
	}
}
