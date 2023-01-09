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

namespace Aliyun.Acs.PTS.Model.V20201020
{
	public class GetPtsSceneRunningDataResponse : AcsResponse
	{

		private int? status;

		private long? totalRequestCount;

		private bool? hasReport;

		private int? concurrencyLimit;

		private string message;

		private string requestId;

		private long? beginTime;

		private long? seg90Rt;

		private string responseBps;

		private int? totalAgents;

		private string code;

		private bool? success;

		private long? vum;

		private long? averageRt;

		private string requestBps;

		private long? failedBusinessCount;

		private int? concurrency;

		private int? httpStatusCode;

		private long? failedRequestCount;

		private int? tpsLimit;

		private int? aliveAgents;

		private int? totalRealQps;

		private List<GetPtsSceneRunningData_Location> agentLocation;

		private List<GetPtsSceneRunningData_ChainMonitorData> chainMonitorDataList;

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public long? TotalRequestCount
		{
			get
			{
				return totalRequestCount;
			}
			set	
			{
				totalRequestCount = value;
			}
		}

		public bool? HasReport
		{
			get
			{
				return hasReport;
			}
			set	
			{
				hasReport = value;
			}
		}

		public int? ConcurrencyLimit
		{
			get
			{
				return concurrencyLimit;
			}
			set	
			{
				concurrencyLimit = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
			}
		}

		public long? Seg90Rt
		{
			get
			{
				return seg90Rt;
			}
			set	
			{
				seg90Rt = value;
			}
		}

		public string ResponseBps
		{
			get
			{
				return responseBps;
			}
			set	
			{
				responseBps = value;
			}
		}

		public int? TotalAgents
		{
			get
			{
				return totalAgents;
			}
			set	
			{
				totalAgents = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public long? Vum
		{
			get
			{
				return vum;
			}
			set	
			{
				vum = value;
			}
		}

		public long? AverageRt
		{
			get
			{
				return averageRt;
			}
			set	
			{
				averageRt = value;
			}
		}

		public string RequestBps
		{
			get
			{
				return requestBps;
			}
			set	
			{
				requestBps = value;
			}
		}

		public long? FailedBusinessCount
		{
			get
			{
				return failedBusinessCount;
			}
			set	
			{
				failedBusinessCount = value;
			}
		}

		public int? Concurrency
		{
			get
			{
				return concurrency;
			}
			set	
			{
				concurrency = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public long? FailedRequestCount
		{
			get
			{
				return failedRequestCount;
			}
			set	
			{
				failedRequestCount = value;
			}
		}

		public int? TpsLimit
		{
			get
			{
				return tpsLimit;
			}
			set	
			{
				tpsLimit = value;
			}
		}

		public int? AliveAgents
		{
			get
			{
				return aliveAgents;
			}
			set	
			{
				aliveAgents = value;
			}
		}

		public int? TotalRealQps
		{
			get
			{
				return totalRealQps;
			}
			set	
			{
				totalRealQps = value;
			}
		}

		public List<GetPtsSceneRunningData_Location> AgentLocation
		{
			get
			{
				return agentLocation;
			}
			set	
			{
				agentLocation = value;
			}
		}

		public List<GetPtsSceneRunningData_ChainMonitorData> ChainMonitorDataList
		{
			get
			{
				return chainMonitorDataList;
			}
			set	
			{
				chainMonitorDataList = value;
			}
		}

		public class GetPtsSceneRunningData_Location
		{

			private string region;

			private string isp;

			private int? count;

			private string province;

			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public string Isp
			{
				get
				{
					return isp;
				}
				set	
				{
					isp = value;
				}
			}

			public int? Count
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

			public string Province
			{
				get
				{
					return province;
				}
				set	
				{
					province = value;
				}
			}
		}

		public class GetPtsSceneRunningData_ChainMonitorData
		{

			private long? timePoint;

			private string apiId;

			private int? minRt;

			private float? qps2XX;

			private int? maxRt;

			private int? configQps;

			private long? failedCount;

			private float? failedQps;

			private int? averageRt;

			private long? count2XX;

			private float? realQps;

			private string apiName;

			private long? nodeId;

			private float? concurrency;

			private GetPtsSceneRunningData_CheckPointResult checkPointResult;

			public long? TimePoint
			{
				get
				{
					return timePoint;
				}
				set	
				{
					timePoint = value;
				}
			}

			public string ApiId
			{
				get
				{
					return apiId;
				}
				set	
				{
					apiId = value;
				}
			}

			public int? MinRt
			{
				get
				{
					return minRt;
				}
				set	
				{
					minRt = value;
				}
			}

			public float? Qps2XX
			{
				get
				{
					return qps2XX;
				}
				set	
				{
					qps2XX = value;
				}
			}

			public int? MaxRt
			{
				get
				{
					return maxRt;
				}
				set	
				{
					maxRt = value;
				}
			}

			public int? ConfigQps
			{
				get
				{
					return configQps;
				}
				set	
				{
					configQps = value;
				}
			}

			public long? FailedCount
			{
				get
				{
					return failedCount;
				}
				set	
				{
					failedCount = value;
				}
			}

			public float? FailedQps
			{
				get
				{
					return failedQps;
				}
				set	
				{
					failedQps = value;
				}
			}

			public int? AverageRt
			{
				get
				{
					return averageRt;
				}
				set	
				{
					averageRt = value;
				}
			}

			public long? Count2XX
			{
				get
				{
					return count2XX;
				}
				set	
				{
					count2XX = value;
				}
			}

			public float? RealQps
			{
				get
				{
					return realQps;
				}
				set	
				{
					realQps = value;
				}
			}

			public string ApiName
			{
				get
				{
					return apiName;
				}
				set	
				{
					apiName = value;
				}
			}

			public long? NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public float? Concurrency
			{
				get
				{
					return concurrency;
				}
				set	
				{
					concurrency = value;
				}
			}

			public GetPtsSceneRunningData_CheckPointResult CheckPointResult
			{
				get
				{
					return checkPointResult;
				}
				set	
				{
					checkPointResult = value;
				}
			}

			public class GetPtsSceneRunningData_CheckPointResult
			{

				private long? succeedBusinessCount;

				private float? succeedBusinessQps;

				private long? failedBusinessCount;

				private float? failedBusinessQps;

				public long? SucceedBusinessCount
				{
					get
					{
						return succeedBusinessCount;
					}
					set	
					{
						succeedBusinessCount = value;
					}
				}

				public float? SucceedBusinessQps
				{
					get
					{
						return succeedBusinessQps;
					}
					set	
					{
						succeedBusinessQps = value;
					}
				}

				public long? FailedBusinessCount
				{
					get
					{
						return failedBusinessCount;
					}
					set	
					{
						failedBusinessCount = value;
					}
				}

				public float? FailedBusinessQps
				{
					get
					{
						return failedBusinessQps;
					}
					set	
					{
						failedBusinessQps = value;
					}
				}
			}
		}
	}
}
