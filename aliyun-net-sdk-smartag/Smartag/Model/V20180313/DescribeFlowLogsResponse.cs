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
	public class DescribeFlowLogsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeFlowLogs_FlowLogSetType> flowLogs;

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

		public List<DescribeFlowLogs_FlowLogSetType> FlowLogs
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

		public class DescribeFlowLogs_FlowLogSetType
		{

			private string flowLogId;

			private string description;

			private int? activeAging;

			private int? inactiveAging;

			private string outputType;

			private string slsRegionId;

			private string projectName;

			private string logstoreName;

			private string netflowServerIp;

			private string netflowServerPort;

			private string netflowVersion;

			private string status;

			private string name;

			private int? totalSagNum;

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

			public int? ActiveAging
			{
				get
				{
					return activeAging;
				}
				set	
				{
					activeAging = value;
				}
			}

			public int? InactiveAging
			{
				get
				{
					return inactiveAging;
				}
				set	
				{
					inactiveAging = value;
				}
			}

			public string OutputType
			{
				get
				{
					return outputType;
				}
				set	
				{
					outputType = value;
				}
			}

			public string SlsRegionId
			{
				get
				{
					return slsRegionId;
				}
				set	
				{
					slsRegionId = value;
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

			public string LogstoreName
			{
				get
				{
					return logstoreName;
				}
				set	
				{
					logstoreName = value;
				}
			}

			public string NetflowServerIp
			{
				get
				{
					return netflowServerIp;
				}
				set	
				{
					netflowServerIp = value;
				}
			}

			public string NetflowServerPort
			{
				get
				{
					return netflowServerPort;
				}
				set	
				{
					netflowServerPort = value;
				}
			}

			public string NetflowVersion
			{
				get
				{
					return netflowVersion;
				}
				set	
				{
					netflowVersion = value;
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

			public int? TotalSagNum
			{
				get
				{
					return totalSagNum;
				}
				set	
				{
					totalSagNum = value;
				}
			}
		}
	}
}
