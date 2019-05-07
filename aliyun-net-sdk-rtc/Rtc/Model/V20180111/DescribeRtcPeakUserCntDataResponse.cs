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

using Aliyun.Acs.Core;

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeRtcPeakUserCntDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRtcPeakUserCntData_PeakUserCntModule> peakUserCntDataPerInterval;

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

		public List<DescribeRtcPeakUserCntData_PeakUserCntModule> PeakUserCntDataPerInterval
		{
			get
			{
				return peakUserCntDataPerInterval;
			}
			set	
			{
				peakUserCntDataPerInterval = value;
			}
		}

		public class DescribeRtcPeakUserCntData_PeakUserCntModule
		{

			private string timeStamp;

			private long? activeUserPeak;

			private string activeUserPeakTime;

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

			public long? ActiveUserPeak
			{
				get
				{
					return activeUserPeak;
				}
				set	
				{
					activeUserPeak = value;
				}
			}

			public string ActiveUserPeakTime
			{
				get
				{
					return activeUserPeakTime;
				}
				set	
				{
					activeUserPeakTime = value;
				}
			}
		}
	}
}
