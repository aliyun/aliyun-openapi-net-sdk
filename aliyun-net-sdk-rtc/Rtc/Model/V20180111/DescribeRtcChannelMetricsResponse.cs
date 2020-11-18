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
	public class DescribeRtcChannelMetricsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRtcChannelMetrics_Metric> metrics;

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

		public List<DescribeRtcChannelMetrics_Metric> Metrics
		{
			get
			{
				return metrics;
			}
			set	
			{
				metrics = value;
			}
		}

		public class DescribeRtcChannelMetrics_Metric
		{

			private string uid;

			private string mid;

			private List<string> kVs;

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

			public string Mid
			{
				get
				{
					return mid;
				}
				set	
				{
					mid = value;
				}
			}

			public List<string> KVs
			{
				get
				{
					return kVs;
				}
				set	
				{
					kVs = value;
				}
			}
		}
	}
}
