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
	public class DescribeSlowSQLHistoryListResponse : AcsResponse
	{

		private string requestId;

		private DescribeSlowSQLHistoryList_SlowSQLHistoryList slowSQLHistoryList;

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

		[JsonProperty(PropertyName = "SlowSQLHistoryList")]
		public DescribeSlowSQLHistoryList_SlowSQLHistoryList SlowSQLHistoryList
		{
			get
			{
				return slowSQLHistoryList;
			}
			set	
			{
				slowSQLHistoryList = value;
			}
		}

		public class DescribeSlowSQLHistoryList_SlowSQLHistoryList
		{

			private long? count;

			private List<DescribeSlowSQLHistoryList_ListItem> list;

			[JsonProperty(PropertyName = "Count")]
			public long? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			[JsonProperty(PropertyName = "List")]
			public List<DescribeSlowSQLHistoryList_ListItem> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class DescribeSlowSQLHistoryList_ListItem
			{

				private string sqlId;

				private string sqlType;

				private string tenantName;

				private string userName;

				private string clientIp;

				private string dbName;

				private string _event;

				private string nodeIp;

				private double? affectedRows;

				private double? blockCacheHit;

				private double? blockIndexCacheHit;

				private double? bloomFilterCacheHit;

				private double? executions;

				private double? failTimes;

				private double? rPCCount;

				private double? remotePlans;

				private double? missPlans;

				private double? returnRows;

				private double? logicalRead;

				private double? retryCount;

				private double? rowCacheHit;

				private double? diskRead;

				private double? memstoreReadRowCount;

				private double? ssstoreReadRowCount;

				private double? execPerSecond;

				private double? appWaitTime;

				private double? elapsedTime;

				private double? executeTime;

				private double? queueTime;

				private double? concurrencyWaitTime;

				private double? cpuTime;

				private double? decodeTime;

				private double? netwaitTime;

				private double? iOWaitTime;

				private double? getplanTime;

				private double? maxElapsedTime;

				private double? totalWaitTime;

				private double? scheduleTime;

				private double? maxCpuTime;

				private string endTimeUTCString;

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

				[JsonProperty(PropertyName = "TenantName")]
				public string TenantName
				{
					get
					{
						return tenantName;
					}
					set	
					{
						tenantName = value;
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

				[JsonProperty(PropertyName = "FailTimes")]
				public double? FailTimes
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

				[JsonProperty(PropertyName = "RPCCount")]
				public double? RPCCount
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

				[JsonProperty(PropertyName = "LogicalRead")]
				public double? LogicalRead
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

				[JsonProperty(PropertyName = "DiskRead")]
				public double? DiskRead
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

				[JsonProperty(PropertyName = "MemstoreReadRowCount")]
				public double? MemstoreReadRowCount
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

				[JsonProperty(PropertyName = "SsstoreReadRowCount")]
				public double? SsstoreReadRowCount
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

				[JsonProperty(PropertyName = "ExecPerSecond")]
				public double? ExecPerSecond
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

				[JsonProperty(PropertyName = "AppWaitTime")]
				public double? AppWaitTime
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

				[JsonProperty(PropertyName = "NetwaitTime")]
				public double? NetwaitTime
				{
					get
					{
						return netwaitTime;
					}
					set	
					{
						netwaitTime = value;
					}
				}

				[JsonProperty(PropertyName = "IOWaitTime")]
				public double? IOWaitTime
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

				[JsonProperty(PropertyName = "GetplanTime")]
				public double? GetplanTime
				{
					get
					{
						return getplanTime;
					}
					set	
					{
						getplanTime = value;
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

				[JsonProperty(PropertyName = "EndTimeUTCString")]
				public string EndTimeUTCString
				{
					get
					{
						return endTimeUTCString;
					}
					set	
					{
						endTimeUTCString = value;
					}
				}
			}
		}
	}
}
