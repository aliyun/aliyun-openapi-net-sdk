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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeDiagnosisTasksResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeDiagnosisTasks_SqlTasks> taskList;

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

		public List<DescribeDiagnosisTasks_SqlTasks> TaskList
		{
			get
			{
				return taskList;
			}
			set	
			{
				taskList = value;
			}
		}

		public class DescribeDiagnosisTasks_SqlTasks
		{

			private long? scanCost;

			private long? outputDataSize;

			private long? inputDataSize;

			private string state;

			private long? operatorCost;

			private long? outputRows;

			private long? scanDataSize;

			private long? elapsedTime;

			private long? scanRows;

			private long? peakMemory;

			private string taskId;

			private long? inputRows;

			private long? taskCreateTime;

			private long? taskEndTime;

			private string taskHost;

			private string drivers;

			private string queuedTime;

			private string computeTimeRatio;

			public long? ScanCost
			{
				get
				{
					return scanCost;
				}
				set	
				{
					scanCost = value;
				}
			}

			public long? OutputDataSize
			{
				get
				{
					return outputDataSize;
				}
				set	
				{
					outputDataSize = value;
				}
			}

			public long? InputDataSize
			{
				get
				{
					return inputDataSize;
				}
				set	
				{
					inputDataSize = value;
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

			public long? OperatorCost
			{
				get
				{
					return operatorCost;
				}
				set	
				{
					operatorCost = value;
				}
			}

			public long? OutputRows
			{
				get
				{
					return outputRows;
				}
				set	
				{
					outputRows = value;
				}
			}

			public long? ScanDataSize
			{
				get
				{
					return scanDataSize;
				}
				set	
				{
					scanDataSize = value;
				}
			}

			public long? ElapsedTime
			{
				get
				{
					return elapsedTime;
				}
				set	
				{
					elapsedTime = value;
				}
			}

			public long? ScanRows
			{
				get
				{
					return scanRows;
				}
				set	
				{
					scanRows = value;
				}
			}

			public long? PeakMemory
			{
				get
				{
					return peakMemory;
				}
				set	
				{
					peakMemory = value;
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

			public long? InputRows
			{
				get
				{
					return inputRows;
				}
				set	
				{
					inputRows = value;
				}
			}

			public long? TaskCreateTime
			{
				get
				{
					return taskCreateTime;
				}
				set	
				{
					taskCreateTime = value;
				}
			}

			public long? TaskEndTime
			{
				get
				{
					return taskEndTime;
				}
				set	
				{
					taskEndTime = value;
				}
			}

			public string TaskHost
			{
				get
				{
					return taskHost;
				}
				set	
				{
					taskHost = value;
				}
			}

			public string Drivers
			{
				get
				{
					return drivers;
				}
				set	
				{
					drivers = value;
				}
			}

			public string QueuedTime
			{
				get
				{
					return queuedTime;
				}
				set	
				{
					queuedTime = value;
				}
			}

			public string ComputeTimeRatio
			{
				get
				{
					return computeTimeRatio;
				}
				set	
				{
					computeTimeRatio = value;
				}
			}
		}
	}
}
