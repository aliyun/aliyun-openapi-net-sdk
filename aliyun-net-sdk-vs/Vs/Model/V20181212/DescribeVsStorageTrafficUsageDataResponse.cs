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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class DescribeVsStorageTrafficUsageDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVsStorageTrafficUsageData_TrafficUsageDataModule> trafficUsage;

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

		public List<DescribeVsStorageTrafficUsageData_TrafficUsageDataModule> TrafficUsage
		{
			get
			{
				return trafficUsage;
			}
			set	
			{
				trafficUsage = value;
			}
		}

		public class DescribeVsStorageTrafficUsageData_TrafficUsageDataModule
		{

			private string timeStamp;

			private string bucket;

			private long? lanTrafficInDataValue;

			private long? lanTrafficOutDataValue;

			private long? wanTrafficInDataValue;

			private long? wanTrafficOutDataValue;

			private float? lanBandwidthInDataValue;

			private float? lanBandwidthOutDataValue;

			private float? wanBandwidthInDataValue;

			private float? wanBandwidthOutDataValue;

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

			public string Bucket
			{
				get
				{
					return bucket;
				}
				set	
				{
					bucket = value;
				}
			}

			public long? LanTrafficInDataValue
			{
				get
				{
					return lanTrafficInDataValue;
				}
				set	
				{
					lanTrafficInDataValue = value;
				}
			}

			public long? LanTrafficOutDataValue
			{
				get
				{
					return lanTrafficOutDataValue;
				}
				set	
				{
					lanTrafficOutDataValue = value;
				}
			}

			public long? WanTrafficInDataValue
			{
				get
				{
					return wanTrafficInDataValue;
				}
				set	
				{
					wanTrafficInDataValue = value;
				}
			}

			public long? WanTrafficOutDataValue
			{
				get
				{
					return wanTrafficOutDataValue;
				}
				set	
				{
					wanTrafficOutDataValue = value;
				}
			}

			public float? LanBandwidthInDataValue
			{
				get
				{
					return lanBandwidthInDataValue;
				}
				set	
				{
					lanBandwidthInDataValue = value;
				}
			}

			public float? LanBandwidthOutDataValue
			{
				get
				{
					return lanBandwidthOutDataValue;
				}
				set	
				{
					lanBandwidthOutDataValue = value;
				}
			}

			public float? WanBandwidthInDataValue
			{
				get
				{
					return wanBandwidthInDataValue;
				}
				set	
				{
					wanBandwidthInDataValue = value;
				}
			}

			public float? WanBandwidthOutDataValue
			{
				get
				{
					return wanBandwidthOutDataValue;
				}
				set	
				{
					wanBandwidthOutDataValue = value;
				}
			}
		}
	}
}
