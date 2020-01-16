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
	public class DescribeUserClusterHostResponse : AcsResponse
	{

		private string requestId;

		private string maxRecordsPerPage;

		private int? pageNumber;

		private int? totalRecords;

		private int? itemNumbers;

		private List<DescribeUserClusterHost_HostInfo> hostItems;

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

		public string MaxRecordsPerPage
		{
			get
			{
				return maxRecordsPerPage;
			}
			set	
			{
				maxRecordsPerPage = value;
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

		public int? TotalRecords
		{
			get
			{
				return totalRecords;
			}
			set	
			{
				totalRecords = value;
			}
		}

		public int? ItemNumbers
		{
			get
			{
				return itemNumbers;
			}
			set	
			{
				itemNumbers = value;
			}
		}

		public List<DescribeUserClusterHost_HostInfo> HostItems
		{
			get
			{
				return hostItems;
			}
			set	
			{
				hostItems = value;
			}
		}

		public class DescribeUserClusterHost_HostInfo
		{

			private string clusterId;

			private string hostId;

			private string engine;

			private string hostIP;

			private string hostStatus;

			private string allocationStatus;

			private string hostCpu;

			private string hostMem;

			private string hostStorage;

			private string hostName;

			private int? id;

			private string createTime;

			private string instanceNumber;

			private string regionId;

			private string zoneId;

			private string hostClass;

			private string expireTime;

			private string chargeType;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string HostId
			{
				get
				{
					return hostId;
				}
				set	
				{
					hostId = value;
				}
			}

			public string Engine
			{
				get
				{
					return engine;
				}
				set	
				{
					engine = value;
				}
			}

			public string HostIP
			{
				get
				{
					return hostIP;
				}
				set	
				{
					hostIP = value;
				}
			}

			public string HostStatus
			{
				get
				{
					return hostStatus;
				}
				set	
				{
					hostStatus = value;
				}
			}

			public string AllocationStatus
			{
				get
				{
					return allocationStatus;
				}
				set	
				{
					allocationStatus = value;
				}
			}

			public string HostCpu
			{
				get
				{
					return hostCpu;
				}
				set	
				{
					hostCpu = value;
				}
			}

			public string HostMem
			{
				get
				{
					return hostMem;
				}
				set	
				{
					hostMem = value;
				}
			}

			public string HostStorage
			{
				get
				{
					return hostStorage;
				}
				set	
				{
					hostStorage = value;
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

			public string InstanceNumber
			{
				get
				{
					return instanceNumber;
				}
				set	
				{
					instanceNumber = value;
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

			public string HostClass
			{
				get
				{
					return hostClass;
				}
				set	
				{
					hostClass = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}
		}
	}
}
