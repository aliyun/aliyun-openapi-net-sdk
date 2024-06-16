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
	public class DescribeOasSQLPlansResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeOasSQLPlans_DataItem> data;

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
		public List<DescribeOasSQLPlans_DataItem> Data
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

		public class DescribeOasSQLPlans_DataItem
		{

			private string planHash;

			private long? mergedVersion;

			private string firstLoadTime;

			private string planType;

			private bool? hitDiagnosis;

			private double? hitPercentage;

			private double? avgCpuTime;

			private long? executions;

			private string planUnionHash;

			private string querySql;

			private bool? bounded;

			private List<DescribeOasSQLPlans_PlansItem> plans;

			private DescribeOasSQLPlans_PlanExplain planExplain;

			[JsonProperty(PropertyName = "PlanHash")]
			public string PlanHash
			{
				get
				{
					return planHash;
				}
				set	
				{
					planHash = value;
				}
			}

			[JsonProperty(PropertyName = "MergedVersion")]
			public long? MergedVersion
			{
				get
				{
					return mergedVersion;
				}
				set	
				{
					mergedVersion = value;
				}
			}

			[JsonProperty(PropertyName = "FirstLoadTime")]
			public string FirstLoadTime
			{
				get
				{
					return firstLoadTime;
				}
				set	
				{
					firstLoadTime = value;
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

			[JsonProperty(PropertyName = "HitDiagnosis")]
			public bool? HitDiagnosis
			{
				get
				{
					return hitDiagnosis;
				}
				set	
				{
					hitDiagnosis = value;
				}
			}

			[JsonProperty(PropertyName = "HitPercentage")]
			public double? HitPercentage
			{
				get
				{
					return hitPercentage;
				}
				set	
				{
					hitPercentage = value;
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

			[JsonProperty(PropertyName = "PlanUnionHash")]
			public string PlanUnionHash
			{
				get
				{
					return planUnionHash;
				}
				set	
				{
					planUnionHash = value;
				}
			}

			[JsonProperty(PropertyName = "QuerySql")]
			public string QuerySql
			{
				get
				{
					return querySql;
				}
				set	
				{
					querySql = value;
				}
			}

			[JsonProperty(PropertyName = "Bounded")]
			public bool? Bounded
			{
				get
				{
					return bounded;
				}
				set	
				{
					bounded = value;
				}
			}

			[JsonProperty(PropertyName = "Plans")]
			public List<DescribeOasSQLPlans_PlansItem> Plans
			{
				get
				{
					return plans;
				}
				set	
				{
					plans = value;
				}
			}

			[JsonProperty(PropertyName = "PlanExplain")]
			public DescribeOasSQLPlans_PlanExplain PlanExplain
			{
				get
				{
					return planExplain;
				}
				set	
				{
					planExplain = value;
				}
			}

			public class DescribeOasSQLPlans_PlansItem
			{

				private string uid;

				private long? planId;

				private string firstLoadTime;

				private string planType;

				private string planHash;

				private long? planSize;

				private long? schemaVersion;

				private long? mergedVersion;

				private long? obServerId;

				private long? obDbId;

				private long? serverId;

				private long? firstLoadTimeUs;

				private bool? hitDiagnosis;

				private string outlineData;

				private long? outlineId;

				private long? collectTimeUs;

				private string server;

				private double? hitPercentage;

				private long? executions;

				private double? execPs;

				private double? avgDiskReads;

				private double? avgDiskWrites;

				private double? avgBufferGets;

				private double? avgApplicationWaitTime;

				private double? avgConcurrencyWaitTime;

				private double? avgUserIoWaitTime;

				private double? avgRowProcessed;

				private double? avgElapsedTime;

				private double? avgCpuTime;

				private double? largeQueryPercentage;

				private double? delayedLargeQueryPercentage;

				private double? timeoutPercentage;

				private bool? tableScan;

				private string planUnionHash;

				private string sqlId;

				[JsonProperty(PropertyName = "Uid")]
				public string Uid
				{
					get
					{
						return uid;
					}
					set	
					{
						uid = value;
					}
				}

				[JsonProperty(PropertyName = "PlanId")]
				public long? PlanId
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

				[JsonProperty(PropertyName = "FirstLoadTime")]
				public string FirstLoadTime
				{
					get
					{
						return firstLoadTime;
					}
					set	
					{
						firstLoadTime = value;
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

				[JsonProperty(PropertyName = "PlanHash")]
				public string PlanHash
				{
					get
					{
						return planHash;
					}
					set	
					{
						planHash = value;
					}
				}

				[JsonProperty(PropertyName = "PlanSize")]
				public long? PlanSize
				{
					get
					{
						return planSize;
					}
					set	
					{
						planSize = value;
					}
				}

				[JsonProperty(PropertyName = "SchemaVersion")]
				public long? SchemaVersion
				{
					get
					{
						return schemaVersion;
					}
					set	
					{
						schemaVersion = value;
					}
				}

				[JsonProperty(PropertyName = "MergedVersion")]
				public long? MergedVersion
				{
					get
					{
						return mergedVersion;
					}
					set	
					{
						mergedVersion = value;
					}
				}

				[JsonProperty(PropertyName = "ObServerId")]
				public long? ObServerId
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

				[JsonProperty(PropertyName = "ObDbId")]
				public long? ObDbId
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

				[JsonProperty(PropertyName = "ServerId")]
				public long? ServerId
				{
					get
					{
						return serverId;
					}
					set	
					{
						serverId = value;
					}
				}

				[JsonProperty(PropertyName = "FirstLoadTimeUs")]
				public long? FirstLoadTimeUs
				{
					get
					{
						return firstLoadTimeUs;
					}
					set	
					{
						firstLoadTimeUs = value;
					}
				}

				[JsonProperty(PropertyName = "HitDiagnosis")]
				public bool? HitDiagnosis
				{
					get
					{
						return hitDiagnosis;
					}
					set	
					{
						hitDiagnosis = value;
					}
				}

				[JsonProperty(PropertyName = "OutlineData")]
				public string OutlineData
				{
					get
					{
						return outlineData;
					}
					set	
					{
						outlineData = value;
					}
				}

				[JsonProperty(PropertyName = "OutlineId")]
				public long? OutlineId
				{
					get
					{
						return outlineId;
					}
					set	
					{
						outlineId = value;
					}
				}

				[JsonProperty(PropertyName = "CollectTimeUs")]
				public long? CollectTimeUs
				{
					get
					{
						return collectTimeUs;
					}
					set	
					{
						collectTimeUs = value;
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

				[JsonProperty(PropertyName = "HitPercentage")]
				public double? HitPercentage
				{
					get
					{
						return hitPercentage;
					}
					set	
					{
						hitPercentage = value;
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

				[JsonProperty(PropertyName = "AvgDiskWrites")]
				public double? AvgDiskWrites
				{
					get
					{
						return avgDiskWrites;
					}
					set	
					{
						avgDiskWrites = value;
					}
				}

				[JsonProperty(PropertyName = "AvgBufferGets")]
				public double? AvgBufferGets
				{
					get
					{
						return avgBufferGets;
					}
					set	
					{
						avgBufferGets = value;
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

				[JsonProperty(PropertyName = "AvgRowProcessed")]
				public double? AvgRowProcessed
				{
					get
					{
						return avgRowProcessed;
					}
					set	
					{
						avgRowProcessed = value;
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

				[JsonProperty(PropertyName = "LargeQueryPercentage")]
				public double? LargeQueryPercentage
				{
					get
					{
						return largeQueryPercentage;
					}
					set	
					{
						largeQueryPercentage = value;
					}
				}

				[JsonProperty(PropertyName = "DelayedLargeQueryPercentage")]
				public double? DelayedLargeQueryPercentage
				{
					get
					{
						return delayedLargeQueryPercentage;
					}
					set	
					{
						delayedLargeQueryPercentage = value;
					}
				}

				[JsonProperty(PropertyName = "TimeoutPercentage")]
				public double? TimeoutPercentage
				{
					get
					{
						return timeoutPercentage;
					}
					set	
					{
						timeoutPercentage = value;
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

				[JsonProperty(PropertyName = "PlanUnionHash")]
				public string PlanUnionHash
				{
					get
					{
						return planUnionHash;
					}
					set	
					{
						planUnionHash = value;
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
			}

			public class DescribeOasSQLPlans_PlanExplain
			{

				private string planJsonString;

				[JsonProperty(PropertyName = "PlanJsonString")]
				public string PlanJsonString
				{
					get
					{
						return planJsonString;
					}
					set	
					{
						planJsonString = value;
					}
				}
			}
		}
	}
}
