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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeFlowLogsResponse : AcsResponse
	{

		private string pageSize;

		private string pageNumber;

		private string requestId;

		private string totalCount;

		private string success;

		private List<DescribeFlowLogs_FlowLog> flowLogs;

		public string PageSize
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

		public string PageNumber
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

		public string TotalCount
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

		public string Success
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

		public List<DescribeFlowLogs_FlowLog> FlowLogs
		{
			get
			{
				return flowLogs;
			}
			set	
			{
				flowLogs = value;
			}
		}

		public class DescribeFlowLogs_FlowLog
		{

			private string status;

			private string creationTime;

			private string flowLogName;

			private string trafficType;

			private string resourceType;

			private string description;

			private string projectName;

			private string logStoreName;

			private string resourceId;

			private string regionId;

			private string flowLogId;

			private string businessStatus;

			private int? aggregationInterval;

			private string serviceType;

			private string resourceGroupId;

			private List<DescribeFlowLogs_Tag> tags;

			private List<string> trafficPath;

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

			public string FlowLogName
			{
				get
				{
					return flowLogName;
				}
				set	
				{
					flowLogName = value;
				}
			}

			public string TrafficType
			{
				get
				{
					return trafficType;
				}
				set	
				{
					trafficType = value;
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

			public string ProjectName
			{
				get
				{
					return projectName;
				}
				set	
				{
					projectName = value;
				}
			}

			public string LogStoreName
			{
				get
				{
					return logStoreName;
				}
				set	
				{
					logStoreName = value;
				}
			}

			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
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

			public string FlowLogId
			{
				get
				{
					return flowLogId;
				}
				set	
				{
					flowLogId = value;
				}
			}

			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			public int? AggregationInterval
			{
				get
				{
					return aggregationInterval;
				}
				set	
				{
					aggregationInterval = value;
				}
			}

			public string ServiceType
			{
				get
				{
					return serviceType;
				}
				set	
				{
					serviceType = value;
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

			public List<DescribeFlowLogs_Tag> Tags
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

			public List<string> TrafficPath
			{
				get
				{
					return trafficPath;
				}
				set	
				{
					trafficPath = value;
				}
			}

			public class DescribeFlowLogs_Tag
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
