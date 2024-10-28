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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeDataFlowSubTasksResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private List<DescribeDataFlowSubTasks_DataFlowSubTaskItem> dataFlowSubTask;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<DescribeDataFlowSubTasks_DataFlowSubTaskItem> DataFlowSubTask
		{
			get
			{
				return dataFlowSubTask;
			}
			set	
			{
				dataFlowSubTask = value;
			}
		}

		public class DescribeDataFlowSubTasks_DataFlowSubTaskItem
		{

			private string fileSystemId;

			private string dataFlowId;

			private string dataFlowTaskId;

			private string dataFlowSubTaskId;

			private string srcFilePath;

			private string dstFilePath;

			private string status;

			private int? progress;

			private string createTime;

			private string startTime;

			private string endTime;

			private string errorMsg;

			private DescribeDataFlowSubTasks_ProgressStats progressStats;

			private DescribeDataFlowSubTasks_FileDetail fileDetail;

			public string FileSystemId
			{
				get
				{
					return fileSystemId;
				}
				set	
				{
					fileSystemId = value;
				}
			}

			public string DataFlowId
			{
				get
				{
					return dataFlowId;
				}
				set	
				{
					dataFlowId = value;
				}
			}

			public string DataFlowTaskId
			{
				get
				{
					return dataFlowTaskId;
				}
				set	
				{
					dataFlowTaskId = value;
				}
			}

			public string DataFlowSubTaskId
			{
				get
				{
					return dataFlowSubTaskId;
				}
				set	
				{
					dataFlowSubTaskId = value;
				}
			}

			public string SrcFilePath
			{
				get
				{
					return srcFilePath;
				}
				set	
				{
					srcFilePath = value;
				}
			}

			public string DstFilePath
			{
				get
				{
					return dstFilePath;
				}
				set	
				{
					dstFilePath = value;
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

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
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

			public DescribeDataFlowSubTasks_ProgressStats ProgressStats
			{
				get
				{
					return progressStats;
				}
				set	
				{
					progressStats = value;
				}
			}

			public DescribeDataFlowSubTasks_FileDetail FileDetail
			{
				get
				{
					return fileDetail;
				}
				set	
				{
					fileDetail = value;
				}
			}

			public class DescribeDataFlowSubTasks_ProgressStats
			{

				private long? bytesTotal;

				private long? bytesDone;

				private long? actualBytes;

				private long? averageSpeed;

				public long? BytesTotal
				{
					get
					{
						return bytesTotal;
					}
					set	
					{
						bytesTotal = value;
					}
				}

				public long? BytesDone
				{
					get
					{
						return bytesDone;
					}
					set	
					{
						bytesDone = value;
					}
				}

				public long? ActualBytes
				{
					get
					{
						return actualBytes;
					}
					set	
					{
						actualBytes = value;
					}
				}

				public long? AverageSpeed
				{
					get
					{
						return averageSpeed;
					}
					set	
					{
						averageSpeed = value;
					}
				}
			}

			public class DescribeDataFlowSubTasks_FileDetail
			{

				private long? modifyTime;

				private long? size;

				private string checksum;

				public long? ModifyTime
				{
					get
					{
						return modifyTime;
					}
					set	
					{
						modifyTime = value;
					}
				}

				public long? Size
				{
					get
					{
						return size;
					}
					set	
					{
						size = value;
					}
				}

				public string Checksum
				{
					get
					{
						return checksum;
					}
					set	
					{
						checksum = value;
					}
				}
			}
		}
	}
}
