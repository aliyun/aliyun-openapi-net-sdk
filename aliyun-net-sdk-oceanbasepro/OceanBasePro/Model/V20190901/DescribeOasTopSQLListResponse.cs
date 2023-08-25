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
	public class DescribeOasTopSQLListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeOasTopSQLList_DataItem> data;

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
		public List<DescribeOasTopSQLList_DataItem> Data
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

		public class DescribeOasTopSQLList_DataItem
		{

			private double? executions;

			private double? rpcCount;

			private double? remotePlans;

			private double? missPlans;

			private double? maxElapsedTime;

			private double? totalWaitTime;

			private double? execPs;

			private double? maxCpuTime;

			private double? cpuPercentage;

			private string clientIp;

			private string userName;

			private string dbName;

			private long? retCode4012Count;

			private long? retCode4013Count;

			private long? retCode5001Count;

			private long? retCode5024Count;

			private long? retCode5167Count;

			private long? retCode5217Count;

			private long? retCode6002Count;

			private double? failPercentage;

			private double? sumWaitTime;

			private double? avgWaitCount;

			private double? avgRpcCount;

			private double? localPlanPercentage;

			private double? remotePlanPercentage;

			private double? distPlanPercentage;

			private double? sumElapsedTime;

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

			private string server;

			private string serverIp;

			private long? serverPort;

			private string sqlTextShort;

			private string sqlType;

			private string sqlId;

			private bool? inner;

			private string waitEvent;

			private double? avgAffectedRows;

			private double? avgReturnRows;

			private double? avgPartitionCount;

			private double? failCount;

			private double? avgWaitTime;

			private double? avgElapsedTime;

			private double? avgCpuTime;

			private double? avgNetWaitTime;

			private double? avgQueueTime;

			private double? avgDecodeTime;

			private double? avgGetPlanTime;

			private double? avgExecuteTime;

			private double? avgApplicationWaitTime;

			private double? avgConcurrencyWaitTime;

			private double? avgUserIoWaitTime;

			private double? avgScheduleTime;

			private double? avgRowCacheHit;

			private double? avgBloomFilterCacheHit;

			private double? avgBlockCacheHit;

			private double? avgBlockIndexCacheHit;

			private double? avgDiskReads;

			private double? retryCount;

			private double? avgMemstoreReadRows;

			private double? avgSsstoreReadRows;

			private double? avgLogicalReads;

			private bool? dynamicSql;

			private long? lastFailCode;

			private double? avgDbTime;

			private double? sumDbTime;

			private List<DescribeOasTopSQLList_SqlListItem> sqlList;

			[JsonProperty(PropertyName = "Executions")]
			public double? Executions
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

			[JsonProperty(PropertyName = "RpcCount")]
			public double? RpcCount
			{
				get
				{
					return rpcCount;
				}
				set	
				{
					rpcCount = value;
				}
			}

			[JsonProperty(PropertyName = "RemotePlans")]
			public double? RemotePlans
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
			public double? MissPlans
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

			[JsonProperty(PropertyName = "TotalWaitTime")]
			public double? TotalWaitTime
			{
				get
				{
					return totalWaitTime;
				}
				set	
				{
					totalWaitTime = value;
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

			[JsonProperty(PropertyName = "CpuPercentage")]
			public double? CpuPercentage
			{
				get
				{
					return cpuPercentage;
				}
				set	
				{
					cpuPercentage = value;
				}
			}

			[JsonProperty(PropertyName = "ClientIp")]
			public string ClientIp
			{
				get
				{
					return clientIp;
				}
				set	
				{
					clientIp = value;
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

			[JsonProperty(PropertyName = "RetCode4012Count")]
			public long? RetCode4012Count
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
			public long? RetCode4013Count
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
			public long? RetCode5001Count
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
			public long? RetCode5024Count
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
			public long? RetCode5167Count
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
			public long? RetCode5217Count
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
			public long? RetCode6002Count
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

			[JsonProperty(PropertyName = "AvgRpcCount")]
			public double? AvgRpcCount
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

			[JsonProperty(PropertyName = "ServerIp")]
			public string ServerIp
			{
				get
				{
					return serverIp;
				}
				set	
				{
					serverIp = value;
				}
			}

			[JsonProperty(PropertyName = "ServerPort")]
			public long? ServerPort
			{
				get
				{
					return serverPort;
				}
				set	
				{
					serverPort = value;
				}
			}

			[JsonProperty(PropertyName = "SqlTextShort")]
			public string SqlTextShort
			{
				get
				{
					return sqlTextShort;
				}
				set	
				{
					sqlTextShort = value;
				}
			}

			[JsonProperty(PropertyName = "SqlType")]
			public string SqlType
			{
				get
				{
					return sqlType;
				}
				set	
				{
					sqlType = value;
				}
			}

			[JsonProperty(PropertyName = "SqlId")]
			public string SqlId
			{
				get
				{
					return sqlId;
				}
				set	
				{
					sqlId = value;
				}
			}

			[JsonProperty(PropertyName = "Inner")]
			public bool? Inner
			{
				get
				{
					return inner;
				}
				set	
				{
					inner = value;
				}
			}

			[JsonProperty(PropertyName = "WaitEvent")]
			public string WaitEvent
			{
				get
				{
					return waitEvent;
				}
				set	
				{
					waitEvent = value;
				}
			}

			[JsonProperty(PropertyName = "AvgAffectedRows")]
			public double? AvgAffectedRows
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

			[JsonProperty(PropertyName = "AvgReturnRows")]
			public double? AvgReturnRows
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

			[JsonProperty(PropertyName = "FailCount")]
			public double? FailCount
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

			[JsonProperty(PropertyName = "AvgRowCacheHit")]
			public double? AvgRowCacheHit
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

			[JsonProperty(PropertyName = "AvgBloomFilterCacheHit")]
			public double? AvgBloomFilterCacheHit
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

			[JsonProperty(PropertyName = "AvgBlockCacheHit")]
			public double? AvgBlockCacheHit
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
			public double? AvgBlockIndexCacheHit
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

			[JsonProperty(PropertyName = "AvgDiskReads")]
			public double? AvgDiskReads
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

			[JsonProperty(PropertyName = "RetryCount")]
			public double? RetryCount
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

			[JsonProperty(PropertyName = "AvgMemstoreReadRows")]
			public double? AvgMemstoreReadRows
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
			public double? AvgSsstoreReadRows
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

			[JsonProperty(PropertyName = "AvgLogicalReads")]
			public double? AvgLogicalReads
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

			[JsonProperty(PropertyName = "DynamicSql")]
			public bool? DynamicSql
			{
				get
				{
					return dynamicSql;
				}
				set	
				{
					dynamicSql = value;
				}
			}

			[JsonProperty(PropertyName = "LastFailCode")]
			public long? LastFailCode
			{
				get
				{
					return lastFailCode;
				}
				set	
				{
					lastFailCode = value;
				}
			}

			[JsonProperty(PropertyName = "AvgDbTime")]
			public double? AvgDbTime
			{
				get
				{
					return avgDbTime;
				}
				set	
				{
					avgDbTime = value;
				}
			}

			[JsonProperty(PropertyName = "SumDbTime")]
			public double? SumDbTime
			{
				get
				{
					return sumDbTime;
				}
				set	
				{
					sumDbTime = value;
				}
			}

			[JsonProperty(PropertyName = "SqlList")]
			public List<DescribeOasTopSQLList_SqlListItem> SqlList
			{
				get
				{
					return sqlList;
				}
				set	
				{
					sqlList = value;
				}
			}

			public class DescribeOasTopSQLList_SqlListItem
			{

				private double? executions;

				private double? rpcCount;

				private double? remotePlans;

				private double? missPlans;

				private double? maxElapsedTime;

				private double? totalWaitTime;

				private double? execPs;

				private double? maxCpuTime;

				private double? cpuPercentage;

				private string clientIp;

				private string userName;

				private string dbName;

				private long? retCode4012Count;

				private long? retCode4013Count;

				private long? retCode5001Count;

				private long? retCode5024Count;

				private long? retCode5167Count;

				private long? retCode5217Count;

				private long? retCode6002Count;

				private double? failPercentage;

				private double? sumWaitTime;

				private double? avgWaitCount;

				private double? avgRpcCount;

				private double? localPlanPercentage;

				private double? remotePlanPercentage;

				private double? distPlanPercentage;

				private double? sumElapsedTime;

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

				private string server;

				private string serverIp;

				private long? serverPort;

				private string sqlTextShort;

				private string sqlType;

				private string sqlId;

				private bool? inner;

				private string waitEvent;

				private double? avgAffectedRows;

				private double? avgReturnRows;

				private double? avgPartitionCount;

				private double? failCount;

				private double? avgWaitTime;

				private double? avgElapsedTime;

				private double? avgCpuTime;

				private double? avgNetWaitTime;

				private double? avgQueueTime;

				private double? avgDecodeTime;

				private double? avgGetPlanTime;

				private double? avgExecuteTime;

				private double? avgApplicationWaitTime;

				private double? avgConcurrencyWaitTime;

				private double? avgUserIoWaitTime;

				private double? avgScheduleTime;

				private double? avgRowCacheHit;

				private double? avgBloomFilterCacheHit;

				private double? avgBlockCacheHit;

				private double? avgBlockIndexCacheHit;

				private double? avgDiskReads;

				private double? retryCount;

				private double? avgMemstoreReadRows;

				private double? avgSsstoreReadRows;

				private double? avgLogicalReads;

				private double? avgDbTime;

				private double? sumDbTime;

				[JsonProperty(PropertyName = "Executions")]
				public double? Executions
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

				[JsonProperty(PropertyName = "RpcCount")]
				public double? RpcCount
				{
					get
					{
						return rpcCount;
					}
					set	
					{
						rpcCount = value;
					}
				}

				[JsonProperty(PropertyName = "RemotePlans")]
				public double? RemotePlans
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
				public double? MissPlans
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

				[JsonProperty(PropertyName = "TotalWaitTime")]
				public double? TotalWaitTime
				{
					get
					{
						return totalWaitTime;
					}
					set	
					{
						totalWaitTime = value;
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

				[JsonProperty(PropertyName = "CpuPercentage")]
				public double? CpuPercentage
				{
					get
					{
						return cpuPercentage;
					}
					set	
					{
						cpuPercentage = value;
					}
				}

				[JsonProperty(PropertyName = "ClientIp")]
				public string ClientIp
				{
					get
					{
						return clientIp;
					}
					set	
					{
						clientIp = value;
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

				[JsonProperty(PropertyName = "RetCode4012Count")]
				public long? RetCode4012Count
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
				public long? RetCode4013Count
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
				public long? RetCode5001Count
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
				public long? RetCode5024Count
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
				public long? RetCode5167Count
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
				public long? RetCode5217Count
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
				public long? RetCode6002Count
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

				[JsonProperty(PropertyName = "AvgRpcCount")]
				public double? AvgRpcCount
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

				[JsonProperty(PropertyName = "ServerIp")]
				public string ServerIp
				{
					get
					{
						return serverIp;
					}
					set	
					{
						serverIp = value;
					}
				}

				[JsonProperty(PropertyName = "ServerPort")]
				public long? ServerPort
				{
					get
					{
						return serverPort;
					}
					set	
					{
						serverPort = value;
					}
				}

				[JsonProperty(PropertyName = "SqlTextShort")]
				public string SqlTextShort
				{
					get
					{
						return sqlTextShort;
					}
					set	
					{
						sqlTextShort = value;
					}
				}

				[JsonProperty(PropertyName = "SqlType")]
				public string SqlType
				{
					get
					{
						return sqlType;
					}
					set	
					{
						sqlType = value;
					}
				}

				[JsonProperty(PropertyName = "SqlId")]
				public string SqlId
				{
					get
					{
						return sqlId;
					}
					set	
					{
						sqlId = value;
					}
				}

				[JsonProperty(PropertyName = "Inner")]
				public bool? Inner
				{
					get
					{
						return inner;
					}
					set	
					{
						inner = value;
					}
				}

				[JsonProperty(PropertyName = "WaitEvent")]
				public string WaitEvent
				{
					get
					{
						return waitEvent;
					}
					set	
					{
						waitEvent = value;
					}
				}

				[JsonProperty(PropertyName = "AvgAffectedRows")]
				public double? AvgAffectedRows
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

				[JsonProperty(PropertyName = "AvgReturnRows")]
				public double? AvgReturnRows
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

				[JsonProperty(PropertyName = "FailCount")]
				public double? FailCount
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

				[JsonProperty(PropertyName = "AvgRowCacheHit")]
				public double? AvgRowCacheHit
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

				[JsonProperty(PropertyName = "AvgBloomFilterCacheHit")]
				public double? AvgBloomFilterCacheHit
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

				[JsonProperty(PropertyName = "AvgBlockCacheHit")]
				public double? AvgBlockCacheHit
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
				public double? AvgBlockIndexCacheHit
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

				[JsonProperty(PropertyName = "AvgDiskReads")]
				public double? AvgDiskReads
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

				[JsonProperty(PropertyName = "RetryCount")]
				public double? RetryCount
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

				[JsonProperty(PropertyName = "AvgMemstoreReadRows")]
				public double? AvgMemstoreReadRows
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
				public double? AvgSsstoreReadRows
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

				[JsonProperty(PropertyName = "AvgLogicalReads")]
				public double? AvgLogicalReads
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

				[JsonProperty(PropertyName = "AvgDbTime")]
				public double? AvgDbTime
				{
					get
					{
						return avgDbTime;
					}
					set	
					{
						avgDbTime = value;
					}
				}

				[JsonProperty(PropertyName = "SumDbTime")]
				public double? SumDbTime
				{
					get
					{
						return sumDbTime;
					}
					set	
					{
						sumDbTime = value;
					}
				}
			}
		}
	}
}
