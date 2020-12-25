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
	public class DescribeMetaTablePreviewTaskResponse : AcsResponse
	{

		private string requestId;

		private string taskId;

		private string taskStatus;

		private long? startTime;

		private long? endTime;

		private long? executeTime;

		private int? taskProcess;

		private DescribeMetaTablePreviewTask_Data data;

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

		public string TaskStatus
		{
			get
			{
				return taskStatus;
			}
			set	
			{
				taskStatus = value;
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

		public long? ExecuteTime
		{
			get
			{
				return executeTime;
			}
			set	
			{
				executeTime = value;
			}
		}

		public int? TaskProcess
		{
			get
			{
				return taskProcess;
			}
			set	
			{
				taskProcess = value;
			}
		}

		public DescribeMetaTablePreviewTask_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeMetaTablePreviewTask_Data
		{

			private List<DescribeMetaTablePreviewTask_Row> rows;

			private List<string> headers;

			public List<DescribeMetaTablePreviewTask_Row> Rows
			{
				get
				{
					return rows;
				}
				set	
				{
					rows = value;
				}
			}

			public List<string> Headers
			{
				get
				{
					return headers;
				}
				set	
				{
					headers = value;
				}
			}

			public class DescribeMetaTablePreviewTask_Row
			{

				private List<string> columns;

				public List<string> Columns
				{
					get
					{
						return columns;
					}
					set	
					{
						columns = value;
					}
				}
			}
		}
	}
}
