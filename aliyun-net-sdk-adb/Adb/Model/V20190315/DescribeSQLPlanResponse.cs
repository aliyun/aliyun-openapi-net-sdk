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

			private string state;

			private long? cPUTimeAvg;

			private long? cPUTimeMax;

			private long? operatorCost;

			private long? scanTimeMax;

			private long? inputSizeMax;

			private int? stageId;

			private long? scanSizeMax;

			private long? cPUTimeMin;

			private long? scanTimeMin;

			private long? scanSizeMin;

			private long? inputSizeMin;

			private long? peakMemory;

			private long? scanTimeAvg;

			private long? scanSizeAvg;

			private long? inputSizeAvg;

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
		}

		public class DescribeSQLPlan_Detail
		{

			private string sQL;

			private long? outputSize;

			private string state;

			private long? outputRows;

			private string user;

			private string startTime;

			private long? totalStage;

			private long? queuedTime;

			private long? totalTime;

			private long? totalTask;

			private string database;

			private long? peakMemory;

			private string clientIP;

			private long? planningTime;

			private long? cPUTime;

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
		}
	}
}
