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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeSoarRecordsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSoarRecords_Data> soarExecuteRecords;

		private DescribeSoarRecords_Page page;

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

		public List<DescribeSoarRecords_Data> SoarExecuteRecords
		{
			get
			{
				return soarExecuteRecords;
			}
			set	
			{
				soarExecuteRecords = value;
			}
		}

		public DescribeSoarRecords_Page Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		public class DescribeSoarRecords_Data
		{

			private string triggerType;

			private string triggerDataId;

			private string taskName;

			private long? startTime;

			private long? endTime;

			private string status;

			private int? success;

			private string requestUuid;

			private string triggerUser;

			private string errorMsg;

			private string dataSourceName;

			private string rawEventReq;

			private string resultMessage;

			private string resultDetailInfo;

			private string taskTenantId;

			private string taskType;

			private string taskflowMd5;

			private int? flowTag;

			public string TriggerType
			{
				get
				{
					return triggerType;
				}
				set	
				{
					triggerType = value;
				}
			}

			public string TriggerDataId
			{
				get
				{
					return triggerDataId;
				}
				set	
				{
					triggerDataId = value;
				}
			}

			public string TaskName
			{
				get
				{
					return taskName;
				}
				set	
				{
					taskName = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
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

			public int? Success
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

			public string RequestUuid
			{
				get
				{
					return requestUuid;
				}
				set	
				{
					requestUuid = value;
				}
			}

			public string TriggerUser
			{
				get
				{
					return triggerUser;
				}
				set	
				{
					triggerUser = value;
				}
			}

			public string ErrorMsg
			{
				get
				{
					return errorMsg;
				}
				set	
				{
					errorMsg = value;
				}
			}

			public string DataSourceName
			{
				get
				{
					return dataSourceName;
				}
				set	
				{
					dataSourceName = value;
				}
			}

			public string RawEventReq
			{
				get
				{
					return rawEventReq;
				}
				set	
				{
					rawEventReq = value;
				}
			}

			public string ResultMessage
			{
				get
				{
					return resultMessage;
				}
				set	
				{
					resultMessage = value;
				}
			}

			public string ResultDetailInfo
			{
				get
				{
					return resultDetailInfo;
				}
				set	
				{
					resultDetailInfo = value;
				}
			}

			public string TaskTenantId
			{
				get
				{
					return taskTenantId;
				}
				set	
				{
					taskTenantId = value;
				}
			}

			public string TaskType
			{
				get
				{
					return taskType;
				}
				set	
				{
					taskType = value;
				}
			}

			public string TaskflowMd5
			{
				get
				{
					return taskflowMd5;
				}
				set	
				{
					taskflowMd5 = value;
				}
			}

			public int? FlowTag
			{
				get
				{
					return flowTag;
				}
				set	
				{
					flowTag = value;
				}
			}
		}

		public class DescribeSoarRecords_Page
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

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
		}
	}
}
