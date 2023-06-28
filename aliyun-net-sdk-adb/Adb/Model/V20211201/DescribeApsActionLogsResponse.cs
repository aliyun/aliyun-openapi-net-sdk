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

namespace Aliyun.Acs.adb.Model.V20211201
{
	public class DescribeApsActionLogsResponse : AcsResponse
	{

		private string requestId;

		private string dBClusterId;

		private string workloadId;

		private string totalCount;

		private string pageSize;

		private string pageNumber;

		private List<DescribeApsActionLogs_SlowLogRecord> actionLogs;

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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public string WorkloadId
		{
			get
			{
				return workloadId;
			}
			set	
			{
				workloadId = value;
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

		public List<DescribeApsActionLogs_SlowLogRecord> ActionLogs
		{
			get
			{
				return actionLogs;
			}
			set	
			{
				actionLogs = value;
			}
		}

		public class DescribeApsActionLogs_SlowLogRecord
		{

			private string time;

			private string stage;

			private string state;

			private string context;

			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			public string Stage
			{
				get
				{
					return stage;
				}
				set	
				{
					stage = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string Context
			{
				get
				{
					return context;
				}
				set	
				{
					context = value;
				}
			}
		}
	}
}
