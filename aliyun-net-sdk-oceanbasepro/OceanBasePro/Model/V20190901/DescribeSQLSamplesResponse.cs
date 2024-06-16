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
	public class DescribeSQLSamplesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSQLSamples_DataItem> data;

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
		public List<DescribeSQLSamples_DataItem> Data
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

		public class DescribeSQLSamples_DataItem
		{

			private string requestId;

			private string traceId;

			private string requestTime;

			private string server;

			private string clientIp;

			private string clientPort;

			private string dbName;

			private string userName;

			private string sqlType;

			private double? planId;

			private double? affectedRows;

			private double? returnRows;

			private double? partitionCount;

			private double? retCode;

			private string waitEvent;

			private double? waitTime;

			private double? waitCount;

			private double? rpcCount;

			private string planType;

			private bool? inner;

			private bool? executorRpc;

			private bool? hitPlan;

			private double? elapsedTime;

			private double? cpuTime;

			private double? netTime;

			private double? netWaitTime;

			private double? queueTime;

			private double? decodeTime;

			private double? getPlanTime;

			private double? executeTime;

			private double? applicationWaitTime;

			private double? concurrencyWaitTime;

			private double? userIoWaitTime;

			private double? scheduleTime;

			private double? rowCacheHit;

			private double? bloomFilterCacheHit;

			private double? blockCacheHit;

			private double? blockIndexCacheHit;

			private double? diskReads;

			private double? retryCount;

			private bool? tableScan;

			private string consistencyLevel;

			private double? memstoreReadRows;

			private double? expectedWorkerCount;

			private double? usedWorkerCount;

			private double? ssstoreReadRows;

			private double? obServerId;

			private double? obUserId;

			private double? obDbId;

			private string statement;

			private string transHash;

			private string fullSqlText;

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

			[JsonProperty(PropertyName = "TraceId")]
			public string TraceId
			{
				get
				{
					return traceId;
				}
				set	
				{
					traceId = value;
				}
			}

			[JsonProperty(PropertyName = "RequestTime")]
			public string RequestTime
			{
				get
				{
					return requestTime;
				}
				set	
				{
					requestTime = value;
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

			[JsonProperty(PropertyName = "ClientPort")]
			public string ClientPort
			{
				get
				{
					return clientPort;
				}
				set	
				{
					clientPort = value;
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

			[JsonProperty(PropertyName = "PlanId")]
			public double? PlanId
			{
				get
				{
					return planId;
				}
				set	
				{
					planId = value;
				}
			}

			[JsonProperty(PropertyName = "AffectedRows")]
			public double? AffectedRows
			{
				get
				{
					return affectedRows;
				}
				set	
				{
					affectedRows = value;
				}
			}

			[JsonProperty(PropertyName = "ReturnRows")]
			public double? ReturnRows
			{
				get
				{
					return returnRows;
				}
				set	
				{
					returnRows = value;
				}
			}

			[JsonProperty(PropertyName = "PartitionCount")]
			public double? PartitionCount
			{
				get
				{
					return partitionCount;
				}
				set	
				{
					partitionCount = value;
				}
			}

			[JsonProperty(PropertyName = "RetCode")]
			public double? RetCode
			{
				get
				{
					return retCode;
				}
				set	
				{
					retCode = value;
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

			[JsonProperty(PropertyName = "WaitTime")]
			public double? WaitTime
			{
				get
				{
					return waitTime;
				}
				set	
				{
					waitTime = value;
				}
			}

			[JsonProperty(PropertyName = "WaitCount")]
			public double? WaitCount
			{
				get
				{
					return waitCount;
				}
				set	
				{
					waitCount = value;
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

			[JsonProperty(PropertyName = "PlanType")]
			public string PlanType
			{
				get
				{
					return planType;
				}
				set	
				{
					planType = value;
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

			[JsonProperty(PropertyName = "ExecutorRpc")]
			public bool? ExecutorRpc
			{
				get
				{
					return executorRpc;
				}
				set	
				{
					executorRpc = value;
				}
			}

			[JsonProperty(PropertyName = "HitPlan")]
			public bool? HitPlan
			{
				get
				{
					return hitPlan;
				}
				set	
				{
					hitPlan = value;
				}
			}

			[JsonProperty(PropertyName = "ElapsedTime")]
			public double? ElapsedTime
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

			[JsonProperty(PropertyName = "CpuTime")]
			public double? CpuTime
			{
				get
				{
					return cpuTime;
				}
				set	
				{
					cpuTime = value;
				}
			}

			[JsonProperty(PropertyName = "NetTime")]
			public double? NetTime
			{
				get
				{
					return netTime;
				}
				set	
				{
					netTime = value;
				}
			}

			[JsonProperty(PropertyName = "NetWaitTime")]
			public double? NetWaitTime
			{
				get
				{
					return netWaitTime;
				}
				set	
				{
					netWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "QueueTime")]
			public double? QueueTime
			{
				get
				{
					return queueTime;
				}
				set	
				{
					queueTime = value;
				}
			}

			[JsonProperty(PropertyName = "DecodeTime")]
			public double? DecodeTime
			{
				get
				{
					return decodeTime;
				}
				set	
				{
					decodeTime = value;
				}
			}

			[JsonProperty(PropertyName = "GetPlanTime")]
			public double? GetPlanTime
			{
				get
				{
					return getPlanTime;
				}
				set	
				{
					getPlanTime = value;
				}
			}

			[JsonProperty(PropertyName = "ExecuteTime")]
			public double? ExecuteTime
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

			[JsonProperty(PropertyName = "ApplicationWaitTime")]
			public double? ApplicationWaitTime
			{
				get
				{
					return applicationWaitTime;
				}
				set	
				{
					applicationWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "ConcurrencyWaitTime")]
			public double? ConcurrencyWaitTime
			{
				get
				{
					return concurrencyWaitTime;
				}
				set	
				{
					concurrencyWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "UserIoWaitTime")]
			public double? UserIoWaitTime
			{
				get
				{
					return userIoWaitTime;
				}
				set	
				{
					userIoWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "ScheduleTime")]
			public double? ScheduleTime
			{
				get
				{
					return scheduleTime;
				}
				set	
				{
					scheduleTime = value;
				}
			}

			[JsonProperty(PropertyName = "RowCacheHit")]
			public double? RowCacheHit
			{
				get
				{
					return rowCacheHit;
				}
				set	
				{
					rowCacheHit = value;
				}
			}

			[JsonProperty(PropertyName = "BloomFilterCacheHit")]
			public double? BloomFilterCacheHit
			{
				get
				{
					return bloomFilterCacheHit;
				}
				set	
				{
					bloomFilterCacheHit = value;
				}
			}

			[JsonProperty(PropertyName = "BlockCacheHit")]
			public double? BlockCacheHit
			{
				get
				{
					return blockCacheHit;
				}
				set	
				{
					blockCacheHit = value;
				}
			}

			[JsonProperty(PropertyName = "BlockIndexCacheHit")]
			public double? BlockIndexCacheHit
			{
				get
				{
					return blockIndexCacheHit;
				}
				set	
				{
					blockIndexCacheHit = value;
				}
			}

			[JsonProperty(PropertyName = "DiskReads")]
			public double? DiskReads
			{
				get
				{
					return diskReads;
				}
				set	
				{
					diskReads = value;
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

			[JsonProperty(PropertyName = "TableScan")]
			public bool? TableScan
			{
				get
				{
					return tableScan;
				}
				set	
				{
					tableScan = value;
				}
			}

			[JsonProperty(PropertyName = "ConsistencyLevel")]
			public string ConsistencyLevel
			{
				get
				{
					return consistencyLevel;
				}
				set	
				{
					consistencyLevel = value;
				}
			}

			[JsonProperty(PropertyName = "MemstoreReadRows")]
			public double? MemstoreReadRows
			{
				get
				{
					return memstoreReadRows;
				}
				set	
				{
					memstoreReadRows = value;
				}
			}

			[JsonProperty(PropertyName = "ExpectedWorkerCount")]
			public double? ExpectedWorkerCount
			{
				get
				{
					return expectedWorkerCount;
				}
				set	
				{
					expectedWorkerCount = value;
				}
			}

			[JsonProperty(PropertyName = "UsedWorkerCount")]
			public double? UsedWorkerCount
			{
				get
				{
					return usedWorkerCount;
				}
				set	
				{
					usedWorkerCount = value;
				}
			}

			[JsonProperty(PropertyName = "SsstoreReadRows")]
			public double? SsstoreReadRows
			{
				get
				{
					return ssstoreReadRows;
				}
				set	
				{
					ssstoreReadRows = value;
				}
			}

			[JsonProperty(PropertyName = "ObServerId")]
			public double? ObServerId
			{
				get
				{
					return obServerId;
				}
				set	
				{
					obServerId = value;
				}
			}

			[JsonProperty(PropertyName = "ObUserId")]
			public double? ObUserId
			{
				get
				{
					return obUserId;
				}
				set	
				{
					obUserId = value;
				}
			}

			[JsonProperty(PropertyName = "ObDbId")]
			public double? ObDbId
			{
				get
				{
					return obDbId;
				}
				set	
				{
					obDbId = value;
				}
			}

			[JsonProperty(PropertyName = "Statement")]
			public string Statement
			{
				get
				{
					return statement;
				}
				set	
				{
					statement = value;
				}
			}

			[JsonProperty(PropertyName = "TransHash")]
			public string TransHash
			{
				get
				{
					return transHash;
				}
				set	
				{
					transHash = value;
				}
			}

			[JsonProperty(PropertyName = "FullSqlText")]
			public string FullSqlText
			{
				get
				{
					return fullSqlText;
				}
				set	
				{
					fullSqlText = value;
				}
			}
		}
	}
}
