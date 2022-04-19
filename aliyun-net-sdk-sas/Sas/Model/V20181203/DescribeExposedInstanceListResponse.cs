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
	public class DescribeExposedInstanceListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeExposedInstanceList_ExposedInstance> exposedInstances;

		private DescribeExposedInstanceList_PageInfo pageInfo;

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

		public List<DescribeExposedInstanceList_ExposedInstance> ExposedInstances
		{
			get
			{
				return exposedInstances;
			}
			set	
			{
				exposedInstances = value;
			}
		}

		public DescribeExposedInstanceList_PageInfo PageInfo
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

		public class DescribeExposedInstanceList_ExposedInstance
		{

			private string exposureIp;

			private int? totalVulCount;

			private string internetIp;

			private int? nntfVulCount;

			private string instanceId;

			private string exposureType;

			private string intranetIp;

			private string regionId;

			private string exposureTypeId;

			private int? asapVulCount;

			private string exposurePort;

			private string uuid;

			private string groupName;

			private long? groupId;

			private int? exploitHealthCount;

			private string instanceName;

			private string exposureComponent;

			private int? laterVulCount;

			public string ExposureIp
			{
				get
				{
					return exposureIp;
				}
				set	
				{
					exposureIp = value;
				}
			}

			public int? TotalVulCount
			{
				get
				{
					return totalVulCount;
				}
				set	
				{
					totalVulCount = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public int? NntfVulCount
			{
				get
				{
					return nntfVulCount;
				}
				set	
				{
					nntfVulCount = value;
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

			public string ExposureType
			{
				get
				{
					return exposureType;
				}
				set	
				{
					exposureType = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
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

			public string ExposureTypeId
			{
				get
				{
					return exposureTypeId;
				}
				set	
				{
					exposureTypeId = value;
				}
			}

			public int? AsapVulCount
			{
				get
				{
					return asapVulCount;
				}
				set	
				{
					asapVulCount = value;
				}
			}

			public string ExposurePort
			{
				get
				{
					return exposurePort;
				}
				set	
				{
					exposurePort = value;
				}
			}

			public string Uuid
			{
				get
				{
					return uuid;
				}
				set	
				{
					uuid = value;
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

			public long? GroupId
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

			public int? ExploitHealthCount
			{
				get
				{
					return exploitHealthCount;
				}
				set	
				{
					exploitHealthCount = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string ExposureComponent
			{
				get
				{
					return exposureComponent;
				}
				set	
				{
					exposureComponent = value;
				}
			}

			public int? LaterVulCount
			{
				get
				{
					return laterVulCount;
				}
				set	
				{
					laterVulCount = value;
				}
			}
		}

		public class DescribeExposedInstanceList_PageInfo
		{

			private int? currentPage;

			private int? pageSize;

			private int? totalCount;

			private int? count;

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
		}
	}
}
