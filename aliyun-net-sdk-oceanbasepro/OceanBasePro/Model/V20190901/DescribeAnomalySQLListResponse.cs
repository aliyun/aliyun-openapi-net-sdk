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
	public class DescribeAnomalySQLListResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private List<DescribeAnomalySQLList_Data> anomalySQLList;

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

		[JsonProperty(PropertyName = "AnomalySQLList")]
		public List<DescribeAnomalySQLList_Data> AnomalySQLList
		{
			get
			{
				return anomalySQLList;
			}
			set	
			{
				anomalySQLList = value;
			}
		}

		public class DescribeAnomalySQLList_Data
		{

			private long? key;

			private string diagnosisRule;

			private string sQLText;

			private string suggestion;

			private string dbName;

			private string requestTimeUTCString;

			private float? cpuTime;

			private string sQLId;

			private string diagnosis;

			private float? requestTime;

			private long? executions;

			private string userName;

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

			[JsonProperty(PropertyName = "DiagnosisRule")]
			public string DiagnosisRule
			{
				get
				{
					return diagnosisRule;
				}
				set	
				{
					diagnosisRule = value;
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

			[JsonProperty(PropertyName = "Suggestion")]
			public string Suggestion
			{
				get
				{
					return suggestion;
				}
				set	
				{
					suggestion = value;
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

			[JsonProperty(PropertyName = "RequestTimeUTCString")]
			public string RequestTimeUTCString
			{
				get
				{
					return requestTimeUTCString;
				}
				set	
				{
					requestTimeUTCString = value;
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

			[JsonProperty(PropertyName = "Diagnosis")]
			public string Diagnosis
			{
				get
				{
					return diagnosis;
				}
				set	
				{
					diagnosis = value;
				}
			}

			[JsonProperty(PropertyName = "RequestTime")]
			public float? RequestTime
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
		}
	}
}
