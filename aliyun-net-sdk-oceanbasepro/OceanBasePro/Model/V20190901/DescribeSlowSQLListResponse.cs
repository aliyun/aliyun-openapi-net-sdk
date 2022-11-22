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
	public class DescribeSlowSQLListResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private List<DescribeSlowSQLList_Data> slowSQLList;

		[JsonProperty(PropertyName = "TotalCount")]
		public long? TotalCount
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

		[JsonProperty(PropertyName = "SlowSQLList")]
		public List<DescribeSlowSQLList_Data> SlowSQLList
		{
			get
			{
				return slowSQLList;
			}
			set	
			{
				slowSQLList = value;
			}
		}

		public class DescribeSlowSQLList_Data
		{

			private long? key;

			private float? execPerSecond;

			private string sQLText;

			private float? maxCpuTime;

			private long? blockCacheHit;

			private float? decodeTime;

			private long? remotePlans;

			private long? rPCCount;

			private float? netWaitTime;

			private long? diskRead;

			private string nodeIp;

			private float? concurrencyWaitTime;

			private long? memstoreReadRowCount;

			private string dbName;

			private float? appWaitTime;

			private float? elapsedTime;

			private long? missPlans;

			private long? affectedRows;

			private float? scheduleTime;

			private string _event;

			private float? totalWaitTime;

			private long? returnRows;

			private float? executeTime;

			private string userName;

			private long? executions;

			private float? getPlanTime;

			private float? cpuTime;

			private float? maxElapsedTime;

			private long? sQLType;

			private long? blockIndexCacheHit;

			private long? retryCount;

			private string sQLId;

			private string clientIp;

			private long? bloomFilterCacheHit;

			private float? iOWaitTime;

			private long? failTimes;

			private float? queueTime;

			private long? rowCacheHit;

			private long? logicalRead;

			private long? ssstoreReadRowCount;

			[JsonProperty(PropertyName = "Key")]
			public long? Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			[JsonProperty(PropertyName = "ExecPerSecond")]
			public float? ExecPerSecond
			{
				get
				{
					return execPerSecond;
				}
				set	
				{
					execPerSecond = value;
				}
			}

			[JsonProperty(PropertyName = "SQLText")]
			public string SQLText
			{
				get
				{
					return sQLText;
				}
				set	
				{
					sQLText = value;
				}
			}

			[JsonProperty(PropertyName = "MaxCpuTime")]
			public float? MaxCpuTime
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

			[JsonProperty(PropertyName = "BlockCacheHit")]
			public long? BlockCacheHit
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

			[JsonProperty(PropertyName = "DecodeTime")]
			public float? DecodeTime
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

			[JsonProperty(PropertyName = "RPCCount")]
			public long? RPCCount
			{
				get
				{
					return rPCCount;
				}
				set	
				{
					rPCCount = value;
				}
			}

			[JsonProperty(PropertyName = "NetWaitTime")]
			public float? NetWaitTime
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

			[JsonProperty(PropertyName = "DiskRead")]
			public long? DiskRead
			{
				get
				{
					return diskRead;
				}
				set	
				{
					diskRead = value;
				}
			}

			[JsonProperty(PropertyName = "NodeIp")]
			public string NodeIp
			{
				get
				{
					return nodeIp;
				}
				set	
				{
					nodeIp = value;
				}
			}

			[JsonProperty(PropertyName = "ConcurrencyWaitTime")]
			public float? ConcurrencyWaitTime
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

			[JsonProperty(PropertyName = "MemstoreReadRowCount")]
			public long? MemstoreReadRowCount
			{
				get
				{
					return memstoreReadRowCount;
				}
				set	
				{
					memstoreReadRowCount = value;
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

			[JsonProperty(PropertyName = "AppWaitTime")]
			public float? AppWaitTime
			{
				get
				{
					return appWaitTime;
				}
				set	
				{
					appWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "ElapsedTime")]
			public float? ElapsedTime
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

			[JsonProperty(PropertyName = "AffectedRows")]
			public long? AffectedRows
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

			[JsonProperty(PropertyName = "ScheduleTime")]
			public float? ScheduleTime
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

			[JsonProperty(PropertyName = "_Event")]
			public string _Event
			{
				get
				{
					return _event;
				}
				set	
				{
					_event = value;
				}
			}

			[JsonProperty(PropertyName = "TotalWaitTime")]
			public float? TotalWaitTime
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

			[JsonProperty(PropertyName = "ReturnRows")]
			public long? ReturnRows
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

			[JsonProperty(PropertyName = "ExecuteTime")]
			public float? ExecuteTime
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

			[JsonProperty(PropertyName = "GetPlanTime")]
			public float? GetPlanTime
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

			[JsonProperty(PropertyName = "CpuTime")]
			public float? CpuTime
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

			[JsonProperty(PropertyName = "MaxElapsedTime")]
			public float? MaxElapsedTime
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

			[JsonProperty(PropertyName = "SQLType")]
			public long? SQLType
			{
				get
				{
					return sQLType;
				}
				set	
				{
					sQLType = value;
				}
			}

			[JsonProperty(PropertyName = "BlockIndexCacheHit")]
			public long? BlockIndexCacheHit
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

			[JsonProperty(PropertyName = "BloomFilterCacheHit")]
			public long? BloomFilterCacheHit
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

			[JsonProperty(PropertyName = "IOWaitTime")]
			public float? IOWaitTime
			{
				get
				{
					return iOWaitTime;
				}
				set	
				{
					iOWaitTime = value;
				}
			}

			[JsonProperty(PropertyName = "FailTimes")]
			public long? FailTimes
			{
				get
				{
					return failTimes;
				}
				set	
				{
					failTimes = value;
				}
			}

			[JsonProperty(PropertyName = "QueueTime")]
			public float? QueueTime
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

			[JsonProperty(PropertyName = "RowCacheHit")]
			public long? RowCacheHit
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

			[JsonProperty(PropertyName = "LogicalRead")]
			public long? LogicalRead
			{
				get
				{
					return logicalRead;
				}
				set	
				{
					logicalRead = value;
				}
			}

			[JsonProperty(PropertyName = "SsstoreReadRowCount")]
			public long? SsstoreReadRowCount
			{
				get
				{
					return ssstoreReadRowCount;
				}
				set	
				{
					ssstoreReadRowCount = value;
				}
			}
		}
	}
}
