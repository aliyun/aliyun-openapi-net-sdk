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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeDataMaskingRunHistoryResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeDataMaskingRunHistory_Task> items;

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

		public List<DescribeDataMaskingRunHistory_Task> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeDataMaskingRunHistory_Task
		{

			private int? status;

			private int? type;

			private int? srcType;

			private string srcTableName;

			private long? maskingCount;

			private int? percentage;

			private int? dstType;

			private string failMsg;

			private string failCode;

			private long? conflictCount;

			private string dstTypeCode;

			private long? endTime;

			private int? runIndex;

			private long? startTime;

			private int? hasSubProcess;

			private int? hasDownloadFile;

			private string taskId;

			private string srcTypeCode;

			private long? id;

			public int? Status
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

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? SrcType
			{
				get
				{
					return srcType;
				}
				set	
				{
					srcType = value;
				}
			}

			public string SrcTableName
			{
				get
				{
					return srcTableName;
				}
				set	
				{
					srcTableName = value;
				}
			}

			public long? MaskingCount
			{
				get
				{
					return maskingCount;
				}
				set	
				{
					maskingCount = value;
				}
			}

			public int? Percentage
			{
				get
				{
					return percentage;
				}
				set	
				{
					percentage = value;
				}
			}

			public int? DstType
			{
				get
				{
					return dstType;
				}
				set	
				{
					dstType = value;
				}
			}

			public string FailMsg
			{
				get
				{
					return failMsg;
				}
				set	
				{
					failMsg = value;
				}
			}

			public string FailCode
			{
				get
				{
					return failCode;
				}
				set	
				{
					failCode = value;
				}
			}

			public long? ConflictCount
			{
				get
				{
					return conflictCount;
				}
				set	
				{
					conflictCount = value;
				}
			}

			public string DstTypeCode
			{
				get
				{
					return dstTypeCode;
				}
				set	
				{
					dstTypeCode = value;
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

			public int? RunIndex
			{
				get
				{
					return runIndex;
				}
				set	
				{
					runIndex = value;
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

			public int? HasSubProcess
			{
				get
				{
					return hasSubProcess;
				}
				set	
				{
					hasSubProcess = value;
				}
			}

			public int? HasDownloadFile
			{
				get
				{
					return hasDownloadFile;
				}
				set	
				{
					hasDownloadFile = value;
				}
			}

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public string SrcTypeCode
			{
				get
				{
					return srcTypeCode;
				}
				set	
				{
					srcTypeCode = value;
				}
			}

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
		}
	}
}
