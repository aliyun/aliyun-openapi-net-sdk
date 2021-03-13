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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeSQLPlanResponse : AcsResponse
	{

		private string requestId;

		private string originInfo;

		private List<DescribeSQLPlan_SqlPlanStage> stageList;

		private DescribeSQLPlan_Detail detail;

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

		public string OriginInfo
		{
			get
			{
				return originInfo;
			}
			set	
			{
				originInfo = value;
			}
		}

		public List<DescribeSQLPlan_SqlPlanStage> StageList
		{
			get
			{
				return stageList;
			}
			set	
			{
				stageList = value;
			}
		}

		public DescribeSQLPlan_Detail Detail
		{
			get
			{
				return detail;
			}
			set	
			{
				detail = value;
			}
		}

		public class DescribeSQLPlan_SqlPlanStage
		{

			private int? stageId;

			private string state;

			private long? operatorCost;

			private long? peakMemory;

			private long? cPUTimeMin;

			private long? cPUTimeMax;

			private long? cPUTimeAvg;

			private long? inputSizeMin;

			private long? inputSizeMax;

			private long? inputSizeAvg;

			private long? scanSizeMin;

			private long? scanSizeMax;

			private long? scanSizeAvg;

			private long? scanTimeMin;

			private long? scanTimeMax;

			private long? scanTimeAvg;

			public int? StageId
			{
				get
				{
					return stageId;
				}
				set	
				{
					stageId = value;
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

			public long? CPUTimeMin
			{
				get
				{
					return cPUTimeMin;
				}
				set	
				{
					cPUTimeMin = value;
				}
			}

			public long? CPUTimeMax
			{
				get
				{
					return cPUTimeMax;
				}
				set	
				{
					cPUTimeMax = value;
				}
			}

			public long? CPUTimeAvg
			{
				get
				{
					return cPUTimeAvg;
				}
				set	
				{
					cPUTimeAvg = value;
				}
			}

			public long? InputSizeMin
			{
				get
				{
					return inputSizeMin;
				}
				set	
				{
					inputSizeMin = value;
				}
			}

			public long? InputSizeMax
			{
				get
				{
					return inputSizeMax;
				}
				set	
				{
					inputSizeMax = value;
				}
			}

			public long? InputSizeAvg
			{
				get
				{
					return inputSizeAvg;
				}
				set	
				{
					inputSizeAvg = value;
				}
			}

			public long? ScanSizeMin
			{
				get
				{
					return scanSizeMin;
				}
				set	
				{
					scanSizeMin = value;
				}
			}

			public long? ScanSizeMax
			{
				get
				{
					return scanSizeMax;
				}
				set	
				{
					scanSizeMax = value;
				}
			}

			public long? ScanSizeAvg
			{
				get
				{
					return scanSizeAvg;
				}
				set	
				{
					scanSizeAvg = value;
				}
			}

			public long? ScanTimeMin
			{
				get
				{
					return scanTimeMin;
				}
				set	
				{
					scanTimeMin = value;
				}
			}

			public long? ScanTimeMax
			{
				get
				{
					return scanTimeMax;
				}
				set	
				{
					scanTimeMax = value;
				}
			}

			public long? ScanTimeAvg
			{
				get
				{
					return scanTimeAvg;
				}
				set	
				{
					scanTimeAvg = value;
				}
			}
		}

		public class DescribeSQLPlan_Detail
		{

			private string sQL;

			private string state;

			private string user;

			private string clientIP;

			private string database;

			private long? totalStage;

			private long? totalTask;

			private long? outputRows;

			private long? outputSize;

			private string startTime;

			private long? totalTime;

			private long? queuedTime;

			private long? planningTime;

			private long? cPUTime;

			private long? peakMemory;

			public string SQL
			{
				get
				{
					return sQL;
				}
				set	
				{
					sQL = value;
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

			public string User
			{
				get
				{
					return user;
				}
				set	
				{
					user = value;
				}
			}

			public string ClientIP
			{
				get
				{
					return clientIP;
				}
				set	
				{
					clientIP = value;
				}
			}

			public string Database
			{
				get
				{
					return database;
				}
				set	
				{
					database = value;
				}
			}

			public long? TotalStage
			{
				get
				{
					return totalStage;
				}
				set	
				{
					totalStage = value;
				}
			}

			public long? TotalTask
			{
				get
				{
					return totalTask;
				}
				set	
				{
					totalTask = value;
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

			public long? TotalTime
			{
				get
				{
					return totalTime;
				}
				set	
				{
					totalTime = value;
				}
			}

			public long? QueuedTime
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

			public long? PlanningTime
			{
				get
				{
					return planningTime;
				}
				set	
				{
					planningTime = value;
				}
			}

			public long? CPUTime
			{
				get
				{
					return cPUTime;
				}
				set	
				{
					cPUTime = value;
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
		}
	}
}
