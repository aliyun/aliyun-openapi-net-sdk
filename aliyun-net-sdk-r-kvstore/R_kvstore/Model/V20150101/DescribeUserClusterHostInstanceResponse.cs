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
	public class DescribeUserClusterHostInstanceResponse : AcsResponse
	{

		private string requestId;

		private int? maxRecordsPerPage;

		private int? pageNumber;

		private int? totalRecords;

		private int? itemNumbers;

		private List<DescribeUserClusterHostInstance_InstanceInfo> instancesItems;

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

		public int? MaxRecordsPerPage
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

		public List<DescribeUserClusterHostInstance_InstanceInfo> InstancesItems
		{
			get
			{
				return instancesItems;
			}
			set	
			{
				instancesItems = value;
			}
		}

		public class DescribeUserClusterHostInstance_InstanceInfo
		{

			private string instanceId;

			private string clusterId;

			private string regionId;

			private string zoneId;

			private string instanceType;

			private string engine;

			private string engineVersion;

			private string instanceStatus;

			private string instanceClass;

			private string createTime;

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

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
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

			public string EngineVersion
			{
				get
				{
					return engineVersion;
				}
				set	
				{
					engineVersion = value;
				}
			}

			public string InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
				}
			}

			public string InstanceClass
			{
				get
				{
					return instanceClass;
				}
				set	
				{
					instanceClass = value;
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
		}
	}
}
