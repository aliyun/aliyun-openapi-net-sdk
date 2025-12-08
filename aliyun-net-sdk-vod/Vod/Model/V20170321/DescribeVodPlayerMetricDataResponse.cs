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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribeVodPlayerMetricDataResponse : AcsResponse
	{

		private string requestId;

		private long? pageNumber;

		private long? pageSize;

		private long? totalCnt;

		private List<DescribeVodPlayerMetricData_Datds> dataList;

		private DescribeVodPlayerMetricData_Extend extend;

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

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public long? TotalCnt
		{
			get
			{
				return totalCnt;
			}
			set	
			{
				totalCnt = value;
			}
		}

		public List<DescribeVodPlayerMetricData_Datds> DataList
		{
			get
			{
				return dataList;
			}
			set	
			{
				dataList = value;
			}
		}

		public DescribeVodPlayerMetricData_Extend Extend
		{
			get
			{
				return extend;
			}
			set	
			{
				extend = value;
			}
		}

		public class DescribeVodPlayerMetricData_Datds
		{

			private string timeStamp;

			private string dimension;

			private double? uv;

			private double? vv;

			private double? realVv;

			private double? firstFrame;

			private double? secondPlayRate;

			private double? slowPlayRate;

			private double? stuckCountRate;

			private double? seekDuration;

			private double? stuckDuration100s;

			private double? playFailRate;

			private double? seedFailRate;

			private double? avgPlayBitrate;

			private double? avgStartBitrate;

			private double? errorCount100s;

			private double? avgPerVv;

			private double? avgVideoDuration;

			private double? avgPerPlayDuration;

			private double? avgPerCompletionVv;

			private double? completionVv;

			private double? completionRate;

			private double? avgPlayDuration;

			private double? jumpRate5s;

			private double? totalPlayDuration;

			private string stuckCount100s;

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string Dimension
			{
				get
				{
					return dimension;
				}
				set	
				{
					dimension = value;
				}
			}

			public double? Uv
			{
				get
				{
					return uv;
				}
				set	
				{
					uv = value;
				}
			}

			public double? Vv
			{
				get
				{
					return vv;
				}
				set	
				{
					vv = value;
				}
			}

			public double? RealVv
			{
				get
				{
					return realVv;
				}
				set	
				{
					realVv = value;
				}
			}

			public double? FirstFrame
			{
				get
				{
					return firstFrame;
				}
				set	
				{
					firstFrame = value;
				}
			}

			public double? SecondPlayRate
			{
				get
				{
					return secondPlayRate;
				}
				set	
				{
					secondPlayRate = value;
				}
			}

			public double? SlowPlayRate
			{
				get
				{
					return slowPlayRate;
				}
				set	
				{
					slowPlayRate = value;
				}
			}

			public double? StuckCountRate
			{
				get
				{
					return stuckCountRate;
				}
				set	
				{
					stuckCountRate = value;
				}
			}

			public double? SeekDuration
			{
				get
				{
					return seekDuration;
				}
				set	
				{
					seekDuration = value;
				}
			}

			public double? StuckDuration100s
			{
				get
				{
					return stuckDuration100s;
				}
				set	
				{
					stuckDuration100s = value;
				}
			}

			public double? PlayFailRate
			{
				get
				{
					return playFailRate;
				}
				set	
				{
					playFailRate = value;
				}
			}

			public double? SeedFailRate
			{
				get
				{
					return seedFailRate;
				}
				set	
				{
					seedFailRate = value;
				}
			}

			public double? AvgPlayBitrate
			{
				get
				{
					return avgPlayBitrate;
				}
				set	
				{
					avgPlayBitrate = value;
				}
			}

			public double? AvgStartBitrate
			{
				get
				{
					return avgStartBitrate;
				}
				set	
				{
					avgStartBitrate = value;
				}
			}

			public double? ErrorCount100s
			{
				get
				{
					return errorCount100s;
				}
				set	
				{
					errorCount100s = value;
				}
			}

			public double? AvgPerVv
			{
				get
				{
					return avgPerVv;
				}
				set	
				{
					avgPerVv = value;
				}
			}

			public double? AvgVideoDuration
			{
				get
				{
					return avgVideoDuration;
				}
				set	
				{
					avgVideoDuration = value;
				}
			}

			public double? AvgPerPlayDuration
			{
				get
				{
					return avgPerPlayDuration;
				}
				set	
				{
					avgPerPlayDuration = value;
				}
			}

			public double? AvgPerCompletionVv
			{
				get
				{
					return avgPerCompletionVv;
				}
				set	
				{
					avgPerCompletionVv = value;
				}
			}

			public double? CompletionVv
			{
				get
				{
					return completionVv;
				}
				set	
				{
					completionVv = value;
				}
			}

			public double? CompletionRate
			{
				get
				{
					return completionRate;
				}
				set	
				{
					completionRate = value;
				}
			}

			public double? AvgPlayDuration
			{
				get
				{
					return avgPlayDuration;
				}
				set	
				{
					avgPlayDuration = value;
				}
			}

			public double? JumpRate5s
			{
				get
				{
					return jumpRate5s;
				}
				set	
				{
					jumpRate5s = value;
				}
			}

			public double? TotalPlayDuration
			{
				get
				{
					return totalPlayDuration;
				}
				set	
				{
					totalPlayDuration = value;
				}
			}

			public string StuckCount100s
			{
				get
				{
					return stuckCount100s;
				}
				set	
				{
					stuckCount100s = value;
				}
			}
		}

		public class DescribeVodPlayerMetricData_Extend
		{

			private string actualStartTime;

			private string actualEndTime;

			private long? intervalSeconds;

			public string ActualStartTime
			{
				get
				{
					return actualStartTime;
				}
				set	
				{
					actualStartTime = value;
				}
			}

			public string ActualEndTime
			{
				get
				{
					return actualEndTime;
				}
				set	
				{
					actualEndTime = value;
				}
			}

			public long? IntervalSeconds
			{
				get
				{
					return intervalSeconds;
				}
				set	
				{
					intervalSeconds = value;
				}
			}
		}
	}
}
