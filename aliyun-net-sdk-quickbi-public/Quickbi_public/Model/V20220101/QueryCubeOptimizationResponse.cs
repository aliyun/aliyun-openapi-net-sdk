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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class QueryCubeOptimizationResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<QueryCubeOptimization_Data> result;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public List<QueryCubeOptimization_Data> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class QueryCubeOptimization_Data
		{

			private string adviceType;

			private QueryCubeOptimization_CubePerformanceDiagnoseModel cubePerformanceDiagnoseModel;

			public string AdviceType
			{
				get
				{
					return adviceType;
				}
				set	
				{
					adviceType = value;
				}
			}

			public QueryCubeOptimization_CubePerformanceDiagnoseModel CubePerformanceDiagnoseModel
			{
				get
				{
					return cubePerformanceDiagnoseModel;
				}
				set	
				{
					cubePerformanceDiagnoseModel = value;
				}
			}

			public class QueryCubeOptimization_CubePerformanceDiagnoseModel
			{

				private double? cacheCostTimeAvg;

				private int? cacheQueryCount;

				private double? costTimeAvg;

				private string cubeId;

				private string cubeName;

				private int? queryCount;

				private double? queryCountAvg;

				private double? queryOverFivePercentNum;

				private string queryOverFiveSecPercent;

				private string queryOverTenSecPercent;

				private double? queryOverTenSecPercentNum;

				private int? queryTimeoutCount;

				private double? queryTimeoutCountPercent;

				private double? quickIndexCostTimeAvg;

				private int? quickIndexQueryCount;

				private string repeatQueryPercent;

				private double? repeatQueryPercentNum;

				private int? repeatSqlQueryCount;

				private string repeatSqlQueryPercent;

				private string workspaceId;

				private string workspaceName;

				public double? CacheCostTimeAvg
				{
					get
					{
						return cacheCostTimeAvg;
					}
					set	
					{
						cacheCostTimeAvg = value;
					}
				}

				public int? CacheQueryCount
				{
					get
					{
						return cacheQueryCount;
					}
					set	
					{
						cacheQueryCount = value;
					}
				}

				public double? CostTimeAvg
				{
					get
					{
						return costTimeAvg;
					}
					set	
					{
						costTimeAvg = value;
					}
				}

				public string CubeId
				{
					get
					{
						return cubeId;
					}
					set	
					{
						cubeId = value;
					}
				}

				public string CubeName
				{
					get
					{
						return cubeName;
					}
					set	
					{
						cubeName = value;
					}
				}

				public int? QueryCount
				{
					get
					{
						return queryCount;
					}
					set	
					{
						queryCount = value;
					}
				}

				public double? QueryCountAvg
				{
					get
					{
						return queryCountAvg;
					}
					set	
					{
						queryCountAvg = value;
					}
				}

				public double? QueryOverFivePercentNum
				{
					get
					{
						return queryOverFivePercentNum;
					}
					set	
					{
						queryOverFivePercentNum = value;
					}
				}

				public string QueryOverFiveSecPercent
				{
					get
					{
						return queryOverFiveSecPercent;
					}
					set	
					{
						queryOverFiveSecPercent = value;
					}
				}

				public string QueryOverTenSecPercent
				{
					get
					{
						return queryOverTenSecPercent;
					}
					set	
					{
						queryOverTenSecPercent = value;
					}
				}

				public double? QueryOverTenSecPercentNum
				{
					get
					{
						return queryOverTenSecPercentNum;
					}
					set	
					{
						queryOverTenSecPercentNum = value;
					}
				}

				public int? QueryTimeoutCount
				{
					get
					{
						return queryTimeoutCount;
					}
					set	
					{
						queryTimeoutCount = value;
					}
				}

				public double? QueryTimeoutCountPercent
				{
					get
					{
						return queryTimeoutCountPercent;
					}
					set	
					{
						queryTimeoutCountPercent = value;
					}
				}

				public double? QuickIndexCostTimeAvg
				{
					get
					{
						return quickIndexCostTimeAvg;
					}
					set	
					{
						quickIndexCostTimeAvg = value;
					}
				}

				public int? QuickIndexQueryCount
				{
					get
					{
						return quickIndexQueryCount;
					}
					set	
					{
						quickIndexQueryCount = value;
					}
				}

				public string RepeatQueryPercent
				{
					get
					{
						return repeatQueryPercent;
					}
					set	
					{
						repeatQueryPercent = value;
					}
				}

				public double? RepeatQueryPercentNum
				{
					get
					{
						return repeatQueryPercentNum;
					}
					set	
					{
						repeatQueryPercentNum = value;
					}
				}

				public int? RepeatSqlQueryCount
				{
					get
					{
						return repeatSqlQueryCount;
					}
					set	
					{
						repeatSqlQueryCount = value;
					}
				}

				public string RepeatSqlQueryPercent
				{
					get
					{
						return repeatSqlQueryPercent;
					}
					set	
					{
						repeatSqlQueryPercent = value;
					}
				}

				public string WorkspaceId
				{
					get
					{
						return workspaceId;
					}
					set	
					{
						workspaceId = value;
					}
				}

				public string WorkspaceName
				{
					get
					{
						return workspaceName;
					}
					set	
					{
						workspaceName = value;
					}
				}
			}
		}
	}
}
