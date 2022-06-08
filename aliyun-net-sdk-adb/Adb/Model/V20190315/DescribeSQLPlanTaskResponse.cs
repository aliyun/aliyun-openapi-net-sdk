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
	public class DescribeSQLPlanTaskResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSQLPlanTask_SqlPlanTask> taskList;

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

		public List<DescribeSQLPlanTask_SqlPlanTask> TaskList
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

		public class DescribeSQLPlanTask_SqlPlanTask
		{

			private long? scanCost;

			private long? outputSize;

			private long? inputSize;

			private string state;

			private long? operatorCost;

			private long? outputRows;

			private long? scanSize;

			private long? elapsedTime;

			private long? scanRows;

			private long? peakMemory;

			private int? taskId;

			private long? inputRows;

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

			public long? OutputSize
			{
				get
				{
					return outputSize;
				}
				set	
				{
					outputSize = value;
				}
			}

			public long? InputSize
			{
				get
				{
					return inputSize;
				}
				set	
				{
					inputSize = value;
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

			public long? ScanSize
			{
				get
				{
					return scanSize;
				}
				set	
				{
					scanSize = value;
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

			public int? TaskId
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
		}
	}
}
