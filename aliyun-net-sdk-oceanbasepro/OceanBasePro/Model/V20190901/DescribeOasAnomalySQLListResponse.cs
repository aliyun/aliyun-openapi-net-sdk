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
	public class DescribeOasAnomalySQLListResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private List<DescribeOasAnomalySQLList_DataItem> data;

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

		[JsonProperty(PropertyName = "Data")]
		public List<DescribeOasAnomalySQLList_DataItem> Data
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

		public class DescribeOasAnomalySQLList_DataItem
		{

			private double? avgCpuTime;

			private double? avgElapsedTime;

			private double? avgGetPlanTime;

			private double? cpuTime;

			private string dbName;

			private string diagnosis;

			private double? executions;

			private double? lastExecutedTime;

			private string riskLevel;

			private string sqlId;

			private string sqlTextShort;

			private string suggestion;

			private string sumElapsedTime;

			private string userName;

			private bool? dynamicSql;

			private double? avgDbTime;

			private double? sumDbTime;

			private List<DescribeOasAnomalySQLList_SqlListItem> sqlList;

			private List<string> diagTypes;

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

			[JsonProperty(PropertyName = "LastExecutedTime")]
			public double? LastExecutedTime
			{
				get
				{
					return lastExecutedTime;
				}
				set	
				{
					lastExecutedTime = value;
				}
			}

			[JsonProperty(PropertyName = "RiskLevel")]
			public string RiskLevel
			{
				get
				{
					return riskLevel;
				}
				set	
				{
					riskLevel = value;
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

			[JsonProperty(PropertyName = "SumElapsedTime")]
			public string SumElapsedTime
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
			public List<DescribeOasAnomalySQLList_SqlListItem> SqlList
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

			[JsonProperty(PropertyName = "DiagTypes")]
			public List<string> DiagTypes
			{
				get
				{
					return diagTypes;
				}
				set	
				{
					diagTypes = value;
				}
			}

			public class DescribeOasAnomalySQLList_SqlListItem
			{

				private double? avgCpuTime;

				private double? avgElapsedTime;

				private double? avgGetPlanTime;

				private double? cpuTime;

				private string dbName;

				private string diagnosis;

				private double? executions;

				private double? lastExecutedTime;

				private string riskLevel;

				private string sqlId;

				private string sqlTextShort;

				private string suggestion;

				private string sumElapsedTime;

				private string userName;

				private double? avgDbTime;

				private double? sumDbTime;

				private List<string> diagTypes1;

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

				[JsonProperty(PropertyName = "LastExecutedTime")]
				public double? LastExecutedTime
				{
					get
					{
						return lastExecutedTime;
					}
					set	
					{
						lastExecutedTime = value;
					}
				}

				[JsonProperty(PropertyName = "RiskLevel")]
				public string RiskLevel
				{
					get
					{
						return riskLevel;
					}
					set	
					{
						riskLevel = value;
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

				[JsonProperty(PropertyName = "SumElapsedTime")]
				public string SumElapsedTime
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

				[JsonProperty(PropertyName = "DiagTypes1")]
				public List<string> DiagTypes1
				{
					get
					{
						return diagTypes1;
					}
					set	
					{
						diagTypes1 = value;
					}
				}
			}
		}
	}
}
