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
	public class DescribeDataMaskingTasksResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeDataMaskingTasks_Task> items;

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

		public List<DescribeDataMaskingTasks_Task> Items
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

		public class DescribeDataMaskingTasks_Task
		{

			private int? status;

			private string owner;

			private string taskName;

			private int? srcType;

			private int? dstType;

			private bool? hasUnfinishProcess;

			private bool? originalTable;

			private int? triggerType;

			private string dstTypeCode;

			private int? runCount;

			private long? gmtCreate;

			private string taskId;

			private string dstPath;

			private string srcTypeCode;

			private long? id;

			private string srcPath;

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

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
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

			public bool? HasUnfinishProcess
			{
				get
				{
					return hasUnfinishProcess;
				}
				set	
				{
					hasUnfinishProcess = value;
				}
			}

			public bool? OriginalTable
			{
				get
				{
					return originalTable;
				}
				set	
				{
					originalTable = value;
				}
			}

			public int? TriggerType
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

			public int? RunCount
			{
				get
				{
					return runCount;
				}
				set	
				{
					runCount = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
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

			public string DstPath
			{
				get
				{
					return dstPath;
				}
				set	
				{
					dstPath = value;
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

			public string SrcPath
			{
				get
				{
					return srcPath;
				}
				set	
				{
					srcPath = value;
				}
			}
		}
	}
}
