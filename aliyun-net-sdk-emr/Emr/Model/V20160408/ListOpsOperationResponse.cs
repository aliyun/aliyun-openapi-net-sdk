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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListOpsOperationResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private int? pageNumber;

		private int? pageSize;

		private List<ListOpsOperation_OpsOperationListItem> opsOperationList;

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public List<ListOpsOperation_OpsOperationListItem> OpsOperationList
		{
			get
			{
				return opsOperationList;
			}
			set	
			{
				opsOperationList = value;
			}
		}

		public class ListOpsOperation_OpsOperationListItem
		{

			private long? id;

			private string startTime;

			private string endTime;

			private long? opsCommandId;

			private string opsCommandName;

			private string status;

			private long? totalTaskNum;

			private long? failedTaskNum;

			private long? finishedTaskNum;

			private string clusterId;

			private string regionId;

			private string _params;

			private string remark;

			private long? runningTime;

			private string category;

			public long? Id
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

			public string StartTime
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

			public string EndTime
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

			public long? OpsCommandId
			{
				get
				{
					return opsCommandId;
				}
				set	
				{
					opsCommandId = value;
				}
			}

			public string OpsCommandName
			{
				get
				{
					return opsCommandName;
				}
				set	
				{
					opsCommandName = value;
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

			public long? TotalTaskNum
			{
				get
				{
					return totalTaskNum;
				}
				set	
				{
					totalTaskNum = value;
				}
			}

			public long? FailedTaskNum
			{
				get
				{
					return failedTaskNum;
				}
				set	
				{
					failedTaskNum = value;
				}
			}

			public long? FinishedTaskNum
			{
				get
				{
					return finishedTaskNum;
				}
				set	
				{
					finishedTaskNum = value;
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

			public string _Params
			{
				get
				{
					return _params;
				}
				set	
				{
					_params = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public long? RunningTime
			{
				get
				{
					return runningTime;
				}
				set	
				{
					runningTime = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}
		}
	}
}
