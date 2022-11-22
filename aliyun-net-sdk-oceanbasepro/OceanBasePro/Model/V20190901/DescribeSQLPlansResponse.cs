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
	public class DescribeSQLPlansResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSQLPlans_Data> sQLPlans;

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

		[JsonProperty(PropertyName = "SQLPlans")]
		public List<DescribeSQLPlans_Data> SQLPlans
		{
			get
			{
				return sQLPlans;
			}
			set	
			{
				sQLPlans = value;
			}
		}

		public class DescribeSQLPlans_Data
		{

			private int? hitCount;

			private string outlineData;

			private float? avgExecutionMS;

			private string planUnionHash;

			private long? outlineId;

			private long? avgExecutionTimeMS;

			private int? planId;

			private long? outlineTime;

			private string outlineTimeUTCString;

			private string planFull;

			private string nodeIp;

			private int? mergedVersion;

			private string querySQL;

			private string firstLoadTimeUTCString;

			private long? firstLoadTime;

			private string planInfo;

			[JsonProperty(PropertyName = "HitCount")]
			public int? HitCount
			{
				get
				{
					return hitCount;
				}
				set	
				{
					hitCount = value;
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

			[JsonProperty(PropertyName = "AvgExecutionMS")]
			public float? AvgExecutionMS
			{
				get
				{
					return avgExecutionMS;
				}
				set	
				{
					avgExecutionMS = value;
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

			[JsonProperty(PropertyName = "AvgExecutionTimeMS")]
			public long? AvgExecutionTimeMS
			{
				get
				{
					return avgExecutionTimeMS;
				}
				set	
				{
					avgExecutionTimeMS = value;
				}
			}

			[JsonProperty(PropertyName = "PlanId")]
			public int? PlanId
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

			[JsonProperty(PropertyName = "OutlineTime")]
			public long? OutlineTime
			{
				get
				{
					return outlineTime;
				}
				set	
				{
					outlineTime = value;
				}
			}

			[JsonProperty(PropertyName = "OutlineTimeUTCString")]
			public string OutlineTimeUTCString
			{
				get
				{
					return outlineTimeUTCString;
				}
				set	
				{
					outlineTimeUTCString = value;
				}
			}

			[JsonProperty(PropertyName = "PlanFull")]
			public string PlanFull
			{
				get
				{
					return planFull;
				}
				set	
				{
					planFull = value;
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

			[JsonProperty(PropertyName = "MergedVersion")]
			public int? MergedVersion
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

			[JsonProperty(PropertyName = "QuerySQL")]
			public string QuerySQL
			{
				get
				{
					return querySQL;
				}
				set	
				{
					querySQL = value;
				}
			}

			[JsonProperty(PropertyName = "FirstLoadTimeUTCString")]
			public string FirstLoadTimeUTCString
			{
				get
				{
					return firstLoadTimeUTCString;
				}
				set	
				{
					firstLoadTimeUTCString = value;
				}
			}

			[JsonProperty(PropertyName = "FirstLoadTime")]
			public long? FirstLoadTime
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

			[JsonProperty(PropertyName = "PlanInfo")]
			public string PlanInfo
			{
				get
				{
					return planInfo;
				}
				set	
				{
					planInfo = value;
				}
			}
		}
	}
}
