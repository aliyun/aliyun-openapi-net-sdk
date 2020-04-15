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
	public class DescribeDataMaskingTasksResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeDataMaskingTasks_Task> items;

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

			private long? id;

			private string taskId;

			private string taskName;

			private string owner;

			private long? gmtCreate;

			private int? dstType;

			private string dstPath;

			private int? srcType;

			private string srcPath;

			private int? runCount;

			private int? status;

			private bool? hasUnfinishProcess;

			private string dstTypeCode;

			private string srcTypeCode;

			private int? triggerType;

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
		}
	}
}
