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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeUpBpsPeakDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeUpBpsPeakData_DescribeUpPeakTraffic> describeUpPeakTraffics;

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

		public List<DescribeUpBpsPeakData_DescribeUpPeakTraffic> DescribeUpPeakTraffics
		{
			get
			{
				return describeUpPeakTraffics;
			}
			set	
			{
				describeUpPeakTraffics = value;
			}
		}

		public class DescribeUpBpsPeakData_DescribeUpPeakTraffic
		{

			private string peakTime;

			private string queryTime;

			private string statName;

			private string bandWidth;

			public string PeakTime
			{
				get
				{
					return peakTime;
				}
				set	
				{
					peakTime = value;
				}
			}

			public string QueryTime
			{
				get
				{
					return queryTime;
				}
				set	
				{
					queryTime = value;
				}
			}

			public string StatName
			{
				get
				{
					return statName;
				}
				set	
				{
					statName = value;
				}
			}

			public string BandWidth
			{
				get
				{
					return bandWidth;
				}
				set	
				{
					bandWidth = value;
				}
			}
		}
	}
}
