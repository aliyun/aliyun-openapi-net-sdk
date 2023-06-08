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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeOasSQLHistoryListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeOasSQLHistoryList_DataItem> data;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Data")]
		public List<DescribeOasSQLHistoryList_DataItem> Data
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

		public class DescribeOasSQLHistoryList_DataItem
		{

			private string sQLId;

			private string dbName;

			private long? avgAffectedRows;

			private long? avgBlockCacheHit;

			private long? avgBlockIndexCacheHit;

			private long? avgBloomFilterCacheHit;

			private long? executions;

			private long? failCount;

			private long? avgRpcCount;

			private long? remotePlans;

			private long? missPlans;

			private long? avgReturnRows;

			private long? avgLogicalReads;

			private long? retryCount;

			private long? avgRowCacheHit;

			private long? avgDiskReads;

			private long? avgMemstoreReadRows;

			private long? avgSsstoreReadRows;

			private double? avgApplicationWaitTime;

			private double? avgElapsedTime;

			private double? avgExecuteTime;

			private double? avgQueueTime;

			private double? avgConcurrencyWaitTime;

			private double? avgCpuTime;

			private double? avgDecodeTime;

			private double? avgNetWaitTime;

			private double? avgUserIoWaitTime;

			private double? avgGetPlanTime;

			private double? maxElapsedTime;

			private double? sumWaitTime;

			private double? avgScheduleTime;

			private double? maxCpuTime;

			private double? sumElapsedTime;

			private string timestamp;

			private string server;

			private string userName;

			private double? avgPartitionCount;

			private double? failPercentage;

			private double? retCode4012Count;

			private double? retCode4013Count;

			private double? retCode5001Count;

			private double? retCode5024Count;

			private double? retCode5167Count;

			private double? retCode5217Count;

			private double? retCode6002Count;

			private double? avgWaitTime;

			private double? avgWaitCount;

			private double? localPlanPercentage;

			private double? remotePlanPercentage;

			private double? distPlanPercentage;

			private double? avgNetTime;

			private double? avgExecutorRpcCount;

			private double? missPlanPercentage;

			private double? tableScanPercentage;

			private double? strongConsistencyPercentage;

			private double? weakConsistencyPercentage;

			private double? maxAffectedRows;

			private double? maxReturnRows;

			private double? maxWaitTime;

			private double? maxApplicationWaitTime;

			private double? maxConcurrencyWaitTime;

			private double? maxUserIoWaitTime;

			private double? maxDiskReads;

			private double? avgExpectedWorkerCount;

			private double? avgUsedWorkerCount;

			private double? sumLogicalReads;

			private double? execPs;

			[JsonProperty(PropertyName = "SQLId")]
			public string SQLId
			{
				get
				{
					return sQLId;
				}
				set	
				{
					sQLId = value;
				}
			}

			[JsonProperty(PropertyName = "DbName")]
			public string DbName
			{
				get
				{
					return dbName;
				}
				set	
				{
					dbName = value;
				}
			}

			[JsonProperty(PropertyName = "AvgAffectedRows")]
			public long? AvgAffectedRows
			{
				get
				{
					return avgAffectedRows;
				}
				set	
				{
					avgAffectedRows = value;
				}
			}

			[JsonProperty(PropertyName = "AvgBlockCacheHit")]
			public long? AvgBlockCacheHit
			{
				get
				{
					return avgBlockCacheHit;
				}
				set	
				{
					avgBlockCacheHit = value;
				}
			}

			[JsonProperty(PropertyName = "AvgBlockIndexCacheHit")]
			public long? AvgBlockIndexCacheHit
			{
				get
				{
					return avgBlockIndexCacheHit;
				}
				set	
				{
					avgBlockIndexCacheHit = value;
				}
			}

			[JsonProperty(PropertyName = "AvgBloomFilterCacheHit")]
			public long? AvgBloomFilterCacheHit
			{
				get
				{
					return avgBloomFilterCacheHit;
				}
				set	
				{
					avgBloomFilterCacheHit = value;
				}
			}

			[JsonProperty(PropertyName = "Executions")]
			public long? Executions
			{
				get
				{
					return executions;
				}
				set	
				{
					executions = value;
				}
			}

			[JsonProperty(PropertyName = "FailCount")]
			public long? FailCount
			{
				get
				{
					return failCount;
				}
				set	
				{
					failCount = value;
				}
			}

			[JsonProperty(PropertyName = "AvgRpcCount")]
			public long? AvgRpcCount
			{
				get
				{
					return avgRpcCount;
				}
				set	
				{
					avgRpcCount = value;
				}
			}

			[JsonProperty(PropertyName = "RemotePlans")]
			public long? RemotePlans
			{
				get
				{
					return remotePlans;
				}
				set	
				{
					remotePlans = value;
				}
			}

			[JsonProperty(PropertyName = "MissPlans")]
			public long? MissPlans
			{
				get
				{
					return missPlans;
				}
				set	
				{
					missPlans = value;
				}
			}

			[JsonProperty(PropertyName = "AvgReturnRows")]
			public long? AvgReturnRows
			{
				get
				{
					return avgReturnRows;
				}
				set	
				{
					avgReturnRows = value;
				}
			}

			[JsonProperty(PropertyName = "AvgLogicalReads")]
			public long? AvgLogicalReads
			{
				get
				{
					return avgLogicalReads;
				}
				set	
				{
					avgLogicalReads = value;
				}
			}

			[JsonProperty(PropertyName = "RetryCount")]
			public long? RetryCount
			{
				get
				{
					return retryCount;
				}
				set	
				{
					retryCount = value;
				}
			}

			[JsonProperty(PropertyName = "AvgRowCacheHit")]
			public long? AvgRowCacheHit
			{
				get
				{
					return avgRowCacheHit;
				}
				set	
				{
					avgRowCacheHit = value;
				}
			}

			[JsonProperty(PropertyName = "AvgDiskReads")]
			public long? AvgDiskReads
			{
				get
				{
					return avgDiskReads;
				}
				set	
				{
					avgDiskReads = value;
				}
			}

			[JsonProperty(PropertyName = "AvgMemstoreReadRows")]
			public long? AvgMemstoreReadRows
			{
				get
				{
					return avgMemstoreReadRows;
				}
				set	
				{
					avgMemstoreReadRows = value;
				}
			}

			[JsonProperty(PropertyName = "AvgSsstoreReadRows")]
			public long? AvgSsstoreReadRows
			{
				get
				{
					return avgSsstoreReadRows;
				}
				set	
				{
					avgSsstoreReadRows = value;
				}
			}

			[JsonProperty(PropertyName = "AvgApplicationWaitTime")]
			public double? AvgApplicationWaitTime
			{
				get
				{
					return avgApplicationWaitTime;
				}
				set	
				{
					avgApplicationWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgElapsedTime")]
			public double? AvgElapsedTime
			{
				get
				{
					return avgElapsedTime;
				}
				set	
				{
					avgElapsedTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgExecuteTime")]
			public double? AvgExecuteTime
			{
				get
				{
					return avgExecuteTime;
				}
				set	
				{
					avgExecuteTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgQueueTime")]
			public double? AvgQueueTime
			{
				get
				{
					return avgQueueTime;
				}
				set	
				{
					avgQueueTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgConcurrencyWaitTime")]
			public double? AvgConcurrencyWaitTime
			{
				get
				{
					return avgConcurrencyWaitTime;
				}
				set	
				{
					avgConcurrencyWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgCpuTime")]
			public double? AvgCpuTime
			{
				get
				{
					return avgCpuTime;
				}
				set	
				{
					avgCpuTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgDecodeTime")]
			public double? AvgDecodeTime
			{
				get
				{
					return avgDecodeTime;
				}
				set	
				{
					avgDecodeTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgNetWaitTime")]
			public double? AvgNetWaitTime
			{
				get
				{
					return avgNetWaitTime;
				}
				set	
				{
					avgNetWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgUserIoWaitTime")]
			public double? AvgUserIoWaitTime
			{
				get
				{
					return avgUserIoWaitTime;
				}
				set	
				{
					avgUserIoWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgGetPlanTime")]
			public double? AvgGetPlanTime
			{
				get
				{
					return avgGetPlanTime;
				}
				set	
				{
					avgGetPlanTime = value;
				}
			}

			[JsonProperty(PropertyName = "MaxElapsedTime")]
			public double? MaxElapsedTime
			{
				get
				{
					return maxElapsedTime;
				}
				set	
				{
					maxElapsedTime = value;
				}
			}

			[JsonProperty(PropertyName = "SumWaitTime")]
			public double? SumWaitTime
			{
				get
				{
					return sumWaitTime;
				}
				set	
				{
					sumWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgScheduleTime")]
			public double? AvgScheduleTime
			{
				get
				{
					return avgScheduleTime;
				}
				set	
				{
					avgScheduleTime = value;
				}
			}

			[JsonProperty(PropertyName = "MaxCpuTime")]
			public double? MaxCpuTime
			{
				get
				{
					return maxCpuTime;
				}
				set	
				{
					maxCpuTime = value;
				}
			}

			[JsonProperty(PropertyName = "SumElapsedTime")]
			public double? SumElapsedTime
			{
				get
				{
					return sumElapsedTime;
				}
				set	
				{
					sumElapsedTime = value;
				}
			}

			[JsonProperty(PropertyName = "Timestamp")]
			public string Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			[JsonProperty(PropertyName = "Server")]
			public string Server
			{
				get
				{
					return server;
				}
				set	
				{
					server = value;
				}
			}

			[JsonProperty(PropertyName = "UserName")]
			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}

			[JsonProperty(PropertyName = "AvgPartitionCount")]
			public double? AvgPartitionCount
			{
				get
				{
					return avgPartitionCount;
				}
				set	
				{
					avgPartitionCount = value;
				}
			}

			[JsonProperty(PropertyName = "FailPercentage")]
			public double? FailPercentage
			{
				get
				{
					return failPercentage;
				}
				set	
				{
					failPercentage = value;
				}
			}

			[JsonProperty(PropertyName = "RetCode4012Count")]
			public double? RetCode4012Count
			{
				get
				{
					return retCode4012Count;
				}
				set	
				{
					retCode4012Count = value;
				}
			}

			[JsonProperty(PropertyName = "RetCode4013Count")]
			public double? RetCode4013Count
			{
				get
				{
					return retCode4013Count;
				}
				set	
				{
					retCode4013Count = value;
				}
			}

			[JsonProperty(PropertyName = "RetCode5001Count")]
			public double? RetCode5001Count
			{
				get
				{
					return retCode5001Count;
				}
				set	
				{
					retCode5001Count = value;
				}
			}

			[JsonProperty(PropertyName = "RetCode5024Count")]
			public double? RetCode5024Count
			{
				get
				{
					return retCode5024Count;
				}
				set	
				{
					retCode5024Count = value;
				}
			}

			[JsonProperty(PropertyName = "RetCode5167Count")]
			public double? RetCode5167Count
			{
				get
				{
					return retCode5167Count;
				}
				set	
				{
					retCode5167Count = value;
				}
			}

			[JsonProperty(PropertyName = "RetCode5217Count")]
			public double? RetCode5217Count
			{
				get
				{
					return retCode5217Count;
				}
				set	
				{
					retCode5217Count = value;
				}
			}

			[JsonProperty(PropertyName = "RetCode6002Count")]
			public double? RetCode6002Count
			{
				get
				{
					return retCode6002Count;
				}
				set	
				{
					retCode6002Count = value;
				}
			}

			[JsonProperty(PropertyName = "AvgWaitTime")]
			public double? AvgWaitTime
			{
				get
				{
					return avgWaitTime;
				}
				set	
				{
					avgWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgWaitCount")]
			public double? AvgWaitCount
			{
				get
				{
					return avgWaitCount;
				}
				set	
				{
					avgWaitCount = value;
				}
			}

			[JsonProperty(PropertyName = "LocalPlanPercentage")]
			public double? LocalPlanPercentage
			{
				get
				{
					return localPlanPercentage;
				}
				set	
				{
					localPlanPercentage = value;
				}
			}

			[JsonProperty(PropertyName = "RemotePlanPercentage")]
			public double? RemotePlanPercentage
			{
				get
				{
					return remotePlanPercentage;
				}
				set	
				{
					remotePlanPercentage = value;
				}
			}

			[JsonProperty(PropertyName = "DistPlanPercentage")]
			public double? DistPlanPercentage
			{
				get
				{
					return distPlanPercentage;
				}
				set	
				{
					distPlanPercentage = value;
				}
			}

			[JsonProperty(PropertyName = "AvgNetTime")]
			public double? AvgNetTime
			{
				get
				{
					return avgNetTime;
				}
				set	
				{
					avgNetTime = value;
				}
			}

			[JsonProperty(PropertyName = "AvgExecutorRpcCount")]
			public double? AvgExecutorRpcCount
			{
				get
				{
					return avgExecutorRpcCount;
				}
				set	
				{
					avgExecutorRpcCount = value;
				}
			}

			[JsonProperty(PropertyName = "MissPlanPercentage")]
			public double? MissPlanPercentage
			{
				get
				{
					return missPlanPercentage;
				}
				set	
				{
					missPlanPercentage = value;
				}
			}

			[JsonProperty(PropertyName = "TableScanPercentage")]
			public double? TableScanPercentage
			{
				get
				{
					return tableScanPercentage;
				}
				set	
				{
					tableScanPercentage = value;
				}
			}

			[JsonProperty(PropertyName = "StrongConsistencyPercentage")]
			public double? StrongConsistencyPercentage
			{
				get
				{
					return strongConsistencyPercentage;
				}
				set	
				{
					strongConsistencyPercentage = value;
				}
			}

			[JsonProperty(PropertyName = "WeakConsistencyPercentage")]
			public double? WeakConsistencyPercentage
			{
				get
				{
					return weakConsistencyPercentage;
				}
				set	
				{
					weakConsistencyPercentage = value;
				}
			}

			[JsonProperty(PropertyName = "MaxAffectedRows")]
			public double? MaxAffectedRows
			{
				get
				{
					return maxAffectedRows;
				}
				set	
				{
					maxAffectedRows = value;
				}
			}

			[JsonProperty(PropertyName = "MaxReturnRows")]
			public double? MaxReturnRows
			{
				get
				{
					return maxReturnRows;
				}
				set	
				{
					maxReturnRows = value;
				}
			}

			[JsonProperty(PropertyName = "MaxWaitTime")]
			public double? MaxWaitTime
			{
				get
				{
					return maxWaitTime;
				}
				set	
				{
					maxWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "MaxApplicationWaitTime")]
			public double? MaxApplicationWaitTime
			{
				get
				{
					return maxApplicationWaitTime;
				}
				set	
				{
					maxApplicationWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "MaxConcurrencyWaitTime")]
			public double? MaxConcurrencyWaitTime
			{
				get
				{
					return maxConcurrencyWaitTime;
				}
				set	
				{
					maxConcurrencyWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "MaxUserIoWaitTime")]
			public double? MaxUserIoWaitTime
			{
				get
				{
					return maxUserIoWaitTime;
				}
				set	
				{
					maxUserIoWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "MaxDiskReads")]
			public double? MaxDiskReads
			{
				get
				{
					return maxDiskReads;
				}
				set	
				{
					maxDiskReads = value;
				}
			}

			[JsonProperty(PropertyName = "AvgExpectedWorkerCount")]
			public double? AvgExpectedWorkerCount
			{
				get
				{
					return avgExpectedWorkerCount;
				}
				set	
				{
					avgExpectedWorkerCount = value;
				}
			}

			[JsonProperty(PropertyName = "AvgUsedWorkerCount")]
			public double? AvgUsedWorkerCount
			{
				get
				{
					return avgUsedWorkerCount;
				}
				set	
				{
					avgUsedWorkerCount = value;
				}
			}

			[JsonProperty(PropertyName = "SumLogicalReads")]
			public double? SumLogicalReads
			{
				get
				{
					return sumLogicalReads;
				}
				set	
				{
					sumLogicalReads = value;
				}
			}

			[JsonProperty(PropertyName = "ExecPs")]
			public double? ExecPs
			{
				get
				{
					return execPs;
				}
				set	
				{
					execPs = value;
				}
			}
		}
	}
}
