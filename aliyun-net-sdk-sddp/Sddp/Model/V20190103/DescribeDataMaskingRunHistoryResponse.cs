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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeDataMaskingRunHistoryResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeDataMaskingRunHistory_Task> items;

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

			private long? id;

			private string taskId;

			private long? startTime;

			private long? endTime;

			private int? runIndex;

			private int? type;

			private int? dstType;

			private int? percentage;

			private int? srcType;

			private long? maskingCount;

			private long? conflictCount;

			private int? status;

			private string failCode;

			private string dstTypeCode;

			private string srcTypeCode;

			private int? hasSubProcess;

			private int? hasDownloadFile;

			private string srcTableName;

			private string failMsg;

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
		}
	}
}
